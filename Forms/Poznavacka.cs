using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Poznavacka
{
    public partial class Poznavacka : Form
    {
        static readonly HashSet<string> ValidImageExtensions = new HashSet<string>()
        {
            ".bmp",
            ".gif",
            ".jpe",
            ".jpg",
            ".jpeg",
            ".png",
            ".tif",
            ".tiff"
        };
        string[] picturePaths;
        string currentPictureName;
        int lastPictureIndex;

        int rightAnswers = 0, wrongAnswers = 0;
        bool answeredOnce = false;

        public Poznavacka()
        {
            InitializeComponent();
            ResetForm();
        }

        private void Poznavacka_Shown(object sender, EventArgs e)
        {
            CheckForUpdates();
        }

        private void CheckForUpdates()
        {
            try
            {
                WebClient wc = new WebClient();
                string serverVersion = wc.DownloadString("http://www.poznavacka.8u.cz/program/CurrentVersion.txt");
                string[] serverVersionSplit = serverVersion.Split('.');
                string[] appVersionSplit = Application.ProductVersion.Split('.');

                for (int i = 0; i < 3; i++)
                {
                    if (int.Parse(serverVersionSplit[i]) < int.Parse(appVersionSplit[i]))
                    {
                        return;
                    }
                    else if (int.Parse(serverVersionSplit[i]) > int.Parse(appVersionSplit[i]))
                    {
                        Update update = new Update(serverVersion);
                        update.ShowDialog();
                    }

                }
            }
            catch
            {
            }
        }

        private void ChangeGuessingState(bool state) // 0 = off, 1 = on
        {
            rightAnswers = 0;
            wrongAnswers = 0;
            rightAnswersCount.Text = "0";
            wrongAnswersCount.Text = "0";

            if (selectedFolder.Text == "<nevybrána>")
            {
                startButton.Enabled = false;
            }
            else
            {
                startButton.Enabled = !state;
            }
            nextButton.Enabled = state;
            stopButton.Enabled = state;
            trainingCheckBox.Enabled = !state;

            if (trainingCheckBox.Checked)
            {
                hintCheckBox.Checked = true;
                hintCheckBox.Enabled = false;
                helpButton.Enabled = false;
                inputTextBox.Enabled = false;
                OKButton.Enabled = false;
            }
            else
            {
                hintCheckBox.Enabled = !state;
                helpButton.Enabled = state;
                inputTextBox.Enabled = state;
                OKButton.Enabled = state;
                if (hintCheckBox.Checked)
                {
                    inputTextBox.AutoCompleteMode = AutoCompleteMode.Append;
                    var autocomplete = new AutoCompleteStringCollection();
                    foreach (string p in picturePaths)
                    {
                        autocomplete.Add(RemoveDiacriticsAndKeepLettersOnly(p));
                    }
                    inputTextBox.AutoCompleteCustomSource = autocomplete;
                }
                else
                {
                    inputTextBox.AutoCompleteMode = AutoCompleteMode.None;
                }
            }

            if (state == true)
            {
                if (Properties.Settings.Default.shuffleEnabled)
                {
                    ShufflePictureArray();
                }
            }
        }

        private void ShufflePictureArray()
        {
            Random random = new Random();
            lastPictureIndex = -1;
            for (int i = picturePaths.Length - 1; i > 0; i--)
            {
                int swapIndex = random.Next(i + 1);
                string temp = picturePaths[i];
                picturePaths[i] = picturePaths[swapIndex];
                picturePaths[swapIndex] = temp;
            }
        }

        private string RemoveDiacriticsAndKeepLettersOnly(string inputText)
        {
            inputText = Regex.Replace(Path.GetFileNameWithoutExtension(inputText), "-", " ").ToLower();
            if (Properties.Settings.Default.removeDiacritics)
            {
                var normalizedString = inputText.Normalize(NormalizationForm.FormD);
                var stringBuilder = new StringBuilder();

                foreach (var c in normalizedString)
                {
                    UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                    if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    {
                        stringBuilder.Append(c);
                    }
                }
                inputText = stringBuilder.ToString().Normalize(NormalizationForm.FormC);
            }

            string cleanText = String.Empty;
            foreach (char c in inputText)
            {
                if (char.IsLetter(c) || c == ' ')
                {
                    cleanText += c;
                }
            }
            while (Regex.IsMatch(cleanText, @" $"))
            {
                cleanText = Regex.Replace(cleanText, @" $", String.Empty);
            }
            return cleanText;
        }

        private void NextPicture()
        {
            answeredOnce = false;
            inputTextBox.Text = null;

            if (picturePaths.Length > 0)
            {
                int index;
                if (picturePaths.Length == 1)
                {
                    index = 0;
                }
                else
                {
                    if (Properties.Settings.Default.shuffleEnabled)
                    {
                        if (lastPictureIndex == picturePaths.Length - 1)
                        {
                            MessageBox.Show("Seznam obrázků byl vyčerpán. Začíná nové kolo.");
                            ShufflePictureArray();
                        }
                        index = lastPictureIndex + 1;
                    }
                    else
                    {
                        do
                        {
                            index = Guid.NewGuid().GetHashCode() % picturePaths.Length;
                            index = index > 0 ? index : -index;
                        }
                        while (index == lastPictureIndex);
                    }
                }
                lastPictureIndex = index;
                pictureBox.ImageLocation = picturePaths[index];
                currentPictureName = RemoveDiacriticsAndKeepLettersOnly(picturePaths[index]);
                if (trainingCheckBox.Checked)
                {
                    inputTextBox.Text = currentPictureName;
                }
            }
            else
            {
                MessageBox.Show("Ve složce nejsou žádné obrázky!");
                ChangeGuessingState(false);
            }
        }

        public void ResetForm()
        {
            ChangeGuessingState(false);
            if (Properties.Settings.Default.showStats)
            {
                statsGroupBox.Visible = true;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ChangeGuessingState(false);
                selectedFolder.Text = folderBrowserDialog.SelectedPath;
                picturePaths = Directory.GetFiles(selectedFolder.Text).Where(file => ValidImageExtensions.Contains(Path.GetExtension(file).ToLower())).ToArray();
                startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ChangeGuessingState(true);
            NextPicture();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            ChangeGuessingState(false);
        }

        private void trainingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            hintCheckBox.Enabled = !trainingCheckBox.Checked;
            if (trainingCheckBox.Checked)
            {
                hintCheckBox.Checked = true;
            }
        }

        private void inputTextBox_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = OKButton;
        }

        private void inputTextBox_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.allowShortcuts)
            {
                if (inputTextBox.Text == "?")
                {
                    helpButton.PerformClick();
                    MessageBox.Show("Cheatere!");
                    NextPicture();
                    return;
                }
                else if (inputTextBox.Text == "->" || inputTextBox.Text == "→")
                {
                    NextPicture();
                    return;
                }
            }

            if (RemoveDiacriticsAndKeepLettersOnly(inputTextBox.Text) == currentPictureName)
            {
                if (!answeredOnce)
                {
                    rightAnswers++;
                    rightAnswersCount.Text = rightAnswers.ToString();
                }
                MessageBox.Show("Správně!");
                NextPicture();
            }
            else
            {
                if (!answeredOnce)
                {
                    wrongAnswers++;
                    wrongAnswersCount.Text = wrongAnswers.ToString();
                }
                MessageBox.Show("Špatně!");
                answeredOnce = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            answeredOnce = true;
            inputTextBox.Text = currentPictureName;
            inputTextBox.Focus();
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.ShowDialog();
        }

        private void settingsToolStripButton_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Owner = this;
            settingsForm.ShowDialog();
        }
    }
}
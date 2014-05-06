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

        public Poznavacka()
        {
            InitializeComponent();
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
                    if (int.Parse(serverVersionSplit[i]) > int.Parse(appVersionSplit[i]))
                    {
                        Update update = new Update(serverVersion);
                        update.ShowDialog();
                        return;
                    }
                }
            }
            catch
            {
            }
        }

        private void ChangeGuessingState(bool state) // 0 = off, 1 = on
        {
            startButton.Enabled = !state;
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
        }

        private string RemoveDiacriticsAndKeepLettersOnly(string text)
        {
            text = Regex.Replace(Path.GetFileNameWithoutExtension(text), "-", " ").ToLower();
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            text = Regex.Replace(stringBuilder.ToString().Normalize(NormalizationForm.FormC), @"[^a-z ]", String.Empty);
            while (Regex.IsMatch(text, @" $"))
            {
                text = Regex.Replace(text, @" $", string.Empty);
            }
            return text;
        }

        private void NextPicture()
        {
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
                    do
                    {
                        index = Guid.NewGuid().GetHashCode() % picturePaths.Length;
                        index = index > 0 ? index : -index;
                    }
                    while (index == lastPictureIndex);
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
            switch (inputTextBox.Text)
            {
                case "?":
                    helpButton.PerformClick();
                    OKButton.PerformClick();
                    break;
                case "->":
                    nextButton.PerformClick();
                    break;
                default:
                    if (RemoveDiacriticsAndKeepLettersOnly(inputTextBox.Text) == currentPictureName)
                    {
                        MessageBox.Show("Správně!");
                        NextPicture();
                    }
                    else
                    {
                        MessageBox.Show("Špatně!");
                    }
                    break;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            NextPicture();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = currentPictureName;
            inputTextBox.Focus();
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
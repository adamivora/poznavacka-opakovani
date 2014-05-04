using System;
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
        string[] pictures;
        string currentPicture;
        int lastIndex;

        public Poznavacka()
        {
            InitializeComponent();
        }

        private void Poznavacka_Shown(object sender, EventArgs e)
        {
            checkForUpdates();
        }

        private void checkForUpdates()
        {
            try
            {
                WebClient wc = new WebClient();
                string serverVersion = wc.DownloadString("http://www.poznavacka.8u.cz/program/CurrentVersion.txt");
                string[] serverVersionSplit = serverVersion.Split('.');
                string[] appVersionSplit = Application.ProductVersion.Split('.');
                bool isNewVersion = false;
                for (int i = 0; i < 3; i++)
                {
                    if (int.Parse(serverVersionSplit[i]) > int.Parse(appVersionSplit[i]))
                    {
                        isNewVersion = true;
                        break;
                    }
                }
                if (isNewVersion)
                {
                    Update update = new Update(serverVersion);
                    update.ShowDialog();
                }
            }
            catch { }
        }

        private void trainingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (trainingCheckBox.Checked)
            {
                hintCheckBox.Checked = true;
                hintCheckBox.Enabled = false;
            }
            else
            {
                hintCheckBox.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            nextButton.Enabled = true;
            stopButton.Enabled = true;
            trainingCheckBox.Enabled = false;
            hintCheckBox.Enabled = false;

            if (trainingCheckBox.Checked)
            {
                helpButton.Enabled = false;
                inputTextBox.Enabled = false;
                OKButton.Enabled = false;
            }
            else
            {
                helpButton.Enabled = true;
                inputTextBox.Enabled = true;
                OKButton.Enabled = true;
                if (hintCheckBox.Checked)
                {
                    inputTextBox.AutoCompleteMode = AutoCompleteMode.Append;
                    var autocomplete = new AutoCompleteStringCollection();
                    foreach (string p in pictures)
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

            nextPicture();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            stop();
        }

        private void stop()
        {
            stopButton.Enabled = false;
            nextButton.Enabled = false;
            trainingCheckBox.Enabled = true;
            OKButton.Enabled = false;
            inputTextBox.Enabled = false;
            helpButton.Enabled = false;
            if (trainingCheckBox.Checked)
            {
                hintCheckBox.Checked = true;
                hintCheckBox.Enabled = false;
            }
            else
            {
                hintCheckBox.Enabled = true;
            }
            startButton.Enabled = true;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                stop();
                selectedFolder.Text = folderBrowserDialog.SelectedPath;
                pictures = Directory.GetFiles(selectedFolder.Text).Where(file => new string[] {".jpg", ".JPG", ".bmp", ".BMP", ".png", ".PNG", ".gif", ".GIF"}.Contains(Path.GetExtension(file))).ToArray();
                startButton.Enabled = true;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            nextPicture();
        }

        private void nextPicture()
        {
            inputTextBox.Text = null;
            if (pictures.Length > 0)
            {
                int index;
                if (pictures.Length == 1)
                {
                    index = 0;
                }
                else
                {
                    do
                    {
                        index = Guid.NewGuid().GetHashCode() % pictures.Length;
                        index = index > 0 ? index : -index;
                    }
                    while (index == lastIndex);
                }
                lastIndex = index;
                pictureBox.ImageLocation = pictures[index];
                currentPicture = RemoveDiacriticsAndKeepLettersOnly(pictures[index]);
                if (trainingCheckBox.Checked)
                {
                    inputTextBox.Text = currentPicture;
                }
            }
            else
            {
                MessageBox.Show("Ve složce nejsou žádné obrázky!");
                stop();
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

            text = Regex.Replace(stringBuilder.ToString().Normalize(NormalizationForm.FormC), @"[^a-z ]", "");
            while(Regex.IsMatch(text, @" $"))
            {
                text = Regex.Replace(text, @" $", "");
            }
            return text;
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
            switch(inputTextBox.Text)
            {
                case "?":
                    helpButton.PerformClick();
                    OKButton.PerformClick();
                    break;
                case "->":
                    nextButton.PerformClick();
                    break;
                default:
                    if (RemoveDiacriticsAndKeepLettersOnly(inputTextBox.Text) == currentPicture)
                    {
                        MessageBox.Show("Správně!");
                        nextPicture();
                    }
                    else
                    {
                        MessageBox.Show("Špatně!");
                    }
                    break;
            }
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = currentPicture;
            inputTextBox.Focus();
        }
    }
}
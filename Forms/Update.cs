using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Poznavacka
{
    public partial class Update : Form
    {
        bool showCheckbox;

        public Update(string version, bool showCheckbox = false)
        {
            InitializeComponent();
            this.showCheckbox = showCheckbox;
            if (!showCheckbox)
            {
                checkForUpdatesOnStartupCheckBox.Visible = false;
            }
            updateTextLabel.Text = String.Format("K dispozici je nová verze aplikace ({0}).", version);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Process.Start("https://github.com/adamivora/poznavacka-opakovani/releases");
            Application.Exit();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Dispose();
        }

        private void SaveSettings()
        {
            if (showCheckbox)
            {
                Properties.Settings.Default.checkForUpdatesOnStartup = !checkForUpdatesOnStartupCheckBox.Checked;
                Properties.Settings.Default.Save();
            }
        }
    }
}

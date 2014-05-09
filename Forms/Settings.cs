using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poznavacka
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            SetControlsState();
        }

        private void SetControlsState()
        {
            allowShortcutsCheckBox.Checked = Properties.Settings.Default.allowShortcuts;
            removeDiacriticsCheckBox.Checked = Properties.Settings.Default.removeDiacritics;
            showStatsCheckBox.Checked = Properties.Settings.Default.showStats;
            checkSubfoldersCheckBox.Checked = Properties.Settings.Default.checkSubfolders;
            checkForUpdatesOnStartupCheckBox.Checked = Properties.Settings.Default.checkForUpdatesOnStartup;
            randomRadioButton.Checked = !Properties.Settings.Default.shuffleEnabled;
            shuffleRadioButton.Checked = Properties.Settings.Default.shuffleEnabled;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.allowShortcuts = allowShortcutsCheckBox.Checked;
            Properties.Settings.Default.removeDiacritics = removeDiacriticsCheckBox.Checked;
            Properties.Settings.Default.showStats = showStatsCheckBox.Checked;
            Properties.Settings.Default.checkSubfolders = checkSubfoldersCheckBox.Checked;
            Properties.Settings.Default.checkForUpdatesOnStartup = checkForUpdatesOnStartupCheckBox.Checked;
            Properties.Settings.Default.shuffleEnabled = shuffleRadioButton.Checked;
            Properties.Settings.Default.Save();
            Poznavacka poznavacka = (Poznavacka)Owner;
            poznavacka.ResetForm();
            this.Dispose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void defaultSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.allowShortcuts = true;
            Properties.Settings.Default.removeDiacritics = true;
            Properties.Settings.Default.showStats = true;
            Properties.Settings.Default.checkSubfolders = true;
            Properties.Settings.Default.checkForUpdatesOnStartup = true;
            Properties.Settings.Default.shuffleEnabled = true;
            SetControlsState();
        }
    }
}

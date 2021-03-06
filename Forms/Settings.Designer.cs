﻿namespace Poznavacka
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shuffleEnabledLabel = new System.Windows.Forms.Label();
            this.programSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.checkForUpdatesOnStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.checkSubfoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.showStatsCheckBox = new System.Windows.Forms.CheckBox();
            this.shuffleEnabledPanel = new System.Windows.Forms.Panel();
            this.shuffleRadioButton = new System.Windows.Forms.RadioButton();
            this.randomRadioButton = new System.Windows.Forms.RadioButton();
            this.removeDiacriticsCheckBox = new System.Windows.Forms.CheckBox();
            this.allowShortcutsCheckBox = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.defaultSettingsButton = new System.Windows.Forms.Button();
            this.programSettingsGroupBox.SuspendLayout();
            this.shuffleEnabledPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shuffleEnabledLabel
            // 
            this.shuffleEnabledLabel.AutoSize = true;
            this.shuffleEnabledLabel.Location = new System.Drawing.Point(8, 144);
            this.shuffleEnabledLabel.Name = "shuffleEnabledLabel";
            this.shuffleEnabledLabel.Size = new System.Drawing.Size(76, 13);
            this.shuffleEnabledLabel.TabIndex = 2;
            this.shuffleEnabledLabel.Text = "Další obrázek:";
            // 
            // programSettingsGroupBox
            // 
            this.programSettingsGroupBox.Controls.Add(this.checkForUpdatesOnStartupCheckBox);
            this.programSettingsGroupBox.Controls.Add(this.checkSubfoldersCheckBox);
            this.programSettingsGroupBox.Controls.Add(this.showStatsCheckBox);
            this.programSettingsGroupBox.Controls.Add(this.removeDiacriticsCheckBox);
            this.programSettingsGroupBox.Controls.Add(this.shuffleEnabledLabel);
            this.programSettingsGroupBox.Controls.Add(this.allowShortcutsCheckBox);
            this.programSettingsGroupBox.Controls.Add(this.shuffleEnabledPanel);
            this.programSettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            this.programSettingsGroupBox.Name = "programSettingsGroupBox";
            this.programSettingsGroupBox.Size = new System.Drawing.Size(303, 168);
            this.programSettingsGroupBox.TabIndex = 3;
            this.programSettingsGroupBox.TabStop = false;
            this.programSettingsGroupBox.Text = "Nastavení programu";
            // 
            // checkForUpdatesOnStartupCheckBox
            // 
            this.checkForUpdatesOnStartupCheckBox.AutoSize = true;
            this.checkForUpdatesOnStartupCheckBox.Location = new System.Drawing.Point(9, 99);
            this.checkForUpdatesOnStartupCheckBox.Name = "checkForUpdatesOnStartupCheckBox";
            this.checkForUpdatesOnStartupCheckBox.Size = new System.Drawing.Size(249, 17);
            this.checkForUpdatesOnStartupCheckBox.TabIndex = 7;
            this.checkForUpdatesOnStartupCheckBox.Text = "Zkontrolovat aktualizace při spuštění programu";
            this.checkForUpdatesOnStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkSubfoldersCheckBox
            // 
            this.checkSubfoldersCheckBox.AutoSize = true;
            this.checkSubfoldersCheckBox.Location = new System.Drawing.Point(9, 79);
            this.checkSubfoldersCheckBox.Name = "checkSubfoldersCheckBox";
            this.checkSubfoldersCheckBox.Size = new System.Drawing.Size(124, 17);
            this.checkSubfoldersCheckBox.TabIndex = 6;
            this.checkSubfoldersCheckBox.Text = "Procházet podsložky";
            this.checkSubfoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // showStatsCheckBox
            // 
            this.showStatsCheckBox.AutoSize = true;
            this.showStatsCheckBox.Location = new System.Drawing.Point(9, 59);
            this.showStatsCheckBox.Name = "showStatsCheckBox";
            this.showStatsCheckBox.Size = new System.Drawing.Size(123, 17);
            this.showStatsCheckBox.TabIndex = 5;
            this.showStatsCheckBox.Text = "Zobrazovat statistiky";
            this.showStatsCheckBox.UseVisualStyleBackColor = true;
            // 
            // shuffleEnabledPanel
            // 
            this.shuffleEnabledPanel.AutoSize = true;
            this.shuffleEnabledPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.shuffleEnabledPanel.Controls.Add(this.shuffleRadioButton);
            this.shuffleEnabledPanel.Controls.Add(this.randomRadioButton);
            this.shuffleEnabledPanel.Location = new System.Drawing.Point(84, 139);
            this.shuffleEnabledPanel.Name = "shuffleEnabledPanel";
            this.shuffleEnabledPanel.Size = new System.Drawing.Size(210, 23);
            this.shuffleEnabledPanel.TabIndex = 4;
            // 
            // shuffleRadioButton
            // 
            this.shuffleRadioButton.AutoSize = true;
            this.shuffleRadioButton.Location = new System.Drawing.Point(77, 3);
            this.shuffleRadioButton.Name = "shuffleRadioButton";
            this.shuffleRadioButton.Size = new System.Drawing.Size(130, 17);
            this.shuffleRadioButton.TabIndex = 6;
            this.shuffleRadioButton.TabStop = true;
            this.shuffleRadioButton.Text = "Každý obrázek jednou";
            this.shuffleRadioButton.UseVisualStyleBackColor = true;
            // 
            // randomRadioButton
            // 
            this.randomRadioButton.AutoSize = true;
            this.randomRadioButton.Location = new System.Drawing.Point(3, 3);
            this.randomRadioButton.Name = "randomRadioButton";
            this.randomRadioButton.Size = new System.Drawing.Size(68, 17);
            this.randomRadioButton.TabIndex = 5;
            this.randomRadioButton.TabStop = true;
            this.randomRadioButton.Text = "Náhodný";
            this.randomRadioButton.UseVisualStyleBackColor = true;
            // 
            // removeDiacriticsCheckBox
            // 
            this.removeDiacriticsCheckBox.AutoSize = true;
            this.removeDiacriticsCheckBox.Location = new System.Drawing.Point(9, 39);
            this.removeDiacriticsCheckBox.Name = "removeDiacriticsCheckBox";
            this.removeDiacriticsCheckBox.Size = new System.Drawing.Size(113, 17);
            this.removeDiacriticsCheckBox.TabIndex = 4;
            this.removeDiacriticsCheckBox.Text = "Odstranit diakritiku";
            this.removeDiacriticsCheckBox.UseVisualStyleBackColor = true;
            // 
            // allowShortcutsCheckBox
            // 
            this.allowShortcutsCheckBox.AutoSize = true;
            this.allowShortcutsCheckBox.Location = new System.Drawing.Point(9, 19);
            this.allowShortcutsCheckBox.Name = "allowShortcutsCheckBox";
            this.allowShortcutsCheckBox.Size = new System.Drawing.Size(147, 17);
            this.allowShortcutsCheckBox.TabIndex = 3;
            this.allowShortcutsCheckBox.Text = "Povolit klávesové zkratky";
            this.allowShortcutsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(78, 186);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(159, 186);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Zrušit";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // defaultSettingsButton
            // 
            this.defaultSettingsButton.Location = new System.Drawing.Point(240, 186);
            this.defaultSettingsButton.Name = "defaultSettingsButton";
            this.defaultSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.defaultSettingsButton.TabIndex = 6;
            this.defaultSettingsButton.Text = "Výchozí";
            this.defaultSettingsButton.UseVisualStyleBackColor = true;
            this.defaultSettingsButton.Click += new System.EventHandler(this.defaultSettingsButton_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 221);
            this.ControlBox = false;
            this.Controls.Add(this.programSettingsGroupBox);
            this.Controls.Add(this.defaultSettingsButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nastavení";
            this.programSettingsGroupBox.ResumeLayout(false);
            this.programSettingsGroupBox.PerformLayout();
            this.shuffleEnabledPanel.ResumeLayout(false);
            this.shuffleEnabledPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label shuffleEnabledLabel;
        private System.Windows.Forms.GroupBox programSettingsGroupBox;
        private System.Windows.Forms.CheckBox removeDiacriticsCheckBox;
        private System.Windows.Forms.CheckBox allowShortcutsCheckBox;
        private System.Windows.Forms.RadioButton shuffleRadioButton;
        private System.Windows.Forms.RadioButton randomRadioButton;
        private System.Windows.Forms.Panel shuffleEnabledPanel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox showStatsCheckBox;
        private System.Windows.Forms.Button defaultSettingsButton;
        private System.Windows.Forms.CheckBox checkSubfoldersCheckBox;
        private System.Windows.Forms.CheckBox checkForUpdatesOnStartupCheckBox;


    }
}
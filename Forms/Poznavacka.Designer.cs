namespace Poznavacka
{
    partial class Poznavacka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poznavacka));
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.picturePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.wrongAnswersCount = new System.Windows.Forms.Label();
            this.rightAnswersCount = new System.Windows.Forms.Label();
            this.wrongAnswersLabel = new System.Windows.Forms.Label();
            this.rightAnswersLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.hintCheckBox = new System.Windows.Forms.CheckBox();
            this.trainingCheckBox = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.selectedFolderPanel = new System.Windows.Forms.Panel();
            this.selectedFolderText = new System.Windows.Forms.Label();
            this.selectedFolderLabel = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.settingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.helpToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mainPanel.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.controlsPanel.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.selectedFolderPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.picturePanel, 0, 1);
            this.mainPanel.Controls.Add(this.toolStrip, 0, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 2;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(624, 442);
            this.mainPanel.TabIndex = 0;
            // 
            // picturePanel
            // 
            this.picturePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.picturePanel.ColumnCount = 2;
            this.picturePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.picturePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.picturePanel.Controls.Add(this.pictureBox, 0, 0);
            this.picturePanel.Controls.Add(this.controlsPanel, 1, 0);
            this.picturePanel.Controls.Add(this.selectedFolderPanel, 0, 1);
            this.picturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePanel.Location = new System.Drawing.Point(3, 28);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.RowCount = 2;
            this.picturePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.picturePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.picturePanel.Size = new System.Drawing.Size(618, 411);
            this.picturePanel.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(4, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(428, 382);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.statsGroupBox);
            this.controlsPanel.Controls.Add(this.helpButton);
            this.controlsPanel.Controls.Add(this.OKButton);
            this.controlsPanel.Controls.Add(this.inputTextBox);
            this.controlsPanel.Controls.Add(this.stopButton);
            this.controlsPanel.Controls.Add(this.nextButton);
            this.controlsPanel.Controls.Add(this.hintCheckBox);
            this.controlsPanel.Controls.Add(this.trainingCheckBox);
            this.controlsPanel.Controls.Add(this.startButton);
            this.controlsPanel.Controls.Add(this.browseButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(439, 4);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(175, 382);
            this.controlsPanel.TabIndex = 2;
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.wrongAnswersCount);
            this.statsGroupBox.Controls.Add(this.rightAnswersCount);
            this.statsGroupBox.Controls.Add(this.wrongAnswersLabel);
            this.statsGroupBox.Controls.Add(this.rightAnswersLabel);
            this.statsGroupBox.Location = new System.Drawing.Point(10, 140);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(144, 71);
            this.statsGroupBox.TabIndex = 12;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Statistiky";
            this.statsGroupBox.Visible = false;
            // 
            // wrongAnswersCount
            // 
            this.wrongAnswersCount.Location = new System.Drawing.Point(62, 45);
            this.wrongAnswersCount.Name = "wrongAnswersCount";
            this.wrongAnswersCount.Size = new System.Drawing.Size(67, 13);
            this.wrongAnswersCount.TabIndex = 3;
            this.wrongAnswersCount.Text = "0";
            // 
            // rightAnswersCount
            // 
            this.rightAnswersCount.Location = new System.Drawing.Point(62, 28);
            this.rightAnswersCount.Name = "rightAnswersCount";
            this.rightAnswersCount.Size = new System.Drawing.Size(67, 13);
            this.rightAnswersCount.TabIndex = 2;
            this.rightAnswersCount.Text = "0";
            // 
            // wrongAnswersLabel
            // 
            this.wrongAnswersLabel.AutoSize = true;
            this.wrongAnswersLabel.Location = new System.Drawing.Point(6, 45);
            this.wrongAnswersLabel.Name = "wrongAnswersLabel";
            this.wrongAnswersLabel.Size = new System.Drawing.Size(44, 13);
            this.wrongAnswersLabel.TabIndex = 1;
            this.wrongAnswersLabel.Text = "Špatně:";
            // 
            // rightAnswersLabel
            // 
            this.rightAnswersLabel.AutoSize = true;
            this.rightAnswersLabel.Location = new System.Drawing.Point(6, 28);
            this.rightAnswersLabel.Name = "rightAnswersLabel";
            this.rightAnswersLabel.Size = new System.Drawing.Size(50, 13);
            this.rightAnswersLabel.TabIndex = 0;
            this.rightAnswersLabel.Text = "Správně:";
            // 
            // helpButton
            // 
            this.helpButton.Enabled = false;
            this.helpButton.Location = new System.Drawing.Point(47, 356);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(31, 23);
            this.helpButton.TabIndex = 11;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Enabled = false;
            this.OKButton.Location = new System.Drawing.Point(10, 356);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(31, 23);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputTextBox.Enabled = false;
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputTextBox.Location = new System.Drawing.Point(10, 327);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(144, 23);
            this.inputTextBox.TabIndex = 9;
            this.inputTextBox.Enter += new System.EventHandler(this.inputTextBox_Enter);
            this.inputTextBox.Leave += new System.EventHandler(this.inputTextBox_Leave);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(87, 98);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(67, 23);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(84, 356);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(70, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Další";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // hintCheckBox
            // 
            this.hintCheckBox.AutoSize = true;
            this.hintCheckBox.Checked = true;
            this.hintCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hintCheckBox.Enabled = false;
            this.hintCheckBox.Location = new System.Drawing.Point(10, 63);
            this.hintCheckBox.Name = "hintCheckBox";
            this.hintCheckBox.Size = new System.Drawing.Size(88, 17);
            this.hintCheckBox.TabIndex = 5;
            this.hintCheckBox.Text = "Našeptávání";
            this.hintCheckBox.UseVisualStyleBackColor = true;
            // 
            // trainingCheckBox
            // 
            this.trainingCheckBox.AutoSize = true;
            this.trainingCheckBox.Checked = true;
            this.trainingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trainingCheckBox.Enabled = false;
            this.trainingCheckBox.Location = new System.Drawing.Point(10, 43);
            this.trainingCheckBox.Name = "trainingCheckBox";
            this.trainingCheckBox.Size = new System.Drawing.Size(62, 17);
            this.trainingCheckBox.TabIndex = 3;
            this.trainingCheckBox.Text = "Trénink";
            this.trainingCheckBox.UseVisualStyleBackColor = true;
            this.trainingCheckBox.CheckedChanged += new System.EventHandler(this.trainingCheckBox_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(10, 98);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(67, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(10, 5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(144, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Otevřít složku s obrázky...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // selectedFolderPanel
            // 
            this.selectedFolderPanel.AutoSize = true;
            this.selectedFolderPanel.Controls.Add(this.selectedFolderText);
            this.selectedFolderPanel.Controls.Add(this.selectedFolderLabel);
            this.selectedFolderPanel.Location = new System.Drawing.Point(4, 393);
            this.selectedFolderPanel.Name = "selectedFolderPanel";
            this.selectedFolderPanel.Size = new System.Drawing.Size(163, 13);
            this.selectedFolderPanel.TabIndex = 3;
            // 
            // selectedFolderText
            // 
            this.selectedFolderText.AutoSize = true;
            this.selectedFolderText.Location = new System.Drawing.Point(91, 0);
            this.selectedFolderText.Name = "selectedFolderText";
            this.selectedFolderText.Size = new System.Drawing.Size(69, 13);
            this.selectedFolderText.TabIndex = 1;
            this.selectedFolderText.Text = "<nevybrána>";
            // 
            // selectedFolderLabel
            // 
            this.selectedFolderLabel.AutoSize = true;
            this.selectedFolderLabel.Location = new System.Drawing.Point(4, 0);
            this.selectedFolderLabel.Name = "selectedFolderLabel";
            this.selectedFolderLabel.Size = new System.Drawing.Size(90, 13);
            this.selectedFolderLabel.TabIndex = 0;
            this.selectedFolderLabel.Text = "Složka s obrázky:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripButton,
            this.helpToolStripDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(624, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // settingsToolStripButton
            // 
            this.settingsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsToolStripButton.Name = "settingsToolStripButton";
            this.settingsToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.settingsToolStripButton.Text = "Nastavení";
            this.settingsToolStripButton.Click += new System.EventHandler(this.settingsToolStripButton_Click);
            // 
            // helpToolStripDropDownButton
            // 
            this.helpToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripDropDownButton.Name = "helpToolStripDropDownButton";
            this.helpToolStripDropDownButton.Size = new System.Drawing.Size(58, 22);
            this.helpToolStripDropDownButton.Text = "Pomoc";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.aboutToolStripMenuItem.Text = "O aplikaci";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Zkontrolovat aktualizace";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // Poznavacka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Poznavacka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poznávačka";
            this.Shown += new System.EventHandler(this.Poznavacka_Shown);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.selectedFolderPanel.ResumeLayout(false);
            this.selectedFolderPanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel picturePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.CheckBox hintCheckBox;
        private System.Windows.Forms.CheckBox trainingCheckBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Panel selectedFolderPanel;
        private System.Windows.Forms.Label selectedFolderText;
        private System.Windows.Forms.Label selectedFolderLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.Label wrongAnswersCount;
        private System.Windows.Forms.Label rightAnswersCount;
        private System.Windows.Forms.Label wrongAnswersLabel;
        private System.Windows.Forms.Label rightAnswersLabel;
        private System.Windows.Forms.ToolStripButton settingsToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton helpToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
    }
}

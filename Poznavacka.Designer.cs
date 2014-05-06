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
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.picturePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.helpButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.hintCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trainingCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedFolder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.rightAnswersLabel = new System.Windows.Forms.Label();
            this.wrongAnswersLabel = new System.Windows.Forms.Label();
            this.rightAnswersCount = new System.Windows.Forms.Label();
            this.wrongAnswersCount = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.controlsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.picturePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.picturePanel.Controls.Add(this.pictureBox, 0, 0);
            this.picturePanel.Controls.Add(this.controlsPanel, 1, 0);
            this.picturePanel.Controls.Add(this.panel1, 0, 1);
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
            this.pictureBox.Size = new System.Drawing.Size(436, 382);
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
            this.controlsPanel.Controls.Add(this.label2);
            this.controlsPanel.Controls.Add(this.trainingCheckBox);
            this.controlsPanel.Controls.Add(this.label1);
            this.controlsPanel.Controls.Add(this.startButton);
            this.controlsPanel.Controls.Add(this.browseButton);
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(447, 4);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(167, 382);
            this.controlsPanel.TabIndex = 2;
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
            this.hintCheckBox.Location = new System.Drawing.Point(85, 64);
            this.hintCheckBox.Name = "hintCheckBox";
            this.hintCheckBox.Size = new System.Drawing.Size(15, 14);
            this.hintCheckBox.TabIndex = 5;
            this.hintCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Našeptávání:";
            // 
            // trainingCheckBox
            // 
            this.trainingCheckBox.AutoSize = true;
            this.trainingCheckBox.Checked = true;
            this.trainingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trainingCheckBox.Enabled = false;
            this.trainingCheckBox.Location = new System.Drawing.Point(85, 43);
            this.trainingCheckBox.Name = "trainingCheckBox";
            this.trainingCheckBox.Size = new System.Drawing.Size(15, 14);
            this.trainingCheckBox.TabIndex = 3;
            this.trainingCheckBox.UseVisualStyleBackColor = true;
            this.trainingCheckBox.CheckedChanged += new System.EventHandler(this.trainingCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trénink:";
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
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.selectedFolder);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 13);
            this.panel1.TabIndex = 3;
            // 
            // selectedFolder
            // 
            this.selectedFolder.AutoSize = true;
            this.selectedFolder.Location = new System.Drawing.Point(91, 0);
            this.selectedFolder.Name = "selectedFolder";
            this.selectedFolder.Size = new System.Drawing.Size(69, 13);
            this.selectedFolder.TabIndex = 1;
            this.selectedFolder.Text = "<nevybrána>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Složka s obrázky:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(624, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.aboutToolStripButton.Text = "O programu";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripButton_Click);
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.wrongAnswersCount);
            this.statsGroupBox.Controls.Add(this.rightAnswersCount);
            this.statsGroupBox.Controls.Add(this.wrongAnswersLabel);
            this.statsGroupBox.Controls.Add(this.rightAnswersLabel);
            this.statsGroupBox.Location = new System.Drawing.Point(10, 127);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(144, 71);
            this.statsGroupBox.TabIndex = 12;
            this.statsGroupBox.TabStop = false;
            this.statsGroupBox.Text = "Statistiky";
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
            // wrongAnswersLabel
            // 
            this.wrongAnswersLabel.AutoSize = true;
            this.wrongAnswersLabel.Location = new System.Drawing.Point(6, 45);
            this.wrongAnswersLabel.Name = "wrongAnswersLabel";
            this.wrongAnswersLabel.Size = new System.Drawing.Size(44, 13);
            this.wrongAnswersLabel.TabIndex = 1;
            this.wrongAnswersLabel.Text = "Špatně:";
            // 
            // rightAnswersCount
            // 
            this.rightAnswersCount.Location = new System.Drawing.Point(62, 28);
            this.rightAnswersCount.Name = "rightAnswersCount";
            this.rightAnswersCount.Size = new System.Drawing.Size(67, 13);
            this.rightAnswersCount.TabIndex = 2;
            this.rightAnswersCount.Text = "0";
            // 
            // wrongAnswersCount
            // 
            this.wrongAnswersCount.Location = new System.Drawing.Point(62, 45);
            this.wrongAnswersCount.Name = "wrongAnswersCount";
            this.wrongAnswersCount.Size = new System.Drawing.Size(67, 13);
            this.wrongAnswersCount.TabIndex = 3;
            this.wrongAnswersCount.Text = "0";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.TableLayoutPanel picturePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.CheckBox hintCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox trainingCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label selectedFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.GroupBox statsGroupBox;
        private System.Windows.Forms.Label wrongAnswersCount;
        private System.Windows.Forms.Label rightAnswersCount;
        private System.Windows.Forms.Label wrongAnswersLabel;
        private System.Windows.Forms.Label rightAnswersLabel;
    }
}

namespace Poznavacka
{
    partial class Update
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
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.updateTextLabel = new System.Windows.Forms.Label();
            this.checkForUpdatesOnStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(48, 60);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Aktualizovat";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(129, 60);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Zavřít";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // updateTextLabel
            // 
            this.updateTextLabel.AutoSize = true;
            this.updateTextLabel.Location = new System.Drawing.Point(5, 9);
            this.updateTextLabel.Name = "updateTextLabel";
            this.updateTextLabel.Size = new System.Drawing.Size(203, 13);
            this.updateTextLabel.TabIndex = 2;
            this.updateTextLabel.Text = "K dispozici je nová verze aplikace (0.0.0).";
            // 
            // checkForUpdatesOnStartupCheckBox
            // 
            this.checkForUpdatesOnStartupCheckBox.AutoSize = true;
            this.checkForUpdatesOnStartupCheckBox.Location = new System.Drawing.Point(13, 29);
            this.checkForUpdatesOnStartupCheckBox.Name = "checkForUpdatesOnStartupCheckBox";
            this.checkForUpdatesOnStartupCheckBox.Size = new System.Drawing.Size(122, 17);
            this.checkForUpdatesOnStartupCheckBox.TabIndex = 3;
            this.checkForUpdatesOnStartupCheckBox.Text = "Příště nezobrazovat";
            this.checkForUpdatesOnStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(216, 95);
            this.ControlBox = false;
            this.Controls.Add(this.checkForUpdatesOnStartupCheckBox);
            this.Controls.Add(this.updateTextLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Aktualizace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label updateTextLabel;
        private System.Windows.Forms.CheckBox checkForUpdatesOnStartupCheckBox;
    }
}
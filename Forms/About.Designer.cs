namespace Poznavacka
{
    partial class About
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
            this.closeButton = new System.Windows.Forms.Button();
            this.authorLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.authorTextLabel = new System.Windows.Forms.Label();
            this.versionTextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(80, 57);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(74, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Zavřít";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(12, 9);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(35, 13);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Autor:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 29);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(37, 13);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Verze:";
            // 
            // authorTextLabel
            // 
            this.authorTextLabel.AutoSize = true;
            this.authorTextLabel.Location = new System.Drawing.Point(53, 9);
            this.authorTextLabel.Name = "authorTextLabel";
            this.authorTextLabel.Size = new System.Drawing.Size(61, 13);
            this.authorTextLabel.TabIndex = 3;
            this.authorTextLabel.Text = "Adam Ivora";
            // 
            // versionTextLabel
            // 
            this.versionTextLabel.AutoSize = true;
            this.versionTextLabel.Location = new System.Drawing.Point(53, 29);
            this.versionTextLabel.Name = "versionTextLabel";
            this.versionTextLabel.Size = new System.Drawing.Size(31, 13);
            this.versionTextLabel.TabIndex = 4;
            this.versionTextLabel.Text = "0.0.0";
            // 
            // About
            // 
            this.AcceptButton = this.closeButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(166, 92);
            this.Controls.Add(this.versionTextLabel);
            this.Controls.Add(this.authorTextLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "O aplikaci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label authorTextLabel;
        private System.Windows.Forms.Label versionTextLabel;
    }
}
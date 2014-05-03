using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Poznavacka
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/adamivora/poznavacka-opakovani/releases");
            Application.Exit();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

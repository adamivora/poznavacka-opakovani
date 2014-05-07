using System;
using System.Windows.Forms;

namespace Poznavacka
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            versionTextLabel.Text = Application.ProductVersion;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

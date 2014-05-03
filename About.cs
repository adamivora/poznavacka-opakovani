using System;
using System.Windows.Forms;

namespace Poznavacka
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            label2.Text = String.Format("Verze: {0}", Application.ProductVersion);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

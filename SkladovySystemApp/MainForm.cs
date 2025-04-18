using System;
using System.Windows.Forms;

namespace SkladovySystemApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnKonec_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProdukty_Click_1(object sender, EventArgs e)
        {
            var form = new FormProdukty();
            form.ShowDialog();
        }

        private void btnObjednavky_Click_1(object sender, EventArgs e)
        {
            var form = new FormObjednavky();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var form = new FormObjednavky();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var form = new FormProdukty();
            form.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

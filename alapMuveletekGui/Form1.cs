using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alapMuveletekGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSzorzas_Click(object sender, EventArgs e)
        {
            KerdesBox.Text = "10 * 5";
        }

        private void btnOsszeadas_Click(object sender, EventArgs e)
        {
            KerdesBox.Text = "23 + 4";
        }

        private void btnKivonas_Click(object sender, EventArgs e)
        {
            KerdesBox.Text = "10 - 5";
        }

        private void btnOsztas_Click(object sender, EventArgs e)
        {
            KerdesBox.Text = "10 / 5";
        }

        private void Ellenorzes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A válasz helyes");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}

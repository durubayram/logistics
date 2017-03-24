using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Anasayfa2 : Form
    {
        public Anasayfa2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void yeniKayıtButton_Click(object sender, EventArgs e)
        {
            YeniKayıt yeni = new YeniKayıt();

            yeni.ShowDialog();
        }

        private void ürünTakibiButton_Click(object sender, EventArgs e)
        {
            Takip uruntakip = new Takip();
            uruntakip.ShowDialog();
        }
    }
}

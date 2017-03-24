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
    public partial class Takip : Form
    {
        public Takip()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriTable musteri = new MusteriTable();
            musteri.ShowDialog();
                        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ÜrünTable ürün = new ÜrünTable();
            ürün.ShowDialog();
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.sahlojistik.com");
            
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.ikralojistik.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.ekol.com");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.omsan.com.tr");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.borusanlojistik.com");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.bumeranglojistik.com");
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            YükTürüBilgi form = new YükTürüBilgi();
            form.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelTable personel = new PersonelTable();
            personel.ShowDialog();
        }

    }
}

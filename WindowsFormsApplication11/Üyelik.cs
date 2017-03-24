using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Üyelik : Form
    {
        public Üyelik()
        {
            InitializeComponent();
        }

        private void kayıtButton_Click(object sender, EventArgs e)
        {
            if (kullanıcıTextBox.Text == "" || sifreTextBox.Text == "")
            {
                MessageBox.Show("Lütfen kullanıcı adı yada sifre bölümünü eksiksiz doldurunuz!");
            }
            else
            {
                SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Database.mdf;Integrated Security=True;Connect Timeout=30");
                cnn.Open();

                string sql = "INSERT INTO Uyeler VALUES(@ad,@sifre)";
                SqlCommand komut = new SqlCommand(sql, cnn);

                komut.Parameters.AddWithValue("@ad", kullanıcıTextBox.Text);
                komut.Parameters.AddWithValue("@sifre", sifreTextBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız Tamamlandı", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Anasayfa ana = new Anasayfa();
                ana.ShowDialog();
                Üyelik uye = new Üyelik();
                uye.Hide();

            }
        }

        private void Üyelik_Load(object sender, EventArgs e)
        {

        }
    }
}

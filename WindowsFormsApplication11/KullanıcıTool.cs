using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication11
{
    public partial class KullanıcıTool : UserControl
    {
        public KullanıcıTool()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Database.mdf;Integrated Security=True;Connect Timeout=30");
                cnn.Open();
                SqlParameter prm1 = new SqlParameter("@ad", textBox1.Text);
                SqlParameter prm2 = new SqlParameter("@sifre", textBox2.Text);
                string sql = "";
                sql = "SELECT * FROM Uyeler WHERE ad =@ad AND sifre = @sifre";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Giriş Başarılı!","",MessageBoxButtons.OK);
                    Anasayfa2 a = new Anasayfa2();
                    a.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı ve şifre girdiniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    

        private void uyeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Üyelik uye = new Üyelik();
            uye.ShowDialog();

        }
    }
}

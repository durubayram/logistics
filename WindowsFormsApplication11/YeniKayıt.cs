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
    public partial class YeniKayıt : Form
    {
        private string secim;
       
        

        public YeniKayıt()
        {
            InitializeComponent();
            DateTime dt = DateTime.Now;
            teslimDateTime.MinDate = dt.AddDays(3);
            teslimDateTime.MaxDate = dt.AddMonths(3);

        }

        private void button1_Click(object sender, EventArgs e) {



            if (gonAdSoyadBox.Text != "" && gonTelText.Text != "" && gonSehirText.Text != "" && gonAdresText.Text != "" && aliciAdsoyadText.Text != "" && aliciSehirText.Text != "" && aliciTelText.Text != "" && aliciAdresText.Text != "" && teslimDateTime.Text != "")
            {
                if (!checkBox1.Checked)
                {
                    MessageBox.Show("Lütfen Kullanım Sözleşmesini ve Gizlilik Kaydını Onaylayınız!");
                    return;
                }


                int sira = listView1.Items.Count;


                listView1.Items.Add(RefText.Text);
                listView1.Items[sira].SubItems.Add(gonAdSoyadBox.Text);
                listView1.Items[sira].SubItems.Add(gonTelText.Text);
                listView1.Items[sira].SubItems.Add(gonSehirText.Text);
                listView1.Items[sira].SubItems.Add(gonAdresText.Text);
                listView1.Items[sira].SubItems.Add(aliciAdsoyadText.Text);
                listView1.Items[sira].SubItems.Add(aliciTelText.Text);
                listView1.Items[sira].SubItems.Add(aliciSehirText.Text);
                listView1.Items[sira].SubItems.Add(aliciAdresText.Text);


                if (perakenderadio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(perakenderadio.Text);
                    secim = perakenderadio.Text;
                }
                else if (gıdaradio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(gıdaradio.Text);
                    secim = gıdaradio.Text;
                }
                else if (tekstilradio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(tekstilradio.Text);
                    secim = tekstilradio.Text;
                }
                else if (otomobilradio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(otomobilradio.Text);
                    secim = otomobilradio.Text;
                }
                else if (inşaatradio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(inşaatradio.Text);
                    secim = inşaatradio.Text;
                }

                else if (etkinlikfuarradio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(etkinlikfuarradio.Text);
                    secim = etkinlikfuarradio.Text;
                }
                else if (tehlikelimadderadio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(tehlikelimadderadio.Text);
                    secim = tehlikelimadderadio.Text;
                }
                else if (hastaneilaçradio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(hastaneilaçradio.Text);
                    secim = hastaneilaçradio.Text;
                }
                else if (hayvanradio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(hayvanradio.Text);
                    secim = hayvanradio.Text;
                }

                else if (elektronikradio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(elektronikradio.Text);
                    secim = elektronikradio.Text;
                }
                else if (turizmradio.Checked == true)
                {
                    listView1.Items[sira].SubItems.Add(turizmradio.Text);
                    secim = turizmradio.Text;
                }
                else MessageBox.Show("Lütfen yük türünü işaretleyiniz!");


                listView1.Items[sira].SubItems.Add(yukMiktariNumericUpDown.Text);
                listView1.Items[sira].SubItems.Add(teslimDateTime.Text);

            }
            else
            {

                MessageBox.Show("Lütfen bilgileri tam giriniz!");
                return;
            }

     
            SqlConnection cnn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Database.mdf;Integrated Security=True;Connect Timeout=30");
            cnn.Open();

            String sql= "INSERT INTO Musteri VALUES(@GondAdSoyad,@GondTel,@GondSehir,@GondAdres,@AliciAdSoyad,@AliciTel,@AliciSehir,@AliciAdres)";
            SqlCommand komut = new SqlCommand(sql, cnn);

            komut.Parameters.AddWithValue("@GondAdSoyad", gonAdSoyadBox.Text);
            komut.Parameters.AddWithValue("@GondTel", gonTelText.Text);
            komut.Parameters.AddWithValue("@GondSehir", gonSehirText.Text);
            komut.Parameters.AddWithValue("@GondAdres", gonAdresText.Text);
            komut.Parameters.AddWithValue("@AliciAdSoyad", aliciAdsoyadText.Text);
            komut.Parameters.AddWithValue("@AliciTel", aliciTelText.Text);
            komut.Parameters.AddWithValue("@AliciSehir", aliciSehirText.Text);
            komut.Parameters.AddWithValue("@AliciAdres", aliciAdresText.Text);
            komut.ExecuteNonQuery();

      

            String abc = "INSERT INTO Ürün VALUES(@YükTürü,@YükMiktari,@TeslimTarihi)";
            SqlCommand komut1 = new SqlCommand(abc, cnn);

            komut1.Parameters.AddWithValue("@YükTürü", secim);
            komut1.Parameters.AddWithValue("@YükMiktari", yukMiktariNumericUpDown.Value);
            komut1.Parameters.AddWithValue("@TeslimTarihi", teslimDateTime.Value);
           

            komut1.ExecuteNonQuery();
           



            MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
          
   }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Referans Numarası", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Gönderici", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Gön.Tel", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Gön.Şehir", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Gön.Adres", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Alıcı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Al.Tel", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Al.Şehir", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Al.Adres", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Yük Türü", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Yük Miktarı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Teslim Tarihi", 100, HorizontalAlignment.Left);



        }

        private void telText_KeyPressed(object sender, KeyPressEventArgs e)
        {
            gonTelText.MaxLength = 13;

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                checkBox1.Tag = MessageBox.Show("Kullanıcı, kullanacagı hizmetten faydalanmaya başladığı andan itibaren işbu kullanım sözleşmesini tüm yükümlülüğünü kabul etmiş sayılacağına ve sözleşmenin kendisi hakkında hüküm ifade edeceğini kabul eder. Kullanıcı sözleşme ile üstlenmiş olduğu yükümlülüklere aykırı hareketi nedeni doğrudan ve dolaylı tüm zararları tazmin edecek olup, kullanıcının sözleşmeye aykırı davranışları nedeni ile kamu kurumlarına ve/veya 3. şahıslara ödemek zorunda kalabileceği her türlü tazminat ve / veya idari/adli para cezaları için aynen rücu hakkına sahiptir.");
            }
        }

        private void GonFirmaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar);
        }

        private void GönFirmaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar);
        }


        private void cıkısButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void aliciTelText_KeyPress(object sender, KeyPressEventArgs e)
        {
            aliciTelText.MaxLength = 13;

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }

     

        private void yükTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form();
            var listb = new ListBox();
            listb.Items.Add("Perakende");
            listb.Items.Add("Gıda");
            listb.Items.Add("Tekstil");
            listb.Items.Add("Otomobil");
            listb.Items.Add("İnşaat");
            listb.Items.Add("Etkinlik ve Fuar");
            listb.Items.Add("Tehlikeli Madde");
            listb.Items.Add("Hastane ve İlaç");
            listb.Items.Add("Hayvan");
            listb.Items.Add("Elektronik");
            listb.Items.Add("Turizm");

            myForm.Controls.Add(listb);

            myForm.Show();


        }

        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var myForm = new Form();
            var listb = new ListBox();

            listb.Items.Add("Şah Lojistik");
            listb.Items.Add("İkra Lojistik");
            listb.Items.Add("Ekol");
            listb.Items.Add("Omsan");
            listb.Items.Add("Borusan Lojistik");
            listb.Items.Add("Bumerang Lojitik");
            

            myForm.Controls.Add(listb);

            myForm.Show();

        }

        private void programRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(@"" + Application.StartupPath + "\\LOJİSTİK TAKİP PROGRAMI.docx");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            programRaporuToolStripMenuItem_Click(sender, e);
        }

        private void işlemKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripButton_Click(sender, e);
        }

       private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cıkısButton_Click(sender, e);
        }
    }
}

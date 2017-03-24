using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApplication11
{
    public partial class PersonelTable : Form
    {
        public PersonelTable()
        {
            InitializeComponent();
        }
        void fill()
        {
            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"Personel.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);

            personelDataGridView.DataSource = ds.Tables[0];
            xmlFile.Close();
        }

        private void PersonelTable_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"Personel.xml");

            x.Element("Calisanlar").Add(
            new XElement("Personel",
            new XElement("tc", tcBox.Text),
            new XElement("adsoyad", adBox.Text),
            new XElement("telefon", telBox.Text),
            new XElement("departman", departmanBox.Text) ));

            x.Save(@"Personel.xml");
            MessageBox.Show("Yeni kişi talebiniz sisteme kayıt oldu.");
            fill();
        }

        private void silButton_Click(object sender, EventArgs e)
        { 

                XDocument x = XDocument.Load(@"Personel.xml");
                x.Root.Elements().Where(a => a.Element("tc").Value == tcBox.Text).Remove();
                x.Save(@"Personel.xml");
                MessageBox.Show("Silme işlemi tamamlandı!");
                fill();
      
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            if (tcBox.Text != "")
            {
                XDocument x = XDocument.Load(@"Personel.xml");
                XElement node = x.Element("Calisanlar").Elements("Personel").FirstOrDefault(a => a.Element("tc").Value.Trim() == tcBox.Text);
                if (node != null)
                {
                    node.SetElementValue("adsoyad", adBox.Text);
                    node.SetElementValue("telefon", telBox.Text);
                    node.SetElementValue("departman", departmanBox.Text);
                    x.Save(@"Personel.xml");
                    fill();
                    MessageBox.Show("Güncelleme yapıldı.");
                }
            }
            else
            {
                MessageBox.Show("lütfen güncellemek istediğiniz kişinin tc numarasını giriniz");
            }
        }

        private void telBox_KeyPress(object sender, KeyPressEventArgs e)
        {
             telBox.MaxLength = 11;

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }

        private void tcBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            tcBox.MaxLength = 11;

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            else
            {
                e.Handled = false;
            }
        }
    }
}

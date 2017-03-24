using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication11
{
    public partial class ÜrünTable : Form
    {
        public ÜrünTable()
        {
            InitializeComponent();
        }

        private databaseDataContext db = new databaseDataContext();

        SqlConnection connection;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        private void ÜrünTable_Load(object sender, EventArgs e)
        {
            

            connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename =" + Application.StartupPath + "\\Database.mdf; Integrated Security = True; Connect Timeout = 30");
            connection.Open();
            da = new SqlDataAdapter("Select * from Ürün", connection);
            ds = new DataSet();
            da.Fill(ds, "Ürün");
            ürünDataGridView.DataSource = ds.Tables[0];
            connection.Close();
        }

        private void güncelleButton_Click(object sender, EventArgs e) {
            cmdb = new SqlCommandBuilder(da);
            da.Update(ds, "Ürün");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            string Aratxt = txtAra.Text.Trim().ToUpper();

            int j = -1;

            for (int i = 0; i <= ürünDataGridView.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in ürünDataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in ürünDataGridView.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == Aratxt)
                            {
                                cell.Style.BackColor = Color.Yellow;
                                j = 0;
                                break;
                            }

                        }
                    }
                }
            }
            if (j == -1)
            {
                MessageBox.Show("Kayıt bulunamadı!");
            }
        }
    }
}
    


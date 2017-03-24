namespace WindowsFormsApplication11
{
    partial class deneme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referansnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsteriadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yüktürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yükmiktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.göndericiAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alıcıAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gönSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alanSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.referansnumDataGridViewTextBoxColumn,
            this.müsteriadıDataGridViewTextBoxColumn,
            this.yüktürüDataGridViewTextBoxColumn,
            this.yükmiktarıDataGridViewTextBoxColumn,
            this.göndericiAdresDataGridViewTextBoxColumn,
            this.alıcıAdresDataGridViewTextBoxColumn,
            this.gönSehirDataGridViewTextBoxColumn,
            this.alanSehirDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataSource = typeof(WindowsFormsApplication11.Table);
            // 
            // referansnumDataGridViewTextBoxColumn
            // 
            this.referansnumDataGridViewTextBoxColumn.DataPropertyName = "referansnum";
            this.referansnumDataGridViewTextBoxColumn.HeaderText = "referansnum";
            this.referansnumDataGridViewTextBoxColumn.Name = "referansnumDataGridViewTextBoxColumn";
            // 
            // müsteriadıDataGridViewTextBoxColumn
            // 
            this.müsteriadıDataGridViewTextBoxColumn.DataPropertyName = "müsteri_adı";
            this.müsteriadıDataGridViewTextBoxColumn.HeaderText = "müsteri_adı";
            this.müsteriadıDataGridViewTextBoxColumn.Name = "müsteriadıDataGridViewTextBoxColumn";
            // 
            // yüktürüDataGridViewTextBoxColumn
            // 
            this.yüktürüDataGridViewTextBoxColumn.DataPropertyName = "yüktürü";
            this.yüktürüDataGridViewTextBoxColumn.HeaderText = "yüktürü";
            this.yüktürüDataGridViewTextBoxColumn.Name = "yüktürüDataGridViewTextBoxColumn";
            // 
            // yükmiktarıDataGridViewTextBoxColumn
            // 
            this.yükmiktarıDataGridViewTextBoxColumn.DataPropertyName = "yükmiktarı";
            this.yükmiktarıDataGridViewTextBoxColumn.HeaderText = "yükmiktarı";
            this.yükmiktarıDataGridViewTextBoxColumn.Name = "yükmiktarıDataGridViewTextBoxColumn";
            // 
            // göndericiAdresDataGridViewTextBoxColumn
            // 
            this.göndericiAdresDataGridViewTextBoxColumn.DataPropertyName = "göndericiAdres";
            this.göndericiAdresDataGridViewTextBoxColumn.HeaderText = "göndericiAdres";
            this.göndericiAdresDataGridViewTextBoxColumn.Name = "göndericiAdresDataGridViewTextBoxColumn";
            // 
            // alıcıAdresDataGridViewTextBoxColumn
            // 
            this.alıcıAdresDataGridViewTextBoxColumn.DataPropertyName = "alıcıAdres";
            this.alıcıAdresDataGridViewTextBoxColumn.HeaderText = "alıcıAdres";
            this.alıcıAdresDataGridViewTextBoxColumn.Name = "alıcıAdresDataGridViewTextBoxColumn";
            // 
            // gönSehirDataGridViewTextBoxColumn
            // 
            this.gönSehirDataGridViewTextBoxColumn.DataPropertyName = "gönSehir";
            this.gönSehirDataGridViewTextBoxColumn.HeaderText = "gönSehir";
            this.gönSehirDataGridViewTextBoxColumn.Name = "gönSehirDataGridViewTextBoxColumn";
            // 
            // alanSehirDataGridViewTextBoxColumn
            // 
            this.alanSehirDataGridViewTextBoxColumn.DataPropertyName = "alanSehir";
            this.alanSehirDataGridViewTextBoxColumn.HeaderText = "alanSehir";
            this.alanSehirDataGridViewTextBoxColumn.Name = "alanSehirDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "deneme";
            this.Text = "deneme";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn referansnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteriadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yüktürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yükmiktarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn göndericiAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alıcıAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gönSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alanSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
    }
}
namespace WindowsFormsApplication11
{
    partial class MusteriTable
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
            this.güncelleButton = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.araButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // güncelleButton
            // 
            this.güncelleButton.Location = new System.Drawing.Point(403, 321);
            this.güncelleButton.Name = "güncelleButton";
            this.güncelleButton.Size = new System.Drawing.Size(107, 45);
            this.güncelleButton.TabIndex = 2;
            this.güncelleButton.Text = "GÜNCELLE";
            this.güncelleButton.UseVisualStyleBackColor = true;
            this.güncelleButton.Click += new System.EventHandler(this.güncelleButton_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(19, 332);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 6;
            // 
            // araButton
            // 
            this.araButton.Location = new System.Drawing.Point(134, 332);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(75, 23);
            this.araButton.TabIndex = 5;
            this.araButton.Text = "ARA";
            this.araButton.UseVisualStyleBackColor = true;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Müşteri Bilgi Tablosu";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataSource = typeof(WindowsFormsApplication11.Musteri);
            // 
            // musteriDataGridView
            // 
            this.musteriDataGridView.AutoGenerateColumns = false;
            this.musteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.musteriDataGridView.DataSource = this.musteriBindingSource;
            this.musteriDataGridView.Location = new System.Drawing.Point(12, 35);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.Size = new System.Drawing.Size(941, 280);
            this.musteriDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RefNum";
            this.dataGridViewTextBoxColumn9.HeaderText = "RefNum";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GondAdSoyad";
            this.dataGridViewTextBoxColumn10.HeaderText = "GondAdSoyad";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "GondTel";
            this.dataGridViewTextBoxColumn11.HeaderText = "GondTel";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "GondSehir";
            this.dataGridViewTextBoxColumn12.HeaderText = "GondSehir";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "GondAdres";
            this.dataGridViewTextBoxColumn13.HeaderText = "GondAdres";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "AliciAdSoyad";
            this.dataGridViewTextBoxColumn14.HeaderText = "AliciAdSoyad";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "AliciTel";
            this.dataGridViewTextBoxColumn15.HeaderText = "AliciTel";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "AliciSehir";
            this.dataGridViewTextBoxColumn16.HeaderText = "AliciSehir";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "AliciAdres";
            this.dataGridViewTextBoxColumn17.HeaderText = "AliciAdres";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // MusteriTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 386);
            this.Controls.Add(this.musteriDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.güncelleButton);
            this.Name = "MusteriTable";
            this.Text = "MüsteriTable";
            this.Load += new System.EventHandler(this.GöndericiTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
     
        private System.Windows.Forms.Button güncelleButton;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private System.Windows.Forms.DataGridView musteriDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}
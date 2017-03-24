namespace WindowsFormsApplication11
{
    partial class ÜrünTable
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
            this.ürünBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ürünDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // güncelleButton
            // 
            this.güncelleButton.Location = new System.Drawing.Point(360, 319);
            this.güncelleButton.Name = "güncelleButton";
            this.güncelleButton.Size = new System.Drawing.Size(78, 45);
            this.güncelleButton.TabIndex = 2;
            this.güncelleButton.Text = "GÜNCELLE";
            this.güncelleButton.UseVisualStyleBackColor = true;
            this.güncelleButton.Click += new System.EventHandler(this.güncelleButton_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(36, 339);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 3;
            // 
            // araButton
            // 
            this.araButton.Location = new System.Drawing.Point(159, 332);
            this.araButton.Name = "araButton";
            this.araButton.Size = new System.Drawing.Size(69, 32);
            this.araButton.TabIndex = 4;
            this.araButton.Text = "ARA";
            this.araButton.UseVisualStyleBackColor = true;
            this.araButton.Click += new System.EventHandler(this.araButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ürün Tablosu";
            // 
            // ürünBindingSource
            // 
            this.ürünBindingSource.DataSource = typeof(WindowsFormsApplication11.Ürün);
            // 
            // ürünDataGridView
            // 
            this.ürünDataGridView.AutoGenerateColumns = false;
            this.ürünDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ürünDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.ürünDataGridView.DataSource = this.ürünBindingSource;
            this.ürünDataGridView.Location = new System.Drawing.Point(-5, 35);
            this.ürünDataGridView.Name = "ürünDataGridView";
            this.ürünDataGridView.Size = new System.Drawing.Size(443, 266);
            this.ürünDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RefNum";
            this.dataGridViewTextBoxColumn1.HeaderText = "RefNum";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "YükTürü";
            this.dataGridViewTextBoxColumn2.HeaderText = "YükTürü";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "YükMiktarı";
            this.dataGridViewTextBoxColumn3.HeaderText = "YükMiktarı";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TeslimTarihi";
            this.dataGridViewTextBoxColumn5.HeaderText = "TeslimTarihi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // ÜrünTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 379);
            this.Controls.Add(this.ürünDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.araButton);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.güncelleButton);
            this.Name = "ÜrünTable";
            this.Text = "ÜrünTable";
            this.Load += new System.EventHandler(this.ÜrünTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ürünBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ürünDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button güncelleButton;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button araButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ürünBindingSource;
        private System.Windows.Forms.DataGridView ürünDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
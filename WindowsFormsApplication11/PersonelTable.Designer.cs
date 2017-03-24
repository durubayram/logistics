namespace WindowsFormsApplication11
{
    partial class PersonelTable
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
            this.kaydetButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.telBox = new System.Windows.Forms.TextBox();
            this.adBox = new System.Windows.Forms.TextBox();
            this.departmanBox = new System.Windows.Forms.TextBox();
            this.personelDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tcBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kaydetButton
            // 
            this.kaydetButton.Location = new System.Drawing.Point(258, 365);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(75, 23);
            this.kaydetButton.TabIndex = 1;
            this.kaydetButton.Text = "KAYDET";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Location = new System.Drawing.Point(258, 336);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(75, 23);
            this.guncelleButton.TabIndex = 2;
            this.guncelleButton.Text = "GÜNCELLE";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(258, 307);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(75, 23);
            this.silButton.TabIndex = 3;
            this.silButton.Text = "SİL";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Departman";
            // 
            // telBox
            // 
            this.telBox.Location = new System.Drawing.Point(122, 342);
            this.telBox.Name = "telBox";
            this.telBox.Size = new System.Drawing.Size(100, 20);
            this.telBox.TabIndex = 10;
            this.telBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telBox_KeyPress);
            // 
            // adBox
            // 
            this.adBox.Location = new System.Drawing.Point(122, 316);
            this.adBox.Name = "adBox";
            this.adBox.Size = new System.Drawing.Size(100, 20);
            this.adBox.TabIndex = 8;
            // 
            // departmanBox
            // 
            this.departmanBox.Location = new System.Drawing.Point(122, 368);
            this.departmanBox.Name = "departmanBox";
            this.departmanBox.Size = new System.Drawing.Size(100, 20);
            this.departmanBox.TabIndex = 9;
            // 
            // personelDataGridView
            // 
            this.personelDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.personelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personelDataGridView.Location = new System.Drawing.Point(12, 12);
            this.personelDataGridView.Name = "personelDataGridView";
            this.personelDataGridView.Size = new System.Drawing.Size(501, 259);
            this.personelDataGridView.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TC";
            // 
            // tcBox
            // 
            this.tcBox.Location = new System.Drawing.Point(122, 289);
            this.tcBox.Name = "tcBox";
            this.tcBox.Size = new System.Drawing.Size(100, 20);
            this.tcBox.TabIndex = 13;
            this.tcBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(348, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 55);
            this.label5.TabIndex = 14;
            this.label5.Text = "*Silme ve Güncelleme işlemlerini TC numarasını girdikten sonra yapınız.";
            // 
            // PersonelTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 412);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tcBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.personelDataGridView);
            this.Controls.Add(this.departmanBox);
            this.Controls.Add(this.adBox);
            this.Controls.Add(this.telBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.kaydetButton);
            this.Name = "PersonelTable";
            this.Text = "PersonelTable";
            this.Load += new System.EventHandler(this.PersonelTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telBox;
        private System.Windows.Forms.TextBox adBox;
        private System.Windows.Forms.TextBox departmanBox;
        private System.Windows.Forms.DataGridView personelDataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tcBox;
        private System.Windows.Forms.Label label5;
    }
}
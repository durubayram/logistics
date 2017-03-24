namespace WindowsFormsApplication11
{
    partial class Anasayfa2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yeniKayıtButton = new System.Windows.Forms.Button();
            this.kayıtSorgulaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication11.Properties.Resources.transfererr;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 408);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // yeniKayıtButton
            // 
            this.yeniKayıtButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.yeniKayıtButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.yeniKayıtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniKayıtButton.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniKayıtButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yeniKayıtButton.Location = new System.Drawing.Point(98, 139);
            this.yeniKayıtButton.Name = "yeniKayıtButton";
            this.yeniKayıtButton.Size = new System.Drawing.Size(134, 122);
            this.yeniKayıtButton.TabIndex = 5;
            this.yeniKayıtButton.Text = "YENİ KAYIT";
            this.yeniKayıtButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.yeniKayıtButton.UseVisualStyleBackColor = false;
            this.yeniKayıtButton.Click += new System.EventHandler(this.yeniKayıtButton_Click);
            // 
            // kayıtSorgulaButton
            // 
            this.kayıtSorgulaButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.kayıtSorgulaButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.kayıtSorgulaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayıtSorgulaButton.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayıtSorgulaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kayıtSorgulaButton.Location = new System.Drawing.Point(370, 139);
            this.kayıtSorgulaButton.Name = "kayıtSorgulaButton";
            this.kayıtSorgulaButton.Size = new System.Drawing.Size(132, 122);
            this.kayıtSorgulaButton.TabIndex = 6;
            this.kayıtSorgulaButton.Text = "KAYIT SORGULA";
            this.kayıtSorgulaButton.UseVisualStyleBackColor = false;
            this.kayıtSorgulaButton.Click += new System.EventHandler(this.ürünTakibiButton_Click);
            // 
            // Anasayfa2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 401);
            this.Controls.Add(this.yeniKayıtButton);
            this.Controls.Add(this.kayıtSorgulaButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Anasayfa2";
            this.Text = "Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button yeniKayıtButton;
        private System.Windows.Forms.Button kayıtSorgulaButton;
    }
}
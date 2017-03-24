namespace WindowsFormsApplication11
{
    partial class Üyelik
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
            this.kayıtButton = new System.Windows.Forms.Button();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.kullanıcıTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kayıtButton
            // 
            this.kayıtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kayıtButton.Location = new System.Drawing.Point(295, 147);
            this.kayıtButton.Name = "kayıtButton";
            this.kayıtButton.Size = new System.Drawing.Size(75, 39);
            this.kayıtButton.TabIndex = 10;
            this.kayıtButton.Text = "Kayıt Ol";
            this.kayıtButton.UseVisualStyleBackColor = true;
            this.kayıtButton.Click += new System.EventHandler(this.kayıtButton_Click);
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(281, 117);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(100, 20);
            this.sifreTextBox.TabIndex = 9;
            this.sifreTextBox.UseSystemPasswordChar = true;
            // 
            // kullanıcıTextBox
            // 
            this.kullanıcıTextBox.Location = new System.Drawing.Point(281, 78);
            this.kullanıcıTextBox.Name = "kullanıcıTextBox";
            this.kullanıcıTextBox.Size = new System.Drawing.Size(100, 20);
            this.kullanıcıTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(218, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(182, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication11.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(40, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 145);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Üyelik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 249);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kayıtButton);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullanıcıTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Üyelik";
            this.Text = "Üyelik";
            this.Load += new System.EventHandler(this.Üyelik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button kayıtButton;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.TextBox kullanıcıTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
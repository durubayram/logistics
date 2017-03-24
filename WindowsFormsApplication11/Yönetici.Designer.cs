namespace WindowsFormsApplication11
{
    partial class Yönetici
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanıcıAdıTextBox = new System.Windows.Forms.TextBox();
            this.SıfreTextBox = new System.Windows.Forms.TextBox();
            this.yöneticiGirisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(168, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(168, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // kullanıcıAdıTextBox
            // 
            this.kullanıcıAdıTextBox.Location = new System.Drawing.Point(296, 34);
            this.kullanıcıAdıTextBox.Name = "kullanıcıAdıTextBox";
            this.kullanıcıAdıTextBox.Size = new System.Drawing.Size(100, 20);
            this.kullanıcıAdıTextBox.TabIndex = 2;
            // 
            // SıfreTextBox
            // 
            this.SıfreTextBox.Location = new System.Drawing.Point(296, 79);
            this.SıfreTextBox.Name = "SıfreTextBox";
            this.SıfreTextBox.Size = new System.Drawing.Size(100, 20);
            this.SıfreTextBox.TabIndex = 3;
            // 
            // yöneticiGirisButton
            // 
            this.yöneticiGirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yöneticiGirisButton.Location = new System.Drawing.Point(196, 191);
            this.yöneticiGirisButton.Name = "yöneticiGirisButton";
            this.yöneticiGirisButton.Size = new System.Drawing.Size(234, 47);
            this.yöneticiGirisButton.TabIndex = 4;
            this.yöneticiGirisButton.Text = "GİRİŞ";
            this.yöneticiGirisButton.UseVisualStyleBackColor = true;
            // 
            // Yönetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 342);
            this.Controls.Add(this.yöneticiGirisButton);
            this.Controls.Add(this.SıfreTextBox);
            this.Controls.Add(this.kullanıcıAdıTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Yönetici";
            this.Text = "Yönetici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullanıcıAdıTextBox;
        private System.Windows.Forms.TextBox SıfreTextBox;
        private System.Windows.Forms.Button yöneticiGirisButton;
    }
}
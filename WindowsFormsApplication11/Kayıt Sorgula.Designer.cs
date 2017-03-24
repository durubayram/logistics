namespace WindowsFormsApplication11
{
    partial class Takip
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Perakende");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Gıda");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Tekstil");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Otomobil");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Fuar ve Etkinlik");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("İnşaat");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tehlikeli Madde");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hastane ve İlaç");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Hayvan");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Elektronik");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Turizm");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Yük Türleri Hakkında", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.personelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.treeView1.Location = new System.Drawing.Point(11, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "PerakendeNode";
            treeNode1.Text = "Perakende";
            treeNode2.Name = "gidaNode";
            treeNode2.Text = "Gıda";
            treeNode3.Name = "tekstilNode";
            treeNode3.Text = "Tekstil";
            treeNode4.Name = "otoNode";
            treeNode4.Text = "Otomobil";
            treeNode5.Name = "fuarNode";
            treeNode5.Text = "Fuar ve Etkinlik";
            treeNode6.Name = "insaatNode";
            treeNode6.Text = "İnşaat";
            treeNode7.Name = "tehlikeNode";
            treeNode7.Text = "Tehlikeli Madde";
            treeNode8.Name = "hastaneNode";
            treeNode8.Text = "Hastane ve İlaç";
            treeNode9.Name = "hayvanNode";
            treeNode9.Text = "Hayvan";
            treeNode10.Name = "elektrikNode";
            treeNode10.Text = "Elektronik";
            treeNode11.Name = "turizmNode";
            treeNode11.Text = "Turizm";
            treeNode12.BackColor = System.Drawing.Color.White;
            treeNode12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            treeNode12.Name = "Node8";
            treeNode12.NodeFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            treeNode12.Text = "Yük Türleri Hakkında";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(165, 414);
            this.treeView1.TabIndex = 0;
            this.treeView1.Click += new System.EventHandler(this.treeView1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(75, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Müsteri Bilgileri";
            this.toolTip1.SetToolTip(this.button1, "Gönderici");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(351, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ürün Bilgileri";
            this.toolTip1.SetToolTip(this.button3, "Ürün");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hangi bilgi sistemine giriş yapmak istiyorsunuz?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.linkLabel6);
            this.panel1.Controls.Add(this.linkLabel5);
            this.panel1.Controls.Add(this.linkLabel4);
            this.panel1.Controls.Add(this.linkLabel3);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(224, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 172);
            this.panel1.TabIndex = 6;
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel6.Location = new System.Drawing.Point(186, 110);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(135, 20);
            this.linkLabel6.TabIndex = 6;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Bumerang Lojistik";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel5.Location = new System.Drawing.Point(347, 72);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(60, 20);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Omsan";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel4.Location = new System.Drawing.Point(347, 110);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(88, 20);
            this.linkLabel4.TabIndex = 4;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "İkra Lojistik";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel3.Location = new System.Drawing.Point(186, 72);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(121, 20);
            this.linkLabel3.TabIndex = 3;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Borusan Lojistik";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel2.Location = new System.Drawing.Point(71, 110);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(40, 20);
            this.linkLabel2.TabIndex = 2;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Ekol";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(71, 72);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şah Lojistik";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lojistik Firmalarıyla İlgili Daha Fazla Bilgi Almak İçin:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.personelButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(224, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 169);
            this.panel2.TabIndex = 8;
            // 
            // personelButton
            // 
            this.personelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personelButton.Location = new System.Drawing.Point(220, 120);
            this.personelButton.Name = "personelButton";
            this.personelButton.Size = new System.Drawing.Size(172, 39);
            this.personelButton.TabIndex = 9;
            this.personelButton.Text = "Personel Bilgileri";
            this.personelButton.UseVisualStyleBackColor = true;
            this.personelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Takip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(870, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "Takip";
            this.Text = "Kayıt Arama";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button personelButton;
    }
}
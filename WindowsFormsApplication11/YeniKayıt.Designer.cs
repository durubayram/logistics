namespace WindowsFormsApplication11
{
    partial class YeniKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKayıt));
            this.kaydetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RefText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gonTelText = new System.Windows.Forms.TextBox();
            this.teslimDateTime = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yükTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımİçinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gonSehirText = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.yükmiktarılabel = new System.Windows.Forms.Label();
            this.cıkısButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.helpStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.gönAdSoyad = new System.Windows.Forms.Label();
            this.gönAdreslabel = new System.Windows.Forms.Label();
            this.aliciAdresText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.aliciSehirText = new System.Windows.Forms.ComboBox();
            this.aliciTelText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.aliciAdsoyadText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.gonAdresText = new System.Windows.Forms.TextBox();
            this.yüktürügrupbox = new System.Windows.Forms.GroupBox();
            this.turizmradio = new System.Windows.Forms.RadioButton();
            this.elektronikradio = new System.Windows.Forms.RadioButton();
            this.hayvanradio = new System.Windows.Forms.RadioButton();
            this.hastaneilaçradio = new System.Windows.Forms.RadioButton();
            this.tehlikelimadderadio = new System.Windows.Forms.RadioButton();
            this.etkinlikfuarradio = new System.Windows.Forms.RadioButton();
            this.inşaatradio = new System.Windows.Forms.RadioButton();
            this.otomobilradio = new System.Windows.Forms.RadioButton();
            this.tekstilradio = new System.Windows.Forms.RadioButton();
            this.gıdaradio = new System.Windows.Forms.RadioButton();
            this.perakenderadio = new System.Windows.Forms.RadioButton();
            this.yukMiktariNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gonAdSoyadBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.yüktürügrupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yukMiktariNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // kaydetButton
            // 
            this.kaydetButton.Location = new System.Drawing.Point(89, 546);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(141, 44);
            this.kaydetButton.TabIndex = 0;
            this.kaydetButton.Text = "KAYDET";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Referans Numarası\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(14, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gönderen";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 33);
            this.label8.TabIndex = 9;
            this.label8.Text = "Teslim Tarihi";
            // 
            // RefText
            // 
            this.RefText.Enabled = false;
            this.RefText.Location = new System.Drawing.Point(73, 59);
            this.RefText.Name = "RefText";
            this.RefText.Size = new System.Drawing.Size(121, 20);
            this.RefText.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(14, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 31);
            this.label9.TabIndex = 21;
            this.label9.Text = "Şehir";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefon";
            // 
            // gonTelText
            // 
            this.gonTelText.Location = new System.Drawing.Point(73, 161);
            this.gonTelText.Name = "gonTelText";
            this.gonTelText.Size = new System.Drawing.Size(121, 20);
            this.gonTelText.TabIndex = 10;
            this.gonTelText.Text = "+90";
            this.gonTelText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telText_KeyPressed);
            // 
            // teslimDateTime
            // 
            this.teslimDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimDateTime.Location = new System.Drawing.Point(108, 452);
            this.teslimDateTime.MaxDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.teslimDateTime.MinDate = new System.DateTime(2013, 12, 12, 0, 0, 0, 0);
            this.teslimDateTime.Name = "teslimDateTime";
            this.teslimDateTime.Size = new System.Drawing.Size(200, 20);
            this.teslimDateTime.TabIndex = 28;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemKaydetToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // işlemKaydetToolStripMenuItem
            // 
            this.işlemKaydetToolStripMenuItem.Name = "işlemKaydetToolStripMenuItem";
            this.işlemKaydetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.işlemKaydetToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.işlemKaydetToolStripMenuItem.Text = "İşlem Kaydet";
            this.işlemKaydetToolStripMenuItem.Click += new System.EventHandler(this.işlemKaydetToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yükTürleriToolStripMenuItem,
            this.firmalarToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // yükTürleriToolStripMenuItem
            // 
            this.yükTürleriToolStripMenuItem.Name = "yükTürleriToolStripMenuItem";
            this.yükTürleriToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.yükTürleriToolStripMenuItem.Text = "Yük Türleri";
            this.yükTürleriToolStripMenuItem.ToolTipText = "Mevcut yük türlerini görebilirsiniz.";
            this.yükTürleriToolStripMenuItem.Click += new System.EventHandler(this.yükTürleriToolStripMenuItem_Click);
            // 
            // firmalarToolStripMenuItem
            // 
            this.firmalarToolStripMenuItem.Name = "firmalarToolStripMenuItem";
            this.firmalarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.firmalarToolStripMenuItem.Text = "Firmalar";
            this.firmalarToolStripMenuItem.ToolTipText = "Mevcut firmaları görebilirsiniz.";
            this.firmalarToolStripMenuItem.Click += new System.EventHandler(this.firmalarToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımİçinToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // yardımİçinToolStripMenuItem
            // 
            this.yardımİçinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programRaporuToolStripMenuItem});
            this.yardımİçinToolStripMenuItem.Name = "yardımİçinToolStripMenuItem";
            this.yardımİçinToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.yardımİçinToolStripMenuItem.Text = "Yardım için...";
            // 
            // programRaporuToolStripMenuItem
            // 
            this.programRaporuToolStripMenuItem.Name = "programRaporuToolStripMenuItem";
            this.programRaporuToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.programRaporuToolStripMenuItem.Text = "Program Raporu";
            this.programRaporuToolStripMenuItem.Click += new System.EventHandler(this.programRaporuToolStripMenuItem_Click);
            // 
            // gonSehirText
            // 
            this.gonSehirText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gonSehirText.FormattingEnabled = true;
            this.gonSehirText.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.gonSehirText.Location = new System.Drawing.Point(73, 189);
            this.gonSehirText.Name = "gonSehirText";
            this.gonSehirText.Size = new System.Drawing.Size(121, 21);
            this.gonSehirText.TabIndex = 31;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkBox1.Location = new System.Drawing.Point(33, 508);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(314, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "&Kullanıcı Sözleşmesini ve Gizlilik Kaydını okudum,onaylıyorum.";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(367, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(699, 387);
            this.listView1.TabIndex = 35;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // yükmiktarılabel
            // 
            this.yükmiktarılabel.Location = new System.Drawing.Point(211, 376);
            this.yükmiktarılabel.Name = "yükmiktarılabel";
            this.yükmiktarılabel.Size = new System.Drawing.Size(123, 48);
            this.yükmiktarılabel.TabIndex = 37;
            this.yükmiktarılabel.Text = "Yük Miktarı (ton)";
            // 
            // cıkısButton
            // 
            this.cıkısButton.Location = new System.Drawing.Point(362, 546);
            this.cıkısButton.Name = "cıkısButton";
            this.cıkısButton.Size = new System.Drawing.Size(141, 44);
            this.cıkısButton.TabIndex = 38;
            this.cıkısButton.Text = "ÇIKIŞ";
            this.cıkısButton.UseVisualStyleBackColor = true;
            this.cıkısButton.Click += new System.EventHandler(this.cıkısButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.exitStripButton1,
            this.helpStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1078, 25);
            this.toolStrip1.TabIndex = 39;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Kaydet";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // exitStripButton1
            // 
            this.exitStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("exitStripButton1.Image")));
            this.exitStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitStripButton1.Name = "exitStripButton1";
            this.exitStripButton1.Size = new System.Drawing.Size(23, 22);
            this.exitStripButton1.Text = "Çıkış";
            this.exitStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // helpStripButton3
            // 
            this.helpStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("helpStripButton3.Image")));
            this.helpStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpStripButton3.Name = "helpStripButton3";
            this.helpStripButton3.Size = new System.Drawing.Size(23, 22);
            this.helpStripButton3.Text = "Yardım";
            this.helpStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // gönAdSoyad
            // 
            this.gönAdSoyad.AutoSize = true;
            this.gönAdSoyad.Location = new System.Drawing.Point(14, 134);
            this.gönAdSoyad.Name = "gönAdSoyad";
            this.gönAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.gönAdSoyad.TabIndex = 40;
            this.gönAdSoyad.Text = "Ad Soyad";
            // 
            // gönAdreslabel
            // 
            this.gönAdreslabel.Location = new System.Drawing.Point(14, 223);
            this.gönAdreslabel.Name = "gönAdreslabel";
            this.gönAdreslabel.Size = new System.Drawing.Size(47, 59);
            this.gönAdreslabel.TabIndex = 41;
            this.gönAdreslabel.Text = "Adres";
            // 
            // aliciAdresText
            // 
            this.aliciAdresText.Location = new System.Drawing.Point(77, 376);
            this.aliciAdresText.Name = "aliciAdresText";
            this.aliciAdresText.Size = new System.Drawing.Size(121, 20);
            this.aliciAdresText.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(18, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 59);
            this.label12.TabIndex = 50;
            this.label12.Text = "Adres";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Ad Soyad";
            // 
            // aliciSehirText
            // 
            this.aliciSehirText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aliciSehirText.FormattingEnabled = true;
            this.aliciSehirText.Items.AddRange(new object[] {
            "İstanbul",
            "Ankara",
            "İzmir",
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.aliciSehirText.Location = new System.Drawing.Point(77, 344);
            this.aliciSehirText.Name = "aliciSehirText";
            this.aliciSehirText.Size = new System.Drawing.Size(121, 21);
            this.aliciSehirText.TabIndex = 48;
            // 
            // aliciTelText
            // 
            this.aliciTelText.Location = new System.Drawing.Point(77, 316);
            this.aliciTelText.Name = "aliciTelText";
            this.aliciTelText.Size = new System.Drawing.Size(121, 20);
            this.aliciTelText.TabIndex = 10;
            this.aliciTelText.Text = "+90";
            this.aliciTelText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aliciTelText_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Telefon";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(18, 344);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 31);
            this.label15.TabIndex = 46;
            this.label15.Text = "Şehir";
            // 
            // aliciAdsoyadText
            // 
            this.aliciAdsoyadText.Location = new System.Drawing.Point(77, 289);
            this.aliciAdsoyadText.Name = "aliciAdsoyadText";
            this.aliciAdsoyadText.Size = new System.Drawing.Size(121, 20);
            this.aliciAdsoyadText.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(18, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Alıcı";
            // 
            // gonAdresText
            // 
            this.gonAdresText.Location = new System.Drawing.Point(73, 217);
            this.gonAdresText.Name = "gonAdresText";
            this.gonAdresText.Size = new System.Drawing.Size(121, 20);
            this.gonAdresText.TabIndex = 52;
            // 
            // yüktürügrupbox
            // 
            this.yüktürügrupbox.Controls.Add(this.turizmradio);
            this.yüktürügrupbox.Controls.Add(this.elektronikradio);
            this.yüktürügrupbox.Controls.Add(this.hayvanradio);
            this.yüktürügrupbox.Controls.Add(this.hastaneilaçradio);
            this.yüktürügrupbox.Controls.Add(this.tehlikelimadderadio);
            this.yüktürügrupbox.Controls.Add(this.etkinlikfuarradio);
            this.yüktürügrupbox.Controls.Add(this.inşaatradio);
            this.yüktürügrupbox.Controls.Add(this.otomobilradio);
            this.yüktürügrupbox.Controls.Add(this.tekstilradio);
            this.yüktürügrupbox.Controls.Add(this.gıdaradio);
            this.yüktürügrupbox.Controls.Add(this.perakenderadio);
            this.yüktürügrupbox.Location = new System.Drawing.Point(214, 59);
            this.yüktürügrupbox.Name = "yüktürügrupbox";
            this.yüktürügrupbox.Size = new System.Drawing.Size(143, 305);
            this.yüktürügrupbox.TabIndex = 53;
            this.yüktürügrupbox.TabStop = false;
            this.yüktürügrupbox.Text = "Yük Türü";
            // 
            // turizmradio
            // 
            this.turizmradio.AutoSize = true;
            this.turizmradio.Location = new System.Drawing.Point(22, 278);
            this.turizmradio.Name = "turizmradio";
            this.turizmradio.Size = new System.Drawing.Size(56, 17);
            this.turizmradio.TabIndex = 10;
            this.turizmradio.TabStop = true;
            this.turizmradio.Text = "Turizm";
            this.turizmradio.UseVisualStyleBackColor = true;
            // 
            // elektronikradio
            // 
            this.elektronikradio.AutoSize = true;
            this.elektronikradio.Location = new System.Drawing.Point(22, 254);
            this.elektronikradio.Name = "elektronikradio";
            this.elektronikradio.Size = new System.Drawing.Size(72, 17);
            this.elektronikradio.TabIndex = 9;
            this.elektronikradio.TabStop = true;
            this.elektronikradio.Text = "Elektronik";
            this.elektronikradio.UseVisualStyleBackColor = true;
            // 
            // hayvanradio
            // 
            this.hayvanradio.AutoSize = true;
            this.hayvanradio.Location = new System.Drawing.Point(22, 230);
            this.hayvanradio.Name = "hayvanradio";
            this.hayvanradio.Size = new System.Drawing.Size(62, 17);
            this.hayvanradio.TabIndex = 8;
            this.hayvanradio.TabStop = true;
            this.hayvanradio.Text = "Hayvan";
            this.hayvanradio.UseVisualStyleBackColor = true;
            // 
            // hastaneilaçradio
            // 
            this.hastaneilaçradio.AutoSize = true;
            this.hastaneilaçradio.Location = new System.Drawing.Point(22, 206);
            this.hastaneilaçradio.Name = "hastaneilaçradio";
            this.hastaneilaçradio.Size = new System.Drawing.Size(100, 17);
            this.hastaneilaçradio.TabIndex = 7;
            this.hastaneilaçradio.TabStop = true;
            this.hastaneilaçradio.Text = "Hastane ve İlaç";
            this.hastaneilaçradio.UseVisualStyleBackColor = true;
            // 
            // tehlikelimadderadio
            // 
            this.tehlikelimadderadio.AutoSize = true;
            this.tehlikelimadderadio.Location = new System.Drawing.Point(22, 183);
            this.tehlikelimadderadio.Name = "tehlikelimadderadio";
            this.tehlikelimadderadio.Size = new System.Drawing.Size(100, 17);
            this.tehlikelimadderadio.TabIndex = 6;
            this.tehlikelimadderadio.TabStop = true;
            this.tehlikelimadderadio.Text = "Tehlikeli Madde";
            this.tehlikelimadderadio.UseVisualStyleBackColor = true;
            // 
            // etkinlikfuarradio
            // 
            this.etkinlikfuarradio.AutoSize = true;
            this.etkinlikfuarradio.Location = new System.Drawing.Point(22, 159);
            this.etkinlikfuarradio.Name = "etkinlikfuarradio";
            this.etkinlikfuarradio.Size = new System.Drawing.Size(98, 17);
            this.etkinlikfuarradio.TabIndex = 5;
            this.etkinlikfuarradio.TabStop = true;
            this.etkinlikfuarradio.Text = "Etkinlik ve Fuar";
            this.etkinlikfuarradio.UseVisualStyleBackColor = true;
            // 
            // inşaatradio
            // 
            this.inşaatradio.AutoSize = true;
            this.inşaatradio.Location = new System.Drawing.Point(22, 132);
            this.inşaatradio.Name = "inşaatradio";
            this.inşaatradio.Size = new System.Drawing.Size(54, 17);
            this.inşaatradio.TabIndex = 4;
            this.inşaatradio.TabStop = true;
            this.inşaatradio.Text = "İnşaat";
            this.inşaatradio.UseVisualStyleBackColor = true;
            // 
            // otomobilradio
            // 
            this.otomobilradio.AutoSize = true;
            this.otomobilradio.Location = new System.Drawing.Point(22, 104);
            this.otomobilradio.Name = "otomobilradio";
            this.otomobilradio.Size = new System.Drawing.Size(66, 17);
            this.otomobilradio.TabIndex = 3;
            this.otomobilradio.TabStop = true;
            this.otomobilradio.Text = "Otomobil";
            this.otomobilradio.UseVisualStyleBackColor = true;
            // 
            // tekstilradio
            // 
            this.tekstilradio.AutoSize = true;
            this.tekstilradio.Location = new System.Drawing.Point(22, 76);
            this.tekstilradio.Name = "tekstilradio";
            this.tekstilradio.Size = new System.Drawing.Size(56, 17);
            this.tekstilradio.TabIndex = 2;
            this.tekstilradio.TabStop = true;
            this.tekstilradio.Text = "Tekstil";
            this.tekstilradio.UseVisualStyleBackColor = true;
            // 
            // gıdaradio
            // 
            this.gıdaradio.AutoSize = true;
            this.gıdaradio.Location = new System.Drawing.Point(22, 49);
            this.gıdaradio.Name = "gıdaradio";
            this.gıdaradio.Size = new System.Drawing.Size(47, 17);
            this.gıdaradio.TabIndex = 1;
            this.gıdaradio.TabStop = true;
            this.gıdaradio.Text = "Gıda";
            this.gıdaradio.UseVisualStyleBackColor = true;
            // 
            // perakenderadio
            // 
            this.perakenderadio.AutoSize = true;
            this.perakenderadio.Location = new System.Drawing.Point(22, 22);
            this.perakenderadio.Name = "perakenderadio";
            this.perakenderadio.Size = new System.Drawing.Size(77, 17);
            this.perakenderadio.TabIndex = 0;
            this.perakenderadio.TabStop = true;
            this.perakenderadio.Text = "Perakende";
            this.perakenderadio.UseVisualStyleBackColor = true;
            // 
            // yukMiktariNumericUpDown
            // 
            this.yukMiktariNumericUpDown.Location = new System.Drawing.Point(214, 403);
            this.yukMiktariNumericUpDown.Name = "yukMiktariNumericUpDown";
            this.yukMiktariNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.yukMiktariNumericUpDown.TabIndex = 26;
            // 
            // gonAdSoyadBox
            // 
            this.gonAdSoyadBox.Location = new System.Drawing.Point(73, 131);
            this.gonAdSoyadBox.Name = "gonAdSoyadBox";
            this.gonAdSoyadBox.Size = new System.Drawing.Size(121, 20);
            this.gonAdSoyadBox.TabIndex = 54;
            // 
            // YeniKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1078, 601);
            this.Controls.Add(this.gonAdSoyadBox);
            this.Controls.Add(this.yukMiktariNumericUpDown);
            this.Controls.Add(this.yüktürügrupbox);
            this.Controls.Add(this.gonAdresText);
            this.Controls.Add(this.aliciAdresText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.aliciSehirText);
            this.Controls.Add(this.aliciTelText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.aliciAdsoyadText);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.gönAdreslabel);
            this.Controls.Add(this.gönAdSoyad);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cıkısButton);
            this.Controls.Add(this.yükmiktarılabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gonSehirText);
            this.Controls.Add(this.teslimDateTime);
            this.Controls.Add(this.gonTelText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RefText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "YeniKayıt";
            this.Text = "YeniKayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.yüktürügrupbox.ResumeLayout(false);
            this.yüktürügrupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yukMiktariNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RefText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox gonTelText;
        private System.Windows.Forms.DateTimePicker teslimDateTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox gonSehirText;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label yükmiktarılabel;
        private System.Windows.Forms.Button cıkısButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.Label gönAdSoyad;
        private System.Windows.Forms.Label gönAdreslabel;
        private System.Windows.Forms.TextBox aliciAdresText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox aliciSehirText;
        private System.Windows.Forms.TextBox aliciTelText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox aliciAdsoyadText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox gonAdresText;
        private System.Windows.Forms.GroupBox yüktürügrupbox;
        private System.Windows.Forms.RadioButton turizmradio;
        private System.Windows.Forms.RadioButton elektronikradio;
        private System.Windows.Forms.RadioButton hayvanradio;
        private System.Windows.Forms.RadioButton hastaneilaçradio;
        private System.Windows.Forms.RadioButton tehlikelimadderadio;
        private System.Windows.Forms.RadioButton etkinlikfuarradio;
        private System.Windows.Forms.RadioButton inşaatradio;
        private System.Windows.Forms.RadioButton otomobilradio;
        private System.Windows.Forms.RadioButton tekstilradio;
        private System.Windows.Forms.RadioButton gıdaradio;
        private System.Windows.Forms.RadioButton perakenderadio;
        private System.Windows.Forms.NumericUpDown yukMiktariNumericUpDown;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton exitStripButton1;
        private System.Windows.Forms.TextBox gonAdSoyadBox;
        private System.Windows.Forms.ToolStripMenuItem yükTürleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımİçinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton helpStripButton3;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemKaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}


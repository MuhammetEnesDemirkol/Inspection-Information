namespace Muayene_Bilgi_Sistemi
{
    partial class frmMuayeneEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuayeneEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuYeniMuayene = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMuayeneListele = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReceteListele = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.Button();
            this.boxHastaKayit = new System.Windows.Forms.GroupBox();
            this.btnHastaKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMedeni = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.MaskedTextBox();
            this.txtTcNo = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.txtDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pageHasta = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnHastaBilgiAktar = new System.Windows.Forms.Button();
            this.txtTcKontrol = new System.Windows.Forms.MaskedTextBox();
            this.btnHastaListeGuncelle = new System.Windows.Forms.Button();
            this.dataHastaBilgi = new System.Windows.Forms.DataGridView();
            this.pageMuayene = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHayir = new System.Windows.Forms.Button();
            this.btnEvet = new System.Windows.Forms.Button();
            this.btnRaporKaydet = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUygulananTedavi = new System.Windows.Forms.RichTextBox();
            this.txtHastaSikayet = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHastaMuayeneTarihi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtHastaSoyadi = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaTc = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaAdi = new System.Windows.Forms.MaskedTextBox();
            this.txtHastaTelefon = new System.Windows.Forms.MaskedTextBox();
            this.groupRecete = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIlacTipi = new System.Windows.Forms.MaskedTextBox();
            this.txtIlacBarkod = new System.Windows.Forms.MaskedTextBox();
            this.btnIlacBilgiGetir = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnReceteRaporKaydet = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.numIlacSayi = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIlacAdi = new System.Windows.Forms.MaskedTextBox();
            this.btnIlacDataSil = new System.Windows.Forms.Button();
            this.dataRecete = new System.Windows.Forms.DataGridView();
            this.tc_kimlik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recete_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkod_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kutu_adeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recete_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReceteOlustur = new System.Windows.Forms.Button();
            this.txtReceteNumarasi = new System.Windows.Forms.MaskedTextBox();
            this.pageIlac = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btbnIlacGuncelle = new System.Windows.Forms.Button();
            this.btnIlacSil = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbGuncelleIlacTipi = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtGuncelleBarkod = new System.Windows.Forms.MaskedTextBox();
            this.txtGuncelleIlacAdi = new System.Windows.Forms.MaskedTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnIlacBilgiAktar = new System.Windows.Forms.Button();
            this.txtIlacBilgiAktar = new System.Windows.Forms.MaskedTextBox();
            this.btnListeIlacGuncelle = new System.Windows.Forms.Button();
            this.dataIlac = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnYeniIlac = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbEkleIlacTip = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtEkleBarkod = new System.Windows.Forms.MaskedTextBox();
            this.txtEkleIlacAd = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.menu.SuspendLayout();
            this.boxHastaKayit.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pageHasta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHastaBilgi)).BeginInit();
            this.pageMuayene.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupRecete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIlacSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecete)).BeginInit();
            this.pageIlac.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIlac)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(250, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bİ\'RİCA YENİ MUAYENE KAYIT EKRANI";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 100);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1130, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(54, 47);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 12;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuYeniMuayene,
            this.menuMuayeneListele,
            this.menuReceteListele});
            this.menu.Location = new System.Drawing.Point(38, 71);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(303, 43);
            this.menu.TabIndex = 0;
            this.menu.Text = "menü";
            this.menu.Visible = false;
            // 
            // menuYeniMuayene
            // 
            this.menuYeniMuayene.ForeColor = System.Drawing.Color.Cyan;
            this.menuYeniMuayene.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.menuYeniMuayene.Name = "menuYeniMuayene";
            this.menuYeniMuayene.Size = new System.Drawing.Size(110, 19);
            this.menuYeniMuayene.Text = "YENİ MUAYENE ";
            // 
            // menuMuayeneListele
            // 
            this.menuMuayeneListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.menuMuayeneListele.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.menuMuayeneListele.Name = "menuMuayeneListele";
            this.menuMuayeneListele.Size = new System.Drawing.Size(98, 19);
            this.menuMuayeneListele.Text = "MUAYENELER";
            this.menuMuayeneListele.Click += new System.EventHandler(this.menuMuayeneListele_Click);
            // 
            // menuReceteListele
            // 
            this.menuReceteListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.menuReceteListele.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.menuReceteListele.Name = "menuReceteListele";
            this.menuReceteListele.Size = new System.Drawing.Size(87, 19);
            this.menuReceteListele.Text = "REÇETELER";
            this.menuReceteListele.Click += new System.EventHandler(this.menuReceteListele_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.ForeColor = System.Drawing.Color.Cyan;
            this.btnMenu.Location = new System.Drawing.Point(0, 100);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 578);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.Text = "M\r\nE\r\nN\r\nÜ\r\n";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // boxHastaKayit
            // 
            this.boxHastaKayit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.boxHastaKayit.Controls.Add(this.btnHastaKaydet);
            this.boxHastaKayit.Controls.Add(this.label9);
            this.boxHastaKayit.Controls.Add(this.label8);
            this.boxHastaKayit.Controls.Add(this.cmbMedeni);
            this.boxHastaKayit.Controls.Add(this.cmbCinsiyet);
            this.boxHastaKayit.Controls.Add(this.label4);
            this.boxHastaKayit.Controls.Add(this.label3);
            this.boxHastaKayit.Controls.Add(this.label7);
            this.boxHastaKayit.Controls.Add(this.label6);
            this.boxHastaKayit.Controls.Add(this.label5);
            this.boxHastaKayit.Controls.Add(this.label2);
            this.boxHastaKayit.Controls.Add(this.txtDogumYeri);
            this.boxHastaKayit.Controls.Add(this.txtSoyad);
            this.boxHastaKayit.Controls.Add(this.txtTcNo);
            this.boxHastaKayit.Controls.Add(this.txtAd);
            this.boxHastaKayit.Controls.Add(this.txtTelefonNumarasi);
            this.boxHastaKayit.Controls.Add(this.txtDogumTarihi);
            this.boxHastaKayit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.boxHastaKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.boxHastaKayit.Location = new System.Drawing.Point(19, 124);
            this.boxHastaKayit.Name = "boxHastaKayit";
            this.boxHastaKayit.Size = new System.Drawing.Size(418, 397);
            this.boxHastaKayit.TabIndex = 0;
            this.boxHastaKayit.TabStop = false;
            this.boxHastaKayit.Text = "YENİ KAYIT";
            // 
            // btnHastaKaydet
            // 
            this.btnHastaKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHastaKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaKaydet.Location = new System.Drawing.Point(198, 338);
            this.btnHastaKaydet.Name = "btnHastaKaydet";
            this.btnHastaKaydet.Size = new System.Drawing.Size(153, 25);
            this.btnHastaKaydet.TabIndex = 9;
            this.btnHastaKaydet.Text = "KAYIT OLUŞTUR";
            this.btnHastaKaydet.UseVisualStyleBackColor = true;
            this.btnHastaKaydet.Click += new System.EventHandler(this.btnHastaKaydet_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Medeni Durumu:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cinsiyeti:";
            // 
            // cmbMedeni
            // 
            this.cmbMedeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbMedeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.cmbMedeni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMedeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.cmbMedeni.FormattingEnabled = true;
            this.cmbMedeni.Items.AddRange(new object[] {
            "Evli",
            "Bekar"});
            this.cmbMedeni.Location = new System.Drawing.Point(167, 295);
            this.cmbMedeni.Name = "cmbMedeni";
            this.cmbMedeni.Size = new System.Drawing.Size(211, 23);
            this.cmbMedeni.TabIndex = 8;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCinsiyet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(167, 261);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(211, 23);
            this.cmbCinsiyet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "TC Kimlik Numarası";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon Numarası:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Doğum Yeri:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Soyisim:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doğum Tarihi:";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDogumYeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtDogumYeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtDogumYeri.Location = new System.Drawing.Point(167, 125);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(211, 23);
            this.txtDogumYeri.TabIndex = 3;
            this.txtDogumYeri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDogumYeri.ValidatingType = typeof(System.DateTime);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtSoyad.Location = new System.Drawing.Point(167, 91);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(211, 23);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSoyad.ValidatingType = typeof(System.DateTime);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTcNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtTcNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtTcNo.Location = new System.Drawing.Point(167, 227);
            this.txtTcNo.Mask = "00000000000";
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(211, 23);
            this.txtTcNo.TabIndex = 6;
            this.txtTcNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTcNo.ValidatingType = typeof(int);
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtAd.Location = new System.Drawing.Point(167, 57);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(211, 23);
            this.txtAd.TabIndex = 0;
            this.txtAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAd.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefonNumarasi
            // 
            this.txtTelefonNumarasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefonNumarasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtTelefonNumarasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtTelefonNumarasi.Location = new System.Drawing.Point(167, 193);
            this.txtTelefonNumarasi.Mask = "(999) 000-0000";
            this.txtTelefonNumarasi.Name = "txtTelefonNumarasi";
            this.txtTelefonNumarasi.Size = new System.Drawing.Size(211, 23);
            this.txtTelefonNumarasi.TabIndex = 5;
            this.txtTelefonNumarasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDogumTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtDogumTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtDogumTarihi.Location = new System.Drawing.Point(167, 159);
            this.txtDogumTarihi.Mask = "00/00/0000";
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(211, 23);
            this.txtDogumTarihi.TabIndex = 4;
            this.txtDogumTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.pageHasta);
            this.tabControl.Controls.Add(this.pageMuayene);
            this.tabControl.Controls.Add(this.pageIlac);
            this.tabControl.Location = new System.Drawing.Point(41, 106);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1137, 565);
            this.tabControl.TabIndex = 13;
            // 
            // pageHasta
            // 
            this.pageHasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.pageHasta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageHasta.Controls.Add(this.label20);
            this.pageHasta.Controls.Add(this.groupBox2);
            this.pageHasta.Controls.Add(this.boxHastaKayit);
            this.pageHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.pageHasta.Location = new System.Drawing.Point(4, 27);
            this.pageHasta.Name = "pageHasta";
            this.pageHasta.Padding = new System.Windows.Forms.Padding(3);
            this.pageHasta.Size = new System.Drawing.Size(1129, 534);
            this.pageHasta.TabIndex = 1;
            this.pageHasta.Text = "Hasta Kayıt Ekranı";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.label20.Location = new System.Drawing.Point(193, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(696, 60);
            this.label20.TabIndex = 0;
            this.label20.Text = resources.GetString("label20.Text");
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.btnHastaBilgiAktar);
            this.groupBox2.Controls.Add(this.txtTcKontrol);
            this.groupBox2.Controls.Add(this.btnHastaListeGuncelle);
            this.groupBox2.Controls.Add(this.dataHastaBilgi);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.groupBox2.Location = new System.Drawing.Point(471, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 397);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KAYITLI HASTA LİSTESİ";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(37, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 16);
            this.label21.TabIndex = 25;
            this.label21.Text = "TC Kimlik Numarası";
            // 
            // btnHastaBilgiAktar
            // 
            this.btnHastaBilgiAktar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHastaBilgiAktar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaBilgiAktar.Location = new System.Drawing.Point(336, 34);
            this.btnHastaBilgiAktar.Name = "btnHastaBilgiAktar";
            this.btnHastaBilgiAktar.Size = new System.Drawing.Size(276, 25);
            this.btnHastaBilgiAktar.TabIndex = 12;
            this.btnHastaBilgiAktar.Text = "HASTA BİLGİLERİNİ AKTAR";
            this.btnHastaBilgiAktar.UseVisualStyleBackColor = true;
            this.btnHastaBilgiAktar.Click += new System.EventHandler(this.btnHastaBilgiAktar_Click);
            // 
            // txtTcKontrol
            // 
            this.txtTcKontrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTcKontrol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtTcKontrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtTcKontrol.Location = new System.Drawing.Point(180, 34);
            this.txtTcKontrol.Mask = "00000000000";
            this.txtTcKontrol.Name = "txtTcKontrol";
            this.txtTcKontrol.Size = new System.Drawing.Size(135, 23);
            this.txtTcKontrol.TabIndex = 11;
            this.txtTcKontrol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTcKontrol.ValidatingType = typeof(int);
            // 
            // btnHastaListeGuncelle
            // 
            this.btnHastaListeGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHastaListeGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHastaListeGuncelle.Location = new System.Drawing.Point(70, 366);
            this.btnHastaListeGuncelle.Name = "btnHastaListeGuncelle";
            this.btnHastaListeGuncelle.Size = new System.Drawing.Size(505, 25);
            this.btnHastaListeGuncelle.TabIndex = 10;
            this.btnHastaListeGuncelle.Text = "LİSTEYİ GÜNCELLE";
            this.btnHastaListeGuncelle.UseVisualStyleBackColor = true;
            this.btnHastaListeGuncelle.Click += new System.EventHandler(this.btnHastaListeGuncelle_Click);
            // 
            // dataHastaBilgi
            // 
            this.dataHastaBilgi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataHastaBilgi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.dataHastaBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHastaBilgi.GridColor = System.Drawing.Color.Cyan;
            this.dataHastaBilgi.Location = new System.Drawing.Point(9, 64);
            this.dataHastaBilgi.Name = "dataHastaBilgi";
            this.dataHastaBilgi.ReadOnly = true;
            this.dataHastaBilgi.Size = new System.Drawing.Size(626, 296);
            this.dataHastaBilgi.TabIndex = 0;
            // 
            // pageMuayene
            // 
            this.pageMuayene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.pageMuayene.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageMuayene.Controls.Add(this.label32);
            this.pageMuayene.Controls.Add(this.groupBox1);
            this.pageMuayene.Controls.Add(this.groupBox3);
            this.pageMuayene.Controls.Add(this.groupRecete);
            this.pageMuayene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.pageMuayene.Location = new System.Drawing.Point(4, 27);
            this.pageMuayene.Name = "pageMuayene";
            this.pageMuayene.Padding = new System.Windows.Forms.Padding(3);
            this.pageMuayene.Size = new System.Drawing.Size(1129, 534);
            this.pageMuayene.TabIndex = 2;
            this.pageMuayene.Text = "Muayene Bilgisi";
            this.pageMuayene.ToolTipText = "Kaydedilen hastanın muayene bilgileri";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.label32.Location = new System.Drawing.Point(251, 3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(716, 38);
            this.label32.TabIndex = 15;
            this.label32.Text = "\"Hasta Kayıt Ekranı\" sayfasından, hasta bilgilerini aktarınız. \r\n\'Aktarma Başarıl" +
    "ı\' yazısı geldiyse, bilgileri aktarılan hastanın muayene bilgilerini girmeye baş" +
    "layabilirsiniz.";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.groupBox1.Controls.Add(this.btnHayir);
            this.groupBox1.Controls.Add(this.btnEvet);
            this.groupBox1.Controls.Add(this.btnRaporKaydet);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtUygulananTedavi);
            this.groupBox1.Controls.Add(this.txtHastaSikayet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtHastaMuayeneTarihi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.groupBox1.Location = new System.Drawing.Point(579, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 200);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOKTOR RAPORU";
            // 
            // btnHayir
            // 
            this.btnHayir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHayir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHayir.Location = new System.Drawing.Point(283, 136);
            this.btnHayir.Name = "btnHayir";
            this.btnHayir.Size = new System.Drawing.Size(88, 25);
            this.btnHayir.TabIndex = 20;
            this.btnHayir.Text = "HAYIR";
            this.btnHayir.UseVisualStyleBackColor = true;
            this.btnHayir.Click += new System.EventHandler(this.btnHayir_Click);
            // 
            // btnEvet
            // 
            this.btnEvet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEvet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEvet.Location = new System.Drawing.Point(163, 136);
            this.btnEvet.Name = "btnEvet";
            this.btnEvet.Size = new System.Drawing.Size(88, 25);
            this.btnEvet.TabIndex = 19;
            this.btnEvet.Text = "EVET";
            this.btnEvet.UseVisualStyleBackColor = true;
            this.btnEvet.Click += new System.EventHandler(this.btnEvet_Click);
            // 
            // btnRaporKaydet
            // 
            this.btnRaporKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRaporKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRaporKaydet.Location = new System.Drawing.Point(14, 164);
            this.btnRaporKaydet.Name = "btnRaporKaydet";
            this.btnRaporKaydet.Size = new System.Drawing.Size(505, 25);
            this.btnRaporKaydet.TabIndex = 13;
            this.btnRaporKaydet.Text = "RAPORU YAZDIR";
            this.btnRaporKaydet.UseVisualStyleBackColor = true;
            this.btnRaporKaydet.Visible = false;
            this.btnRaporKaydet.Click += new System.EventHandler(this.btnRaporKaydet_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Reçete Yazılacak Mı?";
            // 
            // txtUygulananTedavi
            // 
            this.txtUygulananTedavi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtUygulananTedavi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtUygulananTedavi.Location = new System.Drawing.Point(163, 103);
            this.txtUygulananTedavi.Name = "txtUygulananTedavi";
            this.txtUygulananTedavi.Size = new System.Drawing.Size(322, 23);
            this.txtUygulananTedavi.TabIndex = 8;
            this.txtUygulananTedavi.Text = "";
            // 
            // txtHastaSikayet
            // 
            this.txtHastaSikayet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtHastaSikayet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtHastaSikayet.Location = new System.Drawing.Point(163, 72);
            this.txtHastaSikayet.MaxLength = 250;
            this.txtHastaSikayet.Name = "txtHastaSikayet";
            this.txtHastaSikayet.Size = new System.Drawing.Size(322, 23);
            this.txtHastaSikayet.TabIndex = 7;
            this.txtHastaSikayet.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Muayene Tarihi:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Uygulanan Tedavi:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Hasta Şikayeti:";
            // 
            // txtHastaMuayeneTarihi
            // 
            this.txtHastaMuayeneTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHastaMuayeneTarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtHastaMuayeneTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtHastaMuayeneTarihi.Location = new System.Drawing.Point(163, 41);
            this.txtHastaMuayeneTarihi.Name = "txtHastaMuayeneTarihi";
            this.txtHastaMuayeneTarihi.ReadOnly = true;
            this.txtHastaMuayeneTarihi.Size = new System.Drawing.Size(322, 23);
            this.txtHastaMuayeneTarihi.TabIndex = 6;
            this.txtHastaMuayeneTarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaMuayeneTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txtHastaSoyadi);
            this.groupBox3.Controls.Add(this.txtHastaTc);
            this.groupBox3.Controls.Add(this.txtHastaAdi);
            this.groupBox3.Controls.Add(this.txtHastaTelefon);
            this.groupBox3.Enabled = false;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.groupBox3.Location = new System.Drawing.Point(30, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 200);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HASTA BİLGİLERİ";
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 141);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(123, 16);
            this.label23.TabIndex = 5;
            this.label23.Text = "TC Kimlik Numarası";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(26, 110);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 16);
            this.label24.TabIndex = 4;
            this.label24.Text = "Telefon Numarası:";
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(81, 79);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 16);
            this.label26.TabIndex = 3;
            this.label26.Text = "Soyisim:";
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(101, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 16);
            this.label27.TabIndex = 3;
            this.label27.Text = "İsim:";
            // 
            // txtHastaSoyadi
            // 
            this.txtHastaSoyadi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHastaSoyadi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtHastaSoyadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtHastaSoyadi.Location = new System.Drawing.Point(167, 72);
            this.txtHastaSoyadi.Name = "txtHastaSoyadi";
            this.txtHastaSoyadi.Size = new System.Drawing.Size(211, 23);
            this.txtHastaSoyadi.TabIndex = 1;
            this.txtHastaSoyadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaSoyadi.ValidatingType = typeof(System.DateTime);
            // 
            // txtHastaTc
            // 
            this.txtHastaTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHastaTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtHastaTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtHastaTc.Location = new System.Drawing.Point(168, 134);
            this.txtHastaTc.Mask = "00000000000";
            this.txtHastaTc.Name = "txtHastaTc";
            this.txtHastaTc.Size = new System.Drawing.Size(211, 23);
            this.txtHastaTc.TabIndex = 6;
            this.txtHastaTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaTc.ValidatingType = typeof(int);
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHastaAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtHastaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtHastaAdi.Location = new System.Drawing.Point(167, 41);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(211, 23);
            this.txtHastaAdi.TabIndex = 0;
            this.txtHastaAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaAdi.ValidatingType = typeof(System.DateTime);
            // 
            // txtHastaTelefon
            // 
            this.txtHastaTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHastaTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtHastaTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtHastaTelefon.Location = new System.Drawing.Point(167, 103);
            this.txtHastaTelefon.Mask = "(999) 000-0000";
            this.txtHastaTelefon.Name = "txtHastaTelefon";
            this.txtHastaTelefon.Size = new System.Drawing.Size(211, 23);
            this.txtHastaTelefon.TabIndex = 5;
            this.txtHastaTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupRecete
            // 
            this.groupRecete.Controls.Add(this.btnEkle);
            this.groupRecete.Controls.Add(this.label18);
            this.groupRecete.Controls.Add(this.txtIlacTipi);
            this.groupRecete.Controls.Add(this.txtIlacBarkod);
            this.groupRecete.Controls.Add(this.btnIlacBilgiGetir);
            this.groupRecete.Controls.Add(this.label17);
            this.groupRecete.Controls.Add(this.btnReceteRaporKaydet);
            this.groupRecete.Controls.Add(this.label16);
            this.groupRecete.Controls.Add(this.numIlacSayi);
            this.groupRecete.Controls.Add(this.label15);
            this.groupRecete.Controls.Add(this.txtIlacAdi);
            this.groupRecete.Controls.Add(this.btnIlacDataSil);
            this.groupRecete.Controls.Add(this.dataRecete);
            this.groupRecete.Controls.Add(this.btnReceteOlustur);
            this.groupRecete.Controls.Add(this.txtReceteNumarasi);
            this.groupRecete.Location = new System.Drawing.Point(30, 246);
            this.groupRecete.Name = "groupRecete";
            this.groupRecete.Size = new System.Drawing.Size(1074, 278);
            this.groupRecete.TabIndex = 9;
            this.groupRecete.TabStop = false;
            this.groupRecete.Text = "Reçete";
            this.groupRecete.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(894, 158);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(153, 25);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "İLACI EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(802, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 21;
            this.label18.Text = "İlaç Tipi:";
            // 
            // txtIlacTipi
            // 
            this.txtIlacTipi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIlacTipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtIlacTipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtIlacTipi.Location = new System.Drawing.Point(869, 129);
            this.txtIlacTipi.Name = "txtIlacTipi";
            this.txtIlacTipi.ReadOnly = true;
            this.txtIlacTipi.Size = new System.Drawing.Size(202, 23);
            this.txtIlacTipi.TabIndex = 20;
            this.txtIlacTipi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIlacTipi.ValidatingType = typeof(System.DateTime);
            // 
            // txtIlacBarkod
            // 
            this.txtIlacBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIlacBarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtIlacBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtIlacBarkod.Location = new System.Drawing.Point(869, 14);
            this.txtIlacBarkod.Name = "txtIlacBarkod";
            this.txtIlacBarkod.Size = new System.Drawing.Size(202, 23);
            this.txtIlacBarkod.TabIndex = 19;
            this.txtIlacBarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIlacBarkod.ValidatingType = typeof(System.DateTime);
            // 
            // btnIlacBilgiGetir
            // 
            this.btnIlacBilgiGetir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIlacBilgiGetir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIlacBilgiGetir.Location = new System.Drawing.Point(894, 69);
            this.btnIlacBilgiGetir.Name = "btnIlacBilgiGetir";
            this.btnIlacBilgiGetir.Size = new System.Drawing.Size(153, 25);
            this.btnIlacBilgiGetir.TabIndex = 18;
            this.btnIlacBilgiGetir.Text = "BİLGİLERİ GETİR";
            this.btnIlacBilgiGetir.UseVisualStyleBackColor = true;
            this.btnIlacBilgiGetir.Click += new System.EventHandler(this.btnIlacBilgiGetir_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(728, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "İlaç Barkod Numarası:";
            // 
            // btnReceteRaporKaydet
            // 
            this.btnReceteRaporKaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceteRaporKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceteRaporKaydet.Location = new System.Drawing.Point(728, 247);
            this.btnReceteRaporKaydet.Name = "btnReceteRaporKaydet";
            this.btnReceteRaporKaydet.Size = new System.Drawing.Size(341, 25);
            this.btnReceteRaporKaydet.TabIndex = 14;
            this.btnReceteRaporKaydet.Text = "RAPORU YAZDIR";
            this.btnReceteRaporKaydet.UseVisualStyleBackColor = true;
            this.btnReceteRaporKaydet.Click += new System.EventHandler(this.btnReceteRaporKaydet_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(765, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "İlaç Kutu Adeti:";
            // 
            // numIlacSayi
            // 
            this.numIlacSayi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.numIlacSayi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.numIlacSayi.Location = new System.Drawing.Point(869, 43);
            this.numIlacSayi.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numIlacSayi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIlacSayi.Name = "numIlacSayi";
            this.numIlacSayi.Size = new System.Drawing.Size(202, 23);
            this.numIlacSayi.TabIndex = 15;
            this.numIlacSayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numIlacSayi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(806, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "İlaç Adı:";
            // 
            // txtIlacAdi
            // 
            this.txtIlacAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIlacAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtIlacAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtIlacAdi.Location = new System.Drawing.Point(869, 100);
            this.txtIlacAdi.Name = "txtIlacAdi";
            this.txtIlacAdi.ReadOnly = true;
            this.txtIlacAdi.Size = new System.Drawing.Size(202, 23);
            this.txtIlacAdi.TabIndex = 13;
            this.txtIlacAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIlacAdi.ValidatingType = typeof(System.DateTime);
            // 
            // btnIlacDataSil
            // 
            this.btnIlacDataSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIlacDataSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIlacDataSil.Location = new System.Drawing.Point(726, 158);
            this.btnIlacDataSil.Name = "btnIlacDataSil";
            this.btnIlacDataSil.Size = new System.Drawing.Size(153, 25);
            this.btnIlacDataSil.TabIndex = 12;
            this.btnIlacDataSil.Text = "İLACI SİL";
            this.btnIlacDataSil.UseVisualStyleBackColor = true;
            this.btnIlacDataSil.Click += new System.EventHandler(this.btnIlacDataSil_Click);
            // 
            // dataRecete
            // 
            this.dataRecete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.dataRecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tc_kimlik,
            this.recete_tarihi,
            this.barkod_no,
            this.kutu_adeti,
            this.recete_no});
            this.dataRecete.GridColor = System.Drawing.Color.Cyan;
            this.dataRecete.Location = new System.Drawing.Point(29, 24);
            this.dataRecete.Name = "dataRecete";
            this.dataRecete.Size = new System.Drawing.Size(683, 250);
            this.dataRecete.TabIndex = 11;
            // 
            // tc_kimlik
            // 
            this.tc_kimlik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tc_kimlik.HeaderText = "tc_kimlik";
            this.tc_kimlik.Name = "tc_kimlik";
            this.tc_kimlik.ReadOnly = true;
            // 
            // recete_tarihi
            // 
            this.recete_tarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recete_tarihi.HeaderText = "recete_tarihi";
            this.recete_tarihi.Name = "recete_tarihi";
            this.recete_tarihi.ReadOnly = true;
            // 
            // barkod_no
            // 
            this.barkod_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.barkod_no.HeaderText = "barkod_no";
            this.barkod_no.Name = "barkod_no";
            this.barkod_no.ReadOnly = true;
            // 
            // kutu_adeti
            // 
            this.kutu_adeti.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kutu_adeti.HeaderText = "kutu_adeti";
            this.kutu_adeti.Name = "kutu_adeti";
            this.kutu_adeti.ReadOnly = true;
            // 
            // recete_no
            // 
            this.recete_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.recete_no.HeaderText = "recete_no";
            this.recete_no.Name = "recete_no";
            this.recete_no.ReadOnly = true;
            // 
            // btnReceteOlustur
            // 
            this.btnReceteOlustur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceteOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceteOlustur.Location = new System.Drawing.Point(818, 188);
            this.btnReceteOlustur.Name = "btnReceteOlustur";
            this.btnReceteOlustur.Size = new System.Drawing.Size(147, 25);
            this.btnReceteOlustur.TabIndex = 10;
            this.btnReceteOlustur.Text = "REÇETE OLUŞTUR";
            this.btnReceteOlustur.UseVisualStyleBackColor = true;
            this.btnReceteOlustur.Click += new System.EventHandler(this.btnReceteOlustur_Click);
            // 
            // txtReceteNumarasi
            // 
            this.txtReceteNumarasi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtReceteNumarasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtReceteNumarasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtReceteNumarasi.Location = new System.Drawing.Point(782, 218);
            this.txtReceteNumarasi.Name = "txtReceteNumarasi";
            this.txtReceteNumarasi.ReadOnly = true;
            this.txtReceteNumarasi.Size = new System.Drawing.Size(233, 23);
            this.txtReceteNumarasi.TabIndex = 5;
            this.txtReceteNumarasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceteNumarasi.Visible = false;
            // 
            // pageIlac
            // 
            this.pageIlac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.pageIlac.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pageIlac.Controls.Add(this.groupBox6);
            this.pageIlac.Controls.Add(this.groupBox5);
            this.pageIlac.Controls.Add(this.groupBox4);
            this.pageIlac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.pageIlac.Location = new System.Drawing.Point(4, 27);
            this.pageIlac.Name = "pageIlac";
            this.pageIlac.Padding = new System.Windows.Forms.Padding(3);
            this.pageIlac.Size = new System.Drawing.Size(1129, 534);
            this.pageIlac.TabIndex = 3;
            this.pageIlac.Text = "İlaç Ekranı";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.groupBox6.Controls.Add(this.btbnIlacGuncelle);
            this.groupBox6.Controls.Add(this.btnIlacSil);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.cmbGuncelleIlacTipi);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.txtGuncelleBarkod);
            this.groupBox6.Controls.Add(this.txtGuncelleIlacAdi);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.groupBox6.Location = new System.Drawing.Point(41, 258);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(418, 197);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "İLAÇ GÜNCELLE | SİL";
            // 
            // btbnIlacGuncelle
            // 
            this.btbnIlacGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbnIlacGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btbnIlacGuncelle.Location = new System.Drawing.Point(64, 144);
            this.btbnIlacGuncelle.Name = "btbnIlacGuncelle";
            this.btbnIlacGuncelle.Size = new System.Drawing.Size(153, 25);
            this.btbnIlacGuncelle.TabIndex = 15;
            this.btbnIlacGuncelle.Text = "GÜNCELLE";
            this.btbnIlacGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btbnIlacGuncelle.UseVisualStyleBackColor = true;
            this.btbnIlacGuncelle.Click += new System.EventHandler(this.btbnIlacGuncelle_Click);
            // 
            // btnIlacSil
            // 
            this.btnIlacSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIlacSil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIlacSil.Location = new System.Drawing.Point(223, 144);
            this.btnIlacSil.Name = "btnIlacSil";
            this.btnIlacSil.Size = new System.Drawing.Size(153, 25);
            this.btnIlacSil.TabIndex = 9;
            this.btnIlacSil.Text = "SİL";
            this.btnIlacSil.UseVisualStyleBackColor = true;
            this.btnIlacSil.Click += new System.EventHandler(this.btnIlacSil_Click);
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(102, 109);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 16);
            this.label28.TabIndex = 14;
            this.label28.Text = "Tipi:";
            // 
            // cmbGuncelleIlacTipi
            // 
            this.cmbGuncelleIlacTipi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGuncelleIlacTipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.cmbGuncelleIlacTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuncelleIlacTipi.Enabled = false;
            this.cmbGuncelleIlacTipi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGuncelleIlacTipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.cmbGuncelleIlacTipi.FormattingEnabled = true;
            this.cmbGuncelleIlacTipi.Items.AddRange(new object[] {
            "Şurup",
            "Tablet",
            "Kapsül",
            "Flakon",
            "Krem",
            "Merhem"});
            this.cmbGuncelleIlacTipi.Location = new System.Drawing.Point(165, 102);
            this.cmbGuncelleIlacTipi.Name = "cmbGuncelleIlacTipi";
            this.cmbGuncelleIlacTipi.Size = new System.Drawing.Size(211, 23);
            this.cmbGuncelleIlacTipi.TabIndex = 7;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(26, 51);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(108, 16);
            this.label29.TabIndex = 5;
            this.label29.Text = "Barkod Numarası:";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(99, 80);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(35, 16);
            this.label30.TabIndex = 3;
            this.label30.Text = "İsim:";
            // 
            // txtGuncelleBarkod
            // 
            this.txtGuncelleBarkod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGuncelleBarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtGuncelleBarkod.Enabled = false;
            this.txtGuncelleBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtGuncelleBarkod.Location = new System.Drawing.Point(165, 44);
            this.txtGuncelleBarkod.Mask = "00000000000";
            this.txtGuncelleBarkod.Name = "txtGuncelleBarkod";
            this.txtGuncelleBarkod.ReadOnly = true;
            this.txtGuncelleBarkod.Size = new System.Drawing.Size(211, 23);
            this.txtGuncelleBarkod.TabIndex = 6;
            this.txtGuncelleBarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuncelleBarkod.ValidatingType = typeof(int);
            // 
            // txtGuncelleIlacAdi
            // 
            this.txtGuncelleIlacAdi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGuncelleIlacAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtGuncelleIlacAdi.Enabled = false;
            this.txtGuncelleIlacAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtGuncelleIlacAdi.Location = new System.Drawing.Point(165, 73);
            this.txtGuncelleIlacAdi.Name = "txtGuncelleIlacAdi";
            this.txtGuncelleIlacAdi.Size = new System.Drawing.Size(211, 23);
            this.txtGuncelleIlacAdi.TabIndex = 0;
            this.txtGuncelleIlacAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuncelleIlacAdi.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.btnIlacBilgiAktar);
            this.groupBox5.Controls.Add(this.txtIlacBilgiAktar);
            this.groupBox5.Controls.Add(this.btnListeIlacGuncelle);
            this.groupBox5.Controls.Add(this.dataIlac);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.groupBox5.Location = new System.Drawing.Point(478, 46);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(641, 409);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "KAYITLI İLAÇ LİSTESİ";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(460, 134);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(132, 16);
            this.label19.TabIndex = 25;
            this.label19.Text = "İlaç Barkod Numarası:";
            // 
            // btnIlacBilgiAktar
            // 
            this.btnIlacBilgiAktar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIlacBilgiAktar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIlacBilgiAktar.Location = new System.Drawing.Point(411, 223);
            this.btnIlacBilgiAktar.Name = "btnIlacBilgiAktar";
            this.btnIlacBilgiAktar.Size = new System.Drawing.Size(214, 25);
            this.btnIlacBilgiAktar.TabIndex = 12;
            this.btnIlacBilgiAktar.Text = "İLAÇ BİLGİLERİNİ AKTAR";
            this.btnIlacBilgiAktar.UseVisualStyleBackColor = true;
            this.btnIlacBilgiAktar.Click += new System.EventHandler(this.btnIlacBilgiAktar_Click);
            // 
            // txtIlacBilgiAktar
            // 
            this.txtIlacBilgiAktar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIlacBilgiAktar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtIlacBilgiAktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtIlacBilgiAktar.Location = new System.Drawing.Point(457, 175);
            this.txtIlacBilgiAktar.Mask = "00000000000";
            this.txtIlacBilgiAktar.Name = "txtIlacBilgiAktar";
            this.txtIlacBilgiAktar.Size = new System.Drawing.Size(135, 23);
            this.txtIlacBilgiAktar.TabIndex = 11;
            this.txtIlacBilgiAktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIlacBilgiAktar.ValidatingType = typeof(int);
            // 
            // btnListeIlacGuncelle
            // 
            this.btnListeIlacGuncelle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListeIlacGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListeIlacGuncelle.Location = new System.Drawing.Point(408, 263);
            this.btnListeIlacGuncelle.Name = "btnListeIlacGuncelle";
            this.btnListeIlacGuncelle.Size = new System.Drawing.Size(217, 25);
            this.btnListeIlacGuncelle.TabIndex = 10;
            this.btnListeIlacGuncelle.Text = "LİSTEYİ GÜNCELLE";
            this.btnListeIlacGuncelle.UseVisualStyleBackColor = true;
            this.btnListeIlacGuncelle.Click += new System.EventHandler(this.btnListeIlacGuncelle_Click);
            // 
            // dataIlac
            // 
            this.dataIlac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataIlac.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.dataIlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIlac.GridColor = System.Drawing.Color.Cyan;
            this.dataIlac.Location = new System.Drawing.Point(40, 33);
            this.dataIlac.Name = "dataIlac";
            this.dataIlac.ReadOnly = true;
            this.dataIlac.Size = new System.Drawing.Size(343, 348);
            this.dataIlac.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.groupBox4.Controls.Add(this.btnYeniIlac);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.cmbEkleIlacTip);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.txtEkleBarkod);
            this.groupBox4.Controls.Add(this.txtEkleIlacAd);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.groupBox4.Location = new System.Drawing.Point(41, 46);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(418, 185);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "YENİ İLAÇ EKLE";
            // 
            // btnYeniIlac
            // 
            this.btnYeniIlac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYeniIlac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYeniIlac.Location = new System.Drawing.Point(194, 137);
            this.btnYeniIlac.Name = "btnYeniIlac";
            this.btnYeniIlac.Size = new System.Drawing.Size(153, 25);
            this.btnYeniIlac.TabIndex = 9;
            this.btnYeniIlac.Text = "EKLE";
            this.btnYeniIlac.UseVisualStyleBackColor = true;
            this.btnYeniIlac.Click += new System.EventHandler(this.btnYeniIlac_Click);
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(102, 103);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 16);
            this.label22.TabIndex = 14;
            this.label22.Text = "Tipi:";
            // 
            // cmbEkleIlacTip
            // 
            this.cmbEkleIlacTip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEkleIlacTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.cmbEkleIlacTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEkleIlacTip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbEkleIlacTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.cmbEkleIlacTip.FormattingEnabled = true;
            this.cmbEkleIlacTip.Items.AddRange(new object[] {
            "Şurup",
            "Tablet",
            "Kapsül",
            "Flakon",
            "Krem",
            "Merhem"});
            this.cmbEkleIlacTip.Location = new System.Drawing.Point(165, 96);
            this.cmbEkleIlacTip.Name = "cmbEkleIlacTip";
            this.cmbEkleIlacTip.Size = new System.Drawing.Size(211, 23);
            this.cmbEkleIlacTip.TabIndex = 7;
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(26, 69);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(108, 16);
            this.label25.TabIndex = 5;
            this.label25.Text = "Barkod Numarası:";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(99, 40);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(35, 16);
            this.label31.TabIndex = 3;
            this.label31.Text = "İsim:";
            // 
            // txtEkleBarkod
            // 
            this.txtEkleBarkod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEkleBarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtEkleBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtEkleBarkod.Location = new System.Drawing.Point(165, 62);
            this.txtEkleBarkod.Mask = "00000000000";
            this.txtEkleBarkod.Name = "txtEkleBarkod";
            this.txtEkleBarkod.Size = new System.Drawing.Size(211, 23);
            this.txtEkleBarkod.TabIndex = 6;
            this.txtEkleBarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEkleBarkod.ValidatingType = typeof(int);
            // 
            // txtEkleIlacAd
            // 
            this.txtEkleIlacAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEkleIlacAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtEkleIlacAd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtEkleIlacAd.Location = new System.Drawing.Point(165, 33);
            this.txtEkleIlacAd.Name = "txtEkleIlacAd";
            this.txtEkleIlacAd.Size = new System.Drawing.Size(211, 23);
            this.txtEkleIlacAd.TabIndex = 0;
            this.txtEkleIlacAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEkleIlacAd.ValidatingType = typeof(System.DateTime);
            // 
            // frmMuayeneEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1184, 678);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMuayeneEkrani";
            this.Text = "MUAYENE EKRANI";
            this.Load += new System.EventHandler(this.frmMuayeneEkrani_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.boxHastaKayit.ResumeLayout(false);
            this.boxHastaKayit.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.pageHasta.ResumeLayout(false);
            this.pageHasta.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHastaBilgi)).EndInit();
            this.pageMuayene.ResumeLayout(false);
            this.pageMuayene.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupRecete.ResumeLayout(false);
            this.groupRecete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIlacSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecete)).EndInit();
            this.pageIlac.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIlac)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.GroupBox boxHastaKayit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtTcNo;
        private System.Windows.Forms.MaskedTextBox txtTelefonNumarasi;
        private System.Windows.Forms.MaskedTextBox txtDogumTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox txtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtDogumYeri;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMedeni;
        private System.Windows.Forms.Button btnHastaKaydet;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pageHasta;
        private System.Windows.Forms.TabPage pageMuayene;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox txtTcKontrol;
        private System.Windows.Forms.Button btnHastaBilgiAktar;
        private System.Windows.Forms.Button btnHastaListeGuncelle;
        private System.Windows.Forms.DataGridView dataHastaBilgi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.MaskedTextBox txtHastaSoyadi;
        private System.Windows.Forms.MaskedTextBox txtHastaTc;
        private System.Windows.Forms.MaskedTextBox txtHastaAdi;
        private System.Windows.Forms.MaskedTextBox txtHastaTelefon;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ToolStripMenuItem menuYeniMuayene;
        private System.Windows.Forms.ToolStripMenuItem menuMuayeneListele;
        private System.Windows.Forms.ToolStripMenuItem menuReceteListele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtHastaMuayeneTarihi;
        private System.Windows.Forms.MaskedTextBox txtReceteNumarasi;
        private System.Windows.Forms.RichTextBox txtUygulananTedavi;
        private System.Windows.Forms.RichTextBox txtHastaSikayet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupRecete;
        private System.Windows.Forms.Button btnReceteOlustur;
        private System.Windows.Forms.Button btnRaporKaydet;
        private System.Windows.Forms.DataGridView dataRecete;
        private System.Windows.Forms.Button btnIlacDataSil;
        private System.Windows.Forms.NumericUpDown numIlacSayi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtIlacAdi;
        private System.Windows.Forms.Button btnIlacBilgiGetir;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnReceteRaporKaydet;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtIlacTipi;
        private System.Windows.Forms.MaskedTextBox txtIlacBarkod;
        private System.Windows.Forms.TabPage pageIlac;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnYeniIlac;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbEkleIlacTip;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.MaskedTextBox txtEkleBarkod;
        private System.Windows.Forms.MaskedTextBox txtEkleIlacAd;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btbnIlacGuncelle;
        private System.Windows.Forms.Button btnIlacSil;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbGuncelleIlacTipi;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.MaskedTextBox txtGuncelleIlacAdi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnIlacBilgiAktar;
        private System.Windows.Forms.MaskedTextBox txtIlacBilgiAktar;
        private System.Windows.Forms.Button btnListeIlacGuncelle;
        private System.Windows.Forms.DataGridView dataIlac;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.MaskedTextBox txtGuncelleBarkod;
        private System.Windows.Forms.Button btnHayir;
        private System.Windows.Forms.Button btnEvet;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridViewComboBoxColumn kutuAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_kimlik;
        private System.Windows.Forms.DataGridViewTextBoxColumn recete_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkod_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn kutu_adeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn recete_no;
        private System.Windows.Forms.PictureBox exit;
    }
}


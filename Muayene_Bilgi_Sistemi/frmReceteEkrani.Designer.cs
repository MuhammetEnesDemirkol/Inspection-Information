namespace Muayene_Bilgi_Sistemi
{
    partial class frmReceteEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceteEkrani));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuYeniMuayene = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMuayeneKayitlari = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupRecete = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTcListele = new System.Windows.Forms.Button();
            this.txtIlacBarkod = new System.Windows.Forms.MaskedTextBox();
            this.btnBarkodListele = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHastaTc = new System.Windows.Forms.MaskedTextBox();
            this.btnReceteListele = new System.Windows.Forms.Button();
            this.dataRecete = new System.Windows.Forms.DataGridView();
            this.table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.menu.SuspendLayout();
            this.groupRecete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(342, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bİ\'RİCA REÇETE KAYITLARI";
            // 
            // table
            // 
            this.table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.table.Controls.Add(this.exit);
            this.table.Controls.Add(this.menu);
            this.table.Controls.Add(this.label1);
            this.table.Dock = System.Windows.Forms.DockStyle.Top;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(1184, 100);
            this.table.TabIndex = 2;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1127, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(54, 47);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 11;
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
            this.menuMuayeneKayitlari,
            this.toolStripMenuItem2});
            this.menu.Location = new System.Drawing.Point(38, 71);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(303, 43);
            this.menu.TabIndex = 10;
            this.menu.Text = "menü";
            this.menu.Visible = false;
            // 
            // menuYeniMuayene
            // 
            this.menuYeniMuayene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.menuYeniMuayene.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.menuYeniMuayene.Name = "menuYeniMuayene";
            this.menuYeniMuayene.Size = new System.Drawing.Size(110, 19);
            this.menuYeniMuayene.Text = "YENİ MUAYENE ";
            this.menuYeniMuayene.Click += new System.EventHandler(this.menuYeniMuayene_Click);
            // 
            // menuMuayeneKayitlari
            // 
            this.menuMuayeneKayitlari.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.menuMuayeneKayitlari.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.menuMuayeneKayitlari.Name = "menuMuayeneKayitlari";
            this.menuMuayeneKayitlari.Size = new System.Drawing.Size(98, 19);
            this.menuMuayeneKayitlari.Text = "MUAYENELER";
            this.menuMuayeneKayitlari.Click += new System.EventHandler(this.menuMuayeneKayitlari_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Cyan;
            this.toolStripMenuItem2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 19);
            this.toolStripMenuItem2.Text = "REÇETELER";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.ForeColor = System.Drawing.Color.Cyan;
            this.btnMenu.Location = new System.Drawing.Point(0, 100);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 578);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "M\r\nE\r\nN\r\nÜ\r\n";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // groupRecete
            // 
            this.groupRecete.Controls.Add(this.groupBox1);
            this.groupRecete.Controls.Add(this.btnReceteListele);
            this.groupRecete.Controls.Add(this.dataRecete);
            this.groupRecete.Location = new System.Drawing.Point(58, 126);
            this.groupRecete.Name = "groupRecete";
            this.groupRecete.Size = new System.Drawing.Size(1114, 540);
            this.groupRecete.TabIndex = 10;
            this.groupRecete.TabStop = false;
            this.groupRecete.Text = "Reçeteler";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTcListele);
            this.groupBox1.Controls.Add(this.txtIlacBarkod);
            this.groupBox1.Controls.Add(this.btnBarkodListele);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtHastaTc);
            this.groupBox1.Location = new System.Drawing.Point(728, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 217);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre Uygula";
            // 
            // btnTcListele
            // 
            this.btnTcListele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTcListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTcListele.Location = new System.Drawing.Point(111, 175);
            this.btnTcListele.Name = "btnTcListele";
            this.btnTcListele.Size = new System.Drawing.Size(153, 25);
            this.btnTcListele.TabIndex = 20;
            this.btnTcListele.Text = "FİLTRE UYGULA";
            this.btnTcListele.UseVisualStyleBackColor = true;
            this.btnTcListele.Click += new System.EventHandler(this.btnTcListele_Click);
            // 
            // txtIlacBarkod
            // 
            this.txtIlacBarkod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIlacBarkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtIlacBarkod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtIlacBarkod.Location = new System.Drawing.Point(187, 23);
            this.txtIlacBarkod.Mask = "00000000000";
            this.txtIlacBarkod.Name = "txtIlacBarkod";
            this.txtIlacBarkod.Size = new System.Drawing.Size(174, 23);
            this.txtIlacBarkod.TabIndex = 19;
            this.txtIlacBarkod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIlacBarkod.ValidatingType = typeof(System.DateTime);
            // 
            // btnBarkodListele
            // 
            this.btnBarkodListele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBarkodListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarkodListele.Location = new System.Drawing.Point(111, 85);
            this.btnBarkodListele.Name = "btnBarkodListele";
            this.btnBarkodListele.Size = new System.Drawing.Size(153, 25);
            this.btnBarkodListele.TabIndex = 18;
            this.btnBarkodListele.Text = "FİLTRE UYGULA";
            this.btnBarkodListele.UseVisualStyleBackColor = true;
            this.btnBarkodListele.Click += new System.EventHandler(this.btnBarkodListele_Click);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(49, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "İlaç Barkod Numarası:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "Hasta TC Kimlik Numarası:";
            // 
            // txtHastaTc
            // 
            this.txtHastaTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHastaTc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.txtHastaTc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.txtHastaTc.Location = new System.Drawing.Point(187, 125);
            this.txtHastaTc.Mask = "00000000000";
            this.txtHastaTc.Name = "txtHastaTc";
            this.txtHastaTc.Size = new System.Drawing.Size(176, 23);
            this.txtHastaTc.TabIndex = 13;
            this.txtHastaTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaTc.ValidatingType = typeof(System.DateTime);
            // 
            // btnReceteListele
            // 
            this.btnReceteListele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceteListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceteListele.Location = new System.Drawing.Point(741, 449);
            this.btnReceteListele.Name = "btnReceteListele";
            this.btnReceteListele.Size = new System.Drawing.Size(361, 40);
            this.btnReceteListele.TabIndex = 14;
            this.btnReceteListele.Text = "TÜM REÇETELERİ LİSTELE";
            this.btnReceteListele.UseVisualStyleBackColor = true;
            this.btnReceteListele.Click += new System.EventHandler(this.btnReceteListele_Click);
            // 
            // dataRecete
            // 
            this.dataRecete.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.dataRecete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRecete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRecete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataRecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRecete.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataRecete.GridColor = System.Drawing.Color.Cyan;
            this.dataRecete.Location = new System.Drawing.Point(29, 24);
            this.dataRecete.Name = "dataRecete";
            this.dataRecete.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRecete.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataRecete.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataRecete.Size = new System.Drawing.Size(657, 494);
            this.dataRecete.TabIndex = 11;
            // 
            // frmReceteEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1184, 678);
            this.Controls.Add(this.groupRecete);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.table);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmReceteEkrani";
            this.Text = "frm1";
            this.Load += new System.EventHandler(this.frmReceteEkrani_Load);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupRecete.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel table;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuYeniMuayene;
        private System.Windows.Forms.ToolStripMenuItem menuMuayeneKayitlari;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.GroupBox groupRecete;
        private System.Windows.Forms.MaskedTextBox txtIlacBarkod;
        private System.Windows.Forms.Button btnBarkodListele;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnReceteListele;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtHastaTc;
        private System.Windows.Forms.DataGridView dataRecete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTcListele;
        private System.Windows.Forms.PictureBox exit;
    }
}
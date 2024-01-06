namespace Muayene_Bilgi_Sistemi
{
    partial class frmMuayeneKayitlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuayeneKayitlari));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuYeniMuayene = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecete = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupRecete = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTcListele = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHastaTc = new System.Windows.Forms.MaskedTextBox();
            this.btnMuayeneListele = new System.Windows.Forms.Button();
            this.dataMuayeneler = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.menu.SuspendLayout();
            this.groupRecete.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMuayeneler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 100);
            this.panel1.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1130, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(54, 47);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 13;
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
            this.toolStripMenuItem1,
            this.menuRecete});
            this.menu.Location = new System.Drawing.Point(38, 71);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(303, 43);
            this.menu.TabIndex = 11;
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Cyan;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 19);
            this.toolStripMenuItem1.Text = "MUAYENELER";
            // 
            // menuRecete
            // 
            this.menuRecete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.menuRecete.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.menuRecete.Name = "menuRecete";
            this.menuRecete.Size = new System.Drawing.Size(87, 19);
            this.menuRecete.Text = "REÇETELER";
            this.menuRecete.Click += new System.EventHandler(this.menuRecete_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(326, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bİ\'RİCA MUAYENE KAYITLARI";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.ForeColor = System.Drawing.Color.Cyan;
            this.btnMenu.Location = new System.Drawing.Point(0, 100);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(35, 578);
            this.btnMenu.TabIndex = 7;
            this.btnMenu.Text = "M\r\nE\r\nN\r\nÜ\r\n";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // groupRecete
            // 
            this.groupRecete.Controls.Add(this.groupBox1);
            this.groupRecete.Controls.Add(this.btnMuayeneListele);
            this.groupRecete.Controls.Add(this.dataMuayeneler);
            this.groupRecete.Location = new System.Drawing.Point(58, 126);
            this.groupRecete.Name = "groupRecete";
            this.groupRecete.Size = new System.Drawing.Size(1112, 529);
            this.groupRecete.TabIndex = 12;
            this.groupRecete.TabStop = false;
            this.groupRecete.Text = "Muayene Kayıtları";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTcListele);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtHastaTc);
            this.groupBox1.Location = new System.Drawing.Point(809, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 134);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtre Uygula";
            // 
            // btnTcListele
            // 
            this.btnTcListele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTcListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTcListele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTcListele.Location = new System.Drawing.Point(68, 81);
            this.btnTcListele.Name = "btnTcListele";
            this.btnTcListele.Size = new System.Drawing.Size(153, 25);
            this.btnTcListele.TabIndex = 20;
            this.btnTcListele.Text = "FİLTRE UYGULA";
            this.btnTcListele.UseVisualStyleBackColor = true;
            this.btnTcListele.Click += new System.EventHandler(this.btnTcListele_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(6, 49);
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
            this.txtHastaTc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtHastaTc.Location = new System.Drawing.Point(173, 42);
            this.txtHastaTc.Mask = "00000000000";
            this.txtHastaTc.Name = "txtHastaTc";
            this.txtHastaTc.Size = new System.Drawing.Size(113, 23);
            this.txtHastaTc.TabIndex = 13;
            this.txtHastaTc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHastaTc.ValidatingType = typeof(System.DateTime);
            // 
            // btnMuayeneListele
            // 
            this.btnMuayeneListele.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMuayeneListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMuayeneListele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMuayeneListele.Location = new System.Drawing.Point(809, 443);
            this.btnMuayeneListele.Name = "btnMuayeneListele";
            this.btnMuayeneListele.Size = new System.Drawing.Size(292, 40);
            this.btnMuayeneListele.TabIndex = 14;
            this.btnMuayeneListele.Text = "TÜM MUAYENE KAYITLARINI LİSTELE";
            this.btnMuayeneListele.UseVisualStyleBackColor = true;
            this.btnMuayeneListele.Click += new System.EventHandler(this.btnMuayeneListele_Click);
            // 
            // dataMuayeneler
            // 
            this.dataMuayeneler.AllowUserToAddRows = false;
            this.dataMuayeneler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            this.dataMuayeneler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataMuayeneler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMuayeneler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataMuayeneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataMuayeneler.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataMuayeneler.GridColor = System.Drawing.Color.Cyan;
            this.dataMuayeneler.Location = new System.Drawing.Point(29, 24);
            this.dataMuayeneler.Name = "dataMuayeneler";
            this.dataMuayeneler.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataMuayeneler.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataMuayeneler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataMuayeneler.Size = new System.Drawing.Size(774, 494);
            this.dataMuayeneler.TabIndex = 11;
            // 
            // frmMuayeneKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(183)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(1184, 678);
            this.Controls.Add(this.groupRecete);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMuayeneKayitlari";
            this.Text = "frm3";
            this.Load += new System.EventHandler(this.frmMuayeneKayitlari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupRecete.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMuayeneler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuYeniMuayene;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuRecete;
        private System.Windows.Forms.GroupBox groupRecete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTcListele;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtHastaTc;
        private System.Windows.Forms.Button btnMuayeneListele;
        private System.Windows.Forms.DataGridView dataMuayeneler;
        private System.Windows.Forms.PictureBox exit;
    }
}
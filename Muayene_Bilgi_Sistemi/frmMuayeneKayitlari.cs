using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muayene_Bilgi_Sistemi
{
    public partial class frmMuayeneKayitlari : Form
    {
        public frmMuayeneKayitlari()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=postgres; user ID=postgres; password=1723");
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menu.Visible)
            {
                menu.Visible = false;

            }
            else
            {
                menu.Visible = true;
            }
        }

        private void menuYeniMuayene_Click(object sender, EventArgs e)
        {
            frmMuayeneEkrani frm = new frmMuayeneEkrani();
            frm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuRecete_Click(object sender, EventArgs e)
        {
            frmReceteEkrani frm = new frmReceteEkrani();
            frm.Show();
            this.Hide();
        }

        private void frmMuayeneKayitlari_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from muayenebilgileri order by muayene_tarihi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataMuayeneler.DataSource = ds.Tables[0];
            dataMuayeneler.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataMuayeneler.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataMuayeneler.DefaultCellStyle.ForeColor = Color.Cyan;
            dataMuayeneler.AutoResizeColumns();
            dataMuayeneler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnTcListele_Click(object sender, EventArgs e)
        {
            //tc numarasına göre listele
            string sorgu = "SELECT * FROM muayenebilgileri WHERE tc_kimliknumarasi = @tcNumarasi";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tcNumarasi", txtHastaTc.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataMuayeneler.DataSource = dt;
            dataMuayeneler.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataMuayeneler.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataMuayeneler.DefaultCellStyle.ForeColor = Color.Cyan;
        }

        private void btnMuayeneListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from muayenebilgileri order by muayene_tarihi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataMuayeneler.DataSource = ds.Tables[0];
            dataMuayeneler.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataMuayeneler.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataMuayeneler.DefaultCellStyle.ForeColor = Color.Cyan;
            dataMuayeneler.AutoResizeColumns();
            dataMuayeneler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}

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
    public partial class frmReceteEkrani : Form
    {
        public frmReceteEkrani()
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

        private void frmReceteEkrani_Load(object sender, EventArgs e)
        {
            //receteleri listele
            string sorgu = "select * from receteler order by recete_tarihi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataRecete.DataSource = ds.Tables[0];
            dataRecete.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.ForeColor = Color.Cyan;
            dataRecete.AutoResizeColumns();
            dataRecete.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnBarkodListele_Click(object sender, EventArgs e)
        {
            //barkod numarasına göre listele
            string sorgu = "SELECT * FROM receteler WHERE ilac_barkod_numarasi = @barkodNumarasi";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@barkodNumarasi", txtIlacBarkod.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataRecete.DataSource = dt;
            dataRecete.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.ForeColor = Color.Cyan;
        }

        private void btnTcListele_Click(object sender, EventArgs e)
        {
            //tc numarasına göre listele
            string sorgu = "SELECT * FROM receteler WHERE tckimlik_numarasi = @tcNumarasi";
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tcNumarasi", txtHastaTc.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataRecete.DataSource = dt;
            dataRecete.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.ForeColor = Color.Cyan;
        }

        private void btnReceteListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from receteler order by recete_tarihi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataRecete.DataSource = ds.Tables[0];
            dataRecete.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.ForeColor = Color.Cyan;
        }

        private void menuMuayeneKayitlari_Click(object sender, EventArgs e)
        {
            frmMuayeneKayitlari frm = new frmMuayeneKayitlari();
            frm.Show();
            this.Hide();
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Muayene_Bilgi_Sistemi
{
    public partial class frmMuayeneEkrani : Form
    {
        public frmMuayeneEkrani()
        {
            InitializeComponent();
            // ToolTip nesnesi oluştur, tablodan ilaç silmek için
            ToolTip toolTip = new ToolTip();
            toolTip.BackColor = Color.FromArgb(0, 39, 53);
            toolTip.ForeColor = Color.Cyan;
            toolTip.IsBalloon = true;
            toolTip.UseAnimation = true;
            toolTip.UseFading = true;
            toolTip.InitialDelay = 100;
            toolTip.SetToolTip(btnIlacDataSil, "İlaç bilgisi silmek için, tablodan silmek istediğiniz ilacı seçiniz.");
            // ToolTip nesnesi oluştur,  ilaç bilgileri güncellemek için
            ToolTip toolTip1 = new ToolTip();
            toolTip1.BackColor = Color.FromArgb(0, 39, 53);
            toolTip1.ForeColor = Color.Cyan;
            toolTip1.IsBalloon = true;
            toolTip1.UseAnimation = true;
            toolTip1.UseFading = true;
            toolTip1.InitialDelay = 100;
            toolTip1.SetToolTip(btnIlacSil, "İlaç bilgisi silmek için, ilaç bilgilerini aktarınız");
            toolTip1.SetToolTip(btbnIlacGuncelle, "İlaç bilgisi güncellemek için, ilaç bilgilerini aktarınız.");

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

        private void frmMuayeneEkrani_Load(object sender, EventArgs e)
        {
            //hastabilgileri listele
            string sorgu = "select * from hastabilgileri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataHastaBilgi.DataSource = ds.Tables[0];
            dataHastaBilgi.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataHastaBilgi.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataHastaBilgi.DefaultCellStyle.ForeColor = Color.Cyan;

            //ilaçbilgileri listele
            string sorgu2 = "select * from ilaclar";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dataIlac.DataSource = ds2.Tables[0];
            dataIlac.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataIlac.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataIlac.DefaultCellStyle.ForeColor = Color.Cyan;

            //tarihi yazdır.
            string tarih = DateTime.Now.ToString("yyyy-MM-dd");
            txtHastaMuayeneTarihi.Text = tarih;

            //dataRecete görsel düzen
            dataRecete.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataRecete.DefaultCellStyle.ForeColor = Color.Cyan;


        }
        private void btnEvet_Click(object sender, EventArgs e)
        {
            groupRecete.Visible = true;
            btnRaporKaydet.Visible = false;
            Random rnd = new Random();
            int rastgele = rnd.Next(10000000, 20000000);
            txtReceteNumarasi.Text = rastgele.ToString();
        }

        private void btnHayir_Click(object sender, EventArgs e)
        {
            btnRaporKaydet.Visible = true;
            groupRecete.Visible = false;
        }

        //*********************************//HASTA KAYIT EKRANI//**********************************

        private void btnHastaBilgiAktar_Click(object sender, EventArgs e)
        {
            //Hastanın bilgilerini, tabpage2'de "hasta bilgileri" kısmına aktar
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from hastabilgileri where \"tc_kimlik_numarasi\" like '" + txtTcKontrol.Text + "' ", baglanti);
            NpgsqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                txtHastaTc.Text = reader[0].ToString();
                txtHastaAdi.Text = reader[1].ToString();
                txtHastaSoyadi.Text = reader[2].ToString();
                txtHastaTelefon.Text = reader[6].ToString();

                if (reader[0] != null)
                {
                    txtHastaTc.Enabled = true;
                    txtHastaAdi.Enabled = true;
                    txtHastaSoyadi.Enabled = true;
                    txtHastaTelefon.Enabled = true;
                    MessageBox.Show("Hasta bilgileri başarıyla aktarıldı. 'Muayene Bilgisi' ekranından işlemlerinize devam edebilirsiniz.", "Aktarma Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControl.SelectedTab = pageMuayene;
                }
            }
            baglanti.Close();
        }

        private void btnHastaListeGuncelle_Click(object sender, EventArgs e)
        {
            //DataGrid'e hastaların bilgilerini getirecek
            string sorgu = "select * from hastabilgileri";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataHastaBilgi.DataSource = ds.Tables[0];
            dataHastaBilgi.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataHastaBilgi.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataHastaBilgi.DefaultCellStyle.ForeColor = Color.Cyan;
        }

        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            //aynı hasta bir daha kaydedilmesin
            string tckimlikNumarasi = txtTcNo.Text;
            baglanti.Open();
            string sorgu2 = "SELECT COUNT(*) FROM hastabilgileri WHERE tc_kimlik_numarasi = @tckimlikNumarasi";
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglanti);
            komut2.Parameters.AddWithValue("@tckimlikNumarasi", tckimlikNumarasi);

            int kayitSayisi = Convert.ToInt32(komut2.ExecuteScalar());
            baglanti.Close();
            if (kayitSayisi > 0)
            {
                MessageBox.Show("Bu hasta için kayıt zaten mevcut. Lütfen 'Kayıtlı Hasta Listesi' ekranından devam ediniz.", "Hasta Kaydı Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //yeni hasta kaydı oluşturacak.

            string sorgu = "INSERT INTO hastabilgileri (tc_kimlik_numarasi, isim, soyisim, dogum_yeri, dogum_tarihi, medeni_durumu, telefon_numarasi, cinsiyet) VALUES (@tcKimlikNo, @isim, @soyisim, @dogumYeri, @dogumTarihi, @medeniDurumu, @telefonNumarasi, @cinsiyet)";
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tcKimlikNo", txtTcNo.Text);
            komut.Parameters.AddWithValue("@isim", txtAd.Text);
            komut.Parameters.AddWithValue("@soyisim", txtSoyad.Text);
            komut.Parameters.AddWithValue("@dogumYeri", txtDogumYeri.Text);
            komut.Parameters.AddWithValue("@dogumTarihi", txtDogumTarihi.Text);
            komut.Parameters.AddWithValue("@medeniDurumu", cmbMedeni.Text);
            komut.Parameters.AddWithValue("@telefonNumarasi", txtTelefonNumarasi.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hasta bilgileri başarıyla kaydedildi. Listelemek için 'Listeyi Güncelle' butonuna basınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //*********************************HASTA KAYIT EKRANI SONU**********************************

        //*********************************//MUAYENE EKRANI//**********************************



        private void btnRaporKaydet_Click(object sender, EventArgs e)
        {
            string tckimlikNumarasi = txtHastaTc.Text;
            string muayeneTarihi = txtHastaMuayeneTarihi.Text;

            //günlük sınır
            string sorgu2 = "SELECT COUNT(*) FROM muayenebilgileri WHERE tc_kimliknumarasi = @tckimlikNumarasi AND muayene_tarihi = @muayeneTarihi";
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglanti);
            komut2.Parameters.AddWithValue("@tckimlikNumarasi", tckimlikNumarasi);
            komut2.Parameters.AddWithValue("@muayeneTarihi", muayeneTarihi);

            int kayitSayisi = Convert.ToInt32(komut2.ExecuteScalar());
            baglanti.Close();
            if (kayitSayisi > 0)
            {
                MessageBox.Show("Bu hasta için bu tarihte zaten bir muayene kaydı mevcut. Lütfen başka bir tarih seçiniz.", "Kayıt Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //reçetesiz muayene kaydı

            string sorgu = "INSERT INTO muayenebilgileri (tc_kimliknumarasi, muayene_tarihi, hasta_sikayeti, doktor_yorumu) VALUES (@tcKimlikNumarasi, @muayeneTarihi, @hastaSikayeti, @doktorYorumu)";
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tcKimlikNumarasi", txtHastaTc.Text);
            komut.Parameters.AddWithValue("@muayeneTarihi", txtHastaMuayeneTarihi.Text);
            komut.Parameters.AddWithValue("@hastaSikayeti", txtHastaSikayet.Text);
            komut.Parameters.AddWithValue("@doktorYorumu", txtUygulananTedavi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rapor başarıyla yazdırıldı. 'Rapor Sorgula' sayfasından kontrol edebilirsiniz.", "Rapor Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReceteRaporKaydet_Click(object sender, EventArgs e)
        {
            string tckimlikNumarasi = txtHastaTc.Text;
            string muayeneTarihi = txtHastaMuayeneTarihi.Text;

            //günlük sınır

            string sorgu2 = "SELECT COUNT(*) FROM muayenebilgileri WHERE tc_kimliknumarasi = @tckimlikNumarasi AND muayene_tarihi = @muayeneTarihi";
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglanti);
            komut2.Parameters.AddWithValue("@tckimlikNumarasi", tckimlikNumarasi);
            komut2.Parameters.AddWithValue("@muayeneTarihi", muayeneTarihi);

            int kayitSayisi = Convert.ToInt32(komut2.ExecuteScalar());
            baglanti.Close();

            if (kayitSayisi > 0)
            {
                MessageBox.Show("Bu hasta için bu tarihte zaten bir muayene kaydı mevcut. Lütfen başka bir hasta seçiniz.", "Kayıt Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //reçeteli muayene kaydı

            string sorgu = "INSERT INTO muayenebilgileri (tc_kimliknumarasi, muayene_tarihi, hasta_sikayeti, doktor_yorumu, recete_numarasi) VALUES (@tcKimlikNumarasi, @muayeneTarihi, @hastaSikayeti, @doktorYorumu, @receteNumarasi)";
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tcKimlikNumarasi", txtHastaTc.Text);
            komut.Parameters.AddWithValue("@muayeneTarihi", txtHastaMuayeneTarihi.Text);
            komut.Parameters.AddWithValue("@hastaSikayeti", txtHastaSikayet.Text);
            komut.Parameters.AddWithValue("@doktorYorumu", txtUygulananTedavi.Text);
            komut.Parameters.AddWithValue("@receteNumarasi", Convert.ToDecimal(txtReceteNumarasi.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Rapor başarıyla yazdırıldı. 'Rapor Sorgula' sayfasından kontrol edebilirsiniz.", "Rapor Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataRecete.Rows.Clear();
        }

        private void btnReceteOlustur_Click(object sender, EventArgs e)
        {
            //recete oluşturulacak

            Random rnd = new Random();
            int rastgele = rnd.Next(10000000, 20000000);
            txtReceteNumarasi.Text = rastgele.ToString();

            //günlük sınır
            string tckimlikNumarasi = txtHastaTc.Text;
            string receteTarihi = txtHastaMuayeneTarihi.Text;

            string sorgu2 = "SELECT COUNT(*) FROM receteler WHERE tckimlik_numarasi = @tckimlikNumarasi AND recete_tarihi = @receteTarihi";
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglanti);
            komut2.Parameters.AddWithValue("@tckimlikNumarasi", tckimlikNumarasi);
            komut2.Parameters.AddWithValue("@receteTarihi", receteTarihi);

            int kayitSayisi = Convert.ToInt32(komut2.ExecuteScalar());
            baglanti.Close();
            if (kayitSayisi > 0)
            {
                MessageBox.Show("Bu hasta için bu tarihte zaten bir reçete kaydı mevcut. Lütfen başka bir hasta seçiniz.", "Reçete Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            // Döngü içinde, datagridview'den her satırı alıp INSERT INTO sorgusunu çalıştırarak verileri ekleyin

            for (int i = 0; i + 1 < dataRecete.Rows.Count; i++)
            {
                DataGridViewRow satir = dataRecete.Rows[i];
                string tckimlik_numarasi = satir.Cells["tc_kimlik"].Value.ToString();
                string recete_tarihi = satir.Cells["recete_tarihi"].Value.ToString();
                string barkod_numarasi = satir.Cells["barkod_no"].Value.ToString();
                string kutu_adeti = satir.Cells["kutu_adeti"].Value.ToString();
                string recete_numarasi = satir.Cells["recete_no"].Value.ToString();

                string sorgu = "INSERT INTO receteler (tckimlik_numarasi, recete_tarihi, ilac_barkod_numarasi, kutu_adeti, recete_numarasi) VALUES (@tckimlik_numarasi, @recete_tarihi, @ilac_barkod_numarasi, @kutu_adeti, @recete_numarasi)";
                baglanti.Open();
                NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tckimlik_numarasi", tckimlik_numarasi);
                komut.Parameters.AddWithValue("@recete_tarihi", recete_tarihi);
                komut.Parameters.AddWithValue("@ilac_barkod_numarasi", barkod_numarasi);
                komut.Parameters.AddWithValue("@kutu_adeti", kutu_adeti);
                komut.Parameters.AddWithValue("@recete_numarasi", recete_numarasi);
                komut.ExecuteNonQuery();
                MessageBox.Show("Reçete başarıyla yazdırıldı. 'Reçete Sorgula' sayfasından kontrol edebilirsiniz.", "Reçete Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }

        }



        private void btnIlacBilgiGetir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from ilaclar where \"barkod_numarasi\" like '" + txtIlacBarkod.Text + "' ", baglanti);
            NpgsqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                txtIlacAdi.Text = reader[1].ToString();
                txtIlacTipi.Text = reader[2].ToString();

                if (reader[1] != null)
                {
                    txtIlacBarkod.Enabled = true;
                    txtIlacAdi.Enabled = true;
                    txtIlacTipi.Enabled = true;
                }
            }
            baglanti.Close();
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            if (dataRecete.Rows.Count > 5)
            {
                MessageBox.Show("Bir reçeteye en fazla 5 ilaç ekleyebilirsiniz!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string tcKimlik = txtHastaTc.Text;
            string receteTarihi = txtHastaMuayeneTarihi.Text;
            string ilacBarkod = txtIlacBarkod.Text;
            int ilacKutuAdeti = (int)numIlacSayi.Value;
            string receteNo = txtReceteNumarasi.Text;

            DataGridViewRow yeniSatir = new DataGridViewRow();
            yeniSatir.CreateCells(dataRecete);
            yeniSatir.Cells[0].Value = tcKimlik;
            yeniSatir.Cells[1].Value = receteTarihi;
            yeniSatir.Cells[2].Value = ilacBarkod;
            yeniSatir.Cells[3].Value = ilacKutuAdeti;
            yeniSatir.Cells[4].Value = receteNo;

            dataRecete.Rows.Add(yeniSatir);

        }

        private void btnIlacDataSil_Click(object sender, EventArgs e)
        {
            //datagridden ilaç sil.
            if (dataRecete.SelectedRows.Count > 0)
            {
                dataRecete.Rows.RemoveAt(dataRecete.SelectedRows[0].Index);
            }
        }
        //*********************************MUAYENE EKRANI SONU**********************************


        //*********************************//İLAÇ EKRANI//**********************************
        private void btnYeniIlac_Click(object sender, EventArgs e)
        {
            //aynı ilaç bir daha kaydedilmesin
            string barkodNumarasi = txtEkleBarkod.Text;
            string sorgu2 = "SELECT COUNT(*) FROM ilaclar WHERE barkod_numarasi = @barkodNumarasi";
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand(sorgu2, baglanti);
            komut2.Parameters.AddWithValue("@barkodNumarasi", barkodNumarasi);

            int kayitSayisi = Convert.ToInt32(komut2.ExecuteScalar());
            baglanti.Close();
            if (kayitSayisi > 0)
            {
                MessageBox.Show("Bu barkod numarası için kayıt zaten mevcut. Lütfen barkod numarasını kontrol ediniz.", "İlaç Kaydı Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            // Yeni ilaç bilgileri eklenecek
           
            string sorgu = "INSERT INTO ilaclar (barkod_numarasi, ilac_adi, ilac_tipi) VALUES (@barkodNumarasi, @ilacAdi, @ilacTipi)";
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@barkodNumarasi", txtEkleBarkod.Text);
            komut.Parameters.AddWithValue("@ilacAdi", txtEkleIlacAd.Text);
            komut.Parameters.AddWithValue("@ilacTipi", cmbEkleIlacTip.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç bilgileri başarıyla kaydedildi. Listelemek için 'Listeyi Güncelle' butonuna basınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListeIlacGuncelle_Click(object sender, EventArgs e)
        {
            //DataGrid'e ilaçların bilgilerini getirecek
            string sorgu = "select * from ilaclar";
            baglanti.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataIlac.DataSource = ds.Tables[0];
            dataIlac.BackgroundColor = Color.FromArgb(0, 122, 146);
            dataIlac.DefaultCellStyle.BackColor = Color.FromArgb(0, 122, 146);
            dataIlac.DefaultCellStyle.ForeColor = Color.Cyan;
            baglanti.Close();
        }

        private void btnIlacBilgiAktar_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select * from ilaclar where \"barkod_numarasi\" like '" + txtIlacBilgiAktar.Text + "' ", baglanti);
            NpgsqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                txtGuncelleBarkod.Text = reader[0].ToString();
                txtGuncelleIlacAdi.Text = reader[1].ToString();
                cmbGuncelleIlacTipi.Text = reader[2].ToString();

                if (reader[0] != null)
                {
                    txtGuncelleBarkod.Enabled = true;
                    txtGuncelleIlacAdi.Enabled = true;
                    cmbGuncelleIlacTipi.Enabled = true;
                    MessageBox.Show("İlaç bilgileri başarıyla aktarıldı. 'İlaç Güncelle | Sil' ekranından işlemlerinize devam edebilirsiniz.", "Aktarma Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            baglanti.Close();
        }

        private void btbnIlacGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("UPDATE ilaclar SET  ilac_adi=@ilacAdi, ilac_tipi=@ilacTipi WHERE barkod_numarasi=@barkodNumarasi", baglanti);
            komut.Parameters.AddWithValue("@ilacAdi", txtGuncelleIlacAdi.Text);
            komut.Parameters.AddWithValue("@ilacTipi", cmbGuncelleIlacTipi.Text);
            komut.Parameters.AddWithValue("@barkodNumarasi", txtGuncelleBarkod.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç bilgileri başarıyla güncellendi.", "Güncelleme Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIlacSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand("Delete FROM ilaclar WHERE barkod_numarasi =@barkodNumarasi", baglanti);
            komut.Parameters.AddWithValue("@barkodNumarasi", txtGuncelleBarkod.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İlaç kaydı silme işlemi başarıyla gerçekleşti. 'LİSTELE GÜNCELLE' butonuna basarak kontrol edebilirsiniz.", "Silme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //*********************************İLAÇ EKRANI SONU**********************************
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuMuayeneListele_Click(object sender, EventArgs e)
        {
            frmMuayeneKayitlari frm = new frmMuayeneKayitlari();
            frm.Show();
            this.Hide();
        }
        private void menuReceteListele_Click(object sender, EventArgs e)
        {
            frmReceteEkrani frm = new frmReceteEkrani();
            frm.Show();
            this.Hide();
        }
    }

}

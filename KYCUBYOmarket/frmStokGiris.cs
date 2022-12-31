using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KYCUBYOmarket
{
    public partial class frmStokGiris : Form
    {
        public frmStokGiris()
        {
            InitializeComponent();
        }
        
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=verıtabanı.accdb");
        int urunsatis, urunalis, urunadet, kritikstok,ürünKdv;                   
        private void btnUrunleriGoster_Click(object sender, EventArgs e)
        {
            frmguncelle urunler = new frmguncelle();
            urunler.Show();
            this.Hide();
        }
        VeriTabanı vt = new VeriTabanı();
        private void butonKaydet_Click(object sender, EventArgs e)
        {
            if (Ürünadı.Text == "" || satışfiyati.Text == "" || Barkodno.Text == "" || alisfiyatı.Text == "" || ÜrünAdet.Text == "" || txtAcıklama.Text == "")
            {
                MessageBox.Show("Bilgileri Eksik Girdiniz", "Uyarı");
            }
            else
            {
                string barkodno = Barkodno.Text;
                string ürünadı = Ürünadı.Text;
                string ürünGrubu = cmbÜrüngrubu.Text;
                ürünKdv = Convert.ToInt16(cmkdv.Text);
                urunadet = Convert.ToInt16(ÜrünAdet.Text);
                urunalis = Convert.ToInt16(alisfiyatı.Text);
                urunsatis = Convert.ToInt16(satışfiyati.Text);
                kritikstok = Convert.ToInt16(kritik.Text);
                string TarihSaat = dateTimePicker2.Text;
                string acıklama = txtAcıklama.Text;

                string komut = "SELECT* FROM ÜrünBilgi WHERE barkodno='" + barkodno + "'";//barkoda göre aynı ürün olup olmadığı.
                OleDbCommand kmd = new OleDbCommand(komut, baglantı);
                baglantı.Open();
                OleDbDataReader dr = kmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bu Ürün Zaten Kayıtlı", "Bilgilendirme");
                    baglantı.Close();
                }

                else
                {
                    baglantı.Close();
                    string kayıtEkle = "INSERT INTO ÜrünBilgi (barkodno,ürünAdı,ürünAdet,alisFiyatı,satisFiyatı,kritikStok,ürünGrubu,ürünKdv,ürünhakında,ürünSatısTarihi,Kullanıcı) VALUES ('" + barkodno + "','" + ürünadı + "','" + urunadet + "','" + urunalis + "','" + urunsatis + "','" + kritikstok + "','" + ürünGrubu + "','" + ürünKdv + "','" + acıklama + "','" + TarihSaat + "','" + frmGırıs.kullaniciad + "')";
                    //OleDbCommand komut2= new OleDbCommand(kayıtEkle, baglantı);
                    vt.komutcalistirici(kayıtEkle);
               
                    MessageBox.Show("Ürün eklenmiştir.", "Uyarı");
                    foreach (Control x in this.Controls)
                    {
                        if (x is TextBox) x.Text="";
                    }
                   
                }
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ÜrünAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void cmkdv_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void alisfiyatı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void satışfiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void kritik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmStokGiris_Load(object sender, EventArgs e)
        {
            int stokgörmeyetki = 0;
            int ekleme = 0;
            string komut = "SELECT * FROM Yetkiler WHERE id =" + frmGırıs.kullaniciyetki_no;

            stokgörmeyetki = vt.yetki("stokGörme", komut);
            ekleme = vt.yetki("ekleme", komut);

            if (stokgörmeyetki == 0)
            {
                btnUrunGoster.Enabled = false;
            }
            if (ekleme==0)
            {
                butonKaydet.Enabled = false;
            }
            baglantı.Open();
            OleDbCommand kmt = new OleDbCommand("SELECT grup FROM ÜrünGrubu", baglantı);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                cmbÜrüngrubu.Items.Add(oku["grup"]);
            }
            baglantı.Close();
            baglantı.Open();
            OleDbCommand kmt1 = new OleDbCommand("SELECT kdv FROM ÜrünKdv", baglantı);
            OleDbDataReader oku1 = kmt1.ExecuteReader();
            while (oku1.Read())
            {
                cmkdv.Items.Add(oku1["kdv"].ToString());

            }
            baglantı.Close();
        }

        private void Barkodno_TextChanged(object sender, EventArgs e)
        {
            Barkodno.Text = Barkodno.Text.ToUpper();
            Barkodno.SelectionStart = Barkodno.Text.Length;
        }
    }
}

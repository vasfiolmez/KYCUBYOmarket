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
    public partial class frmStokGuncelleme : Form
    {
        public frmStokGuncelleme()
        {
            InitializeComponent();
        }
            OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=verıtabanı.accdb");
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            string komut = "UPDATE ÜrünBilgi Set ürünAdı=@ürünadı,ürünAdet=@ürünadet,alisFiyatı=@alışfiyatı,satisFiyatı=@satışfiyatı,kritikStok=@kritikstok,ürünGrubu=@ürüngrup,ÜrünKdv=@ürünkdv,ürünhakında=@ürünacıklama,ürünSatısTarihi=@ürünSatısTarihi Where barkodno=@barkodno";
            OleDbCommand kmt = new OleDbCommand(komut,baglantı);
            kmt.Parameters.AddWithValue("@ürünadı",txtUrunAdi.Text);
            kmt.Parameters.AddWithValue("@ürünadet",txtUrunAdet.Text);
            kmt.Parameters.AddWithValue("@alışfiyatı",Convert.ToInt16(txtAlis.Text));
            kmt.Parameters.AddWithValue("@satışfiyatı",Convert.ToInt16(txtSatiş.Text));
            kmt.Parameters.AddWithValue("@kritikstok",Convert.ToInt16(txtKritikStok.Text));
            kmt.Parameters.AddWithValue("@ürüngrup",cmbUrunGrup.Text);
            kmt.Parameters.AddWithValue("@ürünkdv",Convert.ToInt16(cmbKdv.Text));
            kmt.Parameters.AddWithValue("@ürünacıklama",txtAcıklama.Text);
            kmt.Parameters.AddWithValue("@ürünSatısTarihi", dateTimePicker1.Text);
            kmt.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            kmt.ExecuteNonQuery();
            baglantı.Close();
            guncellesil.griddoldur();
            MessageBox.Show("ürün güncellendi");          
        }

        private void frmStokGuncelleme_FormClosed(object sender, FormClosedEventArgs e)
        {
            

        }
      
        private void frmStokGuncelleme_Load(object sender, EventArgs e)
        {
             baglantı.Open();
            OleDbCommand kmt = new OleDbCommand("SELECT grup FROM ÜrünGrubu",baglantı);
           OleDbDataReader oku= kmt.ExecuteReader();
            while(oku.Read())
            {
                cmbUrunGrup.Items.Add(oku["grup"]);                
            }
            baglantı.Close();
            baglantı.Open();
            OleDbCommand kmt1 = new OleDbCommand("SELECT kdv FROM ÜrünKdv",baglantı);
            OleDbDataReader oku1 = kmt1.ExecuteReader();
            while (oku1.Read())
            {

                cmbKdv.Items.Add(oku1["kdv"]);

            }
            baglantı.Close();

           

      }
        frmguncelle guncellesil = (frmguncelle)System.Windows.Forms.Application.OpenForms["frmguncelle"];

        private void btnSil_Click(object sender, EventArgs e)
        {
            VeriTabanı DB = new VeriTabanı();
            //int ytkSilme = 0;
            //string komut = "SELECT * FROM Yetkiler WHERE Yetki_no =" + frmGırıs.kullaniciyetki_no;
            //ytkSilme = DB.yetki("silme", komut);
            //if (ytkSilme == 0)
            //{
            //    btnSil.Enabled = false;
            //}

            //ürünsil
            string silkomut = "DELETE FROM ÜrünBilgi WHERE barkodno='" + txtBarkodNo.Text+"'";
            DB.komutcalistirici(silkomut);
            guncellesil.griddoldur();
            MessageBox.Show("Kayıt Silindi");
            this.Hide();
        }

        private void txtUrunAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

 
    }
}

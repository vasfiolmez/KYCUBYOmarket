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
    public partial class frmYetkiAta : Form
    {
        public frmYetkiAta()
        {
            InitializeComponent();
        }


        private void frmYetkiAta_Load(object sender, EventArgs e)
        {
            tctK_ad.Enabled = false;
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            VeriTabanı vb = new VeriTabanı();
            int stokekleme = 0, stoksilme = 0, stokgorme = 0, kul_ekleme = 0, kul_silme = 0, satis = 0, stok_guncelleme = 0;

            if(Stok_ekleme.Checked== true)stokekleme=1;
            if(kullanıcıekleme.Checked==true)kul_ekleme=1;
            if(kullanıcısil.Checked==true)kul_silme=1;
            if(stoksil.Checked==true)stoksilme=1;
            if (stokgörme.Checked == true) stokgorme = 1;
            if(satis_.Checked==true)satis=1;
            if (stokgüncelleme.Checked == true) stok_guncelleme = 1;

            string komut = "UPDATE Yetkiler SET ekleme=" + stokekleme + ",silme=" + stoksilme + ",güncelleme=" + stok_guncelleme + ",kullanıcıEkle=" + kul_ekleme + ",kullanıcıSil=" + kul_silme + ",stokGörme=" + stokgorme + ",satis=" + satis + " WHERE id=" +frmGırıs.kullaniciyetki_no + "";
            vb.komutcalistirici(komut);
            MessageBox.Show("Yetkilendirme işlemi tamamlandı.","Bilgilendirme");

        }
    }
}

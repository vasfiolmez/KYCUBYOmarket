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
    public partial class frmSifreGuncelleme : Form
    {
        public frmSifreGuncelleme()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            int onay = Convert.ToInt32(tb_onay.Text);

            if (tb_sifre.Text !=tb_sifretekrar.Text)
            {
                MessageBox.Show("girdiğiniz şifreler birbiriyle aynı değil lütfen kontrol ediniz.","HATA");
            }
            
           else if (tb_sifre.Text==tb_sifretekrar.Text &&frmSıfreOnayKodu.sayı == onay)
            {

            baglantı.Open();
            string yenisifre = "UPDATE KullanıcıBilgileri SET k_sifre='" + tb_sifre.Text + "' WHERE e_mail='" + frmSıfreOnayKodu.mail + "'";
            OleDbCommand kmt = new OleDbCommand(yenisifre,baglantı);
            kmt.ExecuteNonQuery();
            baglantı.Close();

            MessageBox.Show("Şifreniz başarılı bir şekilde yenilenmiştir.","BİLGİLENDİRME");

            frmGırıs gırıs = new frmGırıs();
            gırıs.Show();
            this.Hide();
            }

            
            
              

            

        }

      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KYCUBYOmarket
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void pictureKasa_Click(object sender, EventArgs e)
        {
            frmKasa kasa = new frmKasa();
            kasa.Show();
            this.Hide();
        }

        private void pictureUrun_ekle_Click(object sender, EventArgs e)
        {
            frmStokGiris stokekle = new frmStokGiris();
            stokekle.ShowDialog();
        }

        private void pictureBoxGuncelleme_Click(object sender, EventArgs e)
        {
            frmguncelle guncel = new frmguncelle();
            guncel.ShowDialog() ;
           
        }

        private void pictureİstatistik_Click(object sender, EventArgs e)
        {
            Bilanco bilanco = new Bilanco();
            bilanco.ShowDialog();
        }

        private void pictureAzalan_urunler_Click(object sender, EventArgs e)
        {
            frmİstek azalan = new frmİstek();
            azalan.ShowDialog();
            
            
        }

        private void adminpaneli_Click(object sender, EventArgs e)
        {
            frmAnaKullanıcı adminpaneli = new frmAnaKullanıcı();
            adminpaneli.ShowDialog();
        }

        private void pictureAyarlar_Click(object sender, EventArgs e)
        {
            frmAyarlar ayarlar = new frmAyarlar();
            ayarlar.ShowDialog();
        }

        private void pctrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
  int ytkEkleme, ytkKekleme, ytkKsilme,ytkSatis;//ytkSilme
            public static int ytkVeriGörme ;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        VeriTabanı yetkikontrol = new VeriTabanı();
        private void menu_Load(object sender, EventArgs e)
        {
            string komut = "SELECT * FROM Yetkiler WHERE id =" + frmGırıs.kullaniciyetki_no;
           
            ytkEkleme = yetkikontrol.yetki("ekleme", komut);
            //ytkSilme = yetkikontrol.yetki("Silme",komut);
            ytkKekleme = yetkikontrol.yetki("kullanıcıEkle", komut);
            ytkKsilme = yetkikontrol.yetki("kullanıcıSil", komut);
            ytkVeriGörme = yetkikontrol.yetki("stokgörme", komut);
            ytkSatis = yetkikontrol.yetki("satis", komut);
            if (ytkEkleme == 0) { pictureUrun_ekle.Enabled = false; }
            if (ytkSatis == 0) { pictureKasa.Enabled = false; }
            if (ytkVeriGörme == 0) { pictureİstatistik.Enabled = false; pictureAzalan_urunler.Enabled = false; }
            if (ytkKekleme == 0) { adminpaneli.Enabled = false; }
            if (ytkKsilme == 0) { adminpaneli.Enabled = false; }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmYArdım yardım = new frmYArdım();
            yardım.ShowDialog();
        }
    }
}

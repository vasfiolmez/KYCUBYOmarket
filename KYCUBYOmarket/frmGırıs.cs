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
using System.IO;


namespace KYCUBYOmarket
{
    public partial class frmGırıs : Form
    {
        public frmGırıs()
        {
            InitializeComponent();
        }

        private void pctrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");

        public static string kullaniciad; 
        public static int kullaniciyetki_no;
        private void btnGırıs_Click(object sender, EventArgs e)
        {

            kullaniciad = tbKullanıcıAd.Text;
            try
            {
                if (tbKullanıcıAd.Text == "" && tbKsıfre.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Alanları Doldurunuz");
                }
                else if (tbKullanıcıAd.Text == "")
                {
                    MessageBox.Show("Lütfen Kullanıcı Ad Girişini Boş bırakmayın");
                }
                else if (tbKsıfre.Text == "")
                {
                    MessageBox.Show("Lütfen Şifre Girişini Boş bırakmayın");
                }
                else
                {
                    string sorgu = "SELECT * FROM KullanıcıBilgileri where k_adi='" + tbKullanıcıAd.Text + "' AND k_sifre='" + tbKsıfre.Text + "'";
                    baglantı.Open();
                    OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
                    OleDbDataReader okuyucu = komut.ExecuteReader();
                    
                        if (okuyucu.Read())
                        {
                               kullaniciyetki_no=Convert.ToInt16(okuyucu["kullanıcı_no"]);

                                frmSplashEkranı splash = new frmSplashEkranı();
                                splash.Show();
                                this.Hide();
                                // frmAnaYonetici anaform = new frmAnaYonetici();
                                //anaform.Show();
                                //this.Hide();                                                    
                        }
                    
                    else
                    {
                        baglantı.Close();
                        MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch // bağlantı yoksa..
            {
                MessageBox.Show("Veri Tabanına ulaşılamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
	
        }      
        private void label1_Click(object sender, EventArgs e)
        {
            frmSıfreOnayKodu onay = new frmSıfreOnayKodu();
            onay.Show();
            this.Hide();
        }

        private void frmGırıs_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

       
    }


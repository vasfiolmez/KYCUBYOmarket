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
    public partial class frmAyarlar : Form
    {        
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");

        public frmAyarlar()
        {
            InitializeComponent();
        }   
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();            
        }

        //private void tbAdSoyad_Click(object sender, EventArgs e)
        //{
        //    tbAdSoyad.Clear();
        //}

        //private void tbK_Ad_Click(object sender, EventArgs e)
        //{
        //    tbK_Ad.Clear();
        //}

        //private void tb_email_Click(object sender, EventArgs e)
        //{
        //    tb_email.Clear();
        //}

        //private void tb_sifre_Click(object sender, EventArgs e)
        //{
        //    tb_sifre.Clear();
        //}

        //private void tb_sifretekrar_Click(object sender, EventArgs e)
        //{
        //    tb_sifretekrar.Clear();
        //}
 //       private void frmKayıt_Click(object sender, EventArgs e)
 //       {
 ////           VeriTabanı vt = new VeriTabanı();
 ////           string kaydet;

 ////           if (tb_sifre.Text == tb_sifretekrar.Text) sifre = tb_sifre.Text;
 ////           else if (tb_sifre.Text == "" || tb_sifretekrar.Text == "")
 ////           {
 ////               MessageBox.Show("Sifre Alanlarini Doldurunuz");

 ////           }
 ////           else if (tb_sifre.Text != tb_sifretekrar.Text)
 ////           {
 ////               MessageBox.Show("Sifreler Birbiri İle Aynı Olmalıdır", "Uyarı");
 ////           }
 ////int yetkinumarası;

 ////if (tb_sifre.Text == tb_sifretekrar.Text && tb_sifre.Text != "" && tb_sifretekrar.Text != "")
 ////{
 ////    string kmtkntrl = "SELECT* FROM KullanıcıBilgileri WHERE k_adi='" + tbK_Ad.Text + "'";
 ////    OleDbCommand kmd = new OleDbCommand(kmtkntrl, baglantı);
 ////    baglantı.Open();
 ////    OleDbDataReader dr = kmd.ExecuteReader();
 ////    if (dr.Read())
 ////    {
 ////        MessageBox.Show("Bu Kullanici Adında Zaten Kayıtlı Birisi Var.", "Bilgilendirme");
 ////        baglantı.Close();
 ////    }
 ////    else
 ////    {
 ////        kaydet = "INSERT INTO KullanıcıBilgileri (k_adi,k_sifre,adi_soyadi,e_mail) VALUES ('" + tbK_Ad.Text + "','" + tb_sifre.Text + "','" + tbAdSoyad.Text + "','" + tb_email.Text + "')";
 ////        vt.komutcalistirici(kaydet);

 ////        string komut = "SELECT * FROM KullanıcıBilgileri WHERE k_adi='" + tbK_Ad.Text + "'";
 ////        yetkinumarası = vt.yetki("kullanıcı_no", komut);

 ////        string kaydetyetki = "INSERT INTO Yetkiler(id,ekleme,silme,güncelleme,kullanıcıEkle,kullanıcıSil,stokGörme,satis)VALUES(" + yetkinumarası + ",0,0,0,0,0,0,0)";
 ////        vt.komutcalistirici(kaydetyetki);
 ////        MessageBox.Show("Kayıt başarıyla gerçekleşti.");
 ////        foreach (Control x in Controls)
 ////        {
 ////            if (x is TextBox) x.Text = null;
 ////        }
 ////    }

 ////}
            
 //       }
        //void goster()
        //{
        //    baglantı.Open();
        //    OleDbCommand komut = new OleDbCommand("SELECT kullanıcı_no,k_adi,adi_soyadi,e_mail FROM KullanıcıBilgileri", baglantı);
        //    OleDbDataAdapter data = new OleDbDataAdapter(komut);
        //    DataSet dt = new DataSet();
        //    data.Fill(dt);
        //    dataGridView1.DataSource = dt.Tables[0];
        //    baglantı.Close();
        //    textBox1.Text = "";
        //}

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            //goster();
            textBox3.Text = frmGırıs.kullaniciad;
            textBox3.Enabled = false;
            listBox3.Items.Clear();
            baglantı.Open();
            OleDbCommand kmt = new OleDbCommand("SELECT grup FROM ÜrünGrubu", baglantı);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
               listBox3.Items.Add(oku["grup"]);
            }
            baglantı.Close();
            baglantı.Open();
            OleDbCommand kmt1 = new OleDbCommand("SELECT kdv FROM ÜrünKdv", baglantı);
            OleDbDataReader oku1 = kmt1.ExecuteReader();
            while (oku1.Read())
            {
               listBox2.Items.Add(oku1["kdv"].ToString());

            }
            baglantı.Close();                            
        }
       
        private void btnUrunkdvEkle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            string BırımEkle = "INSERT INTO ÜrünKdv (kdv) VALUES ('" +Convert.ToInt16(tbKdv.Text)+ "')";
            OleDbCommand komut = new OleDbCommand(BırımEkle, baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            listBox2.Items.Clear();
            baglantı.Open();
            OleDbCommand kmt1 = new OleDbCommand("SELECT kdv FROM ÜrünKdv", baglantı);
            OleDbDataReader oku1 = kmt1.ExecuteReader();
            while (oku1.Read())
            {
                listBox2.Items.Add(oku1["kdv"].ToString());

            }
            baglantı.Close();
            MessageBox.Show("Ürün KDV oranı eklenmiştir.");
            tbKdv.Clear();
        }

        private void btnUrunGrupEkle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            string BırımEkle = "INSERT INTO ÜrünGrubu (grup) VALUES ('" + tbGrup.Text + "')";
            OleDbCommand komut = new OleDbCommand(BırımEkle, baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            listBox3.Items.Clear();
            baglantı.Open();
            OleDbCommand kmt = new OleDbCommand("SELECT grup FROM ÜrünGrubu", baglantı);
            OleDbDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                listBox3.Items.Add(oku["grup"]);
            }
            baglantı.Close();
            MessageBox.Show("Ürün grup ismi eklenmiştir.");
            tbGrup.Clear();
        }
        private void btnUrunKdvSİl_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand kmt = new OleDbCommand("Delete * from ÜrünKdv where kdv=@kdv", baglantı);
            kmt.Parameters.AddWithValue("@kdv", listBox2.SelectedItem.ToString());
            kmt.ExecuteNonQuery();
            baglantı.Close();
            listBox2.Items.Clear();
            baglantı.Open();
            OleDbCommand kmt1 = new OleDbCommand("SELECT kdv FROM ÜrünKdv", baglantı);
            OleDbDataReader oku1 = kmt1.ExecuteReader();
            while (oku1.Read())
            {
                listBox2.Items.Add(oku1["kdv"].ToString());

            }
            baglantı.Close();
            MessageBox.Show("Ürün KDV oranı silinmiştir.");
        }
        private void btnUrunGrupSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            OleDbCommand kmt = new OleDbCommand("Delete * from ÜrünGrubu where grup = @grup", baglantı);
            kmt.Parameters.AddWithValue("@grup", listBox3.SelectedItem.ToString());
            kmt.ExecuteNonQuery();
            baglantı.Close();
            listBox3.Items.Clear();
            baglantı.Open();
            OleDbCommand kmt1 = new OleDbCommand("SELECT grup FROM ÜrünGrubu", baglantı);
            OleDbDataReader oku = kmt1.ExecuteReader();
            while (oku.Read())
            {
                listBox3.Items.Add(oku["grup"]);
            }
            baglantı.Close();
            MessageBox.Show("ürün grup ismi silinmiştir.");
        }

        private void tabK_sil_Click(object sender, EventArgs e)
        {
            //goster();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        VeriTabanı DB = new VeriTabanı();

        private void btnkullanıcıSil_Click(object sender, EventArgs e)
        {
            //string silkomut = "DELETE FROM KullanıcıBilgileri WHERE k_adi='" + textBox1.Text + "'";
            //DB.komutcalistirici(silkomut);
            //MessageBox.Show("Kullanıcı başarıyla silinmiştir");
            //goster();         
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
             string kullanıcıadı=textBox3.Text;
             string mevcutşifre=textBox2.Text;
            
             
            //kullanıcı adı ve şifre değiştirme

             OleDbCommand komut = new OleDbCommand("SELECT k_adi,k_sifre FROM KullanıcıBilgileri WHERE k_adi=@kullanıcı",baglantı);
             komut.Parameters.AddWithValue("@kullanıcı", kullanıcıadı);
             baglantı.Open();
             OleDbDataReader dr = komut.ExecuteReader();
             while (dr.Read())
             {
                 string Kullanici = (dr["k_adi"].ToString());
                 string Sifre = (dr["k_sifre"].ToString());

                 if (kullanıcıadı == Kullanici && mevcutşifre == Sifre)
                 {
                     OleDbCommand kmt = new OleDbCommand("UPDATE KullanıcıBilgileri Set k_adi=@kuldegistir,k_sifre=@sifdegistir Where k_adi=@kul And k_sifre=@kulsif", baglantı);
                     kmt.Parameters.AddWithValue("@kuldegistir", textBox2.Text);
                     kmt.Parameters.AddWithValue("@sifdegistir", textBox7.Text);
                     kmt.Parameters.AddWithValue("@kul", textBox3.Text);
                     kmt.Parameters.AddWithValue("@kulsif", textBox2.Text);
                     kmt.ExecuteNonQuery();
                     MessageBox.Show("bilgileriniz değişti");
                 }
                 else
                 {
                     MessageBox.Show("Mevcut bilgilerin yanlış");
                     baglantı.Close();
                 }
             }
        }
      
    }
}

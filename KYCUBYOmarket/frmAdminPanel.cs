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
    public partial class frmAnaKullanıcı : Form
    {
        public frmAnaKullanıcı()
        {
            InitializeComponent();
        }

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");


      
         public static int seçilenkullanıcıno;
         private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
         {
             frmYetkiAta yetki = new frmYetkiAta();
             yetki.tctK_ad.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();//adsoyad    
             seçilenkullanıcıno = Convert.ToInt16(dataGridView1.CurrentRow.Cells["kullanıcı_no"].Value.ToString()); 
             yetki.ShowDialog();
         }

         private void frmAnaKullanıcı_Load(object sender, EventArgs e)
         {
             goster();
             goster2();
         }
         void goster()
         {
             baglantı.Open();
             OleDbCommand komut = new OleDbCommand("SELECT kullanıcı_no,k_adi,adi_soyadi,e_mail FROM KullanıcıBilgileri", baglantı);
             OleDbDataAdapter data = new OleDbDataAdapter(komut);
             DataSet dt = new DataSet();
             data.Fill(dt);
             dataGridView1.DataSource = dt.Tables[0];
             baglantı.Close();
           
         }
         void goster2()
         {
             baglantı.Open();
             OleDbCommand komut = new OleDbCommand("SELECT kullanıcı_no,k_adi,adi_soyadi,e_mail FROM KullanıcıBilgileri", baglantı);
             OleDbDataAdapter data = new OleDbDataAdapter(komut);
             DataSet dt = new DataSet();
             data.Fill(dt);
             dataGridView2.DataSource = dt.Tables[0];
             baglantı.Close();
             textBox5.Text = "";
         }
         VeriTabanı DB = new VeriTabanı();
         private void btnkullanıcıSil_Click(object sender, EventArgs e)
         {
             string silkomut = "DELETE FROM KullanıcıBilgileri WHERE k_adi='" + textBox5.Text + "'";
             DB.komutcalistirici(silkomut);
             MessageBox.Show("Kullanıcı başarıyla silinmiştir");
             goster2();
         }
         string sifre;
         private void textBox1_Click(object sender, EventArgs e)
         {
         }

         private void textBox3_Click(object sender, EventArgs e)
         {
            
         }

         private void textBox2_Click(object sender, EventArgs e)
         {
         }

         private void textBox6_Click(object sender, EventArgs e)
         {
             
         }

         private void textBox4_Click(object sender, EventArgs e)
         {
             
         }

         private void tbAdSoyad_Click(object sender, EventArgs e)
         {
            
         }

         private void tbK_Ad_Click(object sender, EventArgs e)
         {
             tbK_Ad.Clear();
         }

         private void tb_email_Click(object sender, EventArgs e)
         {
             tb_email.Clear();
         }

         private void tb_sifre_Click(object sender, EventArgs e)
         {
             tb_sifre.Clear();
         }

         private void tb_sifretekrar_Click(object sender, EventArgs e)
         {
             tb_sifretekrar.Clear();
         }

         private void btnKayıtOl_Click(object sender, EventArgs e)
         {
             VeriTabanı vt = new VeriTabanı();
             string kaydet;

             if (tb_sifre.Text == tb_sifretekrar.Text) sifre = tb_sifre.Text;
             else if (tb_sifre.Text == "" || tb_sifretekrar.Text == "")
             {
                 MessageBox.Show("Sifre Alanlarini Doldurunuz");

             }
             else if (tb_sifre.Text != tb_sifretekrar.Text)
             {
                 MessageBox.Show("Sifreler Birbiri İle Aynı Olmalıdır", "Uyarı");
             }
             int yetkinumarası;

             if (tb_sifre.Text == tb_sifretekrar.Text && tb_sifre.Text != "" && tb_sifretekrar.Text != "")
             {
                 string kmtkntrl = "SELECT* FROM KullanıcıBilgileri WHERE k_adi='" + tbK_Ad.Text + "'";
                 OleDbCommand kmd = new OleDbCommand(kmtkntrl, baglantı);
                 baglantı.Open();
                 OleDbDataReader dr = kmd.ExecuteReader();
                 if (dr.Read())
                 {
                     MessageBox.Show("Bu Kullanici Adında Zaten Kayıtlı Birisi Var.", "Bilgilendirme");
                     baglantı.Close();
                 }
                 else
                 {
                     kaydet = "INSERT INTO KullanıcıBilgileri (k_adi,k_sifre,adi_soyadi,e_mail) VALUES ('" + tbK_Ad.Text + "','" + tb_sifre.Text + "','" + tbAdSoyad.Text + "','" + tb_email.Text + "')";
                     vt.komutcalistirici(kaydet);

                     string komut = "SELECT * FROM KullanıcıBilgileri WHERE k_adi='" + tbK_Ad.Text + "'";
                     yetkinumarası = vt.yetki("kullanıcı_no", komut);

                     //string kaydetyetki = "INSERT INTO Yetkiler(id,ekleme,silme,güncelleme,kullanıcıEkle,kullanıcıSil,stokGörme,satis)VALUES(" + yetkinumarası + ",0,0,0,0,0,0,0)";
                     //vt.komutcalistirici(kaydetyetki);
                     MessageBox.Show("Kayıt başarıyla gerçekleşti.");
                     tbAdSoyad.Clear();
                     tbK_Ad.Clear();
                     tb_email.Clear();
                     tb_sifre.Clear();
                     tb_sifretekrar.Clear();

                 }

             }

         }
       
         private void btn_degistir_Click(object sender, EventArgs e)
         {
             
             string kullanıcıadı=textBox3.Text;
             string mevcutşifre=textBox1.Text;
            
             

             OleDbCommand komut = new OleDbCommand("SELECT k_adi,k_sifre FROM KullanıcıBilgileri WHERE k_adi=@kullanıcı",baglantı);
             komut.Parameters.AddWithValue("@kullanıcı", kullanıcıadı);
             baglantı.Open();
             OleDbDataReader dr = komut.ExecuteReader();
             while (dr.Read())
             {
                 string Kullanici = (dr["k_adi"].ToString());
                 string Sifre = (dr["k_sifre"].ToString());

                 if (kullanıcıadı==Kullanici && mevcutşifre==Sifre)
                 {
                     OleDbCommand kmt = new OleDbCommand("UPDATE KullanıcıBilgileri Set k_adi=@kuldegistir,k_sifre=@sifdegistir Where k_adi=@kul And k_sifre=@kulsif",baglantı);
                     kmt.Parameters.AddWithValue("@kuldegistir", textBox2.Text);
                     kmt.Parameters.AddWithValue("@sifdegistir", textBox7.Text);
                     kmt.Parameters.AddWithValue("@kul", textBox3.Text);
                     kmt.Parameters.AddWithValue("@kulsif", textBox1.Text);
                     kmt.ExecuteNonQuery();
                     MessageBox.Show("bilgileriniz değişti");
                 }
                 else { MessageBox.Show("Mevcut bilgilerin yanlış");
                 baglantı.Close();
                 }

             }
         }

         private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             textBox5.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();

         }
      
        
    }
}

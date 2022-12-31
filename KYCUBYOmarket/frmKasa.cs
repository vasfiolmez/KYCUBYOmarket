using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;


namespace KYCUBYOmarket
{
    public partial class frmKasa : Form
    {
        public frmKasa()
        {          
            InitializeComponent();           
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }
        
        private void frmKasa_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.Columns[0].Name = "Ürün Barkod Numarası";
            dataGridView1.Columns[1].Name = "Ürün Adı";
            dataGridView1.Columns[2].Name = "Ürün Fiyatı";
            dataGridView1.Columns[3].Name = "Ürün Açıklama";
            dataGridView1.Columns[4].Name = "Ürün Adeti";
            dataGridView1.Columns[5].Name = "Kasiyer İsmi";
        }

        private void frmKasa_KeyDown(object sender, KeyEventArgs e)
        {
            
        }       
        VeriTabanı vt=new VeriTabanı();
        private void txtBarkodNo_KeyDown(object sender, KeyEventArgs e)
        {
           

            if (e.KeyCode == Keys.Enter)
            {
             // vt.data("SELECT * FROM ÜrünBilgi WHERE barkodno='" + txtBarkodNo.Text + "'", dataGridView1, "barkodno", "ürünAdı", "satisFiyatı", "ürünGrubu", adett,frmGırıs.kullaniciad,label2);
            // txtBarkodNo.Text = string.Empty;              
            }
        }
        double satıs = 0.0;
        int adt = 0;
        private void btnUruncıkart_Click(object sender, EventArgs e)
        {
            try
            {
                adt= Convert.ToInt16(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                satıs = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value.ToString());

                GÜNCELPARA -= adt * satıs;
                label2.Text = GÜNCELPARA.ToString() + " ₺";
                
                foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
                {
                    dataGridView1.Rows.Remove(drow);
                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "NP stok TAkip");
            }
            //vt.toplam -= Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            //label2.Text = vt.toplam.ToString() + " ₺";
            //foreach (DataGridViewCell secilibul in dataGridView1.SelectedCells)//seçili ürünü çıkart.
            //{
            //    if (secilibul.Selected)
            //    {
            //        dataGridView1.Rows.RemoveAt(secilibul.RowIndex);
            //    }
            //}
        }
        double alınanpara = 0.0;
        private void pb5tl_Click(object sender, EventArgs e)
        {
            alınanpara += 5;
            txtAlınan_para.Text = alınanpara.ToString();
        }

        private void pb10tl_Click(object sender, EventArgs e)
        {
            alınanpara += 10;
            txtAlınan_para.Text = alınanpara.ToString();
        }

        private void pb20tl_Click(object sender, EventArgs e)
        {
            alınanpara += 20;
            txtAlınan_para.Text = alınanpara.ToString();
        }

        private void pb50tl_Click(object sender, EventArgs e)
        {
            alınanpara += 50;
            txtAlınan_para.Text = alınanpara.ToString();
        }

        private void pb100tl_Click(object sender, EventArgs e)
        {
            alınanpara += 100;
            txtAlınan_para.Text = alınanpara.ToString();
        }

        private void pb200tl_Click(object sender, EventArgs e)
        {
            alınanpara += 200;
            txtAlınan_para.Text = alınanpara.ToString();
        }
        public int adettoplamı, a;
        int ürünfiyatı = 0;
        private void btnSatışYAP_Click(object sender, EventArgs e)
        {

            string barkodlar = "", ürünadı;
            int adet;
            for (int i = 0; i < dataGridView1.Rows.Count ; i++)
            {
                ürünadı = dataGridView1.Rows[i].Cells[1].Value.ToString();
                barkodlar = dataGridView1.Rows[i].Cells[0].Value.ToString();//datagridden barkodlari alıyor
                adet = Convert.ToInt16(dataGridView1.Rows[i].Cells[4].Value.ToString());//datagridden adetleri alıyor
                ürünfiyatı = Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value.ToString());
                string komut = "UPDATE ÜrünBilgi SET ürünAdet=ürünAdet-" + adet + " WHERE barkodno='" + barkodlar + "'";
                vt.komutcalistirici(komut);
            
                baglantı.Open();
            OleDbCommand kmt = new OleDbCommand("INSERT INTO satış (barkodno,ürünadı,ürünfiyatı,ürünhakında,ürünadet,ürünekleyen,tarih) VALUES (@barkodno,@urunadı,@ürünfiyatı,@ürüngrup,@ürünadet,@ürünekleyen,'"+DateTime.Now+"')", baglantı);
            kmt.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells[0].Value.ToString());
            kmt.Parameters.AddWithValue("@urunadı", dataGridView1.Rows[i].Cells[1].Value.ToString());
            kmt.Parameters.AddWithValue("@ürünfiyatı", float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
            kmt.Parameters.AddWithValue("@ürüngrup", dataGridView1.Rows[i].Cells[3].Value.ToString());
            kmt.Parameters.AddWithValue("@ürünadet", dataGridView1.Rows[i].Cells[4].Value.ToString());
            kmt.Parameters.AddWithValue("@kasiyerismi", dataGridView1.Rows[i].Cells[5].Value.ToString());

            kmt.ExecuteNonQuery();
            baglantı.Close();
            txtBarkodNo.Clear();
            txtÜrünadett.Text = "1";
            dataGridView1.Rows.Clear();
            ürünfiyatı = 0;
            MessageBox.Show("Satış İşlemi Başarı İle Gerçekleşti.");
            label2.Text = "0,00 ₺";
            txtAlınan_para.Clear();
            txtPara_ustu.Clear();
           
            }

            //int satırsayısı = dataGridView1.RowCount;


            //for (int i = 0; i <satırsayısı; i++)
            //{
            //    try
            //    {
            //    if (dataGridView1.Rows[i].Cells[0].Value==null)//datagrid içi boşşa hiç bişiyapma
            //    { }
            //    else//değilse
            //       {
           
            //       }
            //    }             
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString(),"hata");
            //    }
            //}

                for (int j = 0; j <dataGridView1.Rows.Count; j++)
                {
                    if (dataGridView1.Rows[j].Cells[0].Value == null) { }
                    else
                    { 
                   
                        baglantı.Open();
                    OleDbCommand kmt1 = new OleDbCommand("UPDATE ÜrünBilgi SET ürünAdet = ürünAdet -'"+dataGridView1.Rows[j].Cells[4].Value+"' WHERE barkodno=@barkodno", baglantı);
                    kmt1.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[j].Cells[0].Value.ToString());
                    kmt1.ExecuteNonQuery();
                       baglantı.Close();
                       MessageBox.Show("Satış başarıyla gerçekleşmiştir.");
                    //dataGridView1.Rows.Clear();
                    //vt.toplam = 0,0;
                    //label2.Text = "0,0" + "₺";
                    //txtPara_ustu.Text = "0,0" + "₺";
                    }
                
                }
                   
                    
              
             }

        int adet = 0; 
            double GÜNCELPARA=0;
        //double satısfıyatı = 0.0;
        VeriTabanı bgl = new VeriTabanı();
        private void btnekle_Click(object sender, EventArgs e)
        {


            string barkod = txtBarkodNo.Text;
            if (barkod=="")
            {
                MessageBox.Show("Barkod'u Yazınız","Uyarı");
            }
            else
            {
            adet = Convert.ToInt16(txtÜrünadett.Text);
            string komutstokkntrl = "SELECT* FROM ÜrünBilgi WHERE barkodno='" + barkod + "'";

           int kalanadet = bgl.yetki("ürünAdet", komutstokkntrl);
            int stokkontrol = kalanadet - adet;
            if (stokkontrol >= 0)
            {
                string _ürün, komut = "SELECT* FROM ÜrünBilgi WHERE barkodno='" + barkod + "'";

                string acıklama;

                int _Fiyat;

                _ürün = vt.stringdondur("ürünAdı", komut);

                _Fiyat = vt.yetki("satisFiyatı", komut);
                acıklama = vt.stringdondur("ürünhakında", komut);



                dataGridView1.Rows.Add(barkod, _ürün, _Fiyat, acıklama, adet, frmGırıs.kullaniciad);
                GÜNCELPARA = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    GÜNCELPARA += Convert.ToInt16(dataGridView1.Rows[i].Cells[2].Value.ToString()) * Convert.ToInt16(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    label2.Text = GÜNCELPARA.ToString() + "₺";
                }

                txtBarkodNo.Clear();
                txtÜrünadett.Text = "1";
            }
            else
            {
                MessageBox.Show("Stok Yetersiz","Uyarı");
            }
 }
            //try
            //{
            //    adett = Convert.ToInt16(txtÜrünadett.Text);
            //    vt.data("SELECT * FROM ÜrünBilgi WHERE barkodno='" + txtBarkodNo.Text + "'", dataGridView1, "barkodno", "ürünAdı", "satisFiyatı", "ürünhakında", adett, frmGırıs.kullaniciad, label2, label8, label7, label9);
            //    txtBarkodNo.Text = string.Empty;
            //    txtÜrünadett.Text = "1";

            //}
            //catch (Exception ex) 
            //{
            //    MessageBox.Show(ex.ToString(),"NP stok takip");
            //}

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            alınanpara = Convert.ToDouble(txtAlınan_para.Text);
            double paraüstü;
            paraüstü = alınanpara - GÜNCELPARA;
            txtPara_ustu.Text = paraüstü.ToString() + " ₺";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void btnSatısİptal_Click(object sender, EventArgs e)
        {
            txtBarkodNo.Clear();
            txtÜrünadett.Text = "1";
            dataGridView1.Rows.Clear();
            MessageBox.Show("Satış İptal Edildi","Bilgilendirme");
            label2.Text = "0,00 ₺";
            dataGridView1.Rows.Clear();
            txtAlınan_para.Clear();
            txtPara_ustu.Clear();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {

            txtBarkodNo.Text = txtBarkodNo.Text.ToUpper();
            txtBarkodNo.SelectionStart = txtBarkodNo.Text.Length;
        }
           
        }

       
    }


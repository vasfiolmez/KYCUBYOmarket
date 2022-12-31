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
    public partial class frmİstek : Form
    {
        public frmİstek()
        {
            InitializeComponent();
        }

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");     
        //private void griddoldur()
        //{
        //    baglantı.Open();
        //    OleDbCommand komut = new OleDbCommand("SELECT barkodno,ürünAdı,ürünAdet,alisFiyatı,satisFiyatı FROM ÜrünBilgi where ürünAdet<=5", baglantı);
        //    OleDbDataAdapter data = new OleDbDataAdapter(komut);
        //    DataSet dt = new DataSet();
        //    data.Fill(dt);
        //    dataGridView1.DataSource = dt.Tables[0];
        //    baglantı.Close();
        //}

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            menu menu = new menu();
            menu.Show();
            this.Hide();
        }
        private void btnFarklıKaydet_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 1)
            {
                saveFileDialog1.Title = "Kayıt edilecek yeri seçiniz...";
                saveFileDialog1.Filter = "Text Dosyalari|*.txt";
                saveFileDialog1.FileName = "";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter yaz = new StreamWriter(saveFileDialog1.OpenFile());
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        yaz.WriteLine(listBox1.Items[i].ToString());
                    }
                    yaz.Close();
                    listBox1.Items.Clear();
                    MessageBox.Show("Listeniz Hazır");
                }
            }
            else { MessageBox.Show("Liste Boş Lütfen Doldurunuz"); }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtUrunadi.Text + "   " + txtAdet.Text + "    " + txtNot.Text + "\n");
           
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }

            }
        }

        private void btnÇıkart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void frmİstek_Load(object sender, EventArgs e)
        {
         
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUrunadi.Text = dataGridView1.CurrentRow.Cells["ürünAdı"].Value.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void göster(int x)
        {
            string komut = "SELECT barkodno,ürünAdı,ürünAdet,alisFiyatı,satisFiyatı FROM ÜrünBilgi where ürünAdet<="+ x;
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut, baglantı);
            DataSet ds = new DataSet();
            baglantı.Open();
            adapter.Fill(ds, "Azalanlar");
            baglantı.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Azalanlar";
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (tbKontrol.Text=="")
            {
                MessageBox.Show("Boş Bir Değer Girdiniz","Uyarı");
            }
            int azalmış = Convert.ToInt32(tbKontrol.Text);
            göster(azalmış);
        }

        private void tbKontrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

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
    public partial class Bilanco : Form
    {
        public Bilanco()
        {
            InitializeComponent();
        }

        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");     

        VeriTabanı vt=new VeriTabanı();
        private void datagrideYansıt(string komut)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(komut, baglantı);
            DataSet ds = new DataSet();
            baglantı.Open();
            adapter.Fill(ds, "Dökümanlar");
            baglantı.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Dökümanlar";
        }
        private void Bilanco_Load(object sender, EventArgs e)
        {

        }

        private void btnGünlük_Click(object sender, EventArgs e)
        {
            string ürünsıralaması = "SELECT * FROM satış ORDER BY ürünadet DESC";
            datagrideYansıt(ürünsıralaması);
            string toplamkznckmt1 = "SELECT SUM(kazanc) AS TOPLAM FROM satış ";
            OleDbCommand kmt = new OleDbCommand(toplamkznckmt1, baglantı);
            baglantı.Open();
            OleDbDataReader kmtreader = kmt.ExecuteReader();
            while (kmtreader.Read())
            {
                lblToplamKznc.Text = kmtreader["TOPLAM"].ToString();
            }
            baglantı.Close();
            string encoksatankmt = "SELECT TOP 1 ürünadı,SUM(ürünadet) FROM satış GROUP BY ürünadı ORDER BY SUM(ürünadet) DESC";
            lblEnCokSatan.Text = vt.stringdondur("ürünadı", encoksatankmt);
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            string artanürünsiralamasi = "SELECT * FROM satış ORDER BY ürünadet ASC";
            datagrideYansıt(artanürünsiralamasi);

            string toplamkznckmt1 = "SELECT SUM(kazanc) AS TOPLAM FROM satış "; // WHERE Tarih BETWEEN " + dt + " AND " + dt2;
            OleDbCommand kmt = new OleDbCommand(toplamkznckmt1, baglantı);
            baglantı.Open();
            OleDbDataReader kmtreader = kmt.ExecuteReader();
            while (kmtreader.Read())
            {
                lblToplamKznc.Text = kmtreader["TOPLAM"].ToString();
            }
            baglantı.Close(); 
            string enAzsatankmt = "SELECT TOP 1 ürünadı,SUM(ürünadet) FROM satış  GROUP BY ürünadı ORDER BY SUM(ürünadet) ASC";
            lblEnAz.Text = vt.stringdondur("ürünadı", enAzsatankmt);
        }

        private void btnTümü_Click(object sender, EventArgs e)
        {
            string komuttümü = "SELECT* FROM satış";
            datagrideYansıt(komuttümü);

            string toplamkznckmt = "SELECT SUM(kazanc) AS TOPLAM FROM satış";
            OleDbCommand kmt = new OleDbCommand(toplamkznckmt, baglantı);
            baglantı.Open();
            OleDbDataReader kmtreader = kmt.ExecuteReader();
            while (kmtreader.Read())
            {
                lblToplamKznc.Text = kmtreader["TOPLAM"].ToString();
            }
            baglantı.Close();
        }
    }
}

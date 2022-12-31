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
    public partial class frmguncelle : Form
    {
        public frmguncelle()
        {
            InitializeComponent();
        }        
        
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");
            
        
        public void griddoldur()
            {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM ÜrünBilgi",baglantı);
            OleDbDataAdapter data = new OleDbDataAdapter(komut);
            DataSet dt = new DataSet();
            data.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglantı.Close();  
            }


        private void frmguncelle_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStokGuncelleme guncelle = new frmStokGuncelleme();
            guncelle.txtBarkodNo.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            guncelle.txtUrunAdi.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            guncelle.txtUrunAdet.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            guncelle.txtAlis.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            guncelle.txtSatiş.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            guncelle.txtKritikStok.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            guncelle.cmbUrunGrup.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            guncelle.cmbKdv.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            guncelle.txtAcıklama.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            guncelle.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            guncelle.ShowDialog();
        }
    }
}

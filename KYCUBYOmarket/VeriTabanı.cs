using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace KYCUBYOmarket
{
    class VeriTabanı
    {
        public static OleDbConnection baglantı;
        public VeriTabanı()
        {               
         baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");
        }

        public void baglantiAc()
        {
            if (baglantı.State != System.Data.ConnectionState.Open)
                baglantı.Open();
        }

        public void baglantiKapat()
        {
            if (baglantı.State == System.Data.ConnectionState.Open)
                baglantı.Close();
        }

        public void komutcalistirici(string ekle)
        {
            OleDbCommand cmd = new OleDbCommand(ekle, baglantı);
            baglantı.Open();
            cmd.ExecuteNonQuery();
            baglantı.Close();
        }
       public string girisyapankisi()
        {
            string komut = "SELECT adi_soyadi FROM KullanıcıBilgileri WHERE k_adi='"+frmGırıs.kullaniciad+"'";
            string isim = "";
            OleDbCommand cmdisle = new OleDbCommand(komut, baglantı);

            baglantı.Open();
            cmdisle.ExecuteNonQuery();
            OleDbDataReader kmtadapter = cmdisle.ExecuteReader();
            while (kmtadapter.Read())
            { 
            isim += kmtadapter["adi_soyadi"].ToString(); 
            }
            baglantı.Close();
            return isim;
        }
       public int yetki(string istenilen, string komut)
       {
           int x = 0;
           OleDbCommand kmt = new OleDbCommand(komut, baglantı);
           baglantı.Open();
           OleDbDataReader okuyucu = kmt.ExecuteReader();
           while (okuyucu.Read())
           { 
           x=Convert.ToInt32(okuyucu[istenilen]); }
           baglantı.Close();
           return x;
       }
       public string stringdondur(string istenilen, string komut)
       {
           string isim = "";
           OleDbCommand cmdisle = new OleDbCommand(komut, baglantı);

           baglantı.Open();
           cmdisle.ExecuteNonQuery();
           OleDbDataReader kmtadapter = cmdisle.ExecuteReader();
           while (kmtadapter.Read())
           { isim += kmtadapter[istenilen].ToString(); }
           baglantı.Close();
           return isim;
       }

     
       

         

    }
}

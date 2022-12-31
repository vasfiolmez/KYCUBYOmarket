using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.OleDb;

namespace KYCUBYOmarket
{
    public partial class frmSıfreOnayKodu : Form
    {
        public frmSıfreOnayKodu()
        {
            InitializeComponent();
        }
        
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OleDB.12.0;Data Source=verıtabanı.accdb");

        public static int sayı;
        Random rnd=new Random();
        public static string mail;
        private void btnOnaykodu_Click(object sender, EventArgs e)
        {
            try {

         mail = tb_email.Text;
         sayı=rnd.Next(1000,10000);
            
            SmtpClient client = new SmtpClient();

            client.Credentials = new System.Net.NetworkCredential("vasfiolmez_1907@hotmail.com","ankaraspor123");
           
            client.Host = "smtp.live.com";
            client.EnableSsl = true;

                
           MailMessage mesaj = new MailMessage();
            mesaj.To.Add(mail);
            mesaj.From=new MailAddress("vasfiolmez_1907@hotmail.com","a");
            mesaj.Subject = "Onay Kodu";
            mesaj.Body = "onay kodunuz" + sayı.ToString();


            //baglantı.Open();
            //string sorgu = "SELECT * FROM KullanıcıBİlgileri  WHERE e_mail="+tb_email.Text;
            //OleDbCommand kmt = new OleDbCommand(sorgu, baglantı);
            //kmt.ExecuteNonQuery();
            //baglantı.Close();
            client.Port = 587;
            client.Send(mesaj);

           
           MessageBox.Show("Onay kodu E-mail'e başarılı bir şekilde gönderilmiştir.\n E-mailinizi kontol ediniz.");

           frmSifreGuncelleme gun = new frmSifreGuncelleme();
           gun.Show();
           this.Hide();
 }

            catch (Exception ex)
            {

                MessageBox.Show("Onay kodu E-mail'e gönderilememiştir."+ex.ToString());
            
            }

            

        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           


        }

    }
}

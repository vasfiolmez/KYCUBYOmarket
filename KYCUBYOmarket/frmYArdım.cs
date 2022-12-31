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
    public partial class frmYArdım : Form
    {
        public frmYArdım()
        {
            InitializeComponent();
        }

        private void kasayardım_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

            label1.Text = "1-Barkod NO kısmına barkodu yazınız.\n2-Ürün adetini girip ekle butonuna basıp ürünleri listeye eklersiniz.\n3-Eğer yanlış ürün girdiyseniz veya müşteri bu ürünü istemiyorsa ürünü listeden çıkart butonuna basın.\n4-Eğer satışı iptal etmek isterseniz satış iptal butonuna basınız.\n5-Tüm işlemler tamamsa alınan para yerine tutarı girip hesapla butonuna bastıktan sonra satış yap butonuna basın.\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "";

            label1.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label2.Text = "1-Sırasıyla belirtilen alanlara giriş yapın.\n2-Eğer boş alanları boş bırakırsanız hata verebilir.\n3-Tüm alanlara giriş yaptıysanız kaydet butonuna basıp ürünü stoka ekleyebilirsiniz.\n4-Ürünleri goster butonuna tıklarsanız stoktaki ürünler gozukur.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "";

            label1.Text = "";
            label2.Text = "";
            label4.Text = "";
            label5.Text = "";
            label3.Text = "1-Karşınıza ürün bilgi listesi çıkar.\n2-Bu listede güncellemek veya silmek istediğiniz alana çift tıklayın.\n3-Yeni bir form açılacak.\n4-Bu formda güncellemek isteğiniz alanın bilgileri değiştirdikten sonra güncelle butonuna basın.\n5-Ürün güncellendi.\n6-Eğer ürünü silmek istiyorsanız sil butonuna basınız.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Text = "";

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label5.Text = "";
            label4.Text = "1-Bu alana sadece admin girebilir.\n2-Bu alanda kullanıcı yetkilendirme,ekleme,silme,şifre değiştirme işlemleri yapılır.\n3-Kullanıcı yetkilendirme alanında liste üzerinden yetkilendirilmek istenen kullanıcı üzerine çift tıklanır.\n4-Açılan pencerede istediğiniz  yetkiyi seçip seçtiğiniz kullanıcıya yetki verilir.\n5-Kullanıcı ekleme bolumunde alanlar doldurulur ve ekle butonuna basılıp kullanıcı eklenir.\n6-Kullanıcı silme bolumunde liste uzerinde kullanıcı adı üzerine mouse la bir kez tıklanır ve sil butonuna basılıp kullanıcı silinir.\n7-Şifre değiştirme alanında admin şifre değiştirebilir.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "1-Stok adet sınırdan isteğiniz değeri girip ara butonuna basıp.\n2-Girdiğiniz değerin altında olan ürünler listelecektir.\n3-İstediğiniz ürünü ürünadı,ürünadet,not kısmından istek listesine ekle butonu yardımıyla ekleyebilirsiniz.\n4-Farklı kaydet butonuylar istek listesini bilgisayarınızda istediğiniz yere kaydetip kullanabilirsiniz.";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "1-Bu Formda 3 tane sekme bulunur.\n2-Ürün kdv ekle sekmesinde kdv girişi yapabilir veya yaptığınız girişi listeden çıkartabilirsiniz.\n3-Ürün grup ekle sekmesinde ürün grubu girişi yapabilir veya yaptığınız girişi listeden çıkartabilirsiniz.\n4-Şifre değiştir sekmesinde mevcut kullanıcı adı ve şifre girilir.\n5-Ardından yeni kullanıcı adı ve şifre girilip değiştir butonuno basılır.";
        }

       
    }
}

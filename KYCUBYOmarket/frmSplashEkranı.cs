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
    public partial class frmSplashEkranı : Form
    {
        public frmSplashEkranı()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            btnSplash.Width += 8;
            if(btnSplash.Width >=525)
            {
                timerSplash.Stop();
                menu menu = new menu();
                menu.Show();
                this.Hide();
            
            }
        }

        private void btnSplash_Click(object sender, EventArgs e)
        {

        }
    }
}

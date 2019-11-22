using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trab2Bim
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void tmrSplashScreen_Tick(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin(this);
            Login.Show();
            this.Hide();
            tmrSplashScreen.Enabled = false;
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            tmrSplashScreen.Enabled = true;
        }
    }
}

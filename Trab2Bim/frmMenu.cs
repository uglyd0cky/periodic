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
    public partial class frmMenu : Form
    {
        
        //form SplashScreen e form Login
        private Form frmLogin;
        private Form frmSplash;
        
        //inicialização do frmMenu
        public frmMenu(Form frmLogin, Form frmSplash)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
            this.frmSplash = frmSplash;
        }

        //opções do item Menu
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            frmLogin.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair do sistema?", "Sair",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                frmLogin.Close();
                frmLogin.Dispose();
                frmSplash.Close();
                frmSplash.Dispose();
                this.Close();
            }

        }

        //opções do item Jogo
        private void btnTrunfo_Click(object sender, EventArgs e)
        {
            picMenu.Size = new Size(360, 220);
            btnIniciar.Size = new Size(360, 29);
            picMenu.Location = new Point(12, 68);
            btnIniciar.Location = new Point(12, 310);
            btnIniciar.Text = "&Iniciar Trunfo Elementar";
            btnIniciar.Visible = true;

        }

        //botão do Menu
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "&Iniciar Trunfo Elementar")
            {
                frmJogo Jogo = new frmJogo(this);
                Jogo.Show();
                this.Hide();
            }
        }

		private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}

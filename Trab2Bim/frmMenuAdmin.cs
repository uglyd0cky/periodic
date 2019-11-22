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
    public partial class frmMenuAdmin : Form
    {
        //form SplashScreen e form Login
        private Form frmLogin;
        private Form frmSplash;
		frmJogo Jogo;
		frmCadastroCartas Cadastro;
		frmConsultaCartas Consulta;

		//inicialização do frmMenu
		public frmMenuAdmin(Form frmLogin, Form frmSplash)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
            this.frmSplash = frmSplash;
			Jogo = new frmJogo(this);
			Cadastro = new frmCadastroCartas(this);
			Consulta = new frmConsultaCartas(this);
		}

        //opções do item Menu
        private void btnLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            frmLogin.Show();
        }

        //botão sair
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair do sistema?", "Sair",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resp==DialogResult.Yes)
            {
                frmLogin.Close();
                frmLogin.Dispose();

                frmSplash.Close();
                frmSplash.Dispose();

                this.Close();
            }
            
        }

        //opções do item Aplicações
        private void btnCadastrarCartas_Click(object sender, EventArgs e)
        {
            picMenu.Size = new Size(250, 250);
            btnIniciar.Size = new Size(250, 29);
            picMenu.Location = new Point(66, 57);
            btnIniciar.Location = new Point(66, 329);
            btnIniciar.Text = "&Cadastrar Cartas";
            btnIniciar.Visible = true;

        }

        private void btnConsultarCartas_Click(object sender, EventArgs e)
        {
            picMenu.Size = new Size(250, 250);
            btnIniciar.Size = new Size(250, 29);
            picMenu.Location = new Point(66, 57);
            btnIniciar.Location = new Point(66, 329);
            btnIniciar.Text = "&Consultar Cartas";
            btnIniciar.Visible = true;

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
            if(btnIniciar.Text == "&Iniciar Trunfo Elementar")
            {
                Jogo.Show();
                this.Hide();
            }

            if(btnIniciar.Text == "&Cadastrar Cartas")
            {
                Cadastro.Show();
                this.Hide();
            }

            if(btnIniciar.Text == "&Consultar Cartas")
            {
                Consulta.Show();
                this.Hide();
            }
        }

		private void frmMenuAdmin_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}

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
using Npgsql;

namespace Trab2Bim
{
    public partial class frmLogin : Form
    {
		Connection c = new Connection();

        //form SplashScreen
        private Form frmSplash, frmCadastro;

        //conexão com o banco de dados

        //inicialização do frmLogin
        public frmLogin(Form frmSplash)
        {
            this.frmSplash = frmSplash;
			this.frmCadastro = new frmCadastro(this);
            InitializeComponent();
            btnSair.Focus();
        }

        //botão Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
			if(check())
			{
				string nome = txtUsuario.Text;
				string senha = txtSenha.Text;
				bool x = c.login(nome, senha);
				if(x && c.IsAdm(nome))
				{
					frmMenuAdmin Menu = new frmMenuAdmin(this, this.frmSplash);
					Menu.Show();
					this.Hide();
				}
				else if(x)
				{
					frmMenu Menu = new frmMenu(this, this.frmSplash);
					Menu.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Senha ou usuario incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Insira corretamente os campos!", "Erro");
			}

		}
		private bool check()
		{
			string nome = txtUsuario.Text;
			string senha = txtSenha.Text;

			if (String.IsNullOrWhiteSpace(nome) || String.IsNullOrWhiteSpace(senha))
				return false;
			return true;
		}

		//botão Sair
		private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair do sistema?", "Sair",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                frmSplash.Close();
                frmSplash.Dispose();
                this.Close();
            }
        }

        //link Clique aqui --> leva ao cadastro de usuários
        private void lblCliqueAqui_Click(object sender, EventArgs e)
        {
            frmCadastro.Show();
            this.Hide();
        }

		private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}
	}
}

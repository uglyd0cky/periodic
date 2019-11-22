using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Trab2Bim
{
    public partial class frmCadastro : Form
    {
        //form Login
        private Form frmLogin;

		Connection c = new Connection();

        //conexão com o banco de dados
       // private NpgsqlConnection c = new NpgsqlConnection();
        //construtor
        public frmCadastro(Form frmLogin)
        {
            this.frmLogin = frmLogin;
            InitializeComponent();
            txtNomeUsuario.Focus();
        }

        //botão Cadastrar - salva os dados do usuário no banco de dados
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
			if(check())
			{
				string nome = txtNomeUsuario.Text;
				string senha = txtSenha.Text;
				string email = txtEmail.Text;

				try
				{
					if (c.insertUser(nome, senha, email))
					{
						MessageBox.Show("Cadastrado com sucesso!", "Cadastro");
					}
					else
					{
						MessageBox.Show("Erro ao cadastrar!", "Erro");
					}
				}
				catch (Exception err)
				{
					throw err;
				}
			}
			else
			{
				MessageBox.Show("Preencha corretamente os campos!","Erro");
			}
		}

        private bool check()
		{
			string nome = txtNomeUsuario.Text;
			string senha = txtSenha.Text;
			string email = txtEmail.Text;

			if(String.IsNullOrWhiteSpace(nome) || String.IsNullOrWhiteSpace(senha) || String.IsNullOrWhiteSpace(email))
				return false;
			return true;
		}

        //botão Voltar ao Login - retorna à tela de Login
        private void btnVoltarLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
        }

		private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}

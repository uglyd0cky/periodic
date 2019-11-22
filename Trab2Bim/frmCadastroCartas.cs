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
    public partial class frmCadastroCartas : Form
    {
        //form MenuAdmin
        private Form frmMenuAdmin;
		Connection c = new Connection();

        //construtor
        public frmCadastroCartas(Form frmMenuAdmin)
        {
            InitializeComponent();
            this.frmMenuAdmin = frmMenuAdmin;
        }

        //botão VOLTAR AO MENU
        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuAdmin.Show();
        }

		private void btnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				string elemento = txtElemento.Text;
				int raio = Convert.ToInt32(txtRaioAtomico.Text);
				int num = Convert.ToInt32(txtNumeroAtomico.Text);
				if (c.insertCard(elemento, raio, num))
					MessageBox.Show("Cadastrado com sucesso!","Cadastro de cartas");
				else
					MessageBox.Show("Erro ao cadastrar", "Cadastro de cartas");
			}
			catch(Exception err)
			{
				MessageBox.Show("Insira corretamente os valores!","Erro");
			}
			
		}

		private void frmCadastroCartas_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}

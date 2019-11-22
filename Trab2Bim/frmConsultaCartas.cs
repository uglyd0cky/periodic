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
    public partial class frmConsultaCartas : Form
    {
        //form MenuAdmin
        private Form frmMenuAdmin;

		//conexão com o banco de dados
		Connection c = new Connection();

        //mostra tabela das cartas no datagridview
        private void mostraDados()
        {
			dgConsultaCartas.DataSource = c.searchAllCards();
		}

        //construtor
        public frmConsultaCartas(Form frmMenuAdmin)
        {
            InitializeComponent();
            this.frmMenuAdmin = frmMenuAdmin;

            mostraDados();
        }

        //botão VOLTAR AO MENU
        private void BtnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuAdmin.Show();
        }

        //botão CONSULTAR
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string elemento = txtElemento.Text;
			string[] info = new string[4];
			info = c.searchCard(elemento);

			if(info != null)
			{
				frmCarta card = new frmCarta(info);
				card.Show();
			}
			else
			{
				MessageBox.Show("Nenhuma carta encontrada","Erro");
			}

        }

		private void lblRefresh_Click(object sender, EventArgs e)
		{
			mostraDados();
		}

		private void frmConsultaCartas_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}

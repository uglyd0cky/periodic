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
	public partial class frmCarta : Form
	{
		string[] info;
		bool alterState = false;
		Connection c = new Connection();

        //construtor
        public frmCarta(string[] inf)
		{
			InitializeComponent();
			this.info = inf;

			txtId.Text = info[0];
			txtElemento.Text = info[1];
			txtNum.Text = info[2];
			txtRaio.Text = info[3];
		}

        //botão VOLTAR
        private void btnVoltar_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}

        //botão ALTERAR
        private void btnAlterar_Click(object sender, EventArgs e)
        {
			if(!alterState)
			{
				txtElemento.Enabled = true;
				txtNum.Enabled = true;
				txtRaio.Enabled = true;

				btnAlterar.Text = "Salvar";
				alterState = true;
			}
			else
			{
				if (check())
				{
					int id = Convert.ToInt32(txtId.Text);
					string nome = txtElemento.Text;
					int num = Convert.ToInt32(txtNum.Text);
					int raio = Convert.ToInt32(txtRaio.Text);

					try
					{
						if (c.alterCard(id, nome, raio, num))
						{
							MessageBox.Show("Alteração efetuada com sucesso!", "Alteração");
							btnAlterar.Text = "Alterar";
							alterState = false;
							txtElemento.Enabled = false;
							txtNum.Enabled = false;
							txtRaio.Enabled = false;
						}
						else
						{
							MessageBox.Show("Erro ao alterar dados!", "Erro");
						}
					}
					catch (Exception err)
					{
						throw err;
					}
				}
				else
				{
					MessageBox.Show("Por favor, preencha corretamente os campos!", "Erro");
				}

				
			}
			
		}

        //botão EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
			DialogResult exclui = MessageBox.Show("Deseja realmente excluir?","Excluir",MessageBoxButtons.YesNo);
            if(check() && exclui==DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text);

                try
                {
                    if (c.deleteCard(id))
                    {
                        MessageBox.Show("Exclusão efetuada com sucesso!", "Exclusão");
						this.Close();
						
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir dados!", "Erro");
                    }
                }
                catch (Exception err)
                {
					MessageBox.Show("Erro: " + err, "Erro");
                }
            }
        }

        //função para checar se os campos estão vazios
        private bool check()
        {
            string id = txtId.Text;
            string nome = txtElemento.Text;
            string num = txtNum.Text;
            string raio = txtRaio.Text;

            if (String.IsNullOrWhiteSpace(id) || String.IsNullOrWhiteSpace(nome) || String.IsNullOrWhiteSpace(num) || String.IsNullOrWhiteSpace(raio))
			{
				MessageBox.Show("Preencha corretamente os campos!","Erro");
				return false;
			}
                

            return true;
        }

		private void btnVoltar_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

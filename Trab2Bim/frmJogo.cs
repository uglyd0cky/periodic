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
    public partial class frmJogo : Form
    {
        //formulário Menu
        private Form frmMenu;

        //variáveis usadas no jogo
        private Random sorteio = new Random();
        private int valorJog1 = 0, valorJog2 = 0;
        private int pontosJog1 = 0, pontosJog2 = 0;
        private int camada1 = 0, camada2 = 0;
        private int cont = 0;

        //inicialização do frmJogo
        public frmJogo(Form frmMenu)
        {
            InitializeComponent();
            this.frmMenu = frmMenu;
            rdNumeroAtomico.Checked = true;
        }

        //função para calcular a camada de valência dos elementos
        private int calcula_camada (int valor)
        {
            int camada = 0;

            if (valor == 1 || valor == 2)
                camada = 1;

            else if (valor >= 3 && valor <= 10)
                camada = 2;

            else if (valor >= 11 && valor <= 18)
                camada = 3;

            else if (valor >= 19 && valor <= 35)
                camada = 4;

            return camada;
        }

        //função para determinar o vencedor em cada rodada
        private void vencedor (int jogador1, int jogador2, int valor1, int valor2)
        {
            
            if (jogador1 > jogador2)
            {
                pontosJog1++;
                if (pontosJog2 > 0)
                    pontosJog2--;
                lblResultado.Text = "O elemento " + jogador1 + " venceu essa rodada!";
                cont++;
            }
            else if(jogador2 > jogador1)
            {
                pontosJog2++;
                if (pontosJog1 > 0)
                    pontosJog1--;
                lblResultado.Text = "O elemento " + jogador2 + " venceu essa rodada!";
                cont++;
            }
            else
            {
                if(rdNumeroAtomico.Checked)
                {
                    lblResultado.Text = "Ops, os elementos são iguais!";
                    cont++;
                }
                else
                {
                    if(valor1 > valor2)
                    {
                        pontosJog1++;
                        if (pontosJog2 > 0)
                            pontosJog2--;
                        lblResultado.Text = "O elemento " + valor1 + " venceu essa rodada!";
                        cont++;
                    }
                    else if(valor2 > valor1)
                    {
                        pontosJog2++;
                        if (pontosJog1 > 0)
                            pontosJog1--;
                        lblResultado.Text = "O elemento " + valor2 + " venceu essa rodada!";
                        cont++;
                    }
                    else
                    {
                        lblResultado.Text = "Ops, os elementos são iguais!";
                        cont++;
                    }
                }
            }
            lblPontosJogador1.Text = pontosJog1.ToString();
            lblPontosJogador2.Text = pontosJog2.ToString();
            lblContador.Text = cont.ToString();
            }

        //botão Jogar
        private void btnJogar_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = true;
            //sorteio das cartas
            int carta = sorteio.Next(1, 36);
            int carta2 = sorteio.Next(1, 36);
            //apresentação das cartas sorteadas
            picCarta1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Imagens_elementos\\" + carta + ".jpg");
            picCarta2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Imagens_elementos\\" + carta2 + ".jpg");
            //associação do valor das cartas aos jogadores 1 e 2
            valorJog1 = carta;
            valorJog2 = carta2;
            //análise da opção escolhida pelo usuário para se definir o vencedor do jogo:
            if(rdNumeroAtomico.Checked)
            {
                vencedor(valorJog1, valorJog2, 0, 0);
            }
            else if(rdRaioAtomico.Checked)
            {
                vencedor(camada1, camada2, valorJog1, valorJog2);
            }
        }

		private void frmJogo_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void zerar()
        {


            if (pontosJog1 > pontosJog2)
            {
                MessageBox.Show("O jogador 1 venceu");
            }
            else if (pontosJog2 > pontosJog1)
            {
                MessageBox.Show("O jogador 2 venceu");
            }
            else
                MessageBox.Show("Empate");

            valorJog1 = 0; valorJog2 = 0;
            pontosJog1 = 0; pontosJog2 = 0;
            camada1 = 0; camada2 = 0;
            cont = 0;
            lblPontosJogador1.Text = "";
            lblPontosJogador2.Text = "";
            lblContador.Text = "";
            lblResultado.Text = "";
        }

        //botão Novo Jogo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            zerar();
        }

        //botão Retornar
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}

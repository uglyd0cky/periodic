namespace Trab2Bim
{
    partial class frmJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogo));
			this.picCarta1 = new System.Windows.Forms.PictureBox();
			this.picCarta2 = new System.Windows.Forms.PictureBox();
			this.gpbJogo = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblContador = new System.Windows.Forms.Label();
			this.btnNovo = new System.Windows.Forms.Button();
			this.btnRetornar = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.lblOpcao = new System.Windows.Forms.Label();
			this.rdNumeroAtomico = new System.Windows.Forms.RadioButton();
			this.rdRaioAtomico = new System.Windows.Forms.RadioButton();
			this.lblX = new System.Windows.Forms.Label();
			this.lblPontosJogador1 = new System.Windows.Forms.Label();
			this.lblPontosJogador2 = new System.Windows.Forms.Label();
			this.btnJogar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picCarta1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCarta2)).BeginInit();
			this.gpbJogo.SuspendLayout();
			this.SuspendLayout();
			// 
			// picCarta1
			// 
			this.picCarta1.BackColor = System.Drawing.Color.Transparent;
			this.picCarta1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCarta1.BackgroundImage")));
			this.picCarta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picCarta1.Location = new System.Drawing.Point(23, 39);
			this.picCarta1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picCarta1.Name = "picCarta1";
			this.picCarta1.Size = new System.Drawing.Size(343, 335);
			this.picCarta1.TabIndex = 0;
			this.picCarta1.TabStop = false;
			// 
			// picCarta2
			// 
			this.picCarta2.BackColor = System.Drawing.Color.Transparent;
			this.picCarta2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCarta2.BackgroundImage")));
			this.picCarta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picCarta2.Location = new System.Drawing.Point(839, 39);
			this.picCarta2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picCarta2.Name = "picCarta2";
			this.picCarta2.Size = new System.Drawing.Size(335, 335);
			this.picCarta2.TabIndex = 1;
			this.picCarta2.TabStop = false;
			// 
			// gpbJogo
			// 
			this.gpbJogo.BackColor = System.Drawing.Color.Transparent;
			this.gpbJogo.Controls.Add(this.label1);
			this.gpbJogo.Controls.Add(this.lblContador);
			this.gpbJogo.Controls.Add(this.btnNovo);
			this.gpbJogo.Controls.Add(this.btnRetornar);
			this.gpbJogo.Controls.Add(this.lblResultado);
			this.gpbJogo.Controls.Add(this.lblOpcao);
			this.gpbJogo.Controls.Add(this.rdNumeroAtomico);
			this.gpbJogo.Controls.Add(this.rdRaioAtomico);
			this.gpbJogo.Controls.Add(this.lblX);
			this.gpbJogo.Controls.Add(this.lblPontosJogador1);
			this.gpbJogo.Controls.Add(this.lblPontosJogador2);
			this.gpbJogo.Controls.Add(this.btnJogar);
			this.gpbJogo.Controls.Add(this.picCarta2);
			this.gpbJogo.Controls.Add(this.picCarta1);
			this.gpbJogo.Location = new System.Drawing.Point(17, 11);
			this.gpbJogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gpbJogo.Name = "gpbJogo";
			this.gpbJogo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gpbJogo.Size = new System.Drawing.Size(1203, 517);
			this.gpbJogo.TabIndex = 2;
			this.gpbJogo.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(401, 208);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 29);
			this.label1.TabIndex = 28;
			this.label1.Text = ">>Rodadas: ";
			// 
			// lblContador
			// 
			this.lblContador.BackColor = System.Drawing.Color.Transparent;
			this.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContador.ForeColor = System.Drawing.Color.Transparent;
			this.lblContador.Location = new System.Drawing.Point(579, 208);
			this.lblContador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblContador.Name = "lblContador";
			this.lblContador.Size = new System.Drawing.Size(52, 28);
			this.lblContador.TabIndex = 25;
			this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNovo
			// 
			this.btnNovo.BackColor = System.Drawing.Color.Black;
			this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNovo.ForeColor = System.Drawing.Color.White;
			this.btnNovo.Location = new System.Drawing.Point(23, 439);
			this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Size = new System.Drawing.Size(343, 36);
			this.btnNovo.TabIndex = 24;
			this.btnNovo.Text = "&Novo Jogo";
			this.btnNovo.UseVisualStyleBackColor = false;
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// btnRetornar
			// 
			this.btnRetornar.BackColor = System.Drawing.Color.Black;
			this.btnRetornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRetornar.ForeColor = System.Drawing.Color.White;
			this.btnRetornar.Location = new System.Drawing.Point(839, 439);
			this.btnRetornar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRetornar.Name = "btnRetornar";
			this.btnRetornar.Size = new System.Drawing.Size(335, 36);
			this.btnRetornar.TabIndex = 23;
			this.btnRetornar.Text = "&Retornar ao Menu";
			this.btnRetornar.UseVisualStyleBackColor = false;
			this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
			// 
			// lblResultado
			// 
			this.lblResultado.BackColor = System.Drawing.Color.Black;
			this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResultado.ForeColor = System.Drawing.Color.White;
			this.lblResultado.Location = new System.Drawing.Point(407, 346);
			this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(389, 28);
			this.lblResultado.TabIndex = 22;
			this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblResultado.Visible = false;
			// 
			// lblOpcao
			// 
			this.lblOpcao.AutoSize = true;
			this.lblOpcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOpcao.ForeColor = System.Drawing.Color.White;
			this.lblOpcao.Location = new System.Drawing.Point(397, 39);
			this.lblOpcao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOpcao.Name = "lblOpcao";
			this.lblOpcao.Size = new System.Drawing.Size(368, 29);
			this.lblOpcao.TabIndex = 21;
			this.lblOpcao.Text = ">> Escolha uma característica:";
			// 
			// rdNumeroAtomico
			// 
			this.rdNumeroAtomico.AutoSize = true;
			this.rdNumeroAtomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNumeroAtomico.ForeColor = System.Drawing.Color.White;
			this.rdNumeroAtomico.Location = new System.Drawing.Point(445, 127);
			this.rdNumeroAtomico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdNumeroAtomico.Name = "rdNumeroAtomico";
			this.rdNumeroAtomico.Size = new System.Drawing.Size(167, 24);
			this.rdNumeroAtomico.TabIndex = 20;
			this.rdNumeroAtomico.Text = "Número &atômico";
			this.rdNumeroAtomico.UseVisualStyleBackColor = true;
			// 
			// rdRaioAtomico
			// 
			this.rdRaioAtomico.AutoSize = true;
			this.rdRaioAtomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdRaioAtomico.ForeColor = System.Drawing.Color.White;
			this.rdRaioAtomico.Location = new System.Drawing.Point(445, 84);
			this.rdRaioAtomico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.rdRaioAtomico.Name = "rdRaioAtomico";
			this.rdRaioAtomico.Size = new System.Drawing.Size(140, 24);
			this.rdRaioAtomico.TabIndex = 19;
			this.rdRaioAtomico.Text = "&Raio atômico";
			this.rdRaioAtomico.UseVisualStyleBackColor = true;
			// 
			// lblX
			// 
			this.lblX.AutoSize = true;
			this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX.Location = new System.Drawing.Point(592, 300);
			this.lblX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(27, 25);
			this.lblX.TabIndex = 18;
			this.lblX.Text = "X";
			// 
			// lblPontosJogador1
			// 
			this.lblPontosJogador1.BackColor = System.Drawing.Color.Black;
			this.lblPontosJogador1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPontosJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPontosJogador1.ForeColor = System.Drawing.Color.White;
			this.lblPontosJogador1.Location = new System.Drawing.Point(405, 299);
			this.lblPontosJogador1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPontosJogador1.Name = "lblPontosJogador1";
			this.lblPontosJogador1.Size = new System.Drawing.Size(171, 28);
			this.lblPontosJogador1.TabIndex = 17;
			this.lblPontosJogador1.Text = "Jogador 1";
			this.lblPontosJogador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPontosJogador2
			// 
			this.lblPontosJogador2.BackColor = System.Drawing.Color.Black;
			this.lblPontosJogador2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPontosJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPontosJogador2.ForeColor = System.Drawing.Color.White;
			this.lblPontosJogador2.Location = new System.Drawing.Point(627, 299);
			this.lblPontosJogador2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPontosJogador2.Name = "lblPontosJogador2";
			this.lblPontosJogador2.Size = new System.Drawing.Size(169, 28);
			this.lblPontosJogador2.TabIndex = 16;
			this.lblPontosJogador2.Text = "Jogador 2";
			this.lblPontosJogador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnJogar
			// 
			this.btnJogar.BackColor = System.Drawing.Color.Black;
			this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnJogar.ForeColor = System.Drawing.Color.White;
			this.btnJogar.Location = new System.Drawing.Point(407, 439);
			this.btnJogar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnJogar.Name = "btnJogar";
			this.btnJogar.Size = new System.Drawing.Size(389, 36);
			this.btnJogar.TabIndex = 15;
			this.btnJogar.Text = "&Jogar";
			this.btnJogar.UseVisualStyleBackColor = false;
			this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
			// 
			// frmJogo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1239, 543);
			this.Controls.Add(this.gpbJogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmJogo";
			this.Text = ">>Trunfo Elementar";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmJogo_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.picCarta1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCarta2)).EndInit();
			this.gpbJogo.ResumeLayout(false);
			this.gpbJogo.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCarta1;
        private System.Windows.Forms.PictureBox picCarta2;
        private System.Windows.Forms.GroupBox gpbJogo;
        private System.Windows.Forms.RadioButton rdNumeroAtomico;
        private System.Windows.Forms.RadioButton rdRaioAtomico;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblPontosJogador1;
        private System.Windows.Forms.Label lblPontosJogador2;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblOpcao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label1;
    }
}
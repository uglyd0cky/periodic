namespace Trab2Bim
{
    partial class frmCadastroCartas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCartas));
			this.gpbCarta = new System.Windows.Forms.GroupBox();
			this.lblCadastroCartas = new System.Windows.Forms.Label();
			this.txtRaioAtomico = new System.Windows.Forms.TextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnVoltarMenu = new System.Windows.Forms.Button();
			this.txtNumeroAtomico = new System.Windows.Forms.TextBox();
			this.txtElemento = new System.Windows.Forms.TextBox();
			this.gpbCarta.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpbCarta
			// 
			this.gpbCarta.BackColor = System.Drawing.Color.Transparent;
			this.gpbCarta.Controls.Add(this.lblCadastroCartas);
			this.gpbCarta.Controls.Add(this.txtRaioAtomico);
			this.gpbCarta.Controls.Add(this.btnCadastrar);
			this.gpbCarta.Controls.Add(this.btnVoltarMenu);
			this.gpbCarta.Controls.Add(this.txtNumeroAtomico);
			this.gpbCarta.Controls.Add(this.txtElemento);
			this.gpbCarta.Location = new System.Drawing.Point(15, 12);
			this.gpbCarta.Name = "gpbCarta";
			this.gpbCarta.Size = new System.Drawing.Size(335, 399);
			this.gpbCarta.TabIndex = 10;
			this.gpbCarta.TabStop = false;
			// 
			// lblCadastroCartas
			// 
			this.lblCadastroCartas.AutoSize = true;
			this.lblCadastroCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastroCartas.ForeColor = System.Drawing.Color.White;
			this.lblCadastroCartas.Location = new System.Drawing.Point(61, 43);
			this.lblCadastroCartas.Name = "lblCadastroCartas";
			this.lblCadastroCartas.Size = new System.Drawing.Size(268, 31);
			this.lblCadastroCartas.TabIndex = 13;
			this.lblCadastroCartas.Text = "Cadastro de Cartas";
			// 
			// txtRaioAtomico
			// 
			this.txtRaioAtomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRaioAtomico.Location = new System.Drawing.Point(50, 162);
			this.txtRaioAtomico.Name = "txtRaioAtomico";
			this.txtRaioAtomico.Size = new System.Drawing.Size(240, 29);
			this.txtRaioAtomico.TabIndex = 12;
			this.txtRaioAtomico.Text = "Raio Atômico...";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.Black;
			this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.Location = new System.Drawing.Point(50, 280);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(240, 29);
			this.btnCadastrar.TabIndex = 10;
			this.btnCadastrar.Text = "&Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnVoltarMenu
			// 
			this.btnVoltarMenu.BackColor = System.Drawing.Color.Black;
			this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltarMenu.ForeColor = System.Drawing.Color.White;
			this.btnVoltarMenu.Location = new System.Drawing.Point(50, 335);
			this.btnVoltarMenu.Name = "btnVoltarMenu";
			this.btnVoltarMenu.Size = new System.Drawing.Size(240, 29);
			this.btnVoltarMenu.TabIndex = 11;
			this.btnVoltarMenu.Text = "&Voltar ao Menu";
			this.btnVoltarMenu.UseVisualStyleBackColor = false;
			this.btnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
			// 
			// txtNumeroAtomico
			// 
			this.txtNumeroAtomico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumeroAtomico.Location = new System.Drawing.Point(50, 216);
			this.txtNumeroAtomico.Name = "txtNumeroAtomico";
			this.txtNumeroAtomico.Size = new System.Drawing.Size(240, 29);
			this.txtNumeroAtomico.TabIndex = 4;
			this.txtNumeroAtomico.Text = "Número Atômico...";
			// 
			// txtElemento
			// 
			this.txtElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtElemento.Location = new System.Drawing.Point(50, 107);
			this.txtElemento.Name = "txtElemento";
			this.txtElemento.Size = new System.Drawing.Size(240, 29);
			this.txtElemento.TabIndex = 3;
			this.txtElemento.Text = "Elemento...";
			// 
			// frmCadastroCartas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(364, 429);
			this.Controls.Add(this.gpbCarta);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmCadastroCartas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ">> Cadastro de Cartas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastroCartas_FormClosing);
			this.gpbCarta.ResumeLayout(false);
			this.gpbCarta.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCarta;
        private System.Windows.Forms.Label lblCadastroCartas;
        private System.Windows.Forms.TextBox txtRaioAtomico;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.TextBox txtNumeroAtomico;
        private System.Windows.Forms.TextBox txtElemento;
    }
}
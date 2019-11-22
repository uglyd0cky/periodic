namespace Trab2Bim
{
    partial class frmMenuAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmin));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLogoff = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
			this.btnAplicacoes = new System.Windows.Forms.ToolStripMenuItem();
			this.btnCadastrarCartas = new System.Windows.Forms.ToolStripMenuItem();
			this.btnConsultarCartas = new System.Windows.Forms.ToolStripMenuItem();
			this.btnJogo = new System.Windows.Forms.ToolStripMenuItem();
			this.btnTrunfo = new System.Windows.Forms.ToolStripMenuItem();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mRUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.temperaturaSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jogarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nomejogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dadinhosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.picMenu = new System.Windows.Forms.PictureBox();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.Black;
			this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu,
            this.btnAplicacoes,
            this.btnJogo});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(512, 28);
			this.menuStrip.TabIndex = 6;
			this.menuStrip.Text = "menuStrip";
			// 
			// btnMenu
			// 
			this.btnMenu.BackColor = System.Drawing.Color.Black;
			this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogoff,
            this.btnSair});
			this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenu.ForeColor = System.Drawing.Color.White;
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(64, 24);
			this.btnMenu.Text = "&Menu";
			// 
			// btnLogoff
			// 
			this.btnLogoff.Name = "btnLogoff";
			this.btnLogoff.Size = new System.Drawing.Size(224, 26);
			this.btnLogoff.Text = "&Logoff";
			this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
			// 
			// btnSair
			// 
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(224, 26);
			this.btnSair.Text = "&Sair";
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// btnAplicacoes
			// 
			this.btnAplicacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarCartas,
            this.btnConsultarCartas});
			this.btnAplicacoes.ForeColor = System.Drawing.Color.White;
			this.btnAplicacoes.Name = "btnAplicacoes";
			this.btnAplicacoes.Size = new System.Drawing.Size(105, 24);
			this.btnAplicacoes.Text = "&Aplicações";
			// 
			// btnCadastrarCartas
			// 
			this.btnCadastrarCartas.Name = "btnCadastrarCartas";
			this.btnCadastrarCartas.Size = new System.Drawing.Size(221, 26);
			this.btnCadastrarCartas.Text = "&Cadastrar Cartas";
			this.btnCadastrarCartas.Click += new System.EventHandler(this.btnCadastrarCartas_Click);
			// 
			// btnConsultarCartas
			// 
			this.btnConsultarCartas.Name = "btnConsultarCartas";
			this.btnConsultarCartas.Size = new System.Drawing.Size(221, 26);
			this.btnConsultarCartas.Text = "&Consultar Cartas";
			this.btnConsultarCartas.Click += new System.EventHandler(this.btnConsultarCartas_Click);
			// 
			// btnJogo
			// 
			this.btnJogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTrunfo});
			this.btnJogo.ForeColor = System.Drawing.Color.White;
			this.btnJogo.Name = "btnJogo";
			this.btnJogo.Size = new System.Drawing.Size(59, 24);
			this.btnJogo.Text = "&Jogo";
			// 
			// btnTrunfo
			// 
			this.btnTrunfo.Name = "btnTrunfo";
			this.btnTrunfo.Size = new System.Drawing.Size(221, 26);
			this.btnTrunfo.Text = "&Trunfo Elementar";
			this.btnTrunfo.Click += new System.EventHandler(this.btnTrunfo_Click);
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
			this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.arquivoToolStripMenuItem.Text = "Menu";
			// 
			// configuraçõesToolStripMenuItem
			// 
			this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
			this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.configuraçõesToolStripMenuItem.Text = "Configurações";
			// 
			// sairToolStripMenuItem
			// 
			this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
			this.sairToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.sairToolStripMenuItem.Text = "Sair";
			// 
			// aplicativoToolStripMenuItem
			// 
			this.aplicativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mRUToolStripMenuItem,
            this.iMCToolStripMenuItem,
            this.temperaturaSToolStripMenuItem});
			this.aplicativoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.aplicativoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.aplicativoToolStripMenuItem.Name = "aplicativoToolStripMenuItem";
			this.aplicativoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.aplicativoToolStripMenuItem.Text = "Aplicativos";
			// 
			// mRUToolStripMenuItem
			// 
			this.mRUToolStripMenuItem.Name = "mRUToolStripMenuItem";
			this.mRUToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
			this.mRUToolStripMenuItem.Text = "IMC";
			// 
			// iMCToolStripMenuItem
			// 
			this.iMCToolStripMenuItem.Name = "iMCToolStripMenuItem";
			this.iMCToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
			this.iMCToolStripMenuItem.Text = "MRU";
			// 
			// temperaturaSToolStripMenuItem
			// 
			this.temperaturaSToolStripMenuItem.Name = "temperaturaSToolStripMenuItem";
			this.temperaturaSToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
			this.temperaturaSToolStripMenuItem.Text = "Temperatura";
			// 
			// jogarToolStripMenuItem
			// 
			this.jogarToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.jogarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nomejogoToolStripMenuItem,
            this.dadinhosToolStripMenuItem});
			this.jogarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.jogarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.jogarToolStripMenuItem.Name = "jogarToolStripMenuItem";
			this.jogarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.jogarToolStripMenuItem.Text = "Jogos";
			// 
			// nomejogoToolStripMenuItem
			// 
			this.nomejogoToolStripMenuItem.Name = "nomejogoToolStripMenuItem";
			this.nomejogoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
			this.nomejogoToolStripMenuItem.Text = "Nome_jogo";
			// 
			// dadinhosToolStripMenuItem
			// 
			this.dadinhosToolStripMenuItem.Name = "dadinhosToolStripMenuItem";
			this.dadinhosToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
			this.dadinhosToolStripMenuItem.Text = "Dadinhos";
			// 
			// picMenu
			// 
			this.picMenu.BackColor = System.Drawing.Color.Transparent;
			this.picMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMenu.BackgroundImage")));
			this.picMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picMenu.Location = new System.Drawing.Point(88, 70);
			this.picMenu.Margin = new System.Windows.Forms.Padding(4);
			this.picMenu.Name = "picMenu";
			this.picMenu.Size = new System.Drawing.Size(333, 308);
			this.picMenu.TabIndex = 13;
			this.picMenu.TabStop = false;
			// 
			// btnIniciar
			// 
			this.btnIniciar.BackColor = System.Drawing.Color.Black;
			this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIniciar.ForeColor = System.Drawing.Color.White;
			this.btnIniciar.Location = new System.Drawing.Point(88, 405);
			this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(333, 36);
			this.btnIniciar.TabIndex = 14;
			this.btnIniciar.Text = "&Iniciar";
			this.btnIniciar.UseVisualStyleBackColor = false;
			this.btnIniciar.Visible = false;
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// frmMenuAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(512, 481);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.picMenu);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmMenuAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ">>Bem-vindo, Administrador!";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuAdmin_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aplicativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mRUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomejogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadinhosToolStripMenuItem;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnLogoff;
        private System.Windows.Forms.ToolStripMenuItem btnAplicacoes;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarCartas;
        private System.Windows.Forms.ToolStripMenuItem btnConsultarCartas;
        private System.Windows.Forms.ToolStripMenuItem btnJogo;
        private System.Windows.Forms.ToolStripMenuItem btnTrunfo;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
    }
}
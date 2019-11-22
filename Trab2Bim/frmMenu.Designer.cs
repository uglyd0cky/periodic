namespace Trab2Bim
{
    partial class frmMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
			this.btnIniciar = new System.Windows.Forms.Button();
			this.picMenu = new System.Windows.Forms.PictureBox();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLogoff = new System.Windows.Forms.ToolStripMenuItem();
			this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
			this.btnJogo = new System.Windows.Forms.ToolStripMenuItem();
			this.btnTrunfo = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnIniciar
			// 
			this.btnIniciar.BackColor = System.Drawing.Color.Black;
			this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIniciar.ForeColor = System.Drawing.Color.White;
			this.btnIniciar.Location = new System.Drawing.Point(88, 406);
			this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(333, 36);
			this.btnIniciar.TabIndex = 17;
			this.btnIniciar.Text = "&Iniciar";
			this.btnIniciar.UseVisualStyleBackColor = false;
			this.btnIniciar.Visible = false;
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// picMenu
			// 
			this.picMenu.BackColor = System.Drawing.Color.Transparent;
			this.picMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMenu.BackgroundImage")));
			this.picMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picMenu.Location = new System.Drawing.Point(88, 71);
			this.picMenu.Margin = new System.Windows.Forms.Padding(4);
			this.picMenu.Name = "picMenu";
			this.picMenu.Size = new System.Drawing.Size(333, 308);
			this.picMenu.TabIndex = 16;
			this.picMenu.TabStop = false;
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.Black;
			this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu,
            this.btnJogo});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(512, 28);
			this.menuStrip.TabIndex = 15;
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
			this.btnLogoff.Size = new System.Drawing.Size(139, 26);
			this.btnLogoff.Text = "&Logoff";
			this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
			// 
			// btnSair
			// 
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(139, 26);
			this.btnSair.Text = "&Sair";
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
			// 
			// frmMenu
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
			this.Name = "frmMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ">>Bem-vindo ao sistema!";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnLogoff;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem btnJogo;
        private System.Windows.Forms.ToolStripMenuItem btnTrunfo;
    }
}
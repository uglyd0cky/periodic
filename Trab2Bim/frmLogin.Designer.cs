namespace Trab2Bim
{
    partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.gpbUsuario = new System.Windows.Forms.GroupBox();
			this.lblCliqueAqui = new System.Windows.Forms.Label();
			this.lblPergunta = new System.Windows.Forms.Label();
			this.picLogin = new System.Windows.Forms.PictureBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnSair = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.gpbUsuario.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
			this.SuspendLayout();
			// 
			// gpbUsuario
			// 
			this.gpbUsuario.BackColor = System.Drawing.Color.Transparent;
			this.gpbUsuario.Controls.Add(this.lblCliqueAqui);
			this.gpbUsuario.Controls.Add(this.lblPergunta);
			this.gpbUsuario.Controls.Add(this.picLogin);
			this.gpbUsuario.Controls.Add(this.btnLogin);
			this.gpbUsuario.Controls.Add(this.btnSair);
			this.gpbUsuario.Controls.Add(this.txtSenha);
			this.gpbUsuario.Controls.Add(this.txtUsuario);
			this.gpbUsuario.Location = new System.Drawing.Point(44, 18);
			this.gpbUsuario.Margin = new System.Windows.Forms.Padding(4);
			this.gpbUsuario.Name = "gpbUsuario";
			this.gpbUsuario.Padding = new System.Windows.Forms.Padding(4);
			this.gpbUsuario.Size = new System.Drawing.Size(420, 518);
			this.gpbUsuario.TabIndex = 8;
			this.gpbUsuario.TabStop = false;
			// 
			// lblCliqueAqui
			// 
			this.lblCliqueAqui.AutoSize = true;
			this.lblCliqueAqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCliqueAqui.ForeColor = System.Drawing.Color.MediumBlue;
			this.lblCliqueAqui.Location = new System.Drawing.Point(155, 470);
			this.lblCliqueAqui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCliqueAqui.Name = "lblCliqueAqui";
			this.lblCliqueAqui.Size = new System.Drawing.Size(112, 20);
			this.lblCliqueAqui.TabIndex = 14;
			this.lblCliqueAqui.Text = "Cadastre-se";
			this.lblCliqueAqui.Click += new System.EventHandler(this.lblCliqueAqui_Click);
			// 
			// lblPergunta
			// 
			this.lblPergunta.AutoSize = true;
			this.lblPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPergunta.Location = new System.Drawing.Point(85, 444);
			this.lblPergunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPergunta.Name = "lblPergunta";
			this.lblPergunta.Size = new System.Drawing.Size(232, 20);
			this.lblPergunta.TabIndex = 13;
			this.lblPergunta.Text = "Ainda não tem uma conta?";
			// 
			// picLogin
			// 
			this.picLogin.BackColor = System.Drawing.Color.Transparent;
			this.picLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogin.BackgroundImage")));
			this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picLogin.Location = new System.Drawing.Point(136, 25);
			this.picLogin.Margin = new System.Windows.Forms.Padding(4);
			this.picLogin.Name = "picLogin";
			this.picLogin.Size = new System.Drawing.Size(153, 142);
			this.picLogin.TabIndex = 12;
			this.picLogin.TabStop = false;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Black;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(51, 322);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(320, 36);
			this.btnLogin.TabIndex = 10;
			this.btnLogin.Text = "&Login";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnSair
			// 
			this.btnSair.BackColor = System.Drawing.Color.Black;
			this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSair.ForeColor = System.Drawing.Color.White;
			this.btnSair.Location = new System.Drawing.Point(51, 373);
			this.btnSair.Margin = new System.Windows.Forms.Padding(4);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(320, 36);
			this.btnSair.TabIndex = 11;
			this.btnSair.Text = "&Sair";
			this.btnSair.UseVisualStyleBackColor = false;
			this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(51, 255);
			this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(319, 29);
			this.txtSenha.TabIndex = 4;
			this.txtSenha.Text = "Senha";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(51, 194);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(319, 29);
			this.txtUsuario.TabIndex = 3;
			this.txtUsuario.Text = "Usuário";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(512, 559);
			this.Controls.Add(this.gpbUsuario);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ">>Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			this.Load += new System.EventHandler(this.frmLogin_Load);
			this.gpbUsuario.ResumeLayout(false);
			this.gpbUsuario.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbUsuario;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Label lblCliqueAqui;
    }
}
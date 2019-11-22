namespace Trab2Bim
{
    partial class frmCadastro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
			this.gpbUsuario = new System.Windows.Forms.GroupBox();
			this.lblCadastro = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.btnVoltarLogin = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtNomeUsuario = new System.Windows.Forms.TextBox();
			this.gpbUsuario.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpbUsuario
			// 
			this.gpbUsuario.BackColor = System.Drawing.Color.Transparent;
			this.gpbUsuario.Controls.Add(this.lblCadastro);
			this.gpbUsuario.Controls.Add(this.txtEmail);
			this.gpbUsuario.Controls.Add(this.btnCadastrar);
			this.gpbUsuario.Controls.Add(this.btnVoltarLogin);
			this.gpbUsuario.Controls.Add(this.txtSenha);
			this.gpbUsuario.Controls.Add(this.txtNomeUsuario);
			this.gpbUsuario.Location = new System.Drawing.Point(12, 10);
			this.gpbUsuario.Name = "gpbUsuario";
			this.gpbUsuario.Size = new System.Drawing.Size(335, 399);
			this.gpbUsuario.TabIndex = 9;
			this.gpbUsuario.TabStop = false;
			// 
			// lblCadastro
			// 
			this.lblCadastro.AutoSize = true;
			this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCadastro.ForeColor = System.Drawing.Color.White;
			this.lblCadastro.Location = new System.Drawing.Point(49, 37);
			this.lblCadastro.Name = "lblCadastro";
			this.lblCadastro.Size = new System.Drawing.Size(297, 31);
			this.lblCadastro.TabIndex = 13;
			this.lblCadastro.Text = "Cadastro de Usuários";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(52, 163);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(235, 29);
			this.txtEmail.TabIndex = 12;
			this.txtEmail.Text = "E-mail...";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.BackColor = System.Drawing.Color.Black;
			this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCadastrar.ForeColor = System.Drawing.Color.White;
			this.btnCadastrar.Location = new System.Drawing.Point(52, 284);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(235, 29);
			this.btnCadastrar.TabIndex = 10;
			this.btnCadastrar.Text = "&Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = false;
			this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
			// 
			// btnVoltarLogin
			// 
			this.btnVoltarLogin.BackColor = System.Drawing.Color.Black;
			this.btnVoltarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltarLogin.ForeColor = System.Drawing.Color.White;
			this.btnVoltarLogin.Location = new System.Drawing.Point(52, 338);
			this.btnVoltarLogin.Name = "btnVoltarLogin";
			this.btnVoltarLogin.Size = new System.Drawing.Size(235, 29);
			this.btnVoltarLogin.TabIndex = 11;
			this.btnVoltarLogin.Text = "&Voltar ao Login";
			this.btnVoltarLogin.UseVisualStyleBackColor = false;
			this.btnVoltarLogin.Click += new System.EventHandler(this.btnVoltarLogin_Click);
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(52, 225);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(235, 29);
			this.txtSenha.TabIndex = 4;
			this.txtSenha.Text = "Senha...";
			// 
			// txtNomeUsuario
			// 
			this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNomeUsuario.Location = new System.Drawing.Point(52, 100);
			this.txtNomeUsuario.Name = "txtNomeUsuario";
			this.txtNomeUsuario.Size = new System.Drawing.Size(235, 29);
			this.txtNomeUsuario.TabIndex = 3;
			this.txtNomeUsuario.Text = "Nome...";
			// 
			// frmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(364, 429);
			this.Controls.Add(this.gpbUsuario);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmCadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ">>Cadastro";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastro_FormClosing);
			this.gpbUsuario.ResumeLayout(false);
			this.gpbUsuario.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbUsuario;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltarLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txtEmail;
    }
}
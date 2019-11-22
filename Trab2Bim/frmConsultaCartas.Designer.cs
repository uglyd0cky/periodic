namespace Trab2Bim
{
    partial class frmConsultaCartas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCartas));
			this.gpbCarta = new System.Windows.Forms.GroupBox();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.lblConsultaCartas = new System.Windows.Forms.Label();
			this.btnVoltarMenu = new System.Windows.Forms.Button();
			this.txtElemento = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblRefresh = new System.Windows.Forms.Label();
			this.lblConsulraGeral = new System.Windows.Forms.Label();
			this.dgConsultaCartas = new System.Windows.Forms.DataGridView();
			this.gpbCarta.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgConsultaCartas)).BeginInit();
			this.SuspendLayout();
			// 
			// gpbCarta
			// 
			this.gpbCarta.BackColor = System.Drawing.Color.Transparent;
			this.gpbCarta.Controls.Add(this.btnConsultar);
			this.gpbCarta.Controls.Add(this.lblConsultaCartas);
			this.gpbCarta.Controls.Add(this.btnVoltarMenu);
			this.gpbCarta.Controls.Add(this.txtElemento);
			this.gpbCarta.Location = new System.Drawing.Point(12, 11);
			this.gpbCarta.Name = "gpbCarta";
			this.gpbCarta.Size = new System.Drawing.Size(588, 141);
			this.gpbCarta.TabIndex = 11;
			this.gpbCarta.TabStop = false;
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.Black;
			this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.ForeColor = System.Drawing.Color.White;
			this.btnConsultar.Location = new System.Drawing.Point(248, 84);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(153, 26);
			this.btnConsultar.TabIndex = 15;
			this.btnConsultar.Text = "&Consultar";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
			// 
			// lblConsultaCartas
			// 
			this.lblConsultaCartas.AutoSize = true;
			this.lblConsultaCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsultaCartas.ForeColor = System.Drawing.Color.White;
			this.lblConsultaCartas.Location = new System.Drawing.Point(21, 32);
			this.lblConsultaCartas.Name = "lblConsultaCartas";
			this.lblConsultaCartas.Size = new System.Drawing.Size(367, 31);
			this.lblConsultaCartas.TabIndex = 13;
			this.lblConsultaCartas.Text = "Consulta Manual de Cartas";
			// 
			// btnVoltarMenu
			// 
			this.btnVoltarMenu.BackColor = System.Drawing.Color.Black;
			this.btnVoltarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltarMenu.ForeColor = System.Drawing.Color.White;
			this.btnVoltarMenu.Location = new System.Drawing.Point(409, 84);
			this.btnVoltarMenu.Name = "btnVoltarMenu";
			this.btnVoltarMenu.Size = new System.Drawing.Size(153, 26);
			this.btnVoltarMenu.TabIndex = 11;
			this.btnVoltarMenu.Text = "&Voltar ao Menu";
			this.btnVoltarMenu.UseVisualStyleBackColor = false;
			this.btnVoltarMenu.Click += new System.EventHandler(this.BtnVoltarMenu_Click);
			// 
			// txtElemento
			// 
			this.txtElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtElemento.Location = new System.Drawing.Point(26, 84);
			this.txtElemento.Name = "txtElemento";
			this.txtElemento.Size = new System.Drawing.Size(209, 29);
			this.txtElemento.TabIndex = 3;
			this.txtElemento.Text = "Elemento...";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lblRefresh);
			this.groupBox1.Controls.Add(this.lblConsulraGeral);
			this.groupBox1.Controls.Add(this.dgConsultaCartas);
			this.groupBox1.Location = new System.Drawing.Point(12, 160);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(590, 359);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// lblRefresh
			// 
			this.lblRefresh.AutoSize = true;
			this.lblRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRefresh.ForeColor = System.Drawing.Color.White;
			this.lblRefresh.Location = new System.Drawing.Point(500, 61);
			this.lblRefresh.Name = "lblRefresh";
			this.lblRefresh.Size = new System.Drawing.Size(62, 20);
			this.lblRefresh.TabIndex = 19;
			this.lblRefresh.Text = "refresh";
			this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
			// 
			// lblConsulraGeral
			// 
			this.lblConsulraGeral.AutoSize = true;
			this.lblConsulraGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsulraGeral.ForeColor = System.Drawing.Color.White;
			this.lblConsulraGeral.Location = new System.Drawing.Point(21, 33);
			this.lblConsulraGeral.Name = "lblConsulraGeral";
			this.lblConsulraGeral.Size = new System.Drawing.Size(344, 31);
			this.lblConsulraGeral.TabIndex = 16;
			this.lblConsulraGeral.Text = "Consulta Geral de Cartas";
			// 
			// dgConsultaCartas
			// 
			this.dgConsultaCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgConsultaCartas.Location = new System.Drawing.Point(26, 84);
			this.dgConsultaCartas.Name = "dgConsultaCartas";
			this.dgConsultaCartas.RowHeadersWidth = 51;
			this.dgConsultaCartas.Size = new System.Drawing.Size(536, 251);
			this.dgConsultaCartas.TabIndex = 18;
			// 
			// frmConsultaCartas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(614, 531);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gpbCarta);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmConsultaCartas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ">> Consulta de Cartas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultaCartas_FormClosing);
			this.gpbCarta.ResumeLayout(false);
			this.gpbCarta.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgConsultaCartas)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCarta;
        private System.Windows.Forms.Label lblConsultaCartas;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblConsulraGeral;
        private System.Windows.Forms.DataGridView dgConsultaCartas;
		private System.Windows.Forms.Label lblRefresh;
	}
}
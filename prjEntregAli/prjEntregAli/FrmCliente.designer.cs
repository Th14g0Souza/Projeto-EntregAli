namespace prjEntregAli
{
    partial class FrmCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lblCelCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.lblRgCliente = new System.Windows.Forms.Label();
            this.lblDataNascCliente = new System.Windows.Forms.Label();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtBairroCli = new System.Windows.Forms.TextBox();
            this.txtEndCli = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndCliente = new System.Windows.Forms.Label();
            this.txtCidadeCli = new System.Windows.Forms.TextBox();
            this.lblCidadeCliente = new System.Windows.Forms.Label();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCPFCli = new System.Windows.Forms.MaskedTextBox();
            this.txtRGCli = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascCli = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneCli = new System.Windows.Forms.MaskedTextBox();
            this.txtCelCliente = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(290, -1);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.Location = new System.Drawing.Point(80, 0);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Location = new System.Drawing.Point(186, 0);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnPri
            // 
            this.btnPri.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPri.FlatAppearance.BorderSize = 0;
            this.btnPri.Click += new System.EventHandler(this.btnPri_Click);
            // 
            // btnAnt
            // 
            this.btnAnt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnt.FlatAppearance.BorderSize = 0;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnDep
            // 
            this.btnDep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDep.FlatAppearance.BorderSize = 0;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnUlt
            // 
            this.btnUlt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUlt.FlatAppearance.BorderSize = 0;
            this.btnUlt.Click += new System.EventHandler(this.btnUlt_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Enabled = false;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.Location = new System.Drawing.Point(486, -1);
            this.btnPesquisar.Size = new System.Drawing.Size(91, 54);
            this.btnPesquisar.TabIndex = 16;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatAppearance.BorderSize = 0;
            this.btnLimparCampos.Location = new System.Drawing.Point(400, 0);
            this.btnLimparCampos.TabIndex = 15;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 401);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(304, 18);
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.Text = "CADASTRO CLIENTE";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 459);
            // 
            // btnSair2
            // 
            this.btnSair2.Location = new System.Drawing.Point(676, 11);
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(142, 72);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(376, 27);
            this.txtNomeCli.TabIndex = 1;
            // 
            // lblCelCliente
            // 
            this.lblCelCliente.AutoSize = true;
            this.lblCelCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelCliente.Location = new System.Drawing.Point(303, 207);
            this.lblCelCliente.Name = "lblCelCliente";
            this.lblCelCliente.Size = new System.Drawing.Size(69, 21);
            this.lblCelCliente.TabIndex = 31;
            this.lblCelCliente.Text = "Celular:";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.Location = new System.Drawing.Point(86, 207);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(80, 21);
            this.lblTelefoneCliente.TabIndex = 30;
            this.lblTelefoneCliente.Text = "Telefone:";
            // 
            // lblRgCliente
            // 
            this.lblRgCliente.AutoSize = true;
            this.lblRgCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgCliente.Location = new System.Drawing.Point(332, 117);
            this.lblRgCliente.Name = "lblRgCliente";
            this.lblRgCliente.Size = new System.Drawing.Size(38, 21);
            this.lblRgCliente.TabIndex = 29;
            this.lblRgCliente.Text = "RG:";
            // 
            // lblDataNascCliente
            // 
            this.lblDataNascCliente.AutoSize = true;
            this.lblDataNascCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascCliente.Location = new System.Drawing.Point(85, 163);
            this.lblDataNascCliente.Name = "lblDataNascCliente";
            this.lblDataNascCliente.Size = new System.Drawing.Size(153, 21);
            this.lblDataNascCliente.TabIndex = 28;
            this.lblDataNascCliente.Text = "Data Nascimento:";
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCliente.Location = new System.Drawing.Point(86, 119);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(44, 21);
            this.lblCPFCliente.TabIndex = 27;
            this.lblCPFCliente.Text = "CPF:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(86, 72);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(61, 21);
            this.lblNomeCliente.TabIndex = 26;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // txtBairroCli
            // 
            this.txtBairroCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCli.Location = new System.Drawing.Point(142, 352);
            this.txtBairroCli.Name = "txtBairroCli";
            this.txtBairroCli.Size = new System.Drawing.Size(135, 27);
            this.txtBairroCli.TabIndex = 8;
            // 
            // txtEndCli
            // 
            this.txtEndCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndCli.Location = new System.Drawing.Point(179, 301);
            this.txtEndCli.Name = "txtEndCli";
            this.txtEndCli.Size = new System.Drawing.Size(348, 27);
            this.txtEndCli.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(85, 355);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(57, 21);
            this.lblBairro.TabIndex = 40;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEndCliente
            // 
            this.lblEndCliente.AutoSize = true;
            this.lblEndCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndCliente.Location = new System.Drawing.Point(84, 304);
            this.lblEndCliente.Name = "lblEndCliente";
            this.lblEndCliente.Size = new System.Drawing.Size(89, 21);
            this.lblEndCliente.TabIndex = 39;
            this.lblEndCliente.Text = "Endereço:";
            // 
            // txtCidadeCli
            // 
            this.txtCidadeCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeCli.Location = new System.Drawing.Point(364, 349);
            this.txtCidadeCli.Name = "txtCidadeCli";
            this.txtCidadeCli.Size = new System.Drawing.Size(164, 27);
            this.txtCidadeCli.TabIndex = 9;
            // 
            // lblCidadeCliente
            // 
            this.lblCidadeCliente.AutoSize = true;
            this.lblCidadeCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCliente.Location = new System.Drawing.Point(285, 352);
            this.lblCidadeCliente.Name = "lblCidadeCliente";
            this.lblCidadeCliente.Size = new System.Drawing.Size(73, 21);
            this.lblCidadeCliente.TabIndex = 43;
            this.lblCidadeCliente.Text = "Cidade:";
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCli.Location = new System.Drawing.Point(156, 253);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(372, 27);
            this.txtEmailCli.TabIndex = 10;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(86, 259);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 21);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtCPFCli
            // 
            this.txtCPFCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFCli.Location = new System.Drawing.Point(133, 116);
            this.txtCPFCli.Mask = "000, 000, 000- 00";
            this.txtCPFCli.Name = "txtCPFCli";
            this.txtCPFCli.Size = new System.Drawing.Size(144, 27);
            this.txtCPFCli.TabIndex = 2;
            // 
            // txtRGCli
            // 
            this.txtRGCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGCli.Location = new System.Drawing.Point(381, 114);
            this.txtRGCli.Mask = "00, 000, 000 - 0";
            this.txtRGCli.Name = "txtRGCli";
            this.txtRGCli.Size = new System.Drawing.Size(137, 27);
            this.txtRGCli.TabIndex = 3;
            // 
            // txtDataNascCli
            // 
            this.txtDataNascCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascCli.Location = new System.Drawing.Point(244, 160);
            this.txtDataNascCli.Mask = "00 /00 / 0000";
            this.txtDataNascCli.Name = "txtDataNascCli";
            this.txtDataNascCli.Size = new System.Drawing.Size(112, 27);
            this.txtDataNascCli.TabIndex = 4;
            this.txtDataNascCli.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefoneCli
            // 
            this.txtTelefoneCli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCli.Location = new System.Drawing.Point(172, 204);
            this.txtTelefoneCli.Name = "txtTelefoneCli";
            this.txtTelefoneCli.Size = new System.Drawing.Size(121, 27);
            this.txtTelefoneCli.TabIndex = 5;
            // 
            // txtCelCliente
            // 
            this.txtCelCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelCliente.Location = new System.Drawing.Point(387, 204);
            this.txtCelCliente.Name = "txtCelCliente";
            this.txtCelCliente.Size = new System.Drawing.Size(140, 27);
            this.txtCelCliente.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjEntregAli.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(608, 340);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(66, 36);
            this.btnVoltar.TabIndex = 55;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 496);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCelCliente);
            this.Controls.Add(this.txtTelefoneCli);
            this.Controls.Add(this.txtDataNascCli);
            this.Controls.Add(this.txtRGCli);
            this.Controls.Add(this.txtCPFCli);
            this.Controls.Add(this.txtEmailCli);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCidadeCli);
            this.Controls.Add(this.lblCidadeCliente);
            this.Controls.Add(this.txtBairroCli);
            this.Controls.Add(this.txtEndCli);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEndCliente);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.lblCelCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.lblRgCliente);
            this.Controls.Add(this.lblDataNascCliente);
            this.Controls.Add(this.lblCPFCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSair2, 0);
            this.Controls.SetChildIndex(this.lblNomeCliente, 0);
            this.Controls.SetChildIndex(this.lblCPFCliente, 0);
            this.Controls.SetChildIndex(this.lblDataNascCliente, 0);
            this.Controls.SetChildIndex(this.lblRgCliente, 0);
            this.Controls.SetChildIndex(this.lblTelefoneCliente, 0);
            this.Controls.SetChildIndex(this.lblCelCliente, 0);
            this.Controls.SetChildIndex(this.txtNomeCli, 0);
            this.Controls.SetChildIndex(this.lblEndCliente, 0);
            this.Controls.SetChildIndex(this.lblBairro, 0);
            this.Controls.SetChildIndex(this.txtEndCli, 0);
            this.Controls.SetChildIndex(this.txtBairroCli, 0);
            this.Controls.SetChildIndex(this.lblCidadeCliente, 0);
            this.Controls.SetChildIndex(this.txtCidadeCli, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtEmailCli, 0);
            this.Controls.SetChildIndex(this.txtCPFCli, 0);
            this.Controls.SetChildIndex(this.txtRGCli, 0);
            this.Controls.SetChildIndex(this.txtDataNascCli, 0);
            this.Controls.SetChildIndex(this.txtTelefoneCli, 0);
            this.Controls.SetChildIndex(this.txtCelCliente, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.btnVoltar, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNomeCli;
        public System.Windows.Forms.Label lblCelCliente;
        public System.Windows.Forms.Label lblTelefoneCliente;
        public System.Windows.Forms.Label lblRgCliente;
        public System.Windows.Forms.Label lblDataNascCliente;
        public System.Windows.Forms.Label lblCPFCliente;
        public System.Windows.Forms.Label lblNomeCliente;
        public System.Windows.Forms.TextBox txtBairroCli;
        public System.Windows.Forms.TextBox txtEndCli;
        public System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.Label lblEndCliente;
        public System.Windows.Forms.TextBox txtCidadeCli;
        public System.Windows.Forms.Label lblCidadeCliente;
        public System.Windows.Forms.TextBox txtEmailCli;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.MaskedTextBox txtCPFCli;
        public System.Windows.Forms.MaskedTextBox txtRGCli;
        public System.Windows.Forms.MaskedTextBox txtDataNascCli;
        public System.Windows.Forms.MaskedTextBox txtTelefoneCli;
        public System.Windows.Forms.MaskedTextBox txtCelCliente;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
    }
}


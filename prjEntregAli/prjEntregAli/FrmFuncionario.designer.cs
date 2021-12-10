namespace prjEntregAli
{
    partial class FrmFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.txtRGFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtCPFFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblRgCliente = new System.Windows.Forms.Label();
            this.lblDataNascCliente = new System.Windows.Forms.Label();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblIdPermissao = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtPermissao = new System.Windows.Forms.MaskedTextBox();
            this.txtUsuario = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtCelFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtTelFunc = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCidadeFunc = new System.Windows.Forms.TextBox();
            this.lblCidadeCliente = new System.Windows.Forms.Label();
            this.txtBairroFunc = new System.Windows.Forms.TextBox();
            this.txtEndFunc = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndCliente = new System.Windows.Forms.Label();
            this.lblCelularCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDataNascFunc = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
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
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatAppearance.BorderSize = 0;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(308, 18);
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.Text = "CADASTRO FUNCIONÁRIO";
            // 
            // btnSair2
            // 
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // txtRGFunc
            // 
            this.txtRGFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRGFunc.Location = new System.Drawing.Point(455, 101);
            this.txtRGFunc.Mask = "00,000,000-0";
            this.txtRGFunc.Name = "txtRGFunc";
            this.txtRGFunc.Size = new System.Drawing.Size(141, 26);
            this.txtRGFunc.TabIndex = 70;
            // 
            // txtCPFFunc
            // 
            this.txtCPFFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFFunc.Location = new System.Drawing.Point(262, 101);
            this.txtCPFFunc.Mask = "000,000,000-00";
            this.txtCPFFunc.Name = "txtCPFFunc";
            this.txtCPFFunc.Size = new System.Drawing.Size(126, 26);
            this.txtCPFFunc.TabIndex = 69;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFunc.Location = new System.Drawing.Point(262, 58);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(334, 26);
            this.txtNomeFunc.TabIndex = 60;
            // 
            // lblRgCliente
            // 
            this.lblRgCliente.AutoSize = true;
            this.lblRgCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRgCliente.Location = new System.Drawing.Point(414, 107);
            this.lblRgCliente.Name = "lblRgCliente";
            this.lblRgCliente.Size = new System.Drawing.Size(35, 20);
            this.lblRgCliente.TabIndex = 57;
            this.lblRgCliente.Text = "RG:";
            // 
            // lblDataNascCliente
            // 
            this.lblDataNascCliente.AutoSize = true;
            this.lblDataNascCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascCliente.Location = new System.Drawing.Point(206, 151);
            this.lblDataNascCliente.Name = "lblDataNascCliente";
            this.lblDataNascCliente.Size = new System.Drawing.Size(164, 20);
            this.lblDataNascCliente.TabIndex = 56;
            this.lblDataNascCliente.Text = "Data de Nascimento:";
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCliente.Location = new System.Drawing.Point(209, 107);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(41, 20);
            this.lblCPFCliente.TabIndex = 55;
            this.lblCPFCliente.Text = "CPF:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(206, 58);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(57, 20);
            this.lblNomeCliente.TabIndex = 54;
            this.lblNomeCliente.Text = "Nome:";
            // 
            // lblIdPermissao
            // 
            this.lblIdPermissao.AutoSize = true;
            this.lblIdPermissao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPermissao.Location = new System.Drawing.Point(650, 122);
            this.lblIdPermissao.Name = "lblIdPermissao";
            this.lblIdPermissao.Size = new System.Drawing.Size(126, 20);
            this.lblIdPermissao.TabIndex = 77;
            this.lblIdPermissao.Text = "Nível Permissão:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(649, 194);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 20);
            this.lblUsuario.TabIndex = 79;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(649, 282);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(58, 20);
            this.lblSenha.TabIndex = 80;
            this.lblSenha.Text = "Senha:";
            // 
            // txtPermissao
            // 
            this.txtPermissao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermissao.Location = new System.Drawing.Point(654, 145);
            this.txtPermissao.Name = "txtPermissao";
            this.txtPermissao.Size = new System.Drawing.Size(115, 26);
            this.txtPermissao.TabIndex = 83;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(653, 217);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(116, 26);
            this.txtUsuario.TabIndex = 84;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(653, 305);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(116, 26);
            this.txtSenha.TabIndex = 86;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(209, 241);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(60, 20);
            this.lblCargo.TabIndex = 87;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(281, 235);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(130, 26);
            this.txtCargo.TabIndex = 88;
            // 
            // txtCelFunc
            // 
            this.txtCelFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelFunc.Location = new System.Drawing.Point(477, 273);
            this.txtCelFunc.Name = "txtCelFunc";
            this.txtCelFunc.Size = new System.Drawing.Size(132, 26);
            this.txtCelFunc.TabIndex = 102;
            // 
            // txtTelFunc
            // 
            this.txtTelFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelFunc.Location = new System.Drawing.Point(281, 276);
            this.txtTelFunc.Name = "txtTelFunc";
            this.txtTelFunc.Size = new System.Drawing.Size(121, 26);
            this.txtTelFunc.TabIndex = 101;
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFunc.Location = new System.Drawing.Point(270, 192);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(333, 26);
            this.txtEmailFunc.TabIndex = 100;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(209, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 20);
            this.lblEmail.TabIndex = 99;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtCidadeFunc
            // 
            this.txtCidadeFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeFunc.Location = new System.Drawing.Point(466, 358);
            this.txtCidadeFunc.Name = "txtCidadeFunc";
            this.txtCidadeFunc.Size = new System.Drawing.Size(147, 26);
            this.txtCidadeFunc.TabIndex = 98;
            // 
            // lblCidadeCliente
            // 
            this.lblCidadeCliente.AutoSize = true;
            this.lblCidadeCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCliente.Location = new System.Drawing.Point(392, 358);
            this.lblCidadeCliente.Name = "lblCidadeCliente";
            this.lblCidadeCliente.Size = new System.Drawing.Size(68, 20);
            this.lblCidadeCliente.TabIndex = 97;
            this.lblCidadeCliente.Text = "Cidade:";
            // 
            // txtBairroFunc
            // 
            this.txtBairroFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroFunc.Location = new System.Drawing.Point(270, 358);
            this.txtBairroFunc.Name = "txtBairroFunc";
            this.txtBairroFunc.Size = new System.Drawing.Size(111, 26);
            this.txtBairroFunc.TabIndex = 96;
            // 
            // txtEndFunc
            // 
            this.txtEndFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndFunc.Location = new System.Drawing.Point(300, 316);
            this.txtEndFunc.Name = "txtEndFunc";
            this.txtEndFunc.Size = new System.Drawing.Size(309, 26);
            this.txtEndFunc.TabIndex = 95;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(211, 358);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 94;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEndCliente
            // 
            this.lblEndCliente.AutoSize = true;
            this.lblEndCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndCliente.Location = new System.Drawing.Point(209, 319);
            this.lblEndCliente.Name = "lblEndCliente";
            this.lblEndCliente.Size = new System.Drawing.Size(85, 20);
            this.lblEndCliente.TabIndex = 93;
            this.lblEndCliente.Text = "Endereço:";
            // 
            // lblCelularCliente
            // 
            this.lblCelularCliente.AutoSize = true;
            this.lblCelularCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelularCliente.Location = new System.Drawing.Point(414, 276);
            this.lblCelularCliente.Name = "lblCelularCliente";
            this.lblCelularCliente.Size = new System.Drawing.Size(65, 20);
            this.lblCelularCliente.TabIndex = 92;
            this.lblCelularCliente.Text = "Celular:";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.Location = new System.Drawing.Point(209, 279);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(75, 20);
            this.lblTelefoneCliente.TabIndex = 91;
            this.lblTelefoneCliente.Text = "Telefone:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnVoltar.Location = new System.Drawing.Point(685, 358);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 32);
            this.btnVoltar.TabIndex = 104;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjEntregAli.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // txtDataNascFunc
            // 
            this.txtDataNascFunc.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtDataNascFunc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNascFunc.Location = new System.Drawing.Point(376, 151);
            this.txtDataNascFunc.Name = "txtDataNascFunc";
            this.txtDataNascFunc.Size = new System.Drawing.Size(119, 26);
            this.txtDataNascFunc.TabIndex = 106;
            this.txtDataNascFunc.Value = new System.DateTime(2021, 12, 1, 0, 0, 0, 0);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 496);
            this.Controls.Add(this.txtDataNascFunc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtCelFunc);
            this.Controls.Add(this.txtTelFunc);
            this.Controls.Add(this.txtEmailFunc);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCidadeFunc);
            this.Controls.Add(this.lblCidadeCliente);
            this.Controls.Add(this.txtBairroFunc);
            this.Controls.Add(this.txtEndFunc);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEndCliente);
            this.Controls.Add(this.lblCelularCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPermissao);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblIdPermissao);
            this.Controls.Add(this.txtRGFunc);
            this.Controls.Add(this.txtCPFFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblRgCliente);
            this.Controls.Add(this.lblDataNascCliente);
            this.Controls.Add(this.lblCPFCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFuncionario";
            this.Text = "FrmFuncionario";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSair2, 0);
            this.Controls.SetChildIndex(this.lblNomeCliente, 0);
            this.Controls.SetChildIndex(this.lblCPFCliente, 0);
            this.Controls.SetChildIndex(this.lblDataNascCliente, 0);
            this.Controls.SetChildIndex(this.lblRgCliente, 0);
            this.Controls.SetChildIndex(this.txtNomeFunc, 0);
            this.Controls.SetChildIndex(this.txtCPFFunc, 0);
            this.Controls.SetChildIndex(this.txtRGFunc, 0);
            this.Controls.SetChildIndex(this.lblIdPermissao, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.lblSenha, 0);
            this.Controls.SetChildIndex(this.txtPermissao, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.txtSenha, 0);
            this.Controls.SetChildIndex(this.lblCargo, 0);
            this.Controls.SetChildIndex(this.txtCargo, 0);
            this.Controls.SetChildIndex(this.lblTelefoneCliente, 0);
            this.Controls.SetChildIndex(this.lblCelularCliente, 0);
            this.Controls.SetChildIndex(this.lblEndCliente, 0);
            this.Controls.SetChildIndex(this.lblBairro, 0);
            this.Controls.SetChildIndex(this.txtEndFunc, 0);
            this.Controls.SetChildIndex(this.txtBairroFunc, 0);
            this.Controls.SetChildIndex(this.lblCidadeCliente, 0);
            this.Controls.SetChildIndex(this.txtCidadeFunc, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtEmailFunc, 0);
            this.Controls.SetChildIndex(this.txtTelFunc, 0);
            this.Controls.SetChildIndex(this.txtCelFunc, 0);
            this.Controls.SetChildIndex(this.btnVoltar, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtDataNascFunc, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox txtRGFunc;
        public System.Windows.Forms.MaskedTextBox txtCPFFunc;
        public System.Windows.Forms.TextBox txtNomeFunc;
        public System.Windows.Forms.Label lblRgCliente;
        public System.Windows.Forms.Label lblDataNascCliente;
        public System.Windows.Forms.Label lblCPFCliente;
        public System.Windows.Forms.Label lblNomeCliente;
        public System.Windows.Forms.Label lblIdPermissao;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.MaskedTextBox txtPermissao;
        public System.Windows.Forms.MaskedTextBox txtUsuario;
        public System.Windows.Forms.MaskedTextBox txtSenha;
        public System.Windows.Forms.Label lblCargo;
        public System.Windows.Forms.TextBox txtCargo;
        public System.Windows.Forms.MaskedTextBox txtCelFunc;
        public System.Windows.Forms.MaskedTextBox txtTelFunc;
        public System.Windows.Forms.TextBox txtEmailFunc;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtCidadeFunc;
        public System.Windows.Forms.Label lblCidadeCliente;
        public System.Windows.Forms.TextBox txtBairroFunc;
        public System.Windows.Forms.TextBox txtEndFunc;
        public System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.Label lblEndCliente;
        public System.Windows.Forms.Label lblCelularCliente;
        public System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DateTimePicker txtDataNascFunc;
    }
}
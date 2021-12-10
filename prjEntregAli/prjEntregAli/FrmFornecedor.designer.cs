namespace prjEntregAli
{
    partial class FrmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            this.txtCNPJForn = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeForn = new System.Windows.Forms.TextBox();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtTelForn = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailForn = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCidadeForn = new System.Windows.Forms.TextBox();
            this.lblCidadeCliente = new System.Windows.Forms.Label();
            this.txtBairroForn = new System.Windows.Forms.TextBox();
            this.txtEndForn = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblEndCliente = new System.Windows.Forms.Label();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.Text = "CADASTRO FORNECEDOR";
            // 
            // btnSair2
            // 
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // txtCNPJForn
            // 
            this.txtCNPJForn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJForn.Location = new System.Drawing.Point(294, 101);
            this.txtCNPJForn.Mask = "00,000,000/0000-00";
            this.txtCNPJForn.Name = "txtCNPJForn";
            this.txtCNPJForn.Size = new System.Drawing.Size(151, 26);
            this.txtCNPJForn.TabIndex = 61;
            // 
            // txtNomeForn
            // 
            this.txtNomeForn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeForn.Location = new System.Drawing.Point(294, 58);
            this.txtNomeForn.Name = "txtNomeForn";
            this.txtNomeForn.Size = new System.Drawing.Size(334, 26);
            this.txtNomeForn.TabIndex = 60;
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCliente.Location = new System.Drawing.Point(206, 104);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(52, 20);
            this.lblCPFCliente.TabIndex = 55;
            this.lblCPFCliente.Text = "CNPJ:";
            this.lblCPFCliente.Click += new System.EventHandler(this.lblCPFCliente_Click);
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
            // txtTelForn
            // 
            this.txtTelForn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelForn.Location = new System.Drawing.Point(294, 185);
            this.txtTelForn.Name = "txtTelForn";
            this.txtTelForn.Size = new System.Drawing.Size(121, 26);
            this.txtTelForn.TabIndex = 64;
            // 
            // txtEmailForn
            // 
            this.txtEmailForn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailForn.Location = new System.Drawing.Point(294, 142);
            this.txtEmailForn.Name = "txtEmailForn";
            this.txtEmailForn.Size = new System.Drawing.Size(333, 26);
            this.txtEmailForn.TabIndex = 63;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(209, 148);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 20);
            this.lblEmail.TabIndex = 99;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtCidadeForn
            // 
            this.txtCidadeForn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidadeForn.Location = new System.Drawing.Point(496, 276);
            this.txtCidadeForn.Name = "txtCidadeForn";
            this.txtCidadeForn.Size = new System.Drawing.Size(147, 26);
            this.txtCidadeForn.TabIndex = 67;
            // 
            // lblCidadeCliente
            // 
            this.lblCidadeCliente.AutoSize = true;
            this.lblCidadeCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCliente.Location = new System.Drawing.Point(422, 279);
            this.lblCidadeCliente.Name = "lblCidadeCliente";
            this.lblCidadeCliente.Size = new System.Drawing.Size(68, 20);
            this.lblCidadeCliente.TabIndex = 97;
            this.lblCidadeCliente.Text = "Cidade:";
            // 
            // txtBairroForn
            // 
            this.txtBairroForn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroForn.Location = new System.Drawing.Point(294, 276);
            this.txtBairroForn.Name = "txtBairroForn";
            this.txtBairroForn.Size = new System.Drawing.Size(111, 26);
            this.txtBairroForn.TabIndex = 66;
            // 
            // txtEndForn
            // 
            this.txtEndForn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndForn.Location = new System.Drawing.Point(294, 229);
            this.txtEndForn.Name = "txtEndForn";
            this.txtEndForn.Size = new System.Drawing.Size(309, 26);
            this.txtEndForn.TabIndex = 65;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(206, 282);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 20);
            this.lblBairro.TabIndex = 94;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblEndCliente
            // 
            this.lblEndCliente.AutoSize = true;
            this.lblEndCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndCliente.Location = new System.Drawing.Point(206, 232);
            this.lblEndCliente.Name = "lblEndCliente";
            this.lblEndCliente.Size = new System.Drawing.Size(85, 20);
            this.lblEndCliente.TabIndex = 93;
            this.lblEndCliente.Text = "Endereço:";
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.Location = new System.Drawing.Point(206, 191);
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
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtTelForn);
            this.Controls.Add(this.txtEmailForn);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCidadeForn);
            this.Controls.Add(this.lblCidadeCliente);
            this.Controls.Add(this.txtBairroForn);
            this.Controls.Add(this.txtEndForn);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblEndCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.txtCNPJForn);
            this.Controls.Add(this.txtNomeForn);
            this.Controls.Add(this.lblCPFCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFornecedor";
            this.Text = "FrmFornecedor";
            this.Activated += new System.EventHandler(this.FrmFornecedor_Activated);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSair2, 0);
            this.Controls.SetChildIndex(this.lblNomeCliente, 0);
            this.Controls.SetChildIndex(this.lblCPFCliente, 0);
            this.Controls.SetChildIndex(this.txtNomeForn, 0);
            this.Controls.SetChildIndex(this.txtCNPJForn, 0);
            this.Controls.SetChildIndex(this.lblTelefoneCliente, 0);
            this.Controls.SetChildIndex(this.lblEndCliente, 0);
            this.Controls.SetChildIndex(this.lblBairro, 0);
            this.Controls.SetChildIndex(this.txtEndForn, 0);
            this.Controls.SetChildIndex(this.txtBairroForn, 0);
            this.Controls.SetChildIndex(this.lblCidadeCliente, 0);
            this.Controls.SetChildIndex(this.txtCidadeForn, 0);
            this.Controls.SetChildIndex(this.lblEmail, 0);
            this.Controls.SetChildIndex(this.txtEmailForn, 0);
            this.Controls.SetChildIndex(this.txtTelForn, 0);
            this.Controls.SetChildIndex(this.btnVoltar, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.MaskedTextBox txtCNPJForn;
        public System.Windows.Forms.TextBox txtNomeForn;
        public System.Windows.Forms.Label lblCPFCliente;
        public System.Windows.Forms.Label lblNomeCliente;
        public System.Windows.Forms.MaskedTextBox txtTelForn;
        public System.Windows.Forms.TextBox txtEmailForn;
        public System.Windows.Forms.Label lblEmail;
        public System.Windows.Forms.TextBox txtCidadeForn;
        public System.Windows.Forms.Label lblCidadeCliente;
        public System.Windows.Forms.TextBox txtBairroForn;
        public System.Windows.Forms.TextBox txtEndForn;
        public System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.Label lblEndCliente;
        public System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
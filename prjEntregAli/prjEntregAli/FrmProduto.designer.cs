namespace prjEntregAli
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.lblIDForn = new System.Windows.Forms.Label();
            this.lblIdCategoria = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.txtIDCategoria = new System.Windows.Forms.TextBox();
            this.txtIDForn = new System.Windows.Forms.TextBox();
            this.txtNomeForn = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtnumQtde = new System.Windows.Forms.NumericUpDown();
            this.lblQtde = new System.Windows.Forms.Label();
            this.txtNomecategoria = new System.Windows.Forms.ComboBox();
            this.cmbEstoque = new System.Windows.Forms.ComboBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumQtde)).BeginInit();
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
            this.btnDeletar.Visible = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Enabled = false;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.Visible = false;
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
            this.btnPesquisar.Visible = false;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatAppearance.BorderSize = 0;
            this.btnLimparCampos.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 406);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(347, 29);
            this.label1.Size = new System.Drawing.Size(204, 23);
            this.label1.Text = "CADASTRO PRODUTO";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1, 464);
            // 
            // btnSair2
            // 
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // txtMaterial
            // 
            this.txtMaterial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterial.Location = new System.Drawing.Point(266, 121);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(397, 27);
            this.txtMaterial.TabIndex = 58;
            this.toolTip1.SetToolTip(this.txtMaterial, "Duplo clique para listar");
            this.txtMaterial.DoubleClick += new System.EventHandler(this.txtMaterial_DoubleClick);
            // 
            // lblIDForn
            // 
            this.lblIDForn.AutoSize = true;
            this.lblIDForn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDForn.Location = new System.Drawing.Point(174, 239);
            this.lblIDForn.Name = "lblIDForn";
            this.lblIDForn.Size = new System.Drawing.Size(124, 21);
            this.lblIDForn.TabIndex = 56;
            this.lblIDForn.Text = "ID Fornecedor:";
            // 
            // lblIdCategoria
            // 
            this.lblIdCategoria.AutoSize = true;
            this.lblIdCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCategoria.Location = new System.Drawing.Point(174, 165);
            this.lblIdCategoria.Name = "lblIdCategoria";
            this.lblIdCategoria.Size = new System.Drawing.Size(164, 21);
            this.lblIdCategoria.TabIndex = 54;
            this.lblIdCategoria.Text = "Categoria Material:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(174, 121);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(79, 21);
            this.lblMaterial.TabIndex = 52;
            this.lblMaterial.Text = "Material:";
            // 
            // txtIDCategoria
            // 
            this.txtIDCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCategoria.Location = new System.Drawing.Point(361, 162);
            this.txtIDCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDCategoria.Name = "txtIDCategoria";
            this.txtIDCategoria.Size = new System.Drawing.Size(57, 27);
            this.txtIDCategoria.TabIndex = 61;
            this.toolTip1.SetToolTip(this.txtIDCategoria, "Dois cliques para buscar");
            this.txtIDCategoria.Visible = false;
            // 
            // txtIDForn
            // 
            this.txtIDForn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDForn.Location = new System.Drawing.Point(303, 239);
            this.txtIDForn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDForn.Name = "txtIDForn";
            this.txtIDForn.Size = new System.Drawing.Size(90, 27);
            this.txtIDForn.TabIndex = 62;
            this.toolTip1.SetToolTip(this.txtIDForn, "Dois cliques para buscar");
            this.txtIDForn.DoubleClick += new System.EventHandler(this.txtIDForn_DoubleClick);
            // 
            // txtNomeForn
            // 
            this.txtNomeForn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeForn.Location = new System.Drawing.Point(414, 239);
            this.txtNomeForn.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeForn.Name = "txtNomeForn";
            this.txtNomeForn.Size = new System.Drawing.Size(249, 27);
            this.txtNomeForn.TabIndex = 70;
            this.toolTip1.SetToolTip(this.txtNomeForn, "Dois cliques para buscar");
            this.txtNomeForn.DoubleClick += new System.EventHandler(this.txtIDForn_DoubleClick);
            // 
            // txtnumQtde
            // 
            this.txtnumQtde.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtnumQtde.Location = new System.Drawing.Point(568, 202);
            this.txtnumQtde.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.txtnumQtde.Name = "txtnumQtde";
            this.txtnumQtde.Size = new System.Drawing.Size(95, 27);
            this.txtnumQtde.TabIndex = 71;
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(450, 202);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(112, 21);
            this.lblQtde.TabIndex = 72;
            this.lblQtde.Text = "Quantidade:";
            // 
            // txtNomecategoria
            // 
            this.txtNomecategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtNomecategoria.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNomecategoria.FormattingEnabled = true;
            this.txtNomecategoria.Items.AddRange(new object[] {
            "Eletrônica",
            "Mecânica"});
            this.txtNomecategoria.Location = new System.Drawing.Point(435, 164);
            this.txtNomecategoria.Name = "txtNomecategoria";
            this.txtNomecategoria.Size = new System.Drawing.Size(228, 25);
            this.txtNomecategoria.TabIndex = 74;
            // 
            // cmbEstoque
            // 
            this.cmbEstoque.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstoque.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.cmbEstoque.FormattingEnabled = true;
            this.cmbEstoque.Location = new System.Drawing.Point(297, 202);
            this.cmbEstoque.Name = "cmbEstoque";
            this.cmbEstoque.Size = new System.Drawing.Size(121, 25);
            this.cmbEstoque.TabIndex = 75;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(214, 201);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(77, 21);
            this.lblEstoque.TabIndex = 76;
            this.lblEstoque.Text = "Estoque:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnVoltar.Location = new System.Drawing.Point(762, 338);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 32);
            this.btnVoltar.TabIndex = 77;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjEntregAli.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(1, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.cmbEstoque);
            this.Controls.Add(this.txtNomecategoria);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.txtnumQtde);
            this.Controls.Add(this.txtNomeForn);
            this.Controls.Add(this.txtIDForn);
            this.Controls.Add(this.txtIDCategoria);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.lblIDForn);
            this.Controls.Add(this.lblIdCategoria);
            this.Controls.Add(this.lblMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProduto";
            this.Text = "Produto";
            this.Activated += new System.EventHandler(this.FrmProduto_Activated);
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.Controls.SetChildIndex(this.lblMaterial, 0);
            this.Controls.SetChildIndex(this.lblIdCategoria, 0);
            this.Controls.SetChildIndex(this.lblIDForn, 0);
            this.Controls.SetChildIndex(this.txtMaterial, 0);
            this.Controls.SetChildIndex(this.txtIDCategoria, 0);
            this.Controls.SetChildIndex(this.txtIDForn, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSair2, 0);
            this.Controls.SetChildIndex(this.txtNomeForn, 0);
            this.Controls.SetChildIndex(this.txtnumQtde, 0);
            this.Controls.SetChildIndex(this.lblQtde, 0);
            this.Controls.SetChildIndex(this.txtNomecategoria, 0);
            this.Controls.SetChildIndex(this.cmbEstoque, 0);
            this.Controls.SetChildIndex(this.lblEstoque, 0);
            this.Controls.SetChildIndex(this.btnVoltar, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtMaterial;
        public System.Windows.Forms.Label lblIDForn;
        public System.Windows.Forms.Label lblIdCategoria;
        public System.Windows.Forms.Label lblMaterial;
        public System.Windows.Forms.TextBox txtIDCategoria;
        public System.Windows.Forms.TextBox txtIDForn;
        public System.Windows.Forms.TextBox txtNomeForn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown txtnumQtde;
        public System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.ComboBox txtNomecategoria;
        private System.Windows.Forms.ComboBox cmbEstoque;
        public System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
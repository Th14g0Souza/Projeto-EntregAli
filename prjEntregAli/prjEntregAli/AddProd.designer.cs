namespace prjEntregAli
{
    partial class AddProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProd));
            this.txtIdProdutoAddProd = new System.Windows.Forms.TextBox();
            this.lblIdProd = new System.Windows.Forms.Label();
            this.txtQuantAddProd = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDescrProd = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
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
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.TabIndex = 5;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.TabIndex = 6;
            // 
            // btnPri
            // 
            this.btnPri.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPri.FlatAppearance.BorderSize = 0;
            this.btnPri.TabIndex = 9;
            // 
            // btnAnt
            // 
            this.btnAnt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnt.FlatAppearance.BorderSize = 0;
            this.btnAnt.TabIndex = 10;
            // 
            // btnDep
            // 
            this.btnDep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDep.FlatAppearance.BorderSize = 0;
            this.btnDep.TabIndex = 11;
            // 
            // btnUlt
            // 
            this.btnUlt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUlt.FlatAppearance.BorderSize = 0;
            this.btnUlt.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.Size = new System.Drawing.Size(92, 54);
            this.btnPesquisar.TabIndex = 8;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.FlatAppearance.BorderSize = 0;
            this.btnLimparCampos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(317, 48);
            this.label1.Size = new System.Drawing.Size(210, 23);
            this.label1.Text = "ADICIONAR PRODUTO";
            // 
            // btnSair2
            // 
            this.btnSair2.TabIndex = 13;
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // txtIdProdutoAddProd
            // 
            this.txtIdProdutoAddProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProdutoAddProd.Location = new System.Drawing.Point(225, 142);
            this.txtIdProdutoAddProd.Name = "txtIdProdutoAddProd";
            this.txtIdProdutoAddProd.Size = new System.Drawing.Size(100, 27);
            this.txtIdProdutoAddProd.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtIdProdutoAddProd, "Dois cliques para selecionar o produto");
            this.txtIdProdutoAddProd.TextChanged += new System.EventHandler(this.txtIdProdutoAddProd_TextChanged);
            this.txtIdProdutoAddProd.DoubleClick += new System.EventHandler(this.txtIdProdutoAddProd_DoubleClick);
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProd.Location = new System.Drawing.Point(109, 148);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(97, 21);
            this.lblIdProd.TabIndex = 16;
            this.lblIdProd.Text = "ID Produto:";
            this.toolTip1.SetToolTip(this.lblIdProd, "Dois cliques na caixa de texto para selecionar o produto");
            // 
            // txtQuantAddProd
            // 
            this.txtQuantAddProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantAddProd.Location = new System.Drawing.Point(225, 187);
            this.txtQuantAddProd.Name = "txtQuantAddProd";
            this.txtQuantAddProd.Size = new System.Drawing.Size(100, 27);
            this.txtQuantAddProd.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtQuantAddProd, "Apenas números");
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(109, 193);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(112, 21);
            this.lblQuantidade.TabIndex = 13;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // txtDescrProd
            // 
            this.txtDescrProd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrProd.Location = new System.Drawing.Point(364, 142);
            this.txtDescrProd.Name = "txtDescrProd";
            this.txtDescrProd.Size = new System.Drawing.Size(390, 27);
            this.txtDescrProd.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtDescrProd, "Dois cliques para selecionar o produto");
            this.txtDescrProd.TextChanged += new System.EventHandler(this.txtDescrProd_TextChanged);
            this.txtDescrProd.DoubleClick += new System.EventHandler(this.txtDescrProd_DoubleClick);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(360, 118);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(87, 21);
            this.lblDescricao.TabIndex = 18;
            this.lblDescricao.Text = "Descrição";
            this.toolTip1.SetToolTip(this.lblDescricao, "Dois cliques na caixa de texto para selecionar o produto");
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.btnVoltar.Location = new System.Drawing.Point(630, 346);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(84, 32);
            this.btnVoltar.TabIndex = 105;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prjEntregAli.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // AddProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtDescrProd);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtIdProdutoAddProd);
            this.Controls.Add(this.lblIdProd);
            this.Controls.Add(this.txtQuantAddProd);
            this.Controls.Add(this.lblQuantidade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProd";
            this.Text = "AddProd";
            this.Activated += new System.EventHandler(this.AddProd_Activated);
            this.Load += new System.EventHandler(this.AddProd_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSair2, 0);
            this.Controls.SetChildIndex(this.lblQuantidade, 0);
            this.Controls.SetChildIndex(this.txtQuantAddProd, 0);
            this.Controls.SetChildIndex(this.lblIdProd, 0);
            this.Controls.SetChildIndex(this.txtIdProdutoAddProd, 0);
            this.Controls.SetChildIndex(this.lblDescricao, 0);
            this.Controls.SetChildIndex(this.txtDescrProd, 0);
            this.Controls.SetChildIndex(this.btnVoltar, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtIdProdutoAddProd;
        public System.Windows.Forms.Label lblIdProd;
        public System.Windows.Forms.TextBox txtQuantAddProd;
        public System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox txtDescrProd;
        public System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
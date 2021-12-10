
namespace prjEntregAli
{
    partial class FrmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoque));
            this.txtEstoqueAtivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridEstoque = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoMat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocalizarProd = new System.Windows.Forms.TextBox();
            this.comboFiltro = new System.Windows.Forms.ComboBox();
            this.btnPesquisaMat = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstoqueAtivo
            // 
            this.txtEstoqueAtivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtEstoqueAtivo.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.txtEstoqueAtivo.FormattingEnabled = true;
            this.txtEstoqueAtivo.Items.AddRange(new object[] {
            "Estoque X",
            "Estoque Y",
            "Estoque Z"});
            this.txtEstoqueAtivo.Location = new System.Drawing.Point(12, 123);
            this.txtEstoqueAtivo.Name = "txtEstoqueAtivo";
            this.txtEstoqueAtivo.Size = new System.Drawing.Size(121, 24);
            this.txtEstoqueAtivo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estoque selecionado:";
            // 
            // GridEstoque
            // 
            this.GridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridEstoque.Location = new System.Drawing.Point(56, 162);
            this.GridEstoque.Name = "GridEstoque";
            this.GridEstoque.Size = new System.Drawing.Size(642, 233);
            this.GridEstoque.TabIndex = 2;
            this.GridEstoque.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEstoque_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(282, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Visualização de Estoque";
            // 
            // txtTipoMat
            // 
            this.txtTipoMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoMat.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.txtTipoMat.FormattingEnabled = true;
            this.txtTipoMat.Items.AddRange(new object[] {
            "Eletrônica",
            "Mecânica"});
            this.txtTipoMat.Location = new System.Drawing.Point(224, 124);
            this.txtTipoMat.Name = "txtTipoMat";
            this.txtTipoMat.Size = new System.Drawing.Size(90, 24);
            this.txtTipoMat.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.label3.Location = new System.Drawing.Point(183, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.label4.Location = new System.Drawing.Point(351, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Filtro:";
            // 
            // txtLocalizarProd
            // 
            this.txtLocalizarProd.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.txtLocalizarProd.Location = new System.Drawing.Point(578, 124);
            this.txtLocalizarProd.Name = "txtLocalizarProd";
            this.txtLocalizarProd.Size = new System.Drawing.Size(179, 21);
            this.txtLocalizarProd.TabIndex = 28;
            // 
            // comboFiltro
            // 
            this.comboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFiltro.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.comboFiltro.FormattingEnabled = true;
            this.comboFiltro.Location = new System.Drawing.Point(397, 123);
            this.comboFiltro.Name = "comboFiltro";
            this.comboFiltro.Size = new System.Drawing.Size(121, 24);
            this.comboFiltro.TabIndex = 27;
            this.comboFiltro.SelectedIndexChanged += new System.EventHandler(this.comboFiltro_SelectedIndexChanged);
            // 
            // btnPesquisaMat
            // 
            this.btnPesquisaMat.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnPesquisaMat.Location = new System.Drawing.Point(341, 420);
            this.btnPesquisaMat.Name = "btnPesquisaMat";
            this.btnPesquisaMat.Size = new System.Drawing.Size(123, 37);
            this.btnPesquisaMat.TabIndex = 32;
            this.btnPesquisaMat.Text = "Pesquisar";
            this.btnPesquisaMat.UseVisualStyleBackColor = false;
            this.btnPesquisaMat.Click += new System.EventHandler(this.btnPesquisaMat_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.btnMaterial.Location = new System.Drawing.Point(12, 37);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(106, 43);
            this.btnMaterial.TabIndex = 33;
            this.btnMaterial.Text = "Inserir Material";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.btnCliente.Location = new System.Drawing.Point(519, 37);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(112, 43);
            this.btnCliente.TabIndex = 34;
            this.btnCliente.Text = "Cadastrar Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.btnFornecedor.Location = new System.Drawing.Point(637, 37);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(151, 43);
            this.btnFornecedor.TabIndex = 36;
            this.btnFornecedor.Text = "Cadastrar Fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.btnFuncionario.Location = new System.Drawing.Point(128, 37);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(121, 43);
            this.btnFuncionario.TabIndex = 35;
            this.btnFuncionario.Text = "Cadastrar Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(539, 420);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(123, 37);
            this.btnPedido.TabIndex = 37;
            this.btnPedido.Text = "Fazer pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 8.5F);
            this.lblTotal.Location = new System.Drawing.Point(4, 420);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 17);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Total em estoque:  ";
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnFornecedor);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnMaterial);
            this.Controls.Add(this.btnPesquisaMat);
            this.Controls.Add(this.txtTipoMat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLocalizarProd);
            this.Controls.Add(this.comboFiltro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GridEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstoqueAtivo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEstoque_FormClosing);
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtEstoqueAtivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridEstoque;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox txtTipoMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLocalizarProd;
        private System.Windows.Forms.ComboBox comboFiltro;
        private System.Windows.Forms.Button btnPesquisaMat;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Label lblTotal;
    }
}
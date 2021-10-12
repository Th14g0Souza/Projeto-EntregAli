namespace prjEntregAli
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.lblStatusPedido = new System.Windows.Forms.Label();
            this.txtDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.txtDataPed = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.DataPed = new System.Windows.Forms.Label();
            this.lblIdFuncPed = new System.Windows.Forms.Label();
            this.lblIdCliPed = new System.Windows.Forms.Label();
            this.dataProduto = new System.Windows.Forms.DataGridView();
            this.btnAddMat = new System.Windows.Forms.Button();
            this.btnFinalPed = new System.Windows.Forms.Button();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.txtcli = new System.Windows.Forms.TextBox();
            this.txtfunc = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtIdCliPed = new System.Windows.Forms.ComboBox();
            this.txtIdFuncPed = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
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
            this.label1.Location = new System.Drawing.Point(342, 18);
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.Text = "REGISTRAR PEDIDO";
            // 
            // btnSair2
            // 
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // lblStatusPedido
            // 
            this.lblStatusPedido.AutoSize = true;
            this.lblStatusPedido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusPedido.Location = new System.Drawing.Point(57, 150);
            this.lblStatusPedido.Name = "lblStatusPedido";
            this.lblStatusPedido.Size = new System.Drawing.Size(54, 19);
            this.lblStatusPedido.TabIndex = 40;
            this.lblStatusPedido.Text = "Status:";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega.Location = new System.Drawing.Point(422, 192);
            this.txtDataEntrega.Mask = "00/00/0000";
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(100, 24);
            this.txtDataEntrega.TabIndex = 39;
            this.txtDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // txtDataPed
            // 
            this.txtDataPed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPed.Location = new System.Drawing.Point(422, 147);
            this.txtDataPed.Mask = "00/00/0000";
            this.txtDataPed.Name = "txtDataPed";
            this.txtDataPed.Size = new System.Drawing.Size(100, 24);
            this.txtDataPed.TabIndex = 38;
            this.txtDataPed.ValidatingType = typeof(System.DateTime);
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrega.Location = new System.Drawing.Point(283, 197);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(129, 19);
            this.lblDataEntrega.TabIndex = 34;
            this.lblDataEntrega.Text = "Data de Entrega:";
            // 
            // DataPed
            // 
            this.DataPed.AutoSize = true;
            this.DataPed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataPed.Location = new System.Drawing.Point(288, 147);
            this.DataPed.Name = "DataPed";
            this.DataPed.Size = new System.Drawing.Size(124, 19);
            this.DataPed.TabIndex = 33;
            this.DataPed.Text = "Data do Pedido:";
            // 
            // lblIdFuncPed
            // 
            this.lblIdFuncPed.AutoSize = true;
            this.lblIdFuncPed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdFuncPed.Location = new System.Drawing.Point(32, 108);
            this.lblIdFuncPed.Name = "lblIdFuncPed";
            this.lblIdFuncPed.Size = new System.Drawing.Size(111, 19);
            this.lblIdFuncPed.TabIndex = 32;
            this.lblIdFuncPed.Text = "ID Funcionário:";
            // 
            // lblIdCliPed
            // 
            this.lblIdCliPed.AutoSize = true;
            this.lblIdCliPed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliPed.Location = new System.Drawing.Point(32, 64);
            this.lblIdCliPed.Name = "lblIdCliPed";
            this.lblIdCliPed.Size = new System.Drawing.Size(79, 19);
            this.lblIdCliPed.TabIndex = 31;
            this.lblIdCliPed.Text = "ID Cliente:";
            // 
            // dataProduto
            // 
            this.dataProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduto.Location = new System.Drawing.Point(562, 62);
            this.dataProduto.Name = "dataProduto";
            this.dataProduto.Size = new System.Drawing.Size(270, 245);
            this.dataProduto.TabIndex = 44;
            this.toolTip1.SetToolTip(this.dataProduto, "Produtos selecionados");
            // 
            // btnAddMat
            // 
            this.btnAddMat.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMat.Location = new System.Drawing.Point(61, 271);
            this.btnAddMat.Name = "btnAddMat";
            this.btnAddMat.Size = new System.Drawing.Size(156, 36);
            this.btnAddMat.TabIndex = 42;
            this.btnAddMat.Text = "Adicionar Material";
            this.btnAddMat.UseVisualStyleBackColor = true;
            this.btnAddMat.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnFinalPed
            // 
            this.btnFinalPed.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnFinalPed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalPed.Location = new System.Drawing.Point(292, 271);
            this.btnFinalPed.Name = "btnFinalPed";
            this.btnFinalPed.Size = new System.Drawing.Size(75, 36);
            this.btnFinalPed.TabIndex = 46;
            this.btnFinalPed.Text = "Finalizar";
            this.btnFinalPed.UseVisualStyleBackColor = false;
            this.btnFinalPed.Click += new System.EventHandler(this.btnFinalPed_Click);
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Incompleto",
            "Faturado"});
            this.comboStatus.Location = new System.Drawing.Point(132, 147);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(121, 27);
            this.comboStatus.TabIndex = 49;
            // 
            // txtcli
            // 
            this.txtcli.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcli.Location = new System.Drawing.Point(292, 63);
            this.txtcli.Name = "txtcli";
            this.txtcli.Size = new System.Drawing.Size(230, 26);
            this.txtcli.TabIndex = 52;
            this.toolTip1.SetToolTip(this.txtcli, "Insira o ID antes");
            // 
            // txtfunc
            // 
            this.txtfunc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfunc.Location = new System.Drawing.Point(292, 103);
            this.txtfunc.Name = "txtfunc";
            this.txtfunc.Size = new System.Drawing.Size(230, 26);
            this.txtfunc.TabIndex = 53;
            this.toolTip1.SetToolTip(this.txtfunc, "Insira o ID antes");
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(438, 271);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(66, 36);
            this.btnVoltar.TabIndex = 54;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtIdCliPed
            // 
            this.txtIdCliPed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtIdCliPed.FormattingEnabled = true;
            this.txtIdCliPed.Location = new System.Drawing.Point(149, 62);
            this.txtIdCliPed.Name = "txtIdCliPed";
            this.txtIdCliPed.Size = new System.Drawing.Size(100, 25);
            this.txtIdCliPed.TabIndex = 55;
            this.txtIdCliPed.SelectedIndexChanged += new System.EventHandler(this.txtIdCliPed_SelectedIndexChanged);
            // 
            // txtIdFuncPed
            // 
            this.txtIdFuncPed.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtIdFuncPed.FormattingEnabled = true;
            this.txtIdFuncPed.Location = new System.Drawing.Point(149, 103);
            this.txtIdFuncPed.Name = "txtIdFuncPed";
            this.txtIdFuncPed.Size = new System.Drawing.Size(100, 25);
            this.txtIdFuncPed.TabIndex = 56;
            this.txtIdFuncPed.SelectedIndexChanged += new System.EventHandler(this.txtIdFuncPed_SelectedIndexChanged);
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 496);
            this.Controls.Add(this.txtIdFuncPed);
            this.Controls.Add(this.txtIdCliPed);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtfunc);
            this.Controls.Add(this.txtcli);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.btnFinalPed);
            this.Controls.Add(this.dataProduto);
            this.Controls.Add(this.btnAddMat);
            this.Controls.Add(this.lblStatusPedido);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.txtDataPed);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.DataPed);
            this.Controls.Add(this.lblIdFuncPed);
            this.Controls.Add(this.lblIdCliPed);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Activated += new System.EventHandler(this.FrmPedido_Activated);
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.Shown += new System.EventHandler(this.FrmPedido_Shown);
            this.Controls.SetChildIndex(this.lblIdCliPed, 0);
            this.Controls.SetChildIndex(this.lblIdFuncPed, 0);
            this.Controls.SetChildIndex(this.DataPed, 0);
            this.Controls.SetChildIndex(this.lblDataEntrega, 0);
            this.Controls.SetChildIndex(this.txtDataPed, 0);
            this.Controls.SetChildIndex(this.txtDataEntrega, 0);
            this.Controls.SetChildIndex(this.lblStatusPedido, 0);
            this.Controls.SetChildIndex(this.btnAddMat, 0);
            this.Controls.SetChildIndex(this.dataProduto, 0);
            this.Controls.SetChildIndex(this.btnFinalPed, 0);
            this.Controls.SetChildIndex(this.comboStatus, 0);
            this.Controls.SetChildIndex(this.txtcli, 0);
            this.Controls.SetChildIndex(this.txtfunc, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.btnSair2, 0);
            this.Controls.SetChildIndex(this.btnVoltar, 0);
            this.Controls.SetChildIndex(this.txtIdCliPed, 0);
            this.Controls.SetChildIndex(this.txtIdFuncPed, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatusPedido;
        public System.Windows.Forms.MaskedTextBox txtDataEntrega;
        public System.Windows.Forms.MaskedTextBox txtDataPed;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.Label DataPed;
        private System.Windows.Forms.Label lblIdFuncPed;
        private System.Windows.Forms.Label lblIdCliPed;
        public System.Windows.Forms.DataGridView dataProduto;
        private System.Windows.Forms.Button btnAddMat;
        private System.Windows.Forms.Button btnFinalPed;
        public System.Windows.Forms.ComboBox comboStatus;
        public System.Windows.Forms.TextBox txtcli;
        public System.Windows.Forms.TextBox txtfunc;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnVoltar;
        public System.Windows.Forms.ComboBox txtIdCliPed;
        public System.Windows.Forms.ComboBox txtIdFuncPed;
    }
}
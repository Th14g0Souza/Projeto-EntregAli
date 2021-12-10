namespace prjEntregAli
{
    partial class LocalizarGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalizarGeral));
            this.btnPesquiLoca = new System.Windows.Forms.Button();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.GridLocalizar = new System.Windows.Forms.DataGridView();
            this.comboLocalizar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridLocalizar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquiLoca
            // 
            this.btnPesquiLoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquiLoca.Location = new System.Drawing.Point(324, 83);
            this.btnPesquiLoca.Name = "btnPesquiLoca";
            this.btnPesquiLoca.Size = new System.Drawing.Size(90, 23);
            this.btnPesquiLoca.TabIndex = 7;
            this.btnPesquiLoca.Text = "Pesquisar";
            this.btnPesquiLoca.UseVisualStyleBackColor = true;
            this.btnPesquiLoca.Click += new System.EventHandler(this.btnPesquiLoca_Click);
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalizar.Location = new System.Drawing.Point(93, 54);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(321, 22);
            this.txtLocalizar.TabIndex = 6;
            // 
            // GridLocalizar
            // 
            this.GridLocalizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLocalizar.Location = new System.Drawing.Point(12, 112);
            this.GridLocalizar.Name = "GridLocalizar";
            this.GridLocalizar.Size = new System.Drawing.Size(402, 171);
            this.GridLocalizar.TabIndex = 5;
            this.GridLocalizar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLocalizar_CellDoubleClick);
            // 
            // comboLocalizar
            // 
            this.comboLocalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLocalizar.FormattingEnabled = true;
            this.comboLocalizar.Location = new System.Drawing.Point(167, 82);
            this.comboLocalizar.Name = "comboLocalizar";
            this.comboLocalizar.Size = new System.Drawing.Size(151, 24);
            this.comboLocalizar.TabIndex = 4;
            this.comboLocalizar.SelectedIndexChanged += new System.EventHandler(this.comboLocalizar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtro:";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Buscar para selecionar o ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Procurar ID para selecionar informações:";
            // 
            // LocalizarGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 295);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquiLoca);
            this.Controls.Add(this.txtLocalizar);
            this.Controls.Add(this.GridLocalizar);
            this.Controls.Add(this.comboLocalizar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LocalizarGeral";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LocalizarGeral_FormClosed);
            this.Load += new System.EventHandler(this.LocalizarGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLocalizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquiLoca;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.DataGridView GridLocalizar;
        private System.Windows.Forms.ComboBox comboLocalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEntregAli
{
    public partial class AddProd : FrmCadastrarGeral
    {
        private ClasseConexao con = new ClasseConexao();
        DataTable dt = new DataTable();
        SetandGet sg = new SetandGet();

        public AddProd()
        {
            InitializeComponent();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        { // MICROSOFT | BLOQUEIA O FECHAMENTO POR ALT+F4
            if (keyData == (Keys.Alt | Keys.F4)) //ou com um |  é binário
                return true;
            else
                return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        { // MICROSOFT | TROCA TAB POR ENTER
            if (keyData == Keys.Enter)
            {
                this.ProcessTabKey(true);
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

        }
        private void txtIdProdutoAddProd_DoubleClick(object sender, EventArgs e)
        {
            sg.Set_AddProd("AddProd");
            String[] paramtblMaterial = new String[5];
            paramtblMaterial[0] = "tblMaterial";
            paramtblMaterial[1] = "idMaterial";
            paramtblMaterial[2] = "nome_material";
            paramtblMaterial[3] = "quantidade";
            paramtblMaterial[4] = "id_categoria";
            sg.Set_ArrayParam(paramtblMaterial);

            String[] combotblMaterial = new String[4];
            combotblMaterial[0] = "Código Material";
            combotblMaterial[1] = "Material";
            combotblMaterial[2] = "Quantidade";
            combotblMaterial[3] = "ID Categoria";
            sg.Set_ArrayCombo(combotblMaterial);

            FrmEstoque est = new FrmEstoque();
            est.ShowDialog();
        }


        private void Cadastrar()
        {
            try
            {
                
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select quantidade from tblMaterial where idMaterial = " + sg.Get_prod());
                int qtde = int.Parse(dt.Rows[0]["quantidade"].ToString());

                if (int.Parse(txtQuantAddProd.Text) > qtde)
                {
                    throw new Exception("Quantidade além do disponível em estoque");
                }
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("insert into tblDetalhePed  values (" + sg.Get_id() + ", " + txtIdProdutoAddProd.Text + "," + txtQuantAddProd.Text + ")");
                sg.Set_prodadicionado("add");

                MessageBox.Show("Material adicionado");
            } catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }


        private void btnSair2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            sg.Set_prod(txtIdProdutoAddProd.Text);
            Cadastrar();
            this.Close();
        }

        private void AddProd_Load(object sender, EventArgs e)
        {
            sg.Set_prodadicionado("");
        }

        private void AddProd_Activated(object sender, EventArgs e)
        {
            if (sg.Get_prod() != null && sg.Get_prod() != "")
            {
                txtIdProdutoAddProd.Text = sg.Get_prod();
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        private void txtDescrProd_TextChanged(object sender, EventArgs e)
        {
            /*dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql("select idMaterial from tblCliente where idMaterial = " + txtIdProdutoAddProd.Text);

            txtIdProdutoAddProd.Text = dt.Rows[0]["nome_material"].ToString();
        */}

        private void txtDescrProd_DoubleClick(object sender, EventArgs e)
        {
            sg.Set_AddProd("AddProd");
            String[] paramtblMaterial = new String[5];
            paramtblMaterial[0] = "tblMaterial";
            paramtblMaterial[1] = "idMaterial";
            paramtblMaterial[2] = "nome_material";
            paramtblMaterial[3] = "quantidade";
            paramtblMaterial[4] = "id_categoria";
            sg.Set_ArrayParam(paramtblMaterial);

            String[] combotblMaterial = new String[4];
            combotblMaterial[0] = "Código Material";
            combotblMaterial[1] = "Material";
            combotblMaterial[2] = "Quantidade";
            combotblMaterial[3] = "ID Categoria";
            sg.Set_ArrayCombo(combotblMaterial);

            FrmEstoque est = new FrmEstoque();
            est.ShowDialog();
        }

        private void txtIdProdutoAddProd_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProdutoAddProd.Text != "")
            { 
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql("select nome_material from tblMaterial where idMaterial = " + txtIdProdutoAddProd.Text);

            if (dt == null || dt.Rows.Count <= 0)
            {
                txtDescrProd.Text = "";
            }
            else
            {
                txtDescrProd.Text = dt.Rows[0]["nome_material"].ToString();
            }

            } else
            {
                txtDescrProd.Text = "";
            }
        }
    }
}

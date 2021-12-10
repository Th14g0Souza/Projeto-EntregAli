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
    public partial class FrmProduto : FrmCadastrarGeral
    {
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();
        SetandGet sg = new SetandGet();
        int pos;
        int maxlinha;
        String del;
        public FrmProduto()
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

        private void Permissoes(int nivel)
        {
            if (nivel == 1)//gerente
            {
                btnDeletar.Enabled = true;
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = true;
            }
            if (nivel == 2)//colaborador/comprador
            {
                btnDeletar.Enabled = false;
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
            }
            if (nivel == 3)//funcionário
            {
                btnDeletar.Enabled = false;
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        private bool checarvazio()
        {
            bool valid = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        valid = true;
                        break;
                    }
                    else
                    {
                        valid = false;
                    }
                }
            }
            return valid;
        }

        private void CadastrarProd()
        {
            try
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select id_categoria from tblCategoria where descr_material = '" + txtNomecategoria.Text + "'");
                string idcat = dt.Rows[0]["id_categoria"].ToString();

                dt = new DataTable();
                con = new ClasseConexao();
                //cmbEstoque.Text = "aaaaaaaaaaaaaaaaaa";
                dt = con.executa_sql("select idEstoque from tblEstoque where nome_estoque = '" + cmbEstoque.Text + "'");
                string idest = dt.Rows[0]["idEstoque"].ToString();

                if (txtMaterial.Text != null || int.Parse(txtnumQtde.Text) > 0 || txtIDForn.Text == "")
                {
                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("select idMaterial from tblMaterial where nome_material = '" + txtMaterial.Text + "'");

                    if (dt.Rows.Count > 0)
                    {
                        dt = new DataTable();
                        con = new ClasseConexao();
                        dt = con.executa_sql("update tblMaterial set quantidade = quantidade + "+ int.Parse(txtnumQtde.Text) +",id_categoria = "+ idcat + ",idEstoque = " + idest + " where nome_material = '" + txtMaterial.Text + "'");
                    }
                    else
                    {
                        dt = new DataTable();
                        con = new ClasseConexao();
                        dt = con.executa_sql("insert into tblMaterial values('" + txtMaterial.Text + "'," + int.Parse(txtnumQtde.Text) + "," + idcat + "," + idest + "," + int.Parse(txtIDForn.Text) + ")");
                    }
                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("update tblEstoque set quant_total = quant_total + " + int.Parse(txtnumQtde.Text) + "where idEstoque = " + idest);

                    MessageBox.Show("Dados inseridos com sucesso.");
                }
                else {
                    MessageBox.Show("Insira todos os dados.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        private void MostrarMaterial(int pos)
        {
            try
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select * from tblMaterial");
                del = (dt.Rows[pos]["idMaterial"]).ToString();
                txtMaterial.Text = (dt.Rows[pos]["nome_material"]).ToString();
                txtIDCategoria.Text = (dt.Rows[pos]["id_categoria"]).ToString();
                txtIDForn.Text = (dt.Rows[pos]["id_forn"]).ToString();

                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select descr_material from tblCategoria where id_categoria = " + txtIDCategoria.Text + "");
                txtNomecategoria.Text = dt.Rows[0][0].ToString();
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select nome_forn from tblFornecedor where id_forn = " + txtIDForn.Text + "");
                txtNomeForn.Text = dt.Rows[0][0].ToString();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        private void Max()
        {
            try
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select * from tblMaterial");
                maxlinha = dt.Rows.Count;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        private void LimparMat()
        {
            txtMaterial.Text = "";
            txtIDCategoria.Text = "";
            txtIDForn.Text = "";
            sg.Set_cat("");
            txtNomecategoria.SelectedItem = null;
            txtNomeForn.Text = "";
            cmbEstoque.SelectedItem = null;
            txtnumQtde.Value = 0;
        }

        private void Deletar()
        {



            if (sg.Get_formulario() == "Feito")
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("Select * from tblDetalhePed where idMaterial=" + sg.Get_excluir() + "");

                if (dt.Rows.Count == 0)
                {

                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("delete from tblMaterial where idMaterial=" + sg.Get_excluir() + "");
                    MessageBox.Show("Operação executada com sucesso.");
                    sg.Set_formulario("");
                    sg.Set_excluir("");
                }

                else
                {
                    MessageBox.Show("Operação não pode ser executada, pois Produto está cadastrado em um Pedido.");
                    sg.Set_formulario("");
                    sg.Set_excluir("");
                }
            }

            else
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("Select * from tblDetalhePed where id_prod=" + del + "");

                if (dt.Rows.Count == 0)
                {

                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("delete from tblMaterial where idMaterial=" + del + "");
                    MessageBox.Show("Operação executada com sucesso.");

                }

                else
                {
                    MessageBox.Show("Operação não pode ser executada, pois Produto está cadastrado em um Pedido.");

                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarProd();
            LimparMat();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparMat();
        }

        private void btnPri_Click(object sender, EventArgs e)
        {
            pos = 0;
            MostrarMaterial(pos);
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos < 0)
            {
                pos = 0;
            }
            MostrarMaterial(pos);
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            Max();
            pos++;
            if (pos > (maxlinha - 1))
            {
                pos = maxlinha - 1;
            }
            MostrarMaterial(pos);
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            Max();
            pos = maxlinha - 1;
            MostrarMaterial(pos);
        }


        private void btnSair2_Click(object sender, EventArgs e)
        {
            sg.Set_cat(""); 
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Deletar();
            LimparMat();
        }

        private void txtIDForn_DoubleClick(object sender, EventArgs e)
        {
            String[] paramtblFornecedor = new String[9];
            paramtblFornecedor[0] = "tblFornecedor";
            paramtblFornecedor[1] = "id_forn";
            paramtblFornecedor[2] = "nome_forn";
            paramtblFornecedor[3] = "CNPJ";
            paramtblFornecedor[4] = "endereco";
            //paramtblFornecedor[5] = "pais";
            paramtblFornecedor[5] = "bairro";
            paramtblFornecedor[6] = "cidade";
            //paramtblFornecedor[8] = "CEP";
            paramtblFornecedor[7] = "telefone";
            paramtblFornecedor[8] = "email";
            //paramtblFornecedor[11] = "responsavel";
            //paramtblFornecedor[12] = "CNPJ";
            sg.Set_ArrayParam(paramtblFornecedor);

            String[] combotblFornecedor = new String[8];
            combotblFornecedor[0] = "Código Fornecedor";
            combotblFornecedor[1] = "Nome/Razão";
            combotblFornecedor[2] = "CNPJ";
            combotblFornecedor[3] = "Endereço";
            combotblFornecedor[4] = "Bairro";
            combotblFornecedor[5] = "Cidade";
            //combotblFornecedor[4] = "País";
            //combotblFornecedor[7] = "CEP";
            combotblFornecedor[6] = "Telefone";
            combotblFornecedor[7] = "E-mail";
            //combotblFornecedor[10] = "Responsável";
            //combotblFornecedor[11] = "CNPJ";
            sg.Set_ArrayCombo(combotblFornecedor);
            sg.Set_CondFornProd("AddForn");
            LocalizarGeral lg = new LocalizarGeral();
            lg.ShowDialog();
            //this.Hide();
        }
        
        private void FrmProduto_Activated(object sender, EventArgs e)
        {
            try
            {
                if (sg.Get_prod() != null && sg.Get_prod() != "")
                {
                    txtMaterial.Text = sg.Get_prod();
                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("select descr_material from tblCategoria where id_categoria = " + sg.Get_cat() + "");
                    txtNomecategoria.SelectedItem = dt.Rows[0][0].ToString();
                    txtIDCategoria.Text = sg.Get_cat();
                    cmbEstoque.SelectedItem = sg.Get_Estoque();
                }

                if (sg.Get_forn() != null && sg.Get_forn() != "")
                //if (sg.Get_CondFornProd() != null && sg.Get_CondFornProd() != "")
                {
                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("select nome_forn from tblFornecedor where id_forn = " + sg.Get_forn() + "");
                    txtNomeForn.Text = dt.Rows[0][0].ToString();
                    txtIDForn.Text = sg.Get_forn();
                    //cmbEstoque.SelectedItem = sg.Get_Estoque(); 
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            Permissoes(int.Parse(sg.Getpermissao()));

            dt = new DataTable();
            con = new ClasseConexao();

            dt = con.executa_sql("SELECT idEstoque, count(*) as _count FROM tblMaterial GROUP BY idEstoque ORDER BY _count desc");
            int maioria = int.Parse(dt.Rows[0]["idEstoque"].ToString());

            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql("select nome_estoque from tblEstoque");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbEstoque.Items.Add(dt.Rows[i]["nome_estoque"]);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmEstoque est = new FrmEstoque();
            this.Hide();
            est.Show();

        }

        private void txtMaterial_DoubleClick(object sender, EventArgs e)
        {
            sg.Set_AddProd("Add");
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
    }
}

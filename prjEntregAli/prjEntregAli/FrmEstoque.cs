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
    public partial class FrmEstoque : Form
    {
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();
        SetandGet tb = new SetandGet();
        String cmbDados;
        int i;

        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void Permissoes(int nivel)
        {
            if (nivel == 1)//gerente
            {
                btnFuncionario.Enabled = true;
                //btnFornecedor.Enabled = true;
                btnMaterial.Enabled = true;
                btnCliente.Enabled = true;

            }
            if (nivel == 2)//colaborador/comprador
            {
                btnFuncionario.Enabled = false;
                //btnFornecedor.Enabled = true;
                btnMaterial.Enabled = true;
                btnCliente.Enabled = true;
            }
            if (nivel == 3)//funcionário
            {
                btnFuncionario.Enabled = false;
                //btnFornecedor.Enabled = false;
                btnMaterial.Enabled = false;
                btnCliente.Enabled = true;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        { // MICROSOFT | BLOQUEIA O FECHAMENTO POR ALT+F4
            if (keyData == (Keys.Alt | Keys.F4)) //ou com um |  é binário
                return true;
            else
                return base.ProcessDialogKey(keyData);
        }

        private void Pesquisar()
        {
            try
            {
                if (comboFiltro.Text == "" && txtLocalizarProd.Text == "")
                {
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("Select idMaterial as 'ID',nome_material as 'Descrição', quantidade as 'Quantidade', id_categoria as 'ID Categoria' from " + tb.Get_ArrayParam()[0] + " where id_categoria in (select id_categoria from tblCategoria where descr_material like '"
                        + txtTipoMat.Text + "%') and idEstoque in (select idEstoque from tblEstoque where nome_estoque = '" + txtEstoqueAtivo.Text + "')");
                    GridEstoque.DataSource = dt;
                }
                else if (comboFiltro.Text.Equals("") && !txtLocalizarProd.Equals(""))
                {

                    throw new Exception("insira um filtro para pesquisar");
                }
                else
                {
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("Select idMaterial as 'ID',nome_material as 'Descrição', quantidade as 'Quantidade', id_categoria as 'ID Categoria' from " + tb.Get_ArrayParam()[0] + " where  " + cmbDados +
                        "  like '" + txtLocalizarProd.Text + "%' and id_categoria in (select id_categoria from tblCategoria where descr_material like '"
                        + txtTipoMat.Text + "%') and idEstoque in (select idEstoque from tblEstoque where nome_estoque = '"
                        + txtEstoqueAtivo.Text + "')");
                    GridEstoque.DataSource = dt;
                }

                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select quant_total from tblEstoque where idEstoque in (select idEstoque from tblEstoque where nome_estoque = '"
                        + txtEstoqueAtivo.Text + "')");
                lblTotal.Text = "Total em estoque:  " + dt.Rows[0]["quant_total"].ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação." + erro);
            }
        }

        private void comboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbDados = tb.Get_ArrayParam()[comboFiltro.SelectedIndex + 1];
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void btnPesquisaMat_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            try
            {
                if (tb.Get_AddProd() == "AddProd" || tb.Get_AddProd() == "Add")
                {
                    btnCliente.Enabled = false;
                    btnFuncionario.Enabled = false;
                    btnMaterial.Enabled = false;
                    btnPedido.Enabled = false;
                }

                    DataTable dt = new DataTable();
                ClasseConexao con = new ClasseConexao();

                txtTipoMat.SelectedItem = null;

                dt = con.executa_sql("SELECT idEstoque, count(*) as _count FROM tblMaterial GROUP BY idEstoque ORDER BY _count desc");
                int maioria = int.Parse(dt.Rows[0]["idEstoque"].ToString());

                dt = new DataTable();
                con = new ClasseConexao();
                //passando o total de materiais pra cada estoque
                dt = con.executa_sql("select idEstoque, quant_total from tblEstoque group by idEstoque,quant_total order by count(quant_total)");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dt2 = new DataTable();
                    ClasseConexao con2 = new ClasseConexao();
                    int id = int.Parse(dt.Rows[i]["idEstoque"].ToString());
                    //int qt = int.Parse(dt.Rows[i]["quant_total"].ToString());
                    dt2 = con2.executa_sql("update tblEstoque set quant_total = (select  sum(quantidade) from tblMaterial where idEstoque = " + id + ") where idEstoque = " + id);
                }

                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("update tblEstoque set quant_total = 0 where quant_total is null");

                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select quant_total from tblEstoque");
                lblTotal.Text += dt.Rows[maioria - 1]["quant_total"].ToString();


                if (maioria == 1)
                {
                    txtEstoqueAtivo.SelectedItem = null;
                    txtEstoqueAtivo.Text = "Estoque X";
                }
                else if (maioria == 2)
                {
                    txtEstoqueAtivo.SelectedItem = null;
                    txtEstoqueAtivo.SelectedText = "Estoque Y";
                }
                else if (maioria == 3)
                {
                    txtEstoqueAtivo.SelectedItem = null;
                    txtEstoqueAtivo.SelectedText = "Estoque Z";
                }

                String[] paramtblMaterial = new String[5];
                paramtblMaterial[0] = "tblMaterial";
                paramtblMaterial[1] = "idMaterial";
                paramtblMaterial[2] = "nome_material";
                paramtblMaterial[3] = "quantidade";
                paramtblMaterial[4] = "id_categoria";
                tb.Set_ArrayParam(paramtblMaterial);

                String[] combotblMaterial = new String[4];
                combotblMaterial[0] = "Código Material";
                combotblMaterial[1] = "Material";
                combotblMaterial[2] = "Quantidade";
                combotblMaterial[3] = "ID Categoria";
                tb.Set_ArrayCombo(combotblMaterial);

                for (i = 0; i < tb.Get_ArrayCombo().Length; i++)
                {

                    comboFiltro.Items.Add(tb.Get_ArrayCombo()[i]);

                }
                tb.Set_prod("");


                dt = new DataTable();
                con = new ClasseConexao();

                dt = con.executa_sql("Select idMaterial as 'ID',nome_material as 'Descrição', quantidade as 'Quantidade', id_categoria as 'ID Categoria' from tblMaterial");
                GridEstoque.DataSource = dt;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void GridEstoque_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tb.Get_AddProd() == "AddProd")
                {
                    tb.Set_prod(GridEstoque.Rows[e.RowIndex].Cells[0].Value.ToString());

                    tb.Set_AddProd("");
                    this.Close();
                }
                else if (tb.Get_AddProd() == "Add")
                {
                    tb.Set_prod(GridEstoque.Rows[e.RowIndex].Cells[1].Value.ToString());
                    tb.Set_cat(GridEstoque.Rows[e.RowIndex].Cells[3].Value.ToString());
                    tb.Set_Estoque(txtEstoqueAtivo.Text);
                    tb.Set_AddProd("");
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            FrmPedido fp = new FrmPedido();
            this.Hide();
            fp.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            FrmProduto fpr = new FrmProduto();
            this.Hide();
            fpr.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FrmFuncionario ff = new FrmFuncionario();
            this.Hide();
            ff.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente fc = new FrmCliente();
            this.Hide();
            fc.Show();
        }
    } 
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEntregAli //     NÃO UTILIZADO -----------------------------------------------------
{
    public partial class LocalizarGeral : Form
    {
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();
        SetandGet tb = new SetandGet();
        String cmbDados;
        int i;
        String vamos;


        public LocalizarGeral()
        {
            InitializeComponent();
            formataGrid();
        }
        

        private void formataGrid()
        {
            //permite personalizar o grid
            //  GridLocalizar.AutoGenerateColumns = false;
            //  GridLocalizar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            //  GridLocalizar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            //altera a cor das linhas alternadas no grid
            //  GridLocalizar.RowsDefaultCellStyle.BackColor = Color.LightBlue;

            //altera o nome das colunas
            //GridLocalizar.Columns[0].HeaderText = "ID";
           // GridLocalizar.Columns[1].HeaderText = "NOME";
            //GridLocalizar.Columns[2].HeaderText = "CPF";
            //GridLocalizar.Columns[3].HeaderText = "Endereco";
            //grid.Columns[3].HeaderText = "PREÇO UNITÁRIO";
            //  GridLocalizar.Columns[0].Width = 20;
            //GridLocalizar.Columns[1].Width = 150;
            //GridLocalizar.Columns[2].Width = 80;
            //GridLocalizar.Columns[2].Width = 150;
            //formata a coluna para moeda (currency)
            //grid.Columns[3].DefaultCellStyle.Format = "c";
            //ao clicar, seleciona a linha inteira
            //    GridLocalizar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //não permite seleção de multiplas linhas    
            //    GridLocalizar.MultiSelect = false;
            // exibe vazio no lugar de null
            //dataGridView1.DefaultCellStyle.NullValue = "";
            //Expande a célula automáticamente
            //  GridLocalizar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //alinha à direita os campos moeda
            //grid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        

        protected override bool ProcessDialogKey(Keys keyData)
        { // MICROSOFT | BLOQUEIA O FECHAMENTO POR ALT+F4
            if (keyData == (Keys.Alt | Keys.F4)) //ou com um |  é binário
                return true;
            else
                return base.ProcessDialogKey(keyData);
        }
        private void LocalizarGeral_Load(object sender, EventArgs e)
        {
            try
            {
                for (i = 0; i < tb.Get_ArrayCombo().Length; i++)
                {

                    comboLocalizar.Items.Add(tb.Get_ArrayCombo()[i]);

                }

                //if (tb.Get_formularioAddServ() == "AddServ")
                //{
                //    con = new ClasseConexao();
                //    dt = new DataTable();
                //    dt = con.executa_sql("select * from " + tb.Get_ArrayParam()[0] + " where  porte  = '" + tb.Get_Porte() + "' ");
                //    GridLocalizar.DataSource = dt;
                //}

                //else
                {
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select * from " + tb.Get_ArrayParam()[0] + "");
                    GridLocalizar.DataSource = dt;
                }

                tb.Set_cli("");
                tb.Set_func("");
                tb.Set_forn("");
                tb.Set_cat("");
                tb.Set_pet("");
                tb.Set_serv("");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        private void Pesquisar()
        {
            try
            {
                if (tb.Get_formularioAddServ() == "AddServ")
                {
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select * from tblServico where  porte  = '" + tb.Get_Porte() + "' and " + cmbDados + " = '" + txtLocalizar.Text + "' ");
                    GridLocalizar.DataSource = dt;

                }

                else
                {
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select * from " + tb.Get_ArrayParam()[0] + " where  " + cmbDados + "  like '" + txtLocalizar.Text + "%'");
                    GridLocalizar.DataSource = dt;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        private void comboLocalizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbDados = tb.Get_ArrayParam()[comboLocalizar.SelectedIndex + 1];
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        private void btnPesquiLoca_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void GridLocalizar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tb.Get_ArrayParam()[0] == "tblPedido")
                {
                    FrmPedido Ped = new FrmPedido();
                    vamos = (GridLocalizar.Rows[e.RowIndex].Cells[0].Value.ToString());
                    tb.Set_idalterar(vamos);
                    Ped.txtIdCliPed.Text = (GridLocalizar.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Ped.txtIdFuncPed.Text = (GridLocalizar.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Ped.txtDataPed.Text = (GridLocalizar.Rows[e.RowIndex].Cells[4].Value.ToString());
                    Ped.txtDataEntrega.Text = (GridLocalizar.Rows[e.RowIndex].Cells[5].Value.ToString());
                    Ped.comboStatus.Text = (GridLocalizar.Rows[e.RowIndex].Cells[3].Value.ToString());
                    //Ped.txthoraped.Text = (GridLocalizar.Rows[e.RowIndex].Cells[6].Value.ToString());
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select nome from tblCliente where  id_cli = " + (GridLocalizar.Rows[e.RowIndex].Cells[2].Value.ToString()) + "");
                    Ped.txtcli.Text = dt.Rows[0][0].ToString();

                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select nome from tblFuncionario where  id_func = " + (GridLocalizar.Rows[e.RowIndex].Cells[3].Value.ToString()) + "");
                    Ped.txtfunc.Text = dt.Rows[0][0].ToString();

                    tb.Set_localizar("Feito");


                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select id_ped as 'Código do Pedido',id_prod as 'Código Produto', qtde as Quantidade from tblDetalhePed  where  id_ped = " + vamos + "  and idMaterial != '' ");
                    Ped.dataProduto.DataSource = dt;
                    Ped.Show();
                    this.Close();
                }
                else if (tb.Get_CondCliPed() == "AddCli")
                {

                    tb.Set_cli(GridLocalizar.Rows[e.RowIndex].Cells[0].Value.ToString());

                    tb.Set_CondCliPed("");
                    this.Close();

                }
                else if (tb.Get_CondFuncPed() == "AddFunc")
                {
                    tb.Set_func(GridLocalizar.Rows[e.RowIndex].Cells[0].Value.ToString());

                    tb.Set_CondFuncPed("");
                    this.Close();

                }

                else if (tb.Get_CondCatProd() == "AddCatProd")
                {

                    tb.Set_cat(GridLocalizar.Rows[e.RowIndex].Cells[0].Value.ToString());

                    tb.Set_CondCatProd("");
                    this.Close();
                }

                else if (tb.Get_CondFornProd() == "AddForn")
                {
                    tb.Set_forn(GridLocalizar.Rows[e.RowIndex].Cells[0].Value.ToString());

                    tb.Set_CondFornProd("");
                    this.Close();

                }

                

                
                else if (tb.Get_ArrayParam()[0] == "tblFuncionario")
                {
                    FrmFuncionario Func = new FrmFuncionario();
                    Func.txtNomeFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Func.txtCPFFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Func.txtRGFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Func.txtEndFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[4].Value.ToString());
                    Func.txtBairroFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[5].Value.ToString());
                    Func.txtCidadeFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[6].Value.ToString());
                    Func.txtTelFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[7].Value.ToString());
                    Func.txtCelFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[8].Value.ToString());
                    Func.txtDataNascFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[9].Value.ToString());
                    Func.txtEmailFunc.Text = (GridLocalizar.Rows[e.RowIndex].Cells[10].Value.ToString());
                    Func.txtCargo.Text = (GridLocalizar.Rows[e.RowIndex].Cells[11].Value.ToString());
                    Func.txtUsuario.Text = (GridLocalizar.Rows[e.RowIndex].Cells[13].Value.ToString());
                    Func.txtSenha.Text = (GridLocalizar.Rows[e.RowIndex].Cells[14].Value.ToString());
                    Func.txtPermissao.Text = (GridLocalizar.Rows[e.RowIndex].Cells[15].Value.ToString());

                    Func.Show();
                    this.Close();
                }
                else if (tb.Get_ArrayParam()[0] == "tblCategoriaProd")
                {
                    //FrmCadastrarCategProd Cat = new FrmCadastrarCategProd();
                    //Cat.txtCatProd.Text = (GridLocalizar.Rows[e.RowIndex].Cells[1].Value.ToString());
                    //Cat.Show();
                    this.Close();
                }
                else if (tb.Get_ArrayParam()[0] == "tblCliente")
                {

                    //FrmCliente Cli = new FrmCliente();
                    /*Cli.txtNomeCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[1].Value.ToString());
                    Cli.txtCPFCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Cli.txtRGCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[3].Value.ToString());
                    Cli.txtTelefoneCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[4].Value.ToString());
                    Cli.txtCelCliente.Text = (GridLocalizar.Rows[e.RowIndex].Cells[5].Value.ToString());
                    Cli.txtDataNascCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[6].Value.ToString());
                    Cli.txtEmailCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[7].Value.ToString());
                    Cli.txtEndCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[8].Value.ToString());
                    Cli.txtBairroCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[9].Value.ToString());
                    Cli.txtCidadeCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[10].Value.ToString());
                    Cli.txtUserCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[11].Value.ToString());
                    Cli.txtSenhaCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[12].Value.ToString());
                    Cli.Show();*/
                    this.Close();
                }
                else if (tb.Get_ArrayParam()[0] == "tblFornecedor")
                {
                    //FrmFornecedor forn = new FrmFornecedor();
                    tb.Set_forn(GridLocalizar.Rows[e.RowIndex].Cells[0].Value.ToString());
                    //forn.txtNomeForn.Text = (GridLocalizar.Rows[e.RowIndex].Cells[1].Value.ToString());
                    //forn.txtCNPJForn.Text = (GridLocalizar.Rows[e.RowIndex].Cells[2].Value.ToString());
                    //forn.txtEndForn.Text = (GridLocalizar.Rows[e.RowIndex].Cells[2].Value.ToString());
                    //forn.txtBairroForn.Text = (GridLocalizar.Rows[e.RowIndex].Cells[3].Value.ToString());
                    //forn.txtCidadeForn.Text = (GridLocalizar.Rows[e.RowIndex].Cells[4].Value.ToString());
                    //forn.txtTelForn.Text = (GridLocalizar.Rows[e.RowIndex].Cells[5].Value.ToString());
                    //forn.txtEmailForn.Text = (GridLocalizar.Rows[e.RowIndex].Cells[6].Value.ToString());
                    //forn.txtNumCli.Text = (GridLocalizar.Rows[e.RowIndex].Cells[7].Value.ToString()); ;
                    //forn.txtTelForn.Text = (GridLocalizar.Rows[e.RowIndex].Cells[8].Value.ToString()); ;
                    //forn.txtEmailForn.Text = (GridLocalizar.Rows[e.RowIndex].Cells[9].Value.ToString()); ;
                    //forn.txtResponsavel.Text = (GridLocalizar.Rows[e.RowIndex].Cells[10].Value.ToString()); ;
                     ;
                    //forn.Show();
                    this.Close();

                    //try
                    //{
                    //    if (tb.Get_AddProd() == "AddProd")
                    //    {
                    //        tb.Set_prod(GridEstoque.Rows[e.RowIndex].Cells[0].Value.ToString());

                    //        tb.Set_AddProd("");
                    //        this.Close();
                    //    }
                    //    else if (tb.Get_AddProd() == "Add")
                    //    {
                    //        tb.Set_prod(GridEstoque.Rows[e.RowIndex].Cells[1].Value.ToString());
                    //        tb.Set_cat(GridEstoque.Rows[e.RowIndex].Cells[3].Value.ToString());
                    //        tb.Set_Estoque(txtEstoqueAtivo.Text);
                    //        tb.Set_AddProd("");
                    //        this.Close();
                    //    }
                    //}
                    //catch (Exception erro)
                    //{
                    //    MessageBox.Show("Não foi possível realizar a operação. " + erro);
                    //}
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        private void LocalizarGeral_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tb.Set_formularioAddServ("");
                tb.Set_AddServ("");
                tb.Set_CondCliPed("");
                tb.Set_CondFuncPed("");
                //tb.Set_CondPetPed("");
                tb.Set_CondCatProd("");
                tb.Set_CondFornProd("");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }


    }
}


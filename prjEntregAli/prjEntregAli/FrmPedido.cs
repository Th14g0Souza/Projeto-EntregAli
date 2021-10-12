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
    public partial class FrmPedido : FrmCadastrarGeral
    {
        SetandGet sg = new SetandGet();
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();
        int pos;
        int maxlinha;
        String boragrid;

        public FrmPedido()
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

        private void Max()
        {
            try
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select * from tblPedido");
                maxlinha = dt.Rows.Count;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void CadastrarPedido()
        {
            try
            {
                //dt = new DataTable();
                //con = new ClasseConexao();
                //dt = con.executa_sql(" select * from tblPedido");
                dt = new DataTable();
                con = new ClasseConexao();

                if (comboStatus.Text == "")
                {
                    throw new Exception("Defina o status do pedido");
                }
                else
                {
                    dt = con.executa_sql("insert into tblPedido values (" + txtIdCliPed.Text + ", " + txtIdFuncPed.Text + ", '" + comboStatus.Text + "', '" + txtDataPed.Text + "','" + txtDataEntrega.Text + "')");
                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql(" select * from tblPedido");
                    boragrid = (dt.Rows[pos]["id_ped"]).ToString();
                    sg.Set_cli(txtIdCliPed.Text);
                    sg.Set_func(txtIdFuncPed.Text);
                    MessageBox.Show("Dados do pedido salvos.");
                    btnAddMat.Enabled = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void MostrarPedido(int pos)
        {
            try
            {
                DataTable dt2 = new DataTable();
                ClasseConexao con2 = new ClasseConexao();
                dt2 = con2.executa_sql(" select * from tblPedido");
                if (dt2.Rows.Count == 0)
                {
                    MessageBox.Show("Não há registros!");
                }
                else
                {
                    boragrid = (dt2.Rows[pos]["id_ped"]).ToString();
                    txtIdCliPed.Text = (dt2.Rows[pos]["id_cli"]).ToString();
                    txtIdFuncPed.Text = (dt2.Rows[pos]["id_func"]).ToString();
                    comboStatus.Text = (dt2.Rows[pos]["ped_status"]).ToString();
                    txtDataPed.Text = (dt2.Rows[pos]["dataped"]).ToString();
                    txtDataEntrega.Text = (dt2.Rows[pos]["dataentrega"]).ToString();
                    con2 = new ClasseConexao();
                    dt2 = new DataTable();
                    dt2 = con2.executa_sql("select nome from tblFuncionario where  id_func = " + txtIdFuncPed.Text + "");
                    txtfunc.Text = dt2.Rows[0][0].ToString();
                    con2 = new ClasseConexao();
                    dt2 = new DataTable();
                    dt2 = con2.executa_sql("select nome from tblCliente where  id_cli = " + txtIdCliPed.Text + "");
                    txtcli.Text = dt2.Rows[0][0].ToString();

                    con2 = new ClasseConexao();
                    dt2 = new DataTable();
                    dt2 = con2.executa_sql("select tblDetalhePed.idMaterial, tblMaterial.nome_material as 'Código Material', qtde as 'Quantidade' from tblDetalhePed, tblMaterial where id_ped = " 
                        + boragrid + " and tblMaterial.idMaterial = tblDetalhePed.idMaterial");
                    dataProduto.DataSource = dt2;

                    if (dt2.Rows.Count > 0 && comboStatus.Text != "Faturado")
                    {
                        btnAddMat.Enabled = true;
                        btnFinalPed.Enabled = true;
                    }
                    else if (dt2.Rows.Count == 0 && comboStatus.Text != "Faturado")
                    {
                        btnAddMat.Enabled = true;
                        btnFinalPed.Enabled = false;
                    }
                    else
                    {
                        btnAddMat.Enabled = false;
                        btnFinalPed.Enabled = false;
                    }

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }


        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboStatus.Text == "Faturado") 
                {
                    MessageBox.Show("você não pode mais adicionar Produtos");
                }
                else
                {
                    
                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("select id_ped from tblPedido where id_cli = " + txtIdCliPed.Text + " and id_func = " + txtIdFuncPed.Text + " and ped_status = '" + comboStatus.Text + "' and dataped = '" + txtDataPed.Text + "' and dataentrega = '" + txtDataEntrega.Text + "'");
                    sg.Set_id((dt.Rows[0]["id_ped"]).ToString());
                    AddProd aprod = new AddProd();
                    aprod.ShowDialog();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarPedido();
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            sg.Set_prod("");
            sg.Set_cli("");
            sg.Set_func("");
            sg.Set_prodadicionado("");
            this.Close();

        }

        private void Limpar()
        {
            txtDataPed.Text = "";
            txtDataEntrega.Text = "";
            txtIdCliPed.Text = "";
            comboStatus.Text = "";
            txtIdFuncPed.Text = "";
            dataProduto.DataSource = "";

            //txthoraped.Text = "";
            txtcli.Text = "";
            txtfunc.Text = "";
            sg.Set_serv("");
            sg.Set_prod("");
            sg.Set_cli("");
            sg.Set_func("");
            sg.Set_prodadicionado("");
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select  id_ped from tblPedido where id_cli = " + txtIdCliPed.Text + " and id_func = " + txtIdFuncPed.Text + " and ped_status = '" + comboStatus.Text + "' and dataped = '" + txtDataPed.Text + "' and dataentrega = '" + txtDataEntrega.Text + "'");
                sg.Set_id((dt.Rows[0][0]).ToString());
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("delete from tblDetalhePed where id_ped = " + sg.Get_id() + "");
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("delete from tblPedido where id_ped = " + sg.Get_id() + "");
                MessageBox.Show("Operação executada com sucesso.");
                Limpar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                if (sg.Get_localizar() == ("Feito"))
                {

                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("update tblPedido set dataped = '" + txtDataPed.Text + "',id_cli = " 
                        + txtIdCliPed.Text + ",id_func = " + txtIdFuncPed.Text + ", dataentrega = '" 
                        + txtDataEntrega.Text + "',  ped_status = '" + comboStatus.Text +
                        "',   where id_ped = "
                        + sg.Get_idalteerar() + "");

                    sg.Set_prod("");
                    sg.Set_cli("");
                    sg.Set_func("");
                    sg.Set_prodadicionado("");
                    sg.Set_servadicionado("");
                    MessageBox.Show("Alterado");
                }
                else
                {
                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("update tblPedido set dataped = '" + txtDataPed.Text + "',id_cli = " 
                        + txtIdCliPed.Text + ",id_func = " + txtIdFuncPed.Text + ", dataentrega = '"
                        + txtDataEntrega.Text + "',  ped_status = '" + comboStatus.Text +
                        "' where id_ped = " + boragrid + "");
                    sg.Set_serv("");
                    sg.Set_prod("");
                    sg.Set_cli("");
                    sg.Set_func("");
                    sg.Set_prodadicionado("");
                    sg.Set_servadicionado("");
                    MessageBox.Show("Alterado");
                }
                sg.Set_localizar("");
                sg.Set_idalterar("");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void btnPri_Click(object sender, EventArgs e)
        {
            pos = 0;
            MostrarPedido(pos);
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos < 0)
            {
                pos = 0;
            }
            MostrarPedido(pos);
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            Max();
            pos++;
            if (pos > (maxlinha - 1))
            {
                pos = maxlinha - 1;
            }
            MostrarPedido(pos);
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            Max();
            pos = maxlinha - 1;
            MostrarPedido(pos);
        }

        private void FrmPedido_Activated(object sender, EventArgs e)
        {
            try
            {
                if (sg.Get_cli() != "" && sg.Get_cli() != null)
                {

                    txtIdCliPed.Text = sg.Get_cli();
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select nome from tblCliente where  id_cli = " + sg.Get_cli() + "");
                    txtcli.Text = dt.Rows[0][0].ToString();
                }

                if (sg.Get_func() != "" && sg.Get_func() != null)
                {
                    txtIdFuncPed.Text = sg.Get_func();
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select nome from tblFuncionario where  id_func = " + sg.Get_func() + "");
                    txtfunc.Text = dt.Rows[0][0].ToString();
                }

                if (sg.Get_prodadicionado() != null && sg.Get_prodadicionado() != "")
                {

                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("select id_ped as 'Código do Pedido',idMaterial as 'Código Material', qtde as 'Quantidade' from tblDetalhePed  where  id_ped = " + sg.Get_id() + "");
                    dataProduto.DataSource = dt;

                    if (dt.Rows.Count > 0 && comboStatus.Text != "Faturado")
                    {
                        btnAddMat.Enabled = true;
                        btnFinalPed.Enabled = true;
                    }
                    else if (dt.Rows.Count == 0 && comboStatus.Text != "Faturado")
                    {
                        btnAddMat.Enabled = true;
                        btnFinalPed.Enabled = false;
                    }
                    else
                    {
                        btnAddMat.Enabled = true;
                        btnFinalPed.Enabled = false;
                    }

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String[] paramtblPedido = new String[7];
            paramtblPedido[0] = "tblPedido";
            paramtblPedido[1] = "id_ped";
            paramtblPedido[3] = "id_cli";
            paramtblPedido[4] = "id_func";
            paramtblPedido[5] = "ped_status";
            paramtblPedido[6] = "dataped";
            paramtblPedido[7] = "dataentrega";
            sg.Set_ArrayParam(paramtblPedido);
            String[] combotblPedido = new String[6];
            combotblPedido[0] = "Código Pedido";
            combotblPedido[2] = "Código Cliente";
            combotblPedido[3] = "Código Funcionário";
            combotblPedido[4] = "Status do Pedido";
            combotblPedido[5] = "Data do Pedido";
            combotblPedido[6] = "Data de Entrega";
            sg.Set_ArrayCombo(combotblPedido);
            LocalizarGeral Geral = new LocalizarGeral();
            this.Close();
            Geral.Show();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            CadastrarPedido();
        }

        private void btnFinalPed_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql(" select idMaterial,qtde from tblDetalhePed where id_ped = " + boragrid);

            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Pedido vazio. Clique em 'salvar' e adicione itens ao seu pedido");
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dt2 = new DataTable();
                    con = new ClasseConexao();
                    dt2 = con.executa_sql("update tblMaterial set quantidade = quantidade -" + int.Parse(dt.Rows[i]["qtde"].ToString()) + "where idMaterial = " + int.Parse(dt.Rows[i]["idMaterial"].ToString()));
                }

                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("update tblPedido set ped_status = 'Faturado' where id_ped = " + boragrid);


                sg.Set_prod("");
                sg.Set_cli("");
                sg.Set_func("");
                sg.Set_prodadicionado("");
                sg.Set_servadicionado("");


                MessageBox.Show("Pedido finalizado com sucesso.");
            }
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql("select idMaterial as 'Código Material', qtde as Quantidade from tblDetalhePed where id_ped = " + boragrid + "  and id_prod != '' ");
            dataProduto.DataSource = dt;

            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql("select id_cli from tblCliente");
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtIdCliPed.Items.Add(dt.Rows[i]["id_cli"]);
            }

            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql("select id_func from tblFuncionario");

            for (int j = 0; j < dt.Rows.Count; j++)
            {
                txtIdFuncPed.Items.Add(dt.Rows[j]["id_func"]);
            }

            btnAddMat.Enabled = false;
            btnFinalPed.Enabled = false;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmEstoque est = new FrmEstoque();
            this.Hide();
            est.Show();

        }

        private void txtIdCliPed_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql("select nome from tblCliente where id_cli = " + txtIdCliPed.Text);

            txtcli.Text = dt.Rows[0]["nome"].ToString();
        }

        private void txtIdFuncPed_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql("select nome from tblFuncionario where id_func = " + txtIdFuncPed.Text);

            txtfunc.Text = dt.Rows[0]["nome"].ToString();
        }

        private void FrmPedido_Shown(object sender, EventArgs e)
        {
            try
            {
                if (sg.Get_cli() != "" && sg.Get_cli() != null)
                {

                    txtIdCliPed.Text = sg.Get_cli();
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select nome from tblCliente where  id_cli = " + sg.Get_cli() + "");
                    txtcli.Text = dt.Rows[0][0].ToString();
                }

                if (sg.Get_func() != "" && sg.Get_func() != null)
                {
                    txtIdFuncPed.Text = sg.Get_func();
                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("select nome from tblFuncionario where  id_func = " + sg.Get_func() + "");
                    txtfunc.Text = dt.Rows[0][0].ToString();
                }

                if (sg.Get_prodadicionado() != null && sg.Get_prodadicionado() != "")
                {

                    dt = new DataTable();
                    con = new ClasseConexao();
                    dt = con.executa_sql("select id_ped as 'Código do Pedido',id_prod as 'Código Produto', qtde as Quantidade, desconto as Desconto from tblDetalhePed  where  id_ped = " + sg.Get_id() + " and id_prod != ''");
                    dataProduto.DataSource = dt;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        
        }
    }
}

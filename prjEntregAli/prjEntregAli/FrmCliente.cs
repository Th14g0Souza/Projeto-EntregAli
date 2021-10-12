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
    public partial class FrmCliente : FrmCadastrarGeral
    {
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();
        SetandGet sg = new SetandGet();
        //Valida v = new Valida();
        bool data;
        bool cpf;
        int pos;
        int id;
        int maxlinha;

        public FrmCliente()
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

        private void CadastrarCliente()
        {
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executa_sql("insert into tblCliente values ('" + txtNomeCli.Text + "', '" + txtCPFCli.Text + "', '" + txtRGCli.Text + "', '" + txtTelefoneCli.Text + "', '" + txtCelCliente.Text + "', '" + txtDataNascCli.Text + "', '" + txtEmailCli.Text + "', '" + txtEndCli.Text + "', '" + txtBairroCli.Text + "', '" + txtCidadeCli.Text + "')");
            MessageBox.Show("Cliente Cadastrado");
        }

        private void MostrarCli(int pos)
        {
            try
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select * from tblCliente");
                id = int.Parse((dt.Rows[pos]["id_cli"]).ToString());
                txtNomeCli.Text = (dt.Rows[pos]["nome"]).ToString();
                txtCPFCli.Text = (dt.Rows[pos]["CPF"]).ToString();
                txtRGCli.Text = (dt.Rows[pos]["RG"]).ToString();
                txtTelefoneCli.Text = (dt.Rows[pos]["telefone"]).ToString();
                txtCelCliente.Text = (dt.Rows[pos]["celular"]).ToString();
                txtDataNascCli.Text = (dt.Rows[pos]["datanasc"]).ToString();
                txtEmailCli.Text = (dt.Rows[pos]["email"]).ToString();
                txtEndCli.Text = (dt.Rows[pos]["endereco"]).ToString();
                txtBairroCli.Text = (dt.Rows[pos]["bairro"]).ToString();
                txtCidadeCli.Text = (dt.Rows[pos]["cidade"]).ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void Max()
        {
            try
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executa_sql("select * from tblCliente");
                maxlinha = dt.Rows.Count;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void LimparCliente()
        {
            txtNomeCli.Text = "";
            txtCPFCli.Text = "";
            txtRGCli.Text = "";
            txtTelefoneCli.Text = "";
            txtCelCliente.Text = "";
            txtDataNascCli.Text = "";
            txtEmailCli.Text = "";
            txtEndCli.Text = "";
            txtBairroCli.Text = "";
            txtCidadeCli.Text = "";

        }

        /*private bool Validar_Data(string val)
        {
            v = new Valida();

            data = v.ValidarData(val);
            return data;
        }*/

        /*private bool Validar_CPF(string val2)
        {
            v = new Valida();

            cpf = v.ValidarCpf(val2);
            return cpf;

        }
        */
        private void Deletar()
        {

            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executa_sql("select id_cli from tblCliente where nome='" + txtNomeCli.Text + "' and datanasc= '" + txtDataNascCli.Text + "' and cpf='" + txtCPFCli.Text + "' and RG= '" + txtRGCli.Text + "' and telefone= '" + txtTelefoneCli.Text + "' and celular='" + txtCelCliente.Text + "' and email='" + txtEmailCli.Text + "' and endereco='" + txtEndCli.Text + "' and bairro= '" + txtBairroCli.Text + "' and cidade= '" + txtCidadeCli.Text + "' ");
            sg.Set_id((dt.Rows[0][0]).ToString());
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executa_sql("Select * from tblPedido where id_cli= " + sg.Get_id() + " ");
            if (dt.Rows.Count == 0)
            {
                con = new ClasseConexao();
                dt = new DataTable();
                dt = con.executa_sql("Select * from tblPet where id_cli= " + sg.Get_id() + " ");
                if (dt.Rows.Count == 0)
                {

                    con = new ClasseConexao();
                    dt = new DataTable();
                    dt = con.executa_sql("delete from tblCliente where id_cli= " + sg.Get_id() + "");
                    MessageBox.Show("Operação executada com sucesso.");
                }
                else { MessageBox.Show("Não é possível realizar a operação, pois o Cliente já está cadastrado em Pet."); }
            }
            else
            {
                con = new ClasseConexao();
                dt = new DataTable();
                dt = con.executa_sql("Select * from tblPet where id_cli= " + sg.Get_id() + " ");
                if (dt.Rows.Count == 0)
                {

                    MessageBox.Show("Não é possível realizar a operação, pois o Cliente já está cadastrado em um pedido.");

                }

                else {
                    MessageBox.Show("Não é possível realizar a operação, Cliente possui cadastrado em Pedido e Pet.");

                }

            }




        }

        private void Alterar()
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executa_sql("update tblCliente set nome = '" + txtNomeCli.Text + "', CPF = '" + txtCPFCli.Text + "', RG = '" + txtRGCli.Text + "', telefone = '" + txtTelefoneCli.Text + "', celular = '" + txtCelCliente.Text + "', datanasc = '" + txtDataNascCli.Text + "', email = '" + txtEmailCli.Text + "', endereco = '" + txtEndCli.Text + "', bairro = '" + txtBairroCli.Text + "', cidade = '" + txtCidadeCli.Text + "' where id_cli = " + id);
            MessageBox.Show("Alteração realizada com sucesso");
        }



        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Deletar();
            LimparCliente();
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Validar_CPF(txtCPFCli.Text);
            //Validar_Data(txtDataNascCli.Text);

            //condições para ver se o cpf e a data estão certos (está na ordem de validação: 1° cpf depois data)
            /*if (cpf == false)
            {
                MessageBox.Show("Digite um cpf válido.");
                txtCPFCli.Text = "";
            }
            */
            //if (cpf == true)
            //{
               // if (data == true)
                //{
                    CadastrarCliente();
                    LimparCliente();
                //}
                //else
                //{
                  //  MessageBox.Show("Digite uma data válida.");
                   // txtDataNascCli.Text = "";
                //}
            
        }

        private void btnPri_Click(object sender, EventArgs e)
        {
            pos = 0;
            MostrarCli(pos);
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos < 0)
            {
                pos = 0;
            }
            MostrarCli(pos);
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            Max();
            pos++;
            if (pos > (maxlinha - 1))
            {
                pos = maxlinha - 1;
            }
            MostrarCli(pos);
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            Max();
            pos = maxlinha - 1;
            MostrarCli(pos);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String[] paramtblCliente = new String[14];
            paramtblCliente[0] = "tblCliente";
            paramtblCliente[1] = "id_cli";
            paramtblCliente[2] = "nome";
            paramtblCliente[3] = "CPF";
            paramtblCliente[4] = "RG";
            paramtblCliente[5] = "telefone";
            paramtblCliente[6] = "celular";
            paramtblCliente[7] = "datanasc";
            paramtblCliente[8] = "email";
            paramtblCliente[9] = "endereco";
            paramtblCliente[10] = "bairro";
            paramtblCliente[11] = "cidade";
            paramtblCliente[12] = "usuario";
            paramtblCliente[13] = "senha";
            sg.Set_ArrayParam(paramtblCliente);

            String[] combotblCliente = new String[13];
            combotblCliente[0] = "Código Cliente";
            combotblCliente[1] = "Nome";
            combotblCliente[2] = "CPF";
            combotblCliente[3] = "RG";
            combotblCliente[4] = "Telefone";
            combotblCliente[5] = "Celular";
            combotblCliente[6] = "Data de Nascimento";
            combotblCliente[7] = "E-mail";
            combotblCliente[8] = "Endereço";
            combotblCliente[9] = "Bairro";
            combotblCliente[10] = "Cidade";
            combotblCliente[11] = "Usuário";
            combotblCliente[12] = "Senha";
            sg.Set_ArrayCombo(combotblCliente);

            LocalizarGeral lg = new LocalizarGeral();
            lg.Show();
            this.Close();
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCliente();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            txtNomeCli.Text = "Ana Maria Oliveira";
            txtCPFCli.Text = "999.999.999-99";
            txtRGCli.Text = "99.999.999-9";
            txtTelefoneCli.Text = "99999999";
            txtCelCliente.Text = "999999999";
            txtDataNascCli.Text = "23/11/1981";
            txtEmailCli.Text = "anamaria@gmail.com";
            txtEndCli.Text = "Rua Z, 99";
            txtBairroCli.Text = "Bom Retiro";
            txtCidadeCli.Text = "São Paulo";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmEstoque est = new FrmEstoque();
            this.Hide();
            est.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();

        }
    }
}

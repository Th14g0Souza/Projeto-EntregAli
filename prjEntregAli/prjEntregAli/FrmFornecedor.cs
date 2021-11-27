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
    public partial class FrmFornecedor : FrmCadastrarGeral
    {
        ClasseConexao con = new ClasseConexao();
        DataTable dt = new DataTable();
        SetandGet sg = new SetandGet();
        int id;
        int pos;
        int maxlinha;

        public FrmFornecedor()
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

        private void Permissoes(int nivel)
        {
            if (nivel == 1)//gerente
            {
                btnDeletar.Visible = true;
                btnAlterar.Visible = true;
                btnSalvar.Visible = true;
            }
            if (nivel == 2)//colaboradores e mais
            {
                btnDeletar.Visible = false;
                btnAlterar.Visible = false;
                btnSalvar.Visible = false;
            }
        }

        private void CadastrarForn()
        {
            try
            {
                con = new ClasseConexao();
                dt = new DataTable();

                dt = con.executa_sql("insert into tblFornecedor values ('" + txtNomeForn.Text + "','"
                    + txtCNPJForn.Text +  "','" + txtEndForn.Text + "','"
                    + txtBairroForn.Text + "','" + txtCidadeForn.Text + "','" + txtTelForn.Text +
                     "','" + txtEmailForn.Text + 
                     ")");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void AlterarForn()
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executa_sql("update tblFornecedor set nome = '" + txtNomeForn.Text + "', CNPJ = '"
                + txtCNPJForn.Text + "', telefone = '" + txtTelForn.Text 
                + "', email = '" + txtEmailForn.Text + "', endereco = '" + txtEndForn.Text + "', bairro = '"
                + txtBairroForn.Text + "', cidade = '" + txtCidadeForn.Text  + "' where id_Forn = " + id);
            MessageBox.Show("Alteração realizada com sucesso");
        }

        private void LimparForn()
        {
            txtNomeForn.Text = "";
            txtCNPJForn.Text = "";
            
            txtTelForn.Text = "";
            
            txtEndForn.Text = "";
            txtBairroForn.Text = "";
            txtCidadeForn.Text = "";
            txtEmailForn.Text = "";
            
        }

        private void MostrarForn(int pos)
        {
            try
            {
                con = new ClasseConexao();
                dt = new DataTable();

                dt = con.executa_sql("select * from tblFornecedor");
                id = int.Parse((dt.Rows[pos]["nome"]).ToString());
                txtNomeForn.Text = (dt.Rows[pos]["nome"]).ToString();
                txtCNPJForn.Text = (dt.Rows[pos]["CNPJ"]).ToString();
                
                txtTelForn.Text = (dt.Rows[pos]["telefone"]).ToString();
                
                txtEndForn.Text = (dt.Rows[pos]["endereco"]).ToString();
                txtBairroForn.Text = (dt.Rows[pos]["bairro"]).ToString();
                txtCidadeForn.Text = (dt.Rows[pos]["cidade"]).ToString();
                txtEmailForn.Text = (dt.Rows[pos]["email"]).ToString();
                
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
                dt = con.executa_sql("select * from tblFornecedor");
                maxlinha = dt.Rows.Count;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarForn();
            LimparForn();
        }

        private void btnPri_Click(object sender, EventArgs e)
        {
            pos = 0;
            MostrarForn(pos);
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos < 0)
            {
                pos = 0;
            }
            MostrarForn(pos);
        }

        private void btnDep_Click(object sender, EventArgs e)
        {
            Max();
            pos++;
            if (pos > (maxlinha - 1))
            {
                pos = maxlinha - 1;
            }
            MostrarForn(pos);
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            Max();
            pos = maxlinha - 1;
            MostrarForn(pos);
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparForn();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            /*String[] paramtblFuncionario = new String[17];
            paramtblFuncionario[0] = "tblFuncionario";
            paramtblFuncionario[1] = "id_func";
            paramtblFuncionario[2] = "nome";
            paramtblFuncionario[3] = "CPF";
            paramtblFuncionario[4] = "RG";
            paramtblFuncionario[5] = "bairro";
            paramtblFuncionario[6] = "endereco";
            paramtblFuncionario[7] = "cidade";
            paramtblFuncionario[8] = "telefone";
            paramtblFuncionario[9] = "celular";
            paramtblFuncionario[10] = "datanasc";
            paramtblFuncionario[11] = "email";
            paramtblFuncionario[12] = "cargo";
            paramtblFuncionario[13] = "salario";
            paramtblFuncionario[14] = "usuario";
            paramtblFuncionario[15] = "senha";
            paramtblFuncionario[16] = "id_permissao";
            sg.Set_ArrayParam(paramtblFuncionario);

            String[] combotblFuncionario = new String[16];
            combotblFuncionario[0] = "Código Funcionário";
            combotblFuncionario[1] = "Nome";
            combotblFuncionario[2] = "CPF";
            combotblFuncionario[3] = "RG";
            combotblFuncionario[4] = "Bairro";
            combotblFuncionario[5] = "Endereço";
            combotblFuncionario[6] = "Cidade";
            combotblFuncionario[7] = "Telefone";
            combotblFuncionario[8] = "Celular";
            combotblFuncionario[9] = "Data de Nascimento";
            combotblFuncionario[10] = "E-mail";
            combotblFuncionario[11] = "Cargo";
            combotblFuncionario[12] = "Salário";
            combotblFuncionario[13] = "Usuário";
            combotblFuncionario[14] = "Senha";
            combotblFuncionario[15] = "Código Permissão";
            sg.Set_ArrayCombo(combotblFuncionario);

            LocalizarGeral lg = new LocalizarGeral();
            lg.Show();
            this.Hide();*/
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            Permissoes(int.Parse(sg.Getpermissao()));
        }

        /*private void btnSair2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }*/

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                con = new ClasseConexao();
                dt = new DataTable();
                dt = con.executa_sql("delete from tblFornecedor where id = '" + id + "");
                MessageBox.Show("Operação executada com sucesso.");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmEstoque est = new FrmEstoque();
            this.Hide();
            est.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarForn();
        }

        private void lblCPFCliente_Click(object sender, EventArgs e)
        {

        }
    }
}

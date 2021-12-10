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
                if (checarvazio() == true)
                {
                    MessageBox.Show("Favor preencher todos os campos");
                }
                con = new ClasseConexao();
                dt = new DataTable();

                dt = con.executa_sql("insert into tblFornecedor values ('" + txtNomeForn.Text + "','"
                    + txtCNPJForn.Text +  "','" + txtEndForn.Text + "','"
                    + txtBairroForn.Text + "','" + txtCidadeForn.Text + "','" + txtTelForn.Text +
                     "','" + txtEmailForn.Text + 
                     "')");
                MessageBox.Show("Cadastro realizado com sucesso");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        private void AlterarForn()
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executa_sql("update tblFornecedor set nome_forn = '" + txtNomeForn.Text + "', CNPJ = '"
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
                id = int.Parse((dt.Rows[pos]["id_forn"]).ToString());
                txtNomeForn.Text = (dt.Rows[pos]["nome_forn"]).ToString();
                txtCNPJForn.Text = (dt.Rows[pos]["CNPJ"]).ToString();
                
                txtTelForn.Text = (dt.Rows[pos]["telefone"]).ToString();
                
                txtEndForn.Text = (dt.Rows[pos]["endereco"]).ToString();
                txtBairroForn.Text = (dt.Rows[pos]["bairro"]).ToString();
                txtCidadeForn.Text = (dt.Rows[pos]["cidade"]).ToString();
                txtEmailForn.Text = (dt.Rows[pos]["email"]).ToString();
                
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
                dt = con.executa_sql("select * from tblFornecedor");
                maxlinha = dt.Rows.Count;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
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
            String[] paramtblFornecedor = new String[9];
            paramtblFornecedor[0] = "tblFornecedor";
            paramtblFornecedor[1] = "id_forn";
            paramtblFornecedor[2] = "nome_forn";
            paramtblFornecedor[3] = "CNPJ";
            paramtblFornecedor[4] = "endereco";
            paramtblFornecedor[5] = "bairro";
            paramtblFornecedor[6] = "cidade";
            paramtblFornecedor[7] = "telefone";
            paramtblFornecedor[8] = "email";
            sg.Set_ArrayParam(paramtblFornecedor);

            String[] combotblFornecedor = new String[8];
            combotblFornecedor[0] = "Código Fornecedor";
            combotblFornecedor[1] = "Nome/Razão";
            combotblFornecedor[2] = "CNPJ";
            combotblFornecedor[3] = "Endereço";
            combotblFornecedor[4] = "Bairro";
            combotblFornecedor[5] = "Cidade";
            combotblFornecedor[6] = "Telefone";
            combotblFornecedor[7] = "E-mail";
            
            sg.Set_ArrayCombo(combotblFornecedor);
            
            LocalizarGeral lg = new LocalizarGeral();
            lg.ShowDialog();

      
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            Permissoes(int.Parse(sg.Getpermissao()));
        }


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
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
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

        private void FrmFornecedor_Activated(object sender, EventArgs e)
        {
            try
            {
                if (sg.Get_forn() != null && sg.Get_forn() != "")
                {
                    //txtMaterial.Text = sg.Get_forn();
                    dt = new DataTable();
                    //con = new ClasseConexao();
                    //dt = con.executa_sql("select * from tblFoernecedor where id_forn = " + sg.Get_forn() + "");
                    //txtNomeForn.Text = dt.Rows[0][0].ToString();
                    //txtIDCategoria.Text = sg.Get_cat();
                    //cmbEstoque.SelectedItem = sg.Get_Estoque(); 
                }


            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. " + erro.Message);
            }
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            FrmEstoque est = new FrmEstoque();
            est.Show();
            this.Close();
        }
    }
}

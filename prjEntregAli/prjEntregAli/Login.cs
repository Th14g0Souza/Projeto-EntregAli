using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using Microsoft.SqlServer.Server;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace prjEntregAli
{
    public partial class Login : Form
    {
        ClasseConexao con = new ClasseConexao();
        DataTable dt = new DataTable();
        SetandGet sg = new SetandGet();


        public Login()
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
                //this.ProcessTabKey(true);
                //return true;
                btnEntrar_Click(new object(), new EventArgs());
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                con = new ClasseConexao();
                dt = new DataTable();
                dt = con.executa_sql("select id_permissao from tblFuncionario where usuario like '" + txtUsuario.Text + "' and senha like '" + txtSenha.Text + "'");

                if (dt.Rows.Count > 0)
                {
                    sg.Setpermissao(dt.Rows[0][0].ToString());//tem que colocar .Rows[0][0] para especificar o dado que está pegando da tabela, não basta dar o select
                    Splash s = new Splash();
                    s.Show();
                    

                    con = new ClasseConexao();
                    dt = new DataTable();

                    dt = con.executa_sql("Select nome from tblFuncionario where usuario like '" + txtUsuario.Text.ToString()+"'"); //nome bem vindo
                    sg.Set_nome(dt.Rows[0][0].ToString());
                    //MessageBox.Show(sg.Get_nome()+ "");

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos.");
                }
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível realizar a operação. Erro: "+erro.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            { 
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);     
            }
            catch (Exception erro)
            {     
                    MessageBox.Show("Erro no login: " + erro.Message);
            }

        }
    }
}

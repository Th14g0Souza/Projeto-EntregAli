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
                this.ProcessTabKey(true);
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
                MessageBox.Show("Não foi possível realizar a operação. Erro: "+erro);
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
                string sqlConnectionString = @"Trusted_Connection=yes;Persist Security Info=False;Initial Catalog=Master;Data Source=.\sqlexpress";

                //string script = File.ReadAllText(@"C:\\Users\\"+Environment.UserName+ "\\Desktop\\EntregAli_V2\\Application Files\\prjEntregAli_1_0_0_17\\EntregAliDB.sql.deploy");
                string script = File.ReadAllText(@"C:\\Program Files\\EntregAli_V2\\Application Files\\prjEntregAli_1_0_0_34\\EntregAliDB.sql.deploy",System.Text.Encoding.GetEncoding("iso-8859-1"));

                //string script = File.ReadAllText(@"C:\Users\THIAG\Desktop\prjEntregAli_v2\prjEntregAli\EntregAliDB.sql",System.Text.Encoding.GetEncoding("iso-8859-1"));


                SqlConnection conn = new SqlConnection(sqlConnectionString);

                SqlCommand command = new SqlCommand("SET NOCOUNT Off", conn);
                command.Connection.Open();
                command = new SqlCommand("SELECT * FROM master.dbo.sysdatabases where name = 'EntregAliDB2'", conn);

                //conn.ChangeDatabase("master");

                var exists = command.ExecuteScalar();

                if (exists == null)
                {
                    command = new SqlCommand("create database EntregAliDB2", conn);
                    command.ExecuteScalar();

                    command = new SqlCommand("use EntregAliDB2", conn);
                    command.ExecuteScalar();

                    command = new SqlCommand(script, conn);
                    command.ExecuteScalar();

                    MessageBox.Show("Banco carregado");
                }
                else
                {
                    MessageBox.Show("Banco já existente");
                }
            } 
            catch (Exception erro)
            {
                if (erro.Message.StartsWith("Erro de rede"))
                {
                    MessageBox.Show("Erro de conexão ao banco");

                }
                else
                {
                    MessageBox.Show("Erro: " + erro);
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEntregAli
{
    public partial class Cliente : UserControl
    {
        public Cliente()
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
        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cli = new FrmCliente();
            cli.Show();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ClasseConexao con = new ClasseConexao();

            dt = con.executa_sql("Select id_cli as 'ID',nome as 'Nome', endereco as 'Endereco',cpf as 'CPF',RG as 'RG', Telefone as 'Telefone', Celular as 'Celular' from tblCliente ");
            dataGridView1.DataSource = dt;
        }
    }
}

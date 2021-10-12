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
    public partial class Splash : Form
    {
        public Splash()
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


        private void timer1_Tick(object sender, EventArgs e)
        {
           

            if (progressBar1.Value < 100)
            {
                
                progressBar1.Value = progressBar1.Value + 2;
                
            }
            else 
            {
                timer1.Stop();
                timer1.Enabled = false;
                this.Visible = false;

                FrmEstoque est = new FrmEstoque();
                est.Show(); 

            }
            
        }    
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaPrjVendas
{
    public partial class FrmSplash : Form
    {
        int tempo = 0;
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void trmSplash_Tick(object sender, EventArgs e)
        {
            trmSplash.Enabled = true;
            if (tempo <= 20)
            {
                pgbSplash.Increment(20);
                tempo++;
            }
            else
            {
                this.Close();
            }
        }

        private void pgbSplash_Click(object sender, EventArgs e)
        {

        }
    }

}

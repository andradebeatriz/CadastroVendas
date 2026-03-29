using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaPrjVendas
{
    public partial class FrmRptProdutos : Form
    {
        public FrmRptProdutos()
        {
            InitializeComponent();
        }

        private void FrmRptProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetVendas.pc_produto'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_produtoTableAdapter.Fill(this.dataSetVendas.pc_produto);

            this.reportViewer1.RefreshReport();
        }
    }
}

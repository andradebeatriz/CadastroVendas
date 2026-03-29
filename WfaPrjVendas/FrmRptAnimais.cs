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
    public partial class FrmRptAnimais : Form
    {
        public FrmRptAnimais()
        {
            InitializeComponent();
        }

        private void FrmRptAnimais_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetVendas.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.dataSetVendas.animal);
            reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.RefreshReport();
        }
    }
}

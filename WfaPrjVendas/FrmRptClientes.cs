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
    public partial class FrmRptClientes : Form
    {
        public FrmRptClientes()
        {
            InitializeComponent();
        }

        private void FrmRptClientes_Load(object sender, EventArgs e)
        {
            // Carrega a tabela pc_clientes usando o TableAdapter
            this.pc_clientesTableAdapter.Fill(this.dataSetVendas.pc_clientes);

            // Limpa fontes antigas
            reportViewer1.LocalReport.DataSources.Clear();

            // Envia o DataTable que o ReportViewer precisa
            Microsoft.Reporting.WinForms.ReportDataSource rds =
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", this.dataSetVendas.pc_clientes as DataTable);

            reportViewer1.LocalReport.DataSources.Add(rds);

            // Atualiza o relatório
            this.reportViewer1.RefreshReport();
        }
    }
}

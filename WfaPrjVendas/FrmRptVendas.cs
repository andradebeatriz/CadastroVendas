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
    public partial class FrmRptVendas : Form
    {
        public FrmRptVendas()
        {
            InitializeComponent();
        }

        private void FrmRptVendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetVendas.RptVendas'. Você pode movê-la ou removê-la conforme necessário.
            this.rptVendasTableAdapter.Fill(this.dataSetVendas.RptVendas);
            this.reportViewer1.RefreshReport();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime dataInicial = dtpDataInicial.Value.Date;
            DateTime dataFinal = dtpDataFinal.Value.Date;

            if (dataFinal < dataInicial)
            {
                MessageBox.Show("A data final não pode ser menor que a data inicial.", "Erro de Filtro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.reportViewer1.LocalReport.DataSources.Clear();

            this.rptVendasTableAdapter.FillByData(
                this.dataSetVendas.RptVendas,
                dataInicial,
                dataFinal
            );

            Microsoft.Reporting.WinForms.ReportDataSource rds =
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", (DataTable)this.dataSetVendas.RptVendas);

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}

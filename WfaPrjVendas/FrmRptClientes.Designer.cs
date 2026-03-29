namespace WfaPrjVendas
{
    partial class FrmRptClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptClientes));
            this.pcclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVendas = new WfaPrjVendas.DataSetVendas();
            this.pc_clientesTableAdapter = new WfaPrjVendas.DataSetVendasTableAdapters.pc_clientesTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pc_clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pcclientesBindingSource
            // 
            this.pcclientesBindingSource.DataMember = "pc_clientes";
            this.pcclientesBindingSource.DataSource = this.dataSetVendas;
            // 
            // dataSetVendas
            // 
            this.dataSetVendas.DataSetName = "DataSetVendas";
            this.dataSetVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_clientesTableAdapter
            // 
            this.pc_clientesTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pcclientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WfaPrjVendas.RptClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(962, 577);
            this.reportViewer1.TabIndex = 0;
            // 
            // pc_clientesBindingSource
            // 
            this.pc_clientesBindingSource.DataMember = "pc_clientes";
            this.pc_clientesBindingSource.DataSource = this.dataSetVendas;
            // 
            // FrmRptClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 576);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRptClientes";
            this.Text = "Relatório de Clientes";
            this.Load += new System.EventHandler(this.FrmRptClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetVendas dataSetVendas;
        private DataSetVendasTableAdapters.pc_clientesTableAdapter pc_clientesTableAdapter;
        private System.Windows.Forms.BindingSource pcclientesBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pc_clientesBindingSource;
    }
}
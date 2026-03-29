namespace WfaPrjVendas
{
    partial class FrmRptProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptProdutos));
            this.pcprodutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVendas = new WfaPrjVendas.DataSetVendas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pc_produtoTableAdapter = new WfaPrjVendas.DataSetVendasTableAdapters.pc_produtoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pcprodutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // pcprodutoBindingSource
            // 
            this.pcprodutoBindingSource.DataMember = "pc_produto";
            this.pcprodutoBindingSource.DataSource = this.dataSetVendas;
            // 
            // dataSetVendas
            // 
            this.dataSetVendas.DataSetName = "DataSetVendas";
            this.dataSetVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pcprodutoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WfaPrjVendas.RptProdutos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(961, 555);
            this.reportViewer1.TabIndex = 0;
            // 
            // pc_produtoTableAdapter
            // 
            this.pc_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRptProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 554);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmRptProdutos";
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.FrmRptProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcprodutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetVendas dataSetVendas;
        private System.Windows.Forms.BindingSource pcprodutoBindingSource;
        private DataSetVendasTableAdapters.pc_produtoTableAdapter pc_produtoTableAdapter;
    }
}
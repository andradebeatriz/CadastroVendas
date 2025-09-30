namespace WfaPrjVendas
{
    partial class FrmCadVendas
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
            System.Windows.Forms.Label num_vendaLabel;
            System.Windows.Forms.Label datavendaLabel;
            System.Windows.Forms.Label dataentregaLabel;
            System.Windows.Forms.Label cod_cliLabel;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label cod_proLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precounitLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadVendas));
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.num_venda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVendas = new WfaPrjVendas.DataSetVendas();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.pc_itemvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.cod_pro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precounit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.txtNum_venda = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPesquisarItem = new System.Windows.Forms.TextBox();
            this.btnPesquisarItem = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnGravarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.pc_itemvendaTableAdapter = new WfaPrjVendas.DataSetVendasTableAdapters.pc_itemvendaTableAdapter();
            this.pc_vendaTableAdapter = new WfaPrjVendas.DataSetVendasTableAdapters.pc_vendaTableAdapter();
            this.tableAdapterManager = new WfaPrjVendas.DataSetVendasTableAdapters.TableAdapterManager();
            num_vendaLabel = new System.Windows.Forms.Label();
            datavendaLabel = new System.Windows.Forms.Label();
            dataentregaLabel = new System.Windows.Forms.Label();
            cod_cliLabel = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            cod_proLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).BeginInit();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_vendaLabel
            // 
            num_vendaLabel.AutoSize = true;
            num_vendaLabel.Location = new System.Drawing.Point(6, 13);
            num_vendaLabel.Name = "num_vendaLabel";
            num_vendaLabel.Size = new System.Drawing.Size(85, 15);
            num_vendaLabel.TabIndex = 47;
            num_vendaLabel.Text = "Num Venda:";
            // 
            // datavendaLabel
            // 
            datavendaLabel.AutoSize = true;
            datavendaLabel.Location = new System.Drawing.Point(6, 41);
            datavendaLabel.Name = "datavendaLabel";
            datavendaLabel.Size = new System.Drawing.Size(105, 15);
            datavendaLabel.TabIndex = 49;
            datavendaLabel.Text = "Data da Venda:";
            // 
            // dataentregaLabel
            // 
            dataentregaLabel.AutoSize = true;
            dataentregaLabel.Location = new System.Drawing.Point(209, 41);
            dataentregaLabel.Name = "dataentregaLabel";
            dataentregaLabel.Size = new System.Drawing.Size(115, 15);
            dataentregaLabel.TabIndex = 51;
            dataentregaLabel.Text = "Data de Entrega:";
            // 
            // cod_cliLabel
            // 
            cod_cliLabel.AutoSize = true;
            cod_cliLabel.Location = new System.Drawing.Point(182, 13);
            cod_cliLabel.Name = "cod_cliLabel";
            cod_cliLabel.Size = new System.Drawing.Size(56, 15);
            cod_cliLabel.TabIndex = 53;
            cod_cliLabel.Text = "Cliente:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(6, 67);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(36, 15);
            obsLabel.TabIndex = 55;
            obsLabel.Text = "Obs:";
            // 
            // cod_proLabel
            // 
            cod_proLabel.AutoSize = true;
            cod_proLabel.Location = new System.Drawing.Point(15, 21);
            cod_proLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cod_proLabel.Name = "cod_proLabel";
            cod_proLabel.Size = new System.Drawing.Size(61, 15);
            cod_proLabel.TabIndex = 0;
            cod_proLabel.Text = "Produto:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(163, 21);
            quantidadeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(85, 15);
            quantidadeLabel.TabIndex = 2;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.Location = new System.Drawing.Point(271, 21);
            precounitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(103, 15);
            precounitLabel.TabIndex = 4;
            precounitLabel.Text = "Preço Unitário:";
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(393, 21);
            subtotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(68, 15);
            subtotalLabel.TabIndex = 6;
            subtotalLabel.Text = "SubTotal:";
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.AutoGenerateColumns = false;
            this.dgvVenda.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_venda,
            this.cod_cli,
            this.nome,
            this.datavenda,
            this.dataentrega,
            this.obs});
            this.dgvVenda.DataSource = this.pc_vendaBindingSource;
            this.dgvVenda.Location = new System.Drawing.Point(9, 223);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.RowHeadersWidth = 62;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(755, 119);
            this.dgvVenda.TabIndex = 47;
            this.dgvVenda.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVenda_CellFormatting);
            this.dgvVenda.SelectionChanged += new System.EventHandler(this.dgvVenda_SelectionChanged);
            // 
            // num_venda
            // 
            this.num_venda.DataPropertyName = "num_venda";
            this.num_venda.HeaderText = "Venda";
            this.num_venda.MinimumWidth = 8;
            this.num_venda.Name = "num_venda";
            this.num_venda.ReadOnly = true;
            this.num_venda.Width = 50;
            // 
            // cod_cli
            // 
            this.cod_cli.DataPropertyName = "cod_cli";
            this.cod_cli.HeaderText = "Cliente";
            this.cod_cli.MinimumWidth = 8;
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.ReadOnly = true;
            this.cod_cli.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 8;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 150;
            // 
            // datavenda
            // 
            this.datavenda.DataPropertyName = "datavenda";
            this.datavenda.HeaderText = "Data da Venda";
            this.datavenda.MinimumWidth = 8;
            this.datavenda.Name = "datavenda";
            this.datavenda.ReadOnly = true;
            this.datavenda.Width = 150;
            // 
            // dataentrega
            // 
            this.dataentrega.DataPropertyName = "dataentrega";
            this.dataentrega.HeaderText = "Data da entrega";
            this.dataentrega.MinimumWidth = 8;
            this.dataentrega.Name = "dataentrega";
            this.dataentrega.ReadOnly = true;
            this.dataentrega.Width = 150;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "Obs";
            this.obs.MinimumWidth = 8;
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Width = 200;
            // 
            // pc_vendaBindingSource
            // 
            this.pc_vendaBindingSource.DataMember = "pc_venda";
            this.pc_vendaBindingSource.DataSource = this.dataSetVendas;
            // 
            // dataSetVendas
            // 
            this.dataSetVendas.DataSetName = "DataSetVendas";
            this.dataSetVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_vendaBindingSource, "cod_cli", true));
            this.cmbCliente.Location = new System.Drawing.Point(240, 11);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(79, 23);
            this.cmbCliente.TabIndex = 54;
            // 
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_vendaBindingSource, "obs", true));
            this.txtObs.Location = new System.Drawing.Point(77, 67);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(304, 64);
            this.txtObs.TabIndex = 56;
            // 
            // grpItem
            // 
            this.grpItem.BackColor = System.Drawing.Color.Tan;
            this.grpItem.Controls.Add(this.txtSubTotal);
            this.grpItem.Controls.Add(this.txtPrecoUnit);
            this.grpItem.Controls.Add(this.nudQuantidade);
            this.grpItem.Controls.Add(subtotalLabel);
            this.grpItem.Controls.Add(this.panel1);
            this.grpItem.Controls.Add(precounitLabel);
            this.grpItem.Controls.Add(quantidadeLabel);
            this.grpItem.Controls.Add(cod_proLabel);
            this.grpItem.Controls.Add(this.cmbProduto);
            this.grpItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpItem.Location = new System.Drawing.Point(9, 399);
            this.grpItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpItem.Name = "grpItem";
            this.grpItem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpItem.Size = new System.Drawing.Size(755, 80);
            this.grpItem.TabIndex = 57;
            this.grpItem.TabStop = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "subtotal", true));
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(396, 37);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(90, 21);
            this.txtSubTotal.TabIndex = 61;
            // 
            // pc_itemvendaBindingSource
            // 
            this.pc_itemvendaBindingSource.DataMember = "pc_itemvenda";
            this.pc_itemvendaBindingSource.DataSource = this.dataSetVendas;
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "precounit", true));
            this.txtPrecoUnit.Enabled = false;
            this.txtPrecoUnit.Location = new System.Drawing.Point(273, 37);
            this.txtPrecoUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.ReadOnly = true;
            this.txtPrecoUnit.Size = new System.Drawing.Size(95, 21);
            this.txtPrecoUnit.TabIndex = 60;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_itemvendaBindingSource, "quantidade", true));
            this.nudQuantidade.Location = new System.Drawing.Point(165, 37);
            this.nudQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(80, 21);
            this.nudQuantidade.TabIndex = 59;
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(506, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 47);
            this.panel1.TabIndex = 58;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(124, 15);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(106, 21);
            this.txtTotal.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total da Venda:";
            // 
            // cmbProduto
            // 
            this.cmbProduto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "cod_pro", true));
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(17, 35);
            this.cmbProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 23);
            this.cmbProduto.TabIndex = 1;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_pro,
            this.descricao,
            this.quantidade,
            this.precounit,
            this.subtotal});
            this.dgvItens.DataSource = this.pc_itemvendaBindingSource;
            this.dgvItens.Location = new System.Drawing.Point(10, 492);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersWidth = 62;
            this.dgvItens.RowTemplate.Height = 28;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(754, 122);
            this.dgvItens.TabIndex = 57;
            this.dgvItens.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvItemVenda_CellFormatting);
            // 
            // cod_pro
            // 
            this.cod_pro.DataPropertyName = "cod_pro";
            this.cod_pro.HeaderText = "Produto";
            this.cod_pro.MinimumWidth = 8;
            this.cod_pro.Name = "cod_pro";
            this.cod_pro.ReadOnly = true;
            this.cod_pro.Width = 50;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descricao";
            this.descricao.MinimumWidth = 8;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 150;
            // 
            // quantidade
            // 
            this.quantidade.DataPropertyName = "quantidade";
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.MinimumWidth = 8;
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 150;
            // 
            // precounit
            // 
            this.precounit.DataPropertyName = "precounit";
            dataGridViewCellStyle1.Format = "R$#,###,00";
            this.precounit.DefaultCellStyle = dataGridViewCellStyle1;
            this.precounit.HeaderText = "Preço Unitário";
            this.precounit.MinimumWidth = 8;
            this.precounit.Name = "precounit";
            this.precounit.ReadOnly = true;
            this.precounit.Width = 150;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            dataGridViewCellStyle2.Format = "R$#,###,00";
            dataGridViewCellStyle2.NullValue = null;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.subtotal.HeaderText = "Sub Total";
            this.subtotal.MinimumWidth = 8;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPesquisar);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Location = new System.Drawing.Point(511, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 28);
            this.panel2.TabIndex = 93;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.Linen;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPesquisar.Location = new System.Drawing.Point(3, 5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(119, 21);
            this.txtPesquisar.TabIndex = 43;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPesquisar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPesquisar.Image = global::WfaPrjVendas.Properties.Resources.search;
            this.btnPesquisar.Location = new System.Drawing.Point(128, 4);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(38, 20);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.Text = "&";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tan;
            this.groupBox2.Controls.Add(this.dtpDataEntrega);
            this.groupBox2.Controls.Add(this.dtpDataVenda);
            this.groupBox2.Controls.Add(this.txtNum_venda);
            this.groupBox2.Controls.Add(num_vendaLabel);
            this.groupBox2.Controls.Add(datavendaLabel);
            this.groupBox2.Controls.Add(dataentregaLabel);
            this.groupBox2.Controls.Add(cod_cliLabel);
            this.groupBox2.Controls.Add(this.cmbCliente);
            this.groupBox2.Controls.Add(obsLabel);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 72);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(427, 146);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEntrega.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_vendaBindingSource, "dataentrega", true));
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEntrega.Location = new System.Drawing.Point(322, 39);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(93, 21);
            this.dtpDataEntrega.TabIndex = 58;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.CustomFormat = "dd/MM/yyyy";
            this.dtpDataVenda.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pc_vendaBindingSource, "datavenda", true));
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataVenda.Location = new System.Drawing.Point(111, 41);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(92, 21);
            this.dtpDataVenda.TabIndex = 57;
            // 
            // txtNum_venda
            // 
            this.txtNum_venda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_vendaBindingSource, "num_venda", true));
            this.txtNum_venda.Enabled = false;
            this.txtNum_venda.Location = new System.Drawing.Point(91, 12);
            this.txtNum_venda.Name = "txtNum_venda";
            this.txtNum_venda.ReadOnly = true;
            this.txtNum_venda.Size = new System.Drawing.Size(84, 21);
            this.txtNum_venda.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPesquisarItem);
            this.panel3.Controls.Add(this.btnPesquisarItem);
            this.panel3.Location = new System.Drawing.Point(433, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 28);
            this.panel3.TabIndex = 101;
            // 
            // txtPesquisarItem
            // 
            this.txtPesquisarItem.BackColor = System.Drawing.Color.Linen;
            this.txtPesquisarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPesquisarItem.Location = new System.Drawing.Point(3, 5);
            this.txtPesquisarItem.Name = "txtPesquisarItem";
            this.txtPesquisarItem.Size = new System.Drawing.Size(119, 21);
            this.txtPesquisarItem.TabIndex = 43;
            // 
            // btnPesquisarItem
            // 
            this.btnPesquisarItem.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnPesquisarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPesquisarItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPesquisarItem.Image = global::WfaPrjVendas.Properties.Resources.search;
            this.btnPesquisarItem.Location = new System.Drawing.Point(128, 4);
            this.btnPesquisarItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisarItem.Name = "btnPesquisarItem";
            this.btnPesquisarItem.Size = new System.Drawing.Size(38, 20);
            this.btnPesquisarItem.TabIndex = 36;
            this.btnPesquisarItem.Text = "&";
            this.btnPesquisarItem.UseVisualStyleBackColor = true;
            this.btnPesquisarItem.Click += new System.EventHandler(this.btnPesquisarItem_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCancelarItem.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnCancelarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelarItem.Image = global::WfaPrjVendas.Properties.Resources.cross;
            this.btnCancelarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarItem.Location = new System.Drawing.Point(338, 359);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancelarItem.Size = new System.Drawing.Size(89, 28);
            this.btnCancelarItem.TabIndex = 99;
            this.btnCancelarItem.Text = "&Cancelar";
            this.btnCancelarItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarItem.UseVisualStyleBackColor = false;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnGravarItem
            // 
            this.btnGravarItem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnGravarItem.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnGravarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGravarItem.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGravarItem.Image = global::WfaPrjVendas.Properties.Resources.download;
            this.btnGravarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravarItem.Location = new System.Drawing.Point(254, 359);
            this.btnGravarItem.Name = "btnGravarItem";
            this.btnGravarItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnGravarItem.Size = new System.Drawing.Size(78, 28);
            this.btnGravarItem.TabIndex = 98;
            this.btnGravarItem.Text = "&Gravar";
            this.btnGravarItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravarItem.UseVisualStyleBackColor = false;
            this.btnGravarItem.Click += new System.EventHandler(this.btnGravarItem_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnExcluirItem.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnExcluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnExcluirItem.Image = global::WfaPrjVendas.Properties.Resources.trash;
            this.btnExcluirItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirItem.Location = new System.Drawing.Point(169, 359);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnExcluirItem.Size = new System.Drawing.Size(81, 28);
            this.btnExcluirItem.TabIndex = 97;
            this.btnExcluirItem.Text = "&Apagar";
            this.btnExcluirItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEditarItem.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnEditarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEditarItem.Image = global::WfaPrjVendas.Properties.Resources.pencil;
            this.btnEditarItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarItem.Location = new System.Drawing.Point(86, 359);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnEditarItem.Size = new System.Drawing.Size(77, 28);
            this.btnEditarItem.TabIndex = 96;
            this.btnEditarItem.Text = "&Editar";
            this.btnEditarItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarItem.UseVisualStyleBackColor = false;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIncluirItem.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnIncluirItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIncluirItem.Image = global::WfaPrjVendas.Properties.Resources.plus;
            this.btnIncluirItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirItem.Location = new System.Drawing.Point(9, 359);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnIncluirItem.Size = new System.Drawing.Size(74, 28);
            this.btnIncluirItem.TabIndex = 95;
            this.btnIncluirItem.Text = "&Incluir";
            this.btnIncluirItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluirItem.UseVisualStyleBackColor = false;
            this.btnIncluirItem.Click += new System.EventHandler(this.btnIncluirItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSair.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSair.Image = global::WfaPrjVendas.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(690, 24);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSair.Size = new System.Drawing.Size(65, 28);
            this.btnSair.TabIndex = 46;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnListar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnListar.Image = global::WfaPrjVendas.Properties.Resources.lista_de_mesas;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Location = new System.Drawing.Point(434, 24);
            this.btnListar.Name = "btnListar";
            this.btnListar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnListar.Size = new System.Drawing.Size(72, 28);
            this.btnListar.TabIndex = 45;
            this.btnListar.Text = "&Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCancelar.Image = global::WfaPrjVendas.Properties.Resources.cross;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(338, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancelar.Size = new System.Drawing.Size(89, 28);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnGravar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnGravar.Image = global::WfaPrjVendas.Properties.Resources.download;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(255, 24);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnGravar.Size = new System.Drawing.Size(78, 28);
            this.btnGravar.TabIndex = 43;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnApagar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnApagar.Image = global::WfaPrjVendas.Properties.Resources.trash;
            this.btnApagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApagar.Location = new System.Drawing.Point(170, 24);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnApagar.Size = new System.Drawing.Size(81, 28);
            this.btnApagar.TabIndex = 41;
            this.btnApagar.Text = "&Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEditar.Image = global::WfaPrjVendas.Properties.Resources.pencil;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(87, 24);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnEditar.Size = new System.Drawing.Size(77, 28);
            this.btnEditar.TabIndex = 40;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnIncluir.Image = global::WfaPrjVendas.Properties.Resources.plus;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(9, 24);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnIncluir.Size = new System.Drawing.Size(74, 28);
            this.btnIncluir.TabIndex = 39;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // pc_itemvendaTableAdapter
            // 
            this.pc_itemvendaTableAdapter.ClearBeforeFill = true;
            // 
            // pc_vendaTableAdapter
            // 
            this.pc_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_itemvendaTableAdapter = null;
            this.tableAdapterManager.pc_produtoTableAdapter = null;
            this.tableAdapterManager.pc_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaPrjVendas.DataSetVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmCadVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(779, 630);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCancelarItem);
            this.Controls.Add(this.btnGravarItem);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.btnEditarItem);
            this.Controls.Add(this.btnIncluirItem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.grpItem);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadVendas";
            this.Text = "Cadastro de Vendas";
            
            this.Load += new System.EventHandler(this.FrmCadVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).EndInit();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetVendas dataSetVendas;
        private System.Windows.Forms.BindingSource pc_itemvendaBindingSource;
        private DataSetVendasTableAdapters.pc_itemvendaTableAdapter pc_itemvendaTableAdapter;
        private DataSetVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetVendasTableAdapters.pc_vendaTableAdapter pc_vendaTableAdapter;
        private System.Windows.Forms.BindingSource pc_vendaBindingSource;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.GroupBox grpItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnIncluir;
        protected internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        protected internal System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPesquisarItem;
        private System.Windows.Forms.Button btnPesquisarItem;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.TextBox txtNum_venda;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_pro;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn precounit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}
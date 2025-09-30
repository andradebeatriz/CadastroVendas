namespace WfaPrjVendas
{
    partial class FrmCadProduto
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
            System.Windows.Forms.Label cod_proLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label precounitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadProduto));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pc_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVendas = new WfaPrjVendas.DataSetVendas();
            this.txtCod_pro = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.NudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pc_produtoTableAdapter = new WfaPrjVendas.DataSetVendasTableAdapters.pc_produtoTableAdapter();
            this.tableAdapterManager = new WfaPrjVendas.DataSetVendasTableAdapters.TableAdapterManager();
            cod_proLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cod_proLabel
            // 
            cod_proLabel.AutoSize = true;
            cod_proLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            cod_proLabel.Location = new System.Drawing.Point(67, 31);
            cod_proLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cod_proLabel.Name = "cod_proLabel";
            cod_proLabel.Size = new System.Drawing.Size(54, 17);
            cod_proLabel.TabIndex = 47;
            cod_proLabel.Text = "Código:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            descricaoLabel.Location = new System.Drawing.Point(54, 54);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(68, 17);
            descricaoLabel.TabIndex = 49;
            descricaoLabel.Text = "Descrição:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            quantidadeLabel.Location = new System.Drawing.Point(42, 79);
            quantidadeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(82, 17);
            quantidadeLabel.TabIndex = 51;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            precounitLabel.Location = new System.Drawing.Point(49, 103);
            precounitLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(74, 17);
            precounitLabel.TabIndex = 53;
            precounitLabel.Text = "Preço Unit:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSair.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSair.Image = global::WfaPrjVendas.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(711, 16);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSair.Size = new System.Drawing.Size(71, 27);
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
            this.btnListar.Location = new System.Drawing.Point(449, 16);
            this.btnListar.Name = "btnListar";
            this.btnListar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnListar.Size = new System.Drawing.Size(74, 27);
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
            this.btnCancelar.Location = new System.Drawing.Point(355, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnCancelar.Size = new System.Drawing.Size(89, 27);
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
            this.btnGravar.Location = new System.Drawing.Point(266, 16);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnGravar.Size = new System.Drawing.Size(83, 27);
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
            this.btnApagar.Location = new System.Drawing.Point(179, 15);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnApagar.Size = new System.Drawing.Size(81, 27);
            this.btnApagar.TabIndex = 41;
            this.btnApagar.Text = "&Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEditar.Image = global::WfaPrjVendas.Properties.Resources.pencil;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(95, 16);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnEditar.Size = new System.Drawing.Size(79, 27);
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
            this.btnIncluir.Location = new System.Drawing.Point(9, 16);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnIncluir.Size = new System.Drawing.Size(81, 27);
            this.btnIncluir.TabIndex = 39;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AutoGenerateColumns = false;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvProduto.DataSource = this.pc_produtoBindingSource;
            this.dgvProduto.Location = new System.Drawing.Point(9, 200);
            this.dgvProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersWidth = 62;
            this.dgvProduto.RowTemplate.Height = 28;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(729, 143);
            this.dgvProduto.TabIndex = 47;
            this.dgvProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProduto_CellFormatting);
            this.dgvProduto.SelectionChanged += new System.EventHandler(this.dgvProduto_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_pro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precounit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Preço Unit";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // pc_produtoBindingSource
            // 
            this.pc_produtoBindingSource.DataMember = "pc_produto";
            this.pc_produtoBindingSource.DataSource = this.dataSetVendas;
            // 
            // dataSetVendas
            // 
            this.dataSetVendas.DataSetName = "DataSetVendas";
            this.dataSetVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCod_pro
            // 
            this.txtCod_pro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "cod_pro", true));
            this.txtCod_pro.Enabled = false;
            this.txtCod_pro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtCod_pro.Location = new System.Drawing.Point(135, 29);
            this.txtCod_pro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCod_pro.Name = "txtCod_pro";
            this.txtCod_pro.ReadOnly = true;
            this.txtCod_pro.Size = new System.Drawing.Size(68, 24);
            this.txtCod_pro.TabIndex = 48;
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_produtoBindingSource, "descricao", true));
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtDescricao.Location = new System.Drawing.Point(135, 52);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(187, 24);
            this.txtDescricao.TabIndex = 50;
            // 
            // NudQuantidade
            // 
            this.NudQuantidade.Enabled = false;
            this.NudQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.NudQuantidade.Location = new System.Drawing.Point(135, 78);
            this.NudQuantidade.Name = "NudQuantidade";
            this.NudQuantidade.Size = new System.Drawing.Size(69, 24);
            this.NudQuantidade.TabIndex = 90;
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.Enabled = false;
            this.txtPrecoUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtPrecoUnit.Location = new System.Drawing.Point(135, 101);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.Size = new System.Drawing.Size(93, 24);
            this.txtPrecoUnit.TabIndex = 91;
            this.txtPrecoUnit.Text = "R$ 00,00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Location = new System.Drawing.Point(530, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 27);
            this.panel1.TabIndex = 92;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BackColor = System.Drawing.Color.Linen;
            this.txtPesquisar.Location = new System.Drawing.Point(3, 5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(119, 20);
            this.txtPesquisar.TabIndex = 43;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnPesquisar.Image = global::WfaPrjVendas.Properties.Resources.search;
            this.btnPesquisar.Location = new System.Drawing.Point(128, 4);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(37, 20);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.Text = "&";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.txtPrecoUnit);
            this.groupBox1.Controls.Add(this.NudQuantidade);
            this.groupBox1.Controls.Add(cod_proLabel);
            this.groupBox1.Controls.Add(this.txtCod_pro);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(precounitLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(365, 134);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de produto";
            // 
            // pc_produtoTableAdapter
            // 
            this.pc_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_itemvendaTableAdapter = null;
            this.tableAdapterManager.pc_produtoTableAdapter = this.pc_produtoTableAdapter;
            this.tableAdapterManager.pc_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaPrjVendas.DataSetVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(787, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmCadProduto";
            this.Text = "FrmCadProduto";
            this.Load += new System.EventHandler(this.FrmCadProduto_Load);
            this.Move += new System.EventHandler(this.pc_produtoBindingNavigatorSaveItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnIncluir;
        private DataSetVendas dataSetVendas;
        private System.Windows.Forms.BindingSource pc_produtoBindingSource;
        private DataSetVendasTableAdapters.pc_produtoTableAdapter pc_produtoTableAdapter;
        private DataSetVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtCod_pro;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.NumericUpDown NudQuantidade;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
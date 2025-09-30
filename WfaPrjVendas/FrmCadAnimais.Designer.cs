using WfaPrjVendas;

namespace FrmAnimais
{
    partial class FrmAnimal
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label tutorLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label datanascLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnimal));
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVendas = new WfaPrjVendas.DataSetVendas();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.dgvAnimal = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.btnUpload = new System.Windows.Forms.Button();
            this.grpCampos = new System.Windows.Forms.GroupBox();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.fotoTextBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.animalTableAdapter = new WfaPrjVendas.DataSetVendasTableAdapters.animalTableAdapter();
            this.tableAdapterManager = new WfaPrjVendas.DataSetVendasTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            tutorLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            datanascLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).BeginInit();
            this.grpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoTextBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(113, 33);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 54;
            idLabel.Text = "Id:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(26, 57);
            nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(112, 17);
            nomeLabel.TabIndex = 56;
            nomeLabel.Text = "Nome do animal:";
            // 
            // tutorLabel
            // 
            tutorLabel.AutoSize = true;
            tutorLabel.Location = new System.Drawing.Point(95, 81);
            tutorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tutorLabel.Name = "tutorLabel";
            tutorLabel.Size = new System.Drawing.Size(44, 17);
            tutorLabel.TabIndex = 58;
            tutorLabel.Text = "Tutor:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(99, 107);
            tipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(37, 17);
            tipoLabel.TabIndex = 60;
            tipoLabel.Text = "Tipo:";
            // 
            // datanascLabel
            // 
            datanascLabel.AutoSize = true;
            datanascLabel.Location = new System.Drawing.Point(67, 133);
            datanascLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            datanascLabel.Name = "datanascLabel";
            datanascLabel.Size = new System.Drawing.Size(72, 17);
            datanascLabel.TabIndex = 62;
            datanascLabel.Text = "Data Nasc:";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnListar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnListar.Image = global::WfaPrjVendas.Properties.Resources.lista_de_mesas;
            this.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.Location = new System.Drawing.Point(421, 15);
            this.btnListar.Name = "btnListar";
            this.btnListar.Padding = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.btnListar.Size = new System.Drawing.Size(70, 27);
            this.btnListar.TabIndex = 53;
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
            this.btnCancelar.Location = new System.Drawing.Point(327, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.btnCancelar.Size = new System.Drawing.Size(88, 27);
            this.btnCancelar.TabIndex = 52;
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
            this.btnGravar.Location = new System.Drawing.Point(241, 15);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Padding = new System.Windows.Forms.Padding(3, 0, 2, 0);
            this.btnGravar.Size = new System.Drawing.Size(81, 27);
            this.btnGravar.TabIndex = 51;
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
            this.btnApagar.Location = new System.Drawing.Point(161, 15);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnApagar.Size = new System.Drawing.Size(74, 27);
            this.btnApagar.TabIndex = 49;
            this.btnApagar.Text = "&Apagar";
            this.btnApagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::WfaPrjVendas.Properties.Resources.pencil;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(89, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.btnEditar.Size = new System.Drawing.Size(67, 27);
            this.btnEditar.TabIndex = 48;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.BurlyWood;
            this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Image = global::WfaPrjVendas.Properties.Resources.plus;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(17, 15);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnIncluir.Size = new System.Drawing.Size(67, 27);
            this.btnIncluir.TabIndex = 47;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "nome", true));
            this.txtNome.Location = new System.Drawing.Point(141, 54);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 25);
            this.txtNome.TabIndex = 57;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.dataSetVendas;
            // 
            // dataSetVendas
            // 
            this.dataSetVendas.DataSetName = "DataSetVendas";
            this.dataSetVendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTutor
            // 
            this.txtTutor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "tutor", true));
            this.txtTutor.Location = new System.Drawing.Point(141, 79);
            this.txtTutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(148, 25);
            this.txtTutor.TabIndex = 59;
            // 
            // txtTipo
            // 
            this.txtTipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "tipo", true));
            this.txtTipo.Location = new System.Drawing.Point(141, 105);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(148, 25);
            this.txtTipo.TabIndex = 61;
            // 
            // dgvAnimal
            // 
            this.dgvAnimal.AllowUserToAddRows = false;
            this.dgvAnimal.AllowUserToDeleteRows = false;
            this.dgvAnimal.AutoGenerateColumns = false;
            this.dgvAnimal.BackgroundColor = System.Drawing.Color.Linen;
            this.dgvAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.tutor,
            this.tipo,
            this.datanasc,
            this.foto});
            this.dgvAnimal.DataSource = this.animalBindingSource;
            this.dgvAnimal.Location = new System.Drawing.Point(17, 256);
            this.dgvAnimal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAnimal.Name = "dgvAnimal";
            this.dgvAnimal.ReadOnly = true;
            this.dgvAnimal.RowHeadersWidth = 62;
            this.dgvAnimal.RowTemplate.Height = 28;
            this.dgvAnimal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimal.Size = new System.Drawing.Size(733, 143);
            this.dgvAnimal.TabIndex = 65;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
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
            // tutor
            // 
            this.tutor.DataPropertyName = "tutor";
            this.tutor.HeaderText = "Tutor";
            this.tutor.MinimumWidth = 8;
            this.tutor.Name = "tutor";
            this.tutor.ReadOnly = true;
            this.tutor.Width = 150;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.MinimumWidth = 8;
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 150;
            // 
            // datanasc
            // 
            this.datanasc.DataPropertyName = "datanasc";
            this.datanasc.HeaderText = "Data Nasc";
            this.datanasc.MinimumWidth = 8;
            this.datanasc.Name = "datanasc";
            this.datanasc.ReadOnly = true;
            this.datanasc.Width = 150;
            // 
            // foto
            // 
            this.foto.DataPropertyName = "foto";
            this.foto.HeaderText = "Foto";
            this.foto.MinimumWidth = 8;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 200;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(141, 30);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(77, 25);
            this.txtId.TabIndex = 66;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNasc.Location = new System.Drawing.Point(141, 131);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(105, 25);
            this.dtpDataNasc.TabIndex = 67;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Bisque;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Image = global::WfaPrjVendas.Properties.Resources.upload;
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(366, 158);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Padding = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.btnUpload.Size = new System.Drawing.Size(79, 24);
            this.btnUpload.TabIndex = 69;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // grpCampos
            // 
            this.grpCampos.BackColor = System.Drawing.Color.Linen;
            this.grpCampos.Controls.Add(this.txtCaminhoImagem);
            this.grpCampos.Controls.Add(this.btnUpload);
            this.grpCampos.Controls.Add(this.fotoTextBox);
            this.grpCampos.Controls.Add(this.dtpDataNasc);
            this.grpCampos.Controls.Add(this.txtId);
            this.grpCampos.Controls.Add(idLabel);
            this.grpCampos.Controls.Add(nomeLabel);
            this.grpCampos.Controls.Add(this.txtNome);
            this.grpCampos.Controls.Add(tutorLabel);
            this.grpCampos.Controls.Add(this.txtTutor);
            this.grpCampos.Controls.Add(tipoLabel);
            this.grpCampos.Controls.Add(this.txtTipo);
            this.grpCampos.Controls.Add(datanascLabel);
            this.grpCampos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.grpCampos.Location = new System.Drawing.Point(17, 55);
            this.grpCampos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCampos.Name = "grpCampos";
            this.grpCampos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpCampos.Size = new System.Drawing.Size(733, 187);
            this.grpCampos.TabIndex = 70;
            this.grpCampos.TabStop = false;
            this.grpCampos.Text = "Informações do animal:";
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.Location = new System.Drawing.Point(659, 158);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.Size = new System.Drawing.Size(48, 25);
            this.txtCaminhoImagem.TabIndex = 70;
            this.txtCaminhoImagem.Visible = false;
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.Image = ((System.Drawing.Image)(resources.GetObject("fotoTextBox.Image")));
            this.fotoTextBox.Location = new System.Drawing.Point(451, 10);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.Size = new System.Drawing.Size(190, 172);
            this.fotoTextBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoTextBox.TabIndex = 68;
            this.fotoTextBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPesquisar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Location = new System.Drawing.Point(496, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 27);
            this.panel1.TabIndex = 71;
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
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(128, 4);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(37, 20);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.Text = "&";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSair.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSair.Image = global::WfaPrjVendas.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(681, 15);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSair.Size = new System.Drawing.Size(69, 27);
            this.btnSair.TabIndex = 54;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_itemvendaTableAdapter = null;
            this.tableAdapterManager.pc_produtoTableAdapter = null;
            this.tableAdapterManager.pc_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaPrjVendas.DataSetVendasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FrmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(764, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpCampos);
            this.Controls.Add(this.dgvAnimal);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmAnimal";
            this.Text = "FrmCadAnimais";
           
            this.Load += new System.EventHandler(this.FrmAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimal)).EndInit();
            this.grpCampos.ResumeLayout(false);
            this.grpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoTextBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.BindingSource animalBindingSource;
        private WfaPrjVendas.DataSetVendasTableAdapters.animalTableAdapter animalTableAdapter;
        private WfaPrjVendas.DataSetVendasTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.DataGridView dgvAnimal;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.PictureBox fotoTextBox;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.GroupBox grpCampos;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
    }
}
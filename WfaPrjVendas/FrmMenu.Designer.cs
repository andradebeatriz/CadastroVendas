namespace WfaPrjVendas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.tssStatus = new System.Windows.Forms.StatusStrip();
            this.tssITexto = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeclientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDevendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeprodutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeanimaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeprodutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeanimaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoNaHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadoNaVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspFerramentas = new System.Windows.Forms.ToolStrip();
            this.tsbCadClientes = new System.Windows.Forms.ToolStripButton();
            this.tsbCadVendas = new System.Windows.Forms.ToolStripButton();
            this.tsbCadProduto = new System.Windows.Forms.ToolStripButton();
            this.tsbAnimal = new System.Windows.Forms.ToolStripButton();
            this.tsbRelatorio = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.trmHora = new System.Windows.Forms.Timer(this.components);
            this.tssStatus.SuspendLayout();
            this.mnuMenu.SuspendLayout();
            this.tspFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tssStatus
            // 
            this.tssStatus.BackColor = System.Drawing.Color.Linen;
            this.tssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssITexto,
            this.toolStripStatusLabel1});
            this.tssStatus.Location = new System.Drawing.Point(0, 428);
            this.tssStatus.Name = "tssStatus";
            this.tssStatus.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.tssStatus.Size = new System.Drawing.Size(800, 22);
            this.tssStatus.TabIndex = 0;
            this.tssStatus.Text = "statusStrip1";
            // 
            // tssITexto
            // 
            this.tssITexto.BackColor = System.Drawing.Color.Linen;
            this.tssITexto.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssITexto.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tssITexto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tssITexto.Name = "tssITexto";
            this.tssITexto.Size = new System.Drawing.Size(584, 17);
            this.tssITexto.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(200, 17);
            // 
            // mnuMenu
            // 
            this.mnuMenu.BackColor = System.Drawing.Color.Peru;
            this.mnuMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuMenu.Size = new System.Drawing.Size(800, 28);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "mnuMenu";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeclientesToolStripMenuItem,
            this.cadastroDevendasToolStripMenuItem,
            this.cadastroDeprodutosToolStripMenuItem,
            this.cadastroDeanimaisToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.pasta;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // cadastroDeclientesToolStripMenuItem
            // 
            this.cadastroDeclientesToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.user;
            this.cadastroDeclientesToolStripMenuItem.Name = "cadastroDeclientesToolStripMenuItem";
            this.cadastroDeclientesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cadastroDeclientesToolStripMenuItem.Text = "Cadastro de &clientes";
            this.cadastroDeclientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeclientesToolStripMenuItem_Click);
            // 
            // cadastroDevendasToolStripMenuItem
            // 
            this.cadastroDevendasToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.icons8_vendas_96;
            this.cadastroDevendasToolStripMenuItem.Name = "cadastroDevendasToolStripMenuItem";
            this.cadastroDevendasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cadastroDevendasToolStripMenuItem.Text = "Cadastro de &vendas";
            this.cadastroDevendasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDevendasToolStripMenuItem_Click);
            // 
            // cadastroDeprodutosToolStripMenuItem
            // 
            this.cadastroDeprodutosToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.adicionar_produto;
            this.cadastroDeprodutosToolStripMenuItem.Name = "cadastroDeprodutosToolStripMenuItem";
            this.cadastroDeprodutosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cadastroDeprodutosToolStripMenuItem.Text = "Cadastro de &produtos";
            this.cadastroDeprodutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeprodutosToolStripMenuItem_Click);
            // 
            // cadastroDeanimaisToolStripMenuItem
            // 
            this.cadastroDeanimaisToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.animal;
            this.cadastroDeanimaisToolStripMenuItem.Name = "cadastroDeanimaisToolStripMenuItem";
            this.cadastroDeanimaisToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cadastroDeanimaisToolStripMenuItem.Text = "Cadastro de &animais";
            this.cadastroDeanimaisToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeanimaisToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.sair;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeToolStripMenuItem,
            this.relatórioDeVendasToolStripMenuItem,
            this.relatórioDeprodutosToolStripMenuItem,
            this.relatórioDeanimaisToolStripMenuItem});
            this.relatoriosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.relatoriosToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.relatorio;
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.relatoriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // relatórioDeToolStripMenuItem
            // 
            this.relatórioDeToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.user;
            this.relatórioDeToolStripMenuItem.Name = "relatórioDeToolStripMenuItem";
            this.relatórioDeToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.relatórioDeToolStripMenuItem.Text = "Relatório de &clientes";
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            this.relatórioDeVendasToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.icons8_vendas_96;
            this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.relatórioDeVendasToolStripMenuItem.Text = "Relatório de &vendas";
            // 
            // relatórioDeprodutosToolStripMenuItem
            // 
            this.relatórioDeprodutosToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.adicionar_produto;
            this.relatórioDeprodutosToolStripMenuItem.Name = "relatórioDeprodutosToolStripMenuItem";
            this.relatórioDeprodutosToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.relatórioDeprodutosToolStripMenuItem.Text = "Relatório de &produtos";
            // 
            // relatórioDeanimaisToolStripMenuItem
            // 
            this.relatórioDeanimaisToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.animal;
            this.relatórioDeanimaisToolStripMenuItem.Name = "relatórioDeanimaisToolStripMenuItem";
            this.relatórioDeanimaisToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.relatórioDeanimaisToolStripMenuItem.Text = "Relatório de &animais";
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarToolStripMenuItem});
            this.janelasToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.desktop;
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // organizarToolStripMenuItem
            // 
            this.organizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascataToolStripMenuItem,
            this.ladoALadoNaHorizontalToolStripMenuItem,
            this.ladoALadoNaVerticalToolStripMenuItem});
            this.organizarToolStripMenuItem.Name = "organizarToolStripMenuItem";
            this.organizarToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.organizarToolStripMenuItem.Text = "Organizar";
            // 
            // cascataToolStripMenuItem
            // 
            this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
            this.cascataToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.cascataToolStripMenuItem.Text = "Cascata";
            this.cascataToolStripMenuItem.Click += new System.EventHandler(this.cascataToolStripMenuItem_Click);
            // 
            // ladoALadoNaHorizontalToolStripMenuItem
            // 
            this.ladoALadoNaHorizontalToolStripMenuItem.Name = "ladoALadoNaHorizontalToolStripMenuItem";
            this.ladoALadoNaHorizontalToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.ladoALadoNaHorizontalToolStripMenuItem.Text = "Lado a Lado na &Horizontal";
            this.ladoALadoNaHorizontalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoNaHorizontalToolStripMenuItem_Click);
            // 
            // ladoALadoNaVerticalToolStripMenuItem
            // 
            this.ladoALadoNaVerticalToolStripMenuItem.Name = "ladoALadoNaVerticalToolStripMenuItem";
            this.ladoALadoNaVerticalToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.ladoALadoNaVerticalToolStripMenuItem.Text = "Lado a Lado na &Vertical";
            this.ladoALadoNaVerticalToolStripMenuItem.Click += new System.EventHandler(this.ladoALadoNaVerticalToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topicosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Image = global::WfaPrjVendas.Properties.Resources.ajuda;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // topicosToolStripMenuItem
            // 
            this.topicosToolStripMenuItem.Name = "topicosToolStripMenuItem";
            this.topicosToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.topicosToolStripMenuItem.Text = "&Tópicos";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.sobreToolStripMenuItem.Text = "&Sobre o sistema";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // tspFerramentas
            // 
            this.tspFerramentas.BackColor = System.Drawing.Color.BurlyWood;
            this.tspFerramentas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tspFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCadClientes,
            this.tsbCadVendas,
            this.tsbCadProduto,
            this.tsbAnimal,
            this.tsbRelatorio,
            this.tsbSair});
            this.tspFerramentas.Location = new System.Drawing.Point(0, 28);
            this.tspFerramentas.Name = "tspFerramentas";
            this.tspFerramentas.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tspFerramentas.Size = new System.Drawing.Size(800, 27);
            this.tspFerramentas.TabIndex = 2;
            this.tspFerramentas.Text = "tspFerramentas";
            // 
            // tsbCadClientes
            // 
            this.tsbCadClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadClientes.Image = global::WfaPrjVendas.Properties.Resources.user;
            this.tsbCadClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadClientes.Name = "tsbCadClientes";
            this.tsbCadClientes.Size = new System.Drawing.Size(24, 24);
            this.tsbCadClientes.Text = "Cadastro de clientes";
            this.tsbCadClientes.Click += new System.EventHandler(this.tsbCadClientes_Click);
            // 
            // tsbCadVendas
            // 
            this.tsbCadVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadVendas.Image = global::WfaPrjVendas.Properties.Resources.icons8_vendas_96;
            this.tsbCadVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadVendas.Name = "tsbCadVendas";
            this.tsbCadVendas.Size = new System.Drawing.Size(24, 24);
            this.tsbCadVendas.Text = "Cadastro de vendas";
            this.tsbCadVendas.Click += new System.EventHandler(this.tsbCadVendas_Click);
            // 
            // tsbCadProduto
            // 
            this.tsbCadProduto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCadProduto.Image = global::WfaPrjVendas.Properties.Resources.adicionar_produto;
            this.tsbCadProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCadProduto.Name = "tsbCadProduto";
            this.tsbCadProduto.Size = new System.Drawing.Size(24, 24);
            this.tsbCadProduto.Text = "Cadastro de produtos";
            this.tsbCadProduto.Click += new System.EventHandler(this.tsbCadProduto_Click);
            // 
            // tsbAnimal
            // 
            this.tsbAnimal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnimal.Image = global::WfaPrjVendas.Properties.Resources.animal;
            this.tsbAnimal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnimal.Name = "tsbAnimal";
            this.tsbAnimal.Size = new System.Drawing.Size(24, 24);
            this.tsbAnimal.Text = "Cadastro de animais";
            this.tsbAnimal.Click += new System.EventHandler(this.tsbAnimal_Click);
            // 
            // tsbRelatorio
            // 
            this.tsbRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRelatorio.Image = global::WfaPrjVendas.Properties.Resources.relatorio;
            this.tsbRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRelatorio.Name = "tsbRelatorio";
            this.tsbRelatorio.Size = new System.Drawing.Size(36, 24);
            this.tsbRelatorio.Text = "Cadastro de relatórios";
            this.tsbRelatorio.ButtonClick += new System.EventHandler(this.tsbRelatorio_ButtonClick);
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = global::WfaPrjVendas.Properties.Resources.sair;
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(24, 24);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // trmHora
            // 
            this.trmHora.Enabled = true;
            this.trmHora.Tick += new System.EventHandler(this.trmHora_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tspFerramentas);
            this.Controls.Add(this.tssStatus);
            this.Controls.Add(this.mnuMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuMenu;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Controle de vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.tssStatus.ResumeLayout(false);
            this.tssStatus.PerformLayout();
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.tspFerramentas.ResumeLayout(false);
            this.tspFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip tssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssITexto;
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStrip tspFerramentas;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeclientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDevendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeprodutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeanimaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeprodutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeanimaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoNaHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadoNaVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbCadClientes;
        private System.Windows.Forms.ToolStripButton tsbCadVendas;
        private System.Windows.Forms.ToolStripButton tsbCadProduto;
        private System.Windows.Forms.ToolStripButton tsbAnimal;
        private System.Windows.Forms.ToolStripSplitButton tsbRelatorio;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Timer trmHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
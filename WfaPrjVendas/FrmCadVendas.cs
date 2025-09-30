using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WfaPrjVendas
{
    public partial class FrmCadVendas : Form
    {
        bool incluir = false;
        bool editar = false;
        bool editarItem = false;
        bool incluirItem = false;
        double precoTemp = 0;
        private int codProdutoAntigo = 0;
        string conexao = Properties.Settings.Default.ConnectionString;

        public FrmCadVendas()
        {
            InitializeComponent();
        }

        private void FrmCadVendas_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void dgvVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            DataGridView grid = (DataGridView)sender;

            if (grid.Columns[e.ColumnIndex].Name == "datavenda" ||
                grid.Columns[e.ColumnIndex].Name == "dataentrega")
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dt))
                {
                    e.Value = dt.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }


        private void dgvItemVenda_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0 || e.Value == null) return;
                DataGridView grid = (DataGridView)sender;

                // Formata preço unitário
                if (grid.Columns[e.ColumnIndex].Name == "precounit" ||
                grid.Columns[e.ColumnIndex].DataPropertyName == "precounit")
                {
                    if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                    {
                        e.Value = valor.ToString("R$ #,##0.00");
                        e.FormattingApplied = true;
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment =
                            DataGridViewContentAlignment.MiddleLeft;
                    }
                }

                // Formata subtotal
                else if (grid.Columns[e.ColumnIndex].Name == "subtotal" ||
                         grid.Columns[e.ColumnIndex].DataPropertyName == "subtotal")
                {
                    if (decimal.TryParse(e.Value.ToString(), out decimal valor))
                    {
                        e.Value = valor.ToString("R$ #,##0.00");
                        e.FormattingApplied = true;
                        grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment =
                            DataGridViewContentAlignment.MiddleLeft;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void CarregarDados()
        {
            try
            {
                CarregarClientes();
                CarregarProdutos();
                CarregarVendas();
                LimparCampos();
                habilitaBotoes(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void CarregarClientes()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    string query = "SELECT cod_cli, nome FROM pc_clientes";
                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbCliente.DataSource = dt;
                    cmbCliente.DisplayMember = "nome";
                    cmbCliente.ValueMember = "cod_cli";
                    cmbCliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
            }
        }

        private void CarregarProdutos()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    string query = "SELECT cod_pro, descricao, precounit FROM pc_produto";
                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbProduto.DataSource = dt;
                    cmbProduto.DisplayMember = "descricao";
                    cmbProduto.ValueMember = "cod_pro";
                    cmbProduto.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        private void CarregarVendas()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    string query = @"SELECT v.num_venda, v.datavenda, v.dataentrega, 
                                    v.cod_cli, c.nome AS nome, v.obs
                             FROM pc_venda v
                             LEFT JOIN pc_clientes c ON v.cod_cli = c.cod_cli";

                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvVenda.DataSource = dt;
                    dgvVenda.Columns["num_venda"].HeaderText = "Venda";
                    dgvVenda.Columns["datavenda"].HeaderText = "Data da Venda";
                    dgvVenda.Columns["dataentrega"].HeaderText = "Data da entrega";
                    dgvVenda.Columns["cod_cli"].HeaderText = "Cliente";
                    dgvVenda.Columns["nome"].HeaderText = "Nome";
                    dgvVenda.Columns["obs"].HeaderText = "Obs";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar vendas: " + ex.Message);
            }
        }


        private void CarregarItensVenda(int numVenda)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    string query = @"SELECT i.*, p.descricao 
                             FROM pc_itemvenda i 
                             INNER JOIN pc_produto p ON i.cod_pro = p.cod_pro 
                             WHERE i.num_venda = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("num_venda", numVenda);
                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (!dt.Columns.Contains("subtotal"))
                            dt.Columns.Add("subtotal", typeof(double));

                        foreach (DataRow row in dt.Rows)
                        {
                            row["subtotal"] = Convert.ToDouble(row["quantidade"]) * Convert.ToDouble(row["precounit"]);
                        }

                        dgvItens.DataSource = dt;

                        double total = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            total += Convert.ToDouble(row["subtotal"]);
                        }
                        txtTotal.Text = total.ToString("R$ #,##0.00");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar itens: " + ex.Message);
            }
        }



        // BOTÕES PRINCIPAIS
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            habilitaCampos(true);
            habilitaBotoes(false);
            incluir = true;
            editar = false;
            txtNum_venda.Enabled = false;

            dtpDataVenda.Focus();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVenda.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma venda para editar!");
                return;
            }

            try
            {
                var row = dgvVenda.CurrentRow;

                txtNum_venda.Text = row.Cells["num_venda"].Value.ToString();
                dtpDataVenda.Value = Convert.ToDateTime(row.Cells["datavenda"].Value);

                if (row.Cells["dataentrega"].Value != DBNull.Value)
                    dtpDataEntrega.Value = Convert.ToDateTime(row.Cells["dataentrega"].Value);

                if (row.Cells["cod_cli"].Value != DBNull.Value)
                    cmbCliente.SelectedValue = Convert.ToInt32(row.Cells["cod_cli"].Value);

                txtObs.Text = row.Cells["obs"].Value?.ToString() ?? "";

                habilitaCampos(true);
                habilitaBotoes(false);
                incluir = false;
                editar = true;
                txtNum_venda.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar venda: " + ex.Message);
            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue == null)
            {
                MessageBox.Show("Selecione um cliente!");
                cmbCliente.Focus();
                return;
            }

            try
            {
                int codCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                int numVenda = 0;

                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    conn.Open();

                    if (incluir)
                    {
                        string insertQuery = @"INSERT INTO pc_venda (datavenda, dataentrega, cod_cli, obs)
                                       VALUES (?, ?, ?, ?)";

                        using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("datavenda", dtpDataVenda.Value);
                            cmd.Parameters.AddWithValue("dataentrega", dtpDataEntrega.Value);
                            cmd.Parameters.AddWithValue("cod_cli", codCliente);
                            cmd.Parameters.AddWithValue("obs", txtObs.Text ?? "");

                            cmd.ExecuteNonQuery();
                        }

                        using (OleDbCommand cmdId = new OleDbCommand("SELECT @@IDENTITY", conn))
                        {
                            numVenda = Convert.ToInt32(cmdId.ExecuteScalar());
                        }

                        txtNum_venda.Text = numVenda.ToString();
                        MessageBox.Show("Venda incluída com sucesso!");
                    }
                    else if (editar)
                    {
                        numVenda = Convert.ToInt32(txtNum_venda.Text);

                        string updateQuery = @"UPDATE pc_venda
                                       SET datavenda = ?, dataentrega = ?, cod_cli = ?, obs = ?
                                       WHERE num_venda = ?";

                        using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("datavenda", dtpDataVenda.Value);
                            cmd.Parameters.AddWithValue("dataentrega", dtpDataEntrega.Value);
                            cmd.Parameters.AddWithValue("cod_cli", codCliente);
                            cmd.Parameters.AddWithValue("obs", txtObs.Text ?? "");
                            cmd.Parameters.AddWithValue("num_venda", numVenda);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Venda alterada com sucesso!");
                    }

                    CarregarVendas();
                    LimparCampos();
                    habilitaBotoes(true);
                    incluir = false;
                    editar = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar venda:\n" + ex.Message);
            }
        }


        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (dgvVenda.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma venda para excluir!");
                return;
            }

            int numVenda = Convert.ToInt32(dgvVenda.CurrentRow.Cells["num_venda"].Value);

            if (MessageBox.Show("Deseja realmente excluir esta venda?", "Confirmação",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection(conexao))
                    {
                        conn.Open();

                        string deleteItens = "DELETE FROM pc_itemvenda WHERE num_venda = ?";
                        using (OleDbCommand cmd = new OleDbCommand(deleteItens, conn))
                        {
                            cmd.Parameters.AddWithValue("num_venda", numVenda);
                            cmd.ExecuteNonQuery();
                        }

                        string deleteVenda = "DELETE FROM pc_venda WHERE num_venda = ?";
                        using (OleDbCommand cmd = new OleDbCommand(deleteVenda, conn))
                        {
                            cmd.Parameters.AddWithValue("num_venda", numVenda);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Venda excluída com sucesso!");
                    CarregarVendas();
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir venda:\n" + ex.Message);
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeProcurado = txtPesquisar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeProcurado))
            {
                MessageBox.Show("Digite um nome para pesquisar.");
                return;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    string query = @"SELECT v.num_venda, v.datavenda, v.dataentrega,
                                    v.cod_cli, c.nome AS nome, v.obs
                             FROM pc_venda v
                             LEFT JOIN pc_clientes c ON v.cod_cli = c.cod_cli
                             WHERE c.nome LIKE ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nome", "%" + nomeProcurado + "%");

                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Nenhuma venda encontrada com esse nome.");
                        }

                        dgvVenda.DataSource = dt;
                        dgvVenda.Columns["num_venda"].HeaderText = "Venda";
                        dgvVenda.Columns["datavenda"].HeaderText = "Data da Venda";
                        dgvVenda.Columns["dataentrega"].HeaderText = "Data de entrega";
                        dgvVenda.Columns["cod_cli"].HeaderText = "Cliente";
                        dgvVenda.Columns["nome"].HeaderText = "Nome";
                        dgvVenda.Columns["obs"].HeaderText = "Obs";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa: " + ex.Message);
            }
        }


        // ITENS DA VENDA
        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            if (dgvVenda.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma venda primeiro!");
                return;
            }

            LimparCamposItem();
            habilitaCamposItem(true);
            habilitaBotoesItem(false);
            incluirItem = true;
            editarItem = false;
            cmbProduto.Focus();
        }

        private void btnGravarItem_Click(object sender, EventArgs e)
        {
            // Validações
            if (cmbProduto.SelectedValue == null)
            {
                MessageBox.Show("Selecione um produto!");
                cmbProduto.Focus();
                return;
            }

            if (nudQuantidade.Value <= 0)
            {
                MessageBox.Show("Quantidade deve ser maior que zero!");
                nudQuantidade.Focus();
                return;
            }

            if (dgvVenda.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma venda primeiro!");
                return;
            }

            try
            {
                int numVenda = Convert.ToInt32(dgvVenda.CurrentRow.Cells["num_venda"].Value);
                int codProduto = Convert.ToInt32(cmbProduto.SelectedValue);
                int quantidade = (int)nudQuantidade.Value;

                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    conn.Open();

                    if (incluirItem)
                    {
                        string checkQuery = @"SELECT quantidade FROM pc_itemvenda
                                      WHERE num_venda = ? AND cod_pro = ?";
                        using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("num_venda", numVenda);
                            checkCmd.Parameters.AddWithValue("cod_pro", codProduto);
                            object result = checkCmd.ExecuteScalar();

                            if (result != null)
                            {
                                int qtdAtual = Convert.ToInt32(result);

                                string updateQuery = @"UPDATE pc_itemvenda
                                               SET quantidade = ?, precounit = ?
                                               WHERE num_venda = ? AND cod_pro = ?";
                                using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("quantidade", qtdAtual + quantidade);
                                    updateCmd.Parameters.AddWithValue("precounit", precoTemp);
                                    updateCmd.Parameters.AddWithValue("num_venda", numVenda);
                                    updateCmd.Parameters.AddWithValue("cod_pro", codProduto);
                                    updateCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Quantidade do produto atualizada na venda!");
                            }
                            else
                            {
                                string insertQuery = @"INSERT INTO pc_itemvenda (num_venda, cod_pro, quantidade, precounit)
                                               VALUES (?, ?, ?, ?)";
                                using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("num_venda", numVenda);
                                    insertCmd.Parameters.AddWithValue("cod_pro", codProduto);
                                    insertCmd.Parameters.AddWithValue("quantidade", quantidade);
                                    insertCmd.Parameters.AddWithValue("precounit", precoTemp);
                                    insertCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Item incluído com sucesso!");
                            }
                        }
                    }
                    else if (editarItem)
                    {
                        string updateQuery = @"UPDATE pc_itemvenda
                                       SET cod_pro = ?, quantidade = ?, precounit = ?
                                       WHERE num_venda = ? AND cod_pro = ?";

                        using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("cod_pro", codProduto);
                            cmd.Parameters.AddWithValue("quantidade", quantidade);
                            cmd.Parameters.AddWithValue("precounit", precoTemp);
                            cmd.Parameters.AddWithValue("num_venda", Convert.ToInt32(dgvVenda.CurrentRow.Cells["num_venda"].Value));
                            cmd.Parameters.AddWithValue("cod_pro_old", codProdutoAntigo);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Item alterado com sucesso!");
                    }

                    CarregarItensVenda(numVenda);
                    LimparCamposItem();
                    habilitaBotoesItem(true);
                    incluirItem = false;
                    editarItem = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar item:\n" + ex.Message);
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduto.SelectedValue == null) return;

            try
            {
                var selectedRow = (DataRowView)cmbProduto.SelectedItem;
                precoTemp = Convert.ToDouble(selectedRow["precounit"]);

                txtPrecoUnit.Text = precoTemp.ToString("R$ #,##0.00");
                nudQuantidade_ValueChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar preço: " + ex.Message);
            }
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double subtotal = (double)nudQuantidade.Value * precoTemp;
            txtSubTotal.Text = subtotal.ToString("R$ #,##0.00");
        }

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            if (dgvItens.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item para editar!");
                return;
            }

            try
            {
                var row = dgvItens.CurrentRow;

                codProdutoAntigo = Convert.ToInt32(row.Cells["cod_pro"].Value);

                cmbProduto.SelectedValue = codProdutoAntigo;
                nudQuantidade.Value = Convert.ToInt32(row.Cells["quantidade"].Value);
                precoTemp = Convert.ToDouble(row.Cells["precounit"].Value);

                txtPrecoUnit.Text = precoTemp.ToString("R$ #,##0.00");
                txtSubTotal.Text = (precoTemp * (double)nudQuantidade.Value).ToString("R$ #,##0.00");

                habilitaCamposItem(true);
                habilitaBotoesItem(false);
                incluirItem = false;
                editarItem = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar item: " + ex.Message);
            }
        }


        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            if (dgvItens.CurrentRow == null)
            {
                MessageBox.Show("Selecione um item para excluir!");
                return;
            }

            try
            {
                if (dgvVenda.CurrentRow == null)
                {
                    MessageBox.Show("Selecione uma venda primeiro!");
                    return;
                }

                int numVenda = Convert.ToInt32(dgvVenda.CurrentRow.Cells["num_venda"].Value);
                int codProduto = Convert.ToInt32(dgvItens.CurrentRow.Cells["cod_pro"].Value);

                if (MessageBox.Show("Deseja excluir este item?", "Confirmação",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (OleDbConnection conn = new OleDbConnection(conexao))
                    {
                        conn.Open();

                        string deleteQuery = "DELETE FROM pc_itemvenda WHERE num_venda = ? AND cod_pro = ?";

                        using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("num_venda", numVenda);
                            cmd.Parameters.AddWithValue("cod_pro", codProduto);


                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Item excluído com sucesso!");
                                CarregarItensVenda(numVenda);
                            }
                            else
                            {
                                MessageBox.Show("Item não encontrado!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir item:\n" + ex.Message);
            }
        }

        private void btnPesquisarItem_Click(object sender, EventArgs e)
        {
            string nomeProcurado = txtPesquisarItem.Text.Trim();

            if (string.IsNullOrEmpty(nomeProcurado))
            {
                MessageBox.Show("Digite um nome para pesquisar.");
                return;
            }

            if (dgvVenda.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma venda primeiro!");
                return;
            }

            try
            {
                int numVenda = Convert.ToInt32(dgvVenda.CurrentRow.Cells["num_venda"].Value);

                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    string query = @"SELECT i.*, p.descricao 
                                   FROM pc_itemvenda i 
                                   INNER JOIN pc_produto p ON i.cod_pro = p.cod_pro
                                   WHERE i.num_venda = ? AND p.descricao LIKE ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("num_venda", numVenda);
                        cmd.Parameters.AddWithValue("descricao", "%" + nomeProcurado + "%");

                        OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvItens.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Nenhum produto encontrado com essa descrição.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa: " + ex.Message);
            }
        }

       
        private void habilitaCampos(bool hab)
        {
            txtNum_venda.Enabled = hab;
            cmbCliente.Enabled = hab;
            dtpDataVenda.Enabled = hab;
            dtpDataEntrega.Enabled = hab;
            txtObs.Enabled = hab;
        }

        private void habilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQuantidade.Enabled = hab;
        }

        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnApagar.Enabled = hab;
            btnEditar.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }

        private void habilitaBotoesItem(bool hab)
        {
            btnIncluirItem.Enabled = hab;
            btnExcluirItem.Enabled = hab;
            btnEditarItem.Enabled = hab;
            btnGravarItem.Enabled = !hab;
            btnCancelarItem.Enabled = !hab;
        }

        private void LimparCampos()
        {
            txtNum_venda.Clear();
            dtpDataVenda.Value = DateTime.Now;
            dtpDataEntrega.Value = DateTime.Now.AddDays(7);
            cmbCliente.SelectedIndex = -1;
            txtObs.Clear();
            txtTotal.Text = "R$ 0,00";
            LimparCamposItem();
            habilitaCampos(false);
        }

        private void LimparCamposItem()
        {
            cmbProduto.SelectedIndex = -1;
            nudQuantidade.Value = 1;
            txtPrecoUnit.Text = "R$ 0,00";
            txtSubTotal.Text = "R$ 0,00";
            precoTemp = 0;
            habilitaCamposItem(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            habilitaBotoes(true);
            incluir = false;
            editar = false;
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            LimparCamposItem();
            habilitaBotoesItem(true);
            incluirItem = false;
            editarItem = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            CarregarVendas();
        }

        private void dgvVenda_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVenda.CurrentRow == null) return;

            try
            {
                int numVenda = Convert.ToInt32(dgvVenda.CurrentRow.Cells["num_venda"].Value);
                CarregarItensVenda(numVenda);
            }
            catch { }
        }
    }
}
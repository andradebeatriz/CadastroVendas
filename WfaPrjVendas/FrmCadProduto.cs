using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfaPrjVendas.DataSetVendasTableAdapters;

namespace WfaPrjVendas
{
    public partial class FrmCadProduto : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmCadProduto()
        {
            InitializeComponent();
        }

        private void pc_produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetVendas);

        }

        private void FrmCadProduto_Load(object sender, EventArgs e)
        {
            try
            {
                this.pc_produtoTableAdapter.Fill(this.dataSetVendas.pc_produto);

                txtPesquisar.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduto_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0 && dgvProduto.CurrentRow != null)
            {
                var row = dgvProduto.CurrentRow;
                txtCod_pro.Text = row.Cells[0].Value?.ToString() ?? "";
                txtDescricao.Text = row.Cells[1].Value?.ToString() ?? "";
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                    NudQuantidade.Value = Convert.ToInt32(row.Cells[2].Value);
                else
                    NudQuantidade.Value = 0;
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                    txtPrecoUnit.Text = Convert.ToDecimal(row.Cells[3].Value).ToString("C2");
                else
                    txtPrecoUnit.Text = "0,00";
            }
            else
            {
                limpaCampos();
            }
        }

        private void dgvProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null && e.Value != DBNull.Value)
            {
                DataGridView grid = (DataGridView)sender;

                if (decimal.TryParse(e.Value.ToString(), out decimal preco))
                {
                    e.Value = preco.ToString("R$ #,##0.00");
                    e.FormattingApplied = true;
                    grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment =
                        DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            NudQuantidade.Value = 0;
            habilitaBotoes(true);
            habilitaCampos(false);
            limpaCampos();
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedRows.Count > 0 && dgvProduto.CurrentRow != null)
            {
                alterar = true;
                habilitaBotoes(false);
                habilitaCampos(true);

                var row = dgvProduto.CurrentRow;

                txtCod_pro.Text = row.Cells[0].Value?.ToString() ?? "";
                txtDescricao.Text = row.Cells[1].Value?.ToString() ?? "";

                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                    NudQuantidade.Value = Convert.ToInt32(row.Cells[2].Value);

                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                    txtPrecoUnit.Text = row.Cells[3].Value.ToString();

                txtDescricao.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um produto primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações
                if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    MessageBox.Show("Digite a descrição do produto!", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescricao.Focus();
                    return;
                }

                if (NudQuantidade.Value < 0)
                {
                    MessageBox.Show("Quantidade não pode ser negativa!", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NudQuantidade.Focus();
                    return;
                }

                string precoTexto = txtPrecoUnit.Text.Replace("R$", "").Replace(" ", "").Trim();
                if (!double.TryParse(precoTexto, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out double preco) || preco < 0)
                {
                    MessageBox.Show("Preço unitário inválido! Use números decimais.", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecoUnit.Focus();
                    return;
                }

                string conexao = Properties.Settings.Default.ConnectionString;

                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    conn.Open();

                    if (incluir)
                    {
                        string checkQuery = "SELECT COUNT(*) FROM pc_produto WHERE descricao = ?";
                        using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("descricao", txtDescricao.Text);
                            int existe = (int)checkCmd.ExecuteScalar();

                            if (existe > 0)
                            {
                                MessageBox.Show("Já existe um produto com esta descrição!", "Validação",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string insertQuery = @"INSERT INTO pc_produto (descricao, quantidade, precounit) 
                                       VALUES (?, ?, ?)";

                        using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("descricao", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("quantidade", (int)NudQuantidade.Value);
                            cmd.Parameters.AddWithValue("precounit", preco);

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                                MessageBox.Show("Produto incluído com sucesso!", "Incluir",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (alterar)
                    {
                        string updateQuery = @"UPDATE pc_produto 
                                       SET descricao = ?, quantidade = ?, precounit = ? 
                                       WHERE cod_pro = ?";

                        using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("descricao", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("quantidade", (int)NudQuantidade.Value);
                            cmd.Parameters.AddWithValue("precounit", preco);
                            cmd.Parameters.AddWithValue("cod_pro", Convert.ToInt32(txtCod_pro.Text));

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                                MessageBox.Show("Produto alterado com sucesso!", "Alterar",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Produto não encontrado para alteração!", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                    // Recarrega os dados
                    this.pc_produtoTableAdapter.Fill(this.dataSetVendas.pc_produto);
                    btnCancelar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validações
                if (string.IsNullOrWhiteSpace(txtDescricao.Text))
                {
                    MessageBox.Show("Digite a descrição do produto!", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescricao.Focus();
                    return;
                }

                if (NudQuantidade.Value < 0)
                {
                    MessageBox.Show("Quantidade não pode ser negativa!", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NudQuantidade.Focus();
                    return;
                }

                double preco;
                if (!double.TryParse(txtPrecoUnit.Text.Replace("R$", "").Trim(), out preco) || preco < 0)
                {
                    MessageBox.Show("Preço unitário inválido!", "Validação",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecoUnit.Focus();
                    return;
                }

                if (incluir)
                {
                    pc_produtoTableAdapter.InsertQuery(txtDescricao.Text, int.Parse(NudQuantidade.Text), double.Parse(txtPrecoUnit.Text));
                    MessageBox.Show("Incluído com sucesso!", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (alterar)
                {
                    int codigo = Convert.ToInt32(txtCod_pro.Text);
                    pc_produtoTableAdapter.UpdateQuery(txtDescricao.Text, int.Parse(NudQuantidade.Text), double.Parse(txtPrecoUnit.Text), int.Parse(txtCod_pro.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.pc_produtoTableAdapter.Fill(this.dataSetVendas.pc_produto);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduto.SelectedRows.Count > 0 && dgvProduto.CurrentRow != null)
                {
                    if (MessageBox.Show("Deseja mesmo excluir o produto selecionado?", "Atenção:",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        int codigoProduto = Convert.ToInt32(dgvProduto.CurrentRow.Cells[0].Value);

                        string conexao = Properties.Settings.Default.ConnectionString;

                        using (OleDbConnection conn = new OleDbConnection(conexao))
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM pc_produto WHERE cod_pro = ?";

                            using (OleDbCommand cmd = new OleDbCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("cod_pro", codigoProduto);

                                int result = cmd.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("Produto excluído com sucesso!", "Exclusão",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Produto não encontrado!", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }

                        this.pc_produtoTableAdapter.Fill(this.dataSetVendas.pc_produto);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto primeiro!", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProduto.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_produtoTableAdapter.DeleteQuery(Convert.ToInt32(dgvProduto[0, dgvProduto.CurrentRow.Index].Value.ToString()));
                        FrmCadProduto_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um Produto primeiro!", "Erro ao excluir:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        /*private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Enabled == false)
            {
                habilitaCampos(false);
                txtDescricao.Enabled = true;
                txtDescricao.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome do cliente desejado ou" + "\nparte dele.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                pc_produtoTableAdapter.FillByDescricao(this.dataSetVendas.pc_produto,
                    "%" + txtDescricao.Text + "%");
                btnCancelar_Click(null, null);
            }

        }*/

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeProcurado = txtPesquisar.Text.Trim();

            if (string.IsNullOrEmpty(nomeProcurado))
            {
                MessageBox.Show("Digite um nome para pesquisar.");
                return;
            }

            try
            {
                string conexao = Properties.Settings.Default.ConnectionString;

                using (OleDbConnection conn = new OleDbConnection(conexao))
                {
                    string query = "SELECT * FROM pc_produto WHERE descricao LIKE ?";
                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);

                    da.SelectCommand.Parameters.Add("?", OleDbType.VarChar).Value = "%" + nomeProcurado + "%";

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvProduto.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Nenhum produto encontrado com esse nome.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa: " + ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                txtPesquisar.Text = "";

                dgvProduto.DataSource = this.dataSetVendas.pc_produto;

                this.pc_produtoTableAdapter.Fill(this.dataSetVendas.pc_produto);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos: " + ex.Message);
            }
        }

        //funções auxiliares
        private void habilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnEditar.Enabled = hab;
            btnApagar.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }
        private void habilitaCampos(bool hab)
        {
            txtDescricao.Enabled = hab;
            NudQuantidade.Enabled = hab;
            txtPrecoUnit.Enabled = hab;
        }
        private void limpaCampos()
        {
            txtCod_pro.Clear();
            txtDescricao.Clear();
            NudQuantidade.Value = 0;
            txtPrecoUnit.Text = "0,00";
            txtPesquisar.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            habilitaBotoes(false);
            habilitaCampos(true);
            limpaCampos();
            incluir = true;
            txtDescricao.Focus();
        }
    }
}

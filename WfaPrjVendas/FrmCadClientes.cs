using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfaPrjVendas.DataSetVendasTableAdapters;

namespace WfaPrjVendas
{
    public partial class FrmCadClientes : Form
    {
        bool incluir = false;
        bool alterar = false;

        public FrmCadClientes()
        {
            InitializeComponent();
        }

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {
            this.pc_clientesTableAdapter.Fill(this.DataSetVendas.pc_clientes);
        }

        private void pc_clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSetVendas);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            incluir = true;
            habilitaCampos(true);
            habilitaBotoes(false);
            txtNome.Focus();
            alterar = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    incluir = false;
                    alterar = true;
                    habilitaCampos(true);
                    habilitaBotoes(false);

                    int linha = dgvClientes.CurrentRow.Index;

                    txtCod_cli.Text = dgvClientes[0, linha].Value.ToString();
                    txtNome.Text = dgvClientes[1, linha].Value.ToString();
                    txtEndereco.Text = dgvClientes[2, linha].Value.ToString();
                    txtCidade.Text = dgvClientes[3, linha].Value.ToString();
                    txtBairro.Text = dgvClientes[4, linha].Value.ToString();
                    mskUF.Text = dgvClientes[5, linha].Value.ToString();
                    mskCep.Text = dgvClientes[6, linha].Value.ToString();
                    mskTelefone.Text = dgvClientes[7, linha].Value.ToString();
                    dtpDatanasc.Value = DateTime.Parse(dgvClientes[8, linha].Value.ToString());

                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Não há cliente selecionado!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            habilitaCampos(false);
            habilitaBotoes(true);
            limpaCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_clientesTableAdapter.Insert(
                        txtNome.Text,
                        txtEndereco.Text,
                        txtCidade.Text,
                        txtBairro.Text,
                        mskUF.Text,
                        mskCep.Text,
                        mskTelefone.Text,
                        dtpDatanasc.Value
                    );
                    MessageBox.Show("Cliente incluído com sucesso!");
                }
                else if (alterar)
                {
                    pc_clientesTableAdapter.Update(
                        txtNome.Text,
                        txtEndereco.Text,
                        txtCidade.Text,
                        txtBairro.Text,
                        mskUF.Text,
                        mskCep.Text,
                        mskTelefone.Text,
                        dtpDatanasc.Value,
                        Convert.ToInt32(txtCod_cli.Text)
                    );
                    MessageBox.Show("Cliente alterado com sucesso!");
                }

                this.pc_clientesTableAdapter.Fill(this.DataSetVendas.pc_clientes);
                limpaCampos();
                habilitaCampos(false);
                habilitaBotoes(true);
                incluir = false;
                alterar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar cliente:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    int linha = dgvClientes.CurrentRow.Index;
                    int codCli = Convert.ToInt32(dgvClientes[0, linha].Value);

                    if (MessageBox.Show("Confirma apagar o cliente selecionado?",
                        "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pc_clientesTableAdapter.Delete(codCli);
                        MessageBox.Show("Cliente excluído com sucesso!");
                        this.pc_clientesTableAdapter.Fill(this.DataSetVendas.pc_clientes);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um cliente para apagar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar cliente:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeProcurado = txtPesquisar.Text.Trim();

            if (string.IsNullOrEmpty(nomeProcurado))
            {
                dgvClientes.DataSource = this.DataSetVendas.pc_clientes;
                return;
            }

            try
            {
                DataView dv = new DataView(this.DataSetVendas.pc_clientes);
                dv.RowFilter = $"nome LIKE '%{nomeProcurado.Replace("'", "''")}%'";

                dgvClientes.DataSource = dv;

                if (dv.Count == 0)
                {
                    MessageBox.Show("Nenhum cliente encontrado com esse nome.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa: " + ex.Message);
            }
        }


        private void dgvCliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "telefone")//|| this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "Telefone2")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;

                    if (stringValue != "")
                    {
                        if (stringValue.Length >= 11)
                        {
                            stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5) + "-" + stringValue.Substring(7, 4);
                            e.Value = stringValue;
                        }
                        else
                        {
                            e.Value = stringValue;
                        }
                    }
                }
            }
            else if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "cep")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;

                    if (stringValue != "")
                    {
                        stringValue = new string(stringValue.Where(char.IsDigit).ToArray());

                        if (stringValue.Length == 8)
                        {
                            stringValue = stringValue.Substring(0, 5) + "-" + stringValue.Substring(5, 3);
                            e.Value = stringValue;
                        }
                        else
                        {
                            e.Value = stringValue;
                        }
                    }
                }
            }
        }

        // --- Funções auxiliares ---
        private void habilitaCampos(bool hab)
        {
            txtCod_cli.Enabled = hab;
            txtNome.Enabled = hab;
            txtEndereco.Enabled = hab;
            txtCidade.Enabled = hab;
            txtBairro.Enabled = hab;
            mskUF.Enabled = hab;
            mskCep.Enabled = hab;
            mskTelefone.Enabled = hab;
            dtpDatanasc.Enabled = hab;
        }

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

        private void limpaCampos()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Clear();
                else if (item is MaskedTextBox)
                    ((MaskedTextBox)item).Clear();
                else if (item is DateTimePicker)
                    ((DateTimePicker)item).Value = DateTime.Now;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                txtPesquisar.Text = "";

                dgvClientes.DataSource = this.DataSetVendas.pc_clientes;

                this.pc_clientesTableAdapter.Fill(this.DataSetVendas.pc_clientes);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar clientes: " + ex.Message);
            }
        }
    }
}
    


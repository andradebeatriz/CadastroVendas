using System;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using WfaPrjVendas.DataSetVendasTableAdapters;

namespace FrmAnimais
{
    public partial class FrmAnimal : Form
    {
        bool incluir = false;
        bool alterar = false;
        private string caminhoImagemSelecionada = string.Empty;

        public FrmAnimal()
        {
            InitializeComponent();
        }

        private void FrmAnimal_Load(object sender, EventArgs e)
        {
            try
            {
                this.animalTableAdapter.Fill(this.dataSetVendas.animal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar animais: " + ex.Message);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitaCampos(grpCampos, true);
            HabilitaBotoes(false);
            incluir = true;
            LimpaCampos(grpCampos);
            txtNome.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvAnimal.SelectedRows.Count > 0)
            {
                alterar = true;
                incluir = false;
                HabilitaCampos(grpCampos, true);
                HabilitaBotoes(false);

                var row = dgvAnimal.CurrentRow;

                txtId.Text = row.Cells["id"].Value.ToString();
                txtNome.Text = row.Cells["nome"].Value.ToString();
                txtTutor.Text = row.Cells["tutor"].Value.ToString();
                txtTipo.Text = row.Cells["tipo"].Value.ToString();
                dtpDataNasc.Value = Convert.ToDateTime(row.Cells["datanasc"].Value);

                caminhoImagemSelecionada = row.Cells["foto"].Value?.ToString();
                txtCaminhoImagem.Text = caminhoImagemSelecionada;

                if (!string.IsNullOrEmpty(caminhoImagemSelecionada) && File.Exists(caminhoImagemSelecionada))
                {
                    try
                    {
                        using (var stream = new FileStream(caminhoImagemSelecionada, FileMode.Open, FileAccess.Read))
                        {
                            Image img = Image.FromStream(stream);
                            fotoTextBox.Image = new Bitmap(img);
                        }
                        fotoTextBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch
                    {
                        fotoTextBox.Image = null;
                    }
                }
                else
                {
                    fotoTextBox.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Selecione um animal primeiro!");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens válidas|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string caminho = ofd.FileName;

                // Verifica se o arquivo existe e é uma imagem suportada
                if (System.IO.File.Exists(caminho) &&
                    (caminho.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                     caminho.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                     caminho.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                     caminho.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)))
                {
                    try
                    {
                        // Cria cópia da imagem para evitar travamento
                        using (var stream = new System.IO.FileStream(caminho, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            Image img = Image.FromStream(stream);
                            fotoTextBox.Image = new Bitmap(img);
                        }

                        fotoTextBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        txtCaminhoImagem.Text = caminho;
                        caminhoImagemSelecionada = caminho;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar a imagem:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fotoTextBox.Image = null;
                        txtCaminhoImagem.Text = "";
                        caminhoImagemSelecionada = "";
                    }
                }
                else
                {
                    MessageBox.Show("Arquivo inválido. Escolha uma imagem JPG, PNG ou BMP.");
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    animalTableAdapter.Insert(
                        txtNome.Text,
                        txtTutor.Text,
                        txtTipo.Text,
                        dtpDataNasc.Value,
                        caminhoImagemSelecionada
                    );
                    MessageBox.Show("Animal incluído com sucesso!");
                }
                else if (alterar)
                {
                    animalTableAdapter.Update(
                        txtNome.Text,
                        txtTutor.Text,
                        txtTipo.Text,
                        dtpDataNasc.Value,
                        caminhoImagemSelecionada,
                        int.Parse(txtId.Text)
                    );
                    MessageBox.Show("Animal alterado com sucesso!");
                }

                this.animalTableAdapter.Fill(this.dataSetVendas.animal);
                LimpaCampos(grpCampos);
                HabilitaCampos(grpCampos, false);
                HabilitaBotoes(true);
                incluir = false;
                alterar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar animal:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAnimal.SelectedRows.Count > 0)
                {
                    int linha = dgvAnimal.CurrentRow.Index;
                    int txtId = int.Parse(dgvAnimal[0, linha].Value.ToString());

                    if (MessageBox.Show("Confirma apagar o animal selecionado?",
                        "Confirmação", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        animalTableAdapter.Delete(txtId);
                        MessageBox.Show("Animal excluído com sucesso!");
                        this.animalTableAdapter.Fill(this.dataSetVendas.animal);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um animal para apagar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar animal:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Funções auxiliares
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitaCampos(grpCampos, false);
            HabilitaBotoes(true);
            LimpaCampos(grpCampos);
            incluir = false;
            alterar = false;
            caminhoImagemSelecionada = string.Empty;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                txtPesquisar.Text = "";

                dgvAnimal.DataSource = this.dataSetVendas.animal;

                this.animalTableAdapter.Fill(this.dataSetVendas.animal);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar animais: " + ex.Message);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomeProcurado = txtPesquisar.Text.Trim();

            if (string.IsNullOrEmpty(nomeProcurado))
            {
                dgvAnimal.DataSource = this.dataSetVendas.animal;
                return;
            }

            try
            {
                DataView dv = new DataView(this.dataSetVendas.animal);
                dv.RowFilter = $"nome LIKE '%{nomeProcurado.Replace("'", "''")}%'";

                dgvAnimal.DataSource = dv;

                if (dv.Count == 0)
                {
                    MessageBox.Show("Nenhum animal encontrado com esse nome.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na pesquisa: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void HabilitaCampos(Control container, bool hab)
        {
            txtId.Enabled = hab;
            txtNome.Enabled = hab;
            txtTutor.Enabled = hab;
            txtTipo.Enabled = hab;
            dtpDataNasc.Enabled = hab;
        }

        private void HabilitaBotoes(bool hab)
        {
            btnIncluir.Enabled = hab;
            btnEditar.Enabled = hab;
            btnApagar.Enabled = hab;
            btnPesquisar.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravar.Enabled = !hab;
            btnCancelar.Enabled = !hab;
        }

        private void LimpaCampos(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                else if (c is DateTimePicker) ((DateTimePicker)c).Value = DateTime.Now;
                else if (c is PictureBox) ((PictureBox)c).Image = null;
            }
        }

    }
}
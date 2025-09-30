using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmAnimais;

namespace WfaPrjVendas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void trmHora_Tick(object sender, EventArgs e)
        {
            tssITexto.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void cadastroDeclientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadClientes)
                {
                    form.Activate();
                    return;
                }
            }
            FrmCadClientes frmCadClientes = new FrmCadClientes();
            frmCadClientes.MdiParent = this;
            frmCadClientes.Show();
        }

        private void tsbCadClientes_Click(object sender, EventArgs e)
        {
            cadastroDeclientesToolStripMenuItem_Click(null, null);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDevendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadVendas)
                {
                    form.Activate();
                    return;
                }
            }
            FrmCadVendas frmCadVendas = new FrmCadVendas();
            frmCadVendas.MdiParent = this;
            frmCadVendas.Show();
        }

        private void cadastroDeprodutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmCadProduto)
                {
                    form.Activate();
                    return;
                }
            }
            FrmCadProduto frmCadProduto = new FrmCadProduto();
            frmCadProduto.MdiParent = this;
            frmCadProduto.Show();
        }

        private void cadastroDeanimaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmAnimal)
                {
                    form.Activate();
                    return;
                }
            }
            FrmAnimal frmAnimais = new FrmAnimal();
            frmAnimais.MdiParent = this;
            frmAnimais.Show();
        }

        private void tsbCadVendas_Click(object sender, EventArgs e)
        {
            cadastroDevendasToolStripMenuItem_Click(null, null);
        }

        private void tsbCadProduto_Click(object sender, EventArgs e)
        {
            cadastroDeprodutosToolStripMenuItem_Click(null, null);
        }

        private void tsbAnimal_Click(object sender, EventArgs e)
        {
            cadastroDeanimaisToolStripMenuItem_Click(null, null);
        }

        private void tsbRelatorio_ButtonClick(object sender, EventArgs e)
        {

        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.Cascade);
            }
        }

        private void ladoALadoNaVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileVertical);
            }
        }

        private void ladoALadoNaHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                this.LayoutMdi(MdiLayout.TileHorizontal);
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form is FrmSobre)
                {
                    form.Activate();
                    return;
                }
            }
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.MdiParent = this;
            frmSobre.Show();
        }
    }
}


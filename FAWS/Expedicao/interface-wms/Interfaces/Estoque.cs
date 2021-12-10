using FAWS_WMS.Telas;
using interface_wms.Classes;
using Interface_WMS_Expedicao.Classes;
using Interface_WMS_Expedicao.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace interface_wms
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        internal void tsmiCadastrarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos metodo = new Metodos();
            metodo.Activate();
        }
        internal void tsmiPickingList_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos metodo = new Metodos();
            metodo.tsmiPickingList();

        }
        internal void tsmiLiberarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos metodo = new Metodos();
            metodo.tsmiLiberarPedido();
        }


        internal void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g5_Produto", "CodigoProduto", txtCodigoProduto.Text);
            ConexaoBD.ExibirValoresBD(dgvBuscarProdutos, Dados_Expedição);
        }

        internal void btnVerTodos_Click(object sender, EventArgs e)
        {
            DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g5_Produto");
            ConexaoBD.ExibirValoresBD(dgvBuscarProdutos, Dados_Expedição);
        }

        internal void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frmEstoque_Activated(object sender, EventArgs e)
        {
            lbNomeUsuario.Text = GerenciarAcessos.getUsuario;
        }

        private void optionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmManual>().Count() == 0)
            {
                FrmManual frm = new FrmManual();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmManual)
                    {
                        openForm.Show();
                    }
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiSuporteEstoque_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }
    }
}


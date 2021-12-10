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
    public partial class frmLiberar : Form
    {
        public frmLiberar()
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
        internal void tsmiEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos metodo = new Metodos();
            metodo.tsmiEstoque();
        }


        internal void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido", "cod_pedido", txtCodigoPedido.Text);
            ConexaoBD.ExibirValoresBD(dgvPedidosProntos, Dados_Expedição);
        }

        internal void btnVerTodos_Click(object sender, EventArgs e)
        {
            DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido");
            ConexaoBD.ExibirValoresBD(dgvPedidosProntos, Dados_Expedição);
        }

        internal void btnEnviarParaTransporte_Click(object sender, EventArgs e)
        {
            try
            {

                string selecao = (string)dgvPedidosProntos.SelectedRows[0].Cells[1].Value;
                string text = "UPDATE g2_Pedido SET status_pedido = 'FINALIZADO'"
                          + " WHERE cod_pedido = '" + selecao + "'";
                ConexaoBD.ModificaBD(text);

                DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido");
                ConexaoBD.ExibirValoresBD(dgvPedidosProntos, Dados_Expedição);

            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum cadastro foi selecionado, selecione um cadastro para ser modificado!"
                      , "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void frmLiberar_Activated(object sender, EventArgs e)
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

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }
    }
}

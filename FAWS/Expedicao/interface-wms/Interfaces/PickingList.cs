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
    public partial class frmPickingList : Form
    {
        public frmPickingList()
        {
            InitializeComponent();
        }

        internal void tsmiCadastrarPedido_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Metodos metodo = new Metodos();
            //metodo.tmsiCadastrarPedido();

            this.Close();
            Metodos metodo = new Metodos();
            metodo.Activate();

        }
        internal void tsmiEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos metodo = new Metodos();
            metodo.tsmiEstoque();
        }
        internal void tsmiLiberarPedido_Click(object sender, EventArgs e)
        {
            this.Close();
            Metodos metodo = new Metodos();
            metodo.tsmiLiberarPedido();
        }


        internal void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido", "cod_pedido", txtCodigoPedido.Text);
            ConexaoBD.ExibirValoresBD(dgvResumoPedido, Dados_Expedição);
        }

        internal void btnVerTodos_Click(object sender, EventArgs e)
        {
            DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido");
            ConexaoBD.ExibirValoresBD(dgvResumoPedido, Dados_Expedição);
        }

        internal void btnLiberar_Click(object sender, EventArgs e)
        {
            try
            {

                string selecao = (string)dgvResumoPedido.SelectedRows[0].Cells[1].Value;
                string text = "UPDATE g2_Pedido SET status_pedido = 'LIBERADO PARA ENVIO'"
                          + " WHERE cod_pedido = '" + selecao + "'";
                ConexaoBD.ModificaBD(text);

                DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido");
                ConexaoBD.ExibirValoresBD(dgvResumoPedido, Dados_Expedição);

            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum cadastro foi selecionado, selecione um cadastro para ser modificado!"
                       , "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void btnFaturar_Click(object sender, EventArgs e)
        {
            try
            {

                string selecao = (string)dgvResumoPedido.SelectedRows[0].Cells[1].Value;
                string text = "UPDATE g2_Pedido SET status_pedido = 'PEDIDO FATURADO'"
                          + " WHERE cod_pedido = '" + selecao + "'";
                ConexaoBD.ModificaBD(text);

                DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido");
                ConexaoBD.ExibirValoresBD(dgvResumoPedido, Dados_Expedição);

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

        private void frmPickingList_Activated(object sender, EventArgs e)
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

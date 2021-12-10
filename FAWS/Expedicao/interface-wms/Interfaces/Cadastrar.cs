using FAWS_WMS;
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
    public partial class frmCadastrar : Form
    {
        public frmCadastrar()
        {
            InitializeComponent();
        }

        internal void tsmiPickingList_Click(object sender, EventArgs e)
        {
            Metodos metodo = new Metodos();
            metodo.tsmiPickingList();
        }
        internal void tsmiEstoque_Click(object sender, EventArgs e)
        {
            Metodos metodo = new Metodos();
            metodo.tsmiEstoque();

        }
        internal void tsmiLiberarPedido_Click(object sender, EventArgs e)
        {
            Metodos metodo = new Metodos();
            metodo.tsmiLiberarPedido();

        }


        internal void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoPedido.Text != "")
                {
                    string text = "Insert into g2_Pedido (cod_pedido, cod_cliente, cod_produto, data_emissao, data_entrega, quantidade, status_pedido, descricao_pedido, lote, prioridade, tipo_pedido) Values ";
                    text += "('" + txtCodigoPedido.Text + "','"
                        + txtCodigoCliente.Text + "','" + txtCodigoProduto.Text + "','"
                        + dtpDataEmissao.Text + "','" + dtpDataEntrega.Text + "','"
                        + txtQuantidade.Text + "','" + cboStatusPedido.SelectedItem + "','"
                        + txtDescricaoPedido.Text + "','" + txtLote.Text + "','"
                        + cboPrioridade.SelectedItem + "','" + cboTipoPedido.SelectedItem + "')";

                    ConexaoBD.ModificaBD(text);

                    DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido");
                    ConexaoBD.ExibirValoresBD(dgvConsultarPedidos, Dados_Expedição);

                    DadosGravados();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        internal void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                btnSalvar.Enabled = false;
                btnEditar.Text = "Atualizar";
                btnEditar.Click -= btnEditar_Click;
                btnEditar.Click += btnAtualizar_Click;


                string text = (string)dgvConsultarPedidos.SelectedRows[0].Cells[1].Value;
                DataTable Dados_Expedicao = ConexaoBD.ConsultaBD("g2_Pedido", "cod_pedido", text);
                txtCodigoPedido.Text = (string)Dados_Expedicao.Rows[0][1];
                txtCodigoCliente.Text = (string)Dados_Expedicao.Rows[0][2];
                txtCodigoProduto.Text = (string)Dados_Expedicao.Rows[0][3];
                dtpDataEmissao.Text = (string)Dados_Expedicao.Rows[0][4];
                dtpDataEntrega.Text = (string)Dados_Expedicao.Rows[0][5];
                txtQuantidade.Text = (string)Dados_Expedicao.Rows[0][6];
                cboStatusPedido.SelectedItem = (string)Dados_Expedicao.Rows[0][7];
                txtDescricaoPedido.Text = (string)Dados_Expedicao.Rows[0][8];
                txtLote.Text = (string)Dados_Expedicao.Rows[0][9];
                cboPrioridade.SelectedItem = (string)Dados_Expedicao.Rows[0][10];
                cboTipoPedido.SelectedItem = (string)Dados_Expedicao.Rows[0][11];

            }
            catch (Exception erro)
            {
                btnSalvar.Enabled = true;
                btnEditar.Text = "Editar";
                btnEditar.Click -= btnAtualizar_Click;
                btnEditar.Click += btnEditar_Click;
                MessageBox.Show(erro.Message);
                MessageBox.Show("Nenhum cadastro foi selecionado, selecione um cadastro para ser modificado!"
                     , "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string text = "UPDATE g2_Pedido SET cod_cliente = '" + txtCodigoCliente.Text +
                                            "',cod_produto = '" + txtCodigoProduto.Text +
                                            "',data_emissao = '" + dtpDataEmissao.Text +
                                            "',data_entrega = '" + dtpDataEntrega.Text +
                                            "',quantidade = '" + txtQuantidade.Text +
                                            "',status_pedido = '" + cboStatusPedido.Text +
                                            "',descricao_pedido = '" + txtDescricaoPedido.Text +
                                            "',lote = '" + txtLote.Text +
                                            "',prioridade = '" + cboPrioridade.Text +
                                            "',tipo_pedido = '" + cboTipoPedido.Text +
                                            "' WHERE cod_pedido = '" + txtCodigoPedido.Text + "'";

                ConexaoBD.ModificaBD(text);

                btnSalvar.Enabled = true;
                btnEditar.Text = "Editar";
                btnEditar.Click -= btnAtualizar_Click;
                btnEditar.Click += btnEditar_Click;

                DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido");
                ConexaoBD.ExibirValoresBD(dgvConsultarPedidos, Dados_Expedição);

                DadosGravados();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        internal void btnLiberarParaPickingList_Click(object sender, EventArgs e)
        {
            try
            {

                string selecao = (string)dgvConsultarPedidos.SelectedRows[0].Cells[1].Value;
                string text = "UPDATE g2_Pedido SET status_pedido = 'LIBERADO PARA O PICKING'"
                          + " WHERE cod_pedido = '" + selecao + "'";
                ConexaoBD.ModificaBD(text);

                DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido");
                ConexaoBD.ExibirValoresBD(dgvConsultarPedidos, Dados_Expedição);

            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum cadastro foi selecionado, selecione um cadastro para ser modificado!"
                       , "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void btnVerTodos_Click(object sender, EventArgs e)
        {
            DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido");
            ConexaoBD.ExibirValoresBD(dgvConsultarPedidos, Dados_Expedição);
        }
        internal void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable Dados_Expedição = ConexaoBD.ConsultaBD("g2_Pedido", "cod_pedido", txtCodigoPesquisar.Text);
            ConexaoBD.ExibirValoresBD(dgvConsultarPedidos, Dados_Expedição);
        }

        internal void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void dtpDataEmissao_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataEmissao.Value > dtpDataEntrega.Value && dtpDataEmissao.Value != dtpDataEntrega.Value)
            {
                MessageBox.Show("Não é permitido registrar uma data de emissão antes da data de entrega."
                    , "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDataEmissao.Value = dtpDataEntrega.Value.AddDays(-1);
            }
        }

        private void dtpDataEntrega_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataEntrega.Value < dtpDataEmissao.Value && dtpDataEntrega.Value != dtpDataEmissao.Value)
            {
                MessageBox.Show("Não é permitido registrar uma data de entrega antes da data de emissão."
                    , "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDataEntrega.Value = dtpDataEmissao.Value.AddDays(1);
            }
        }


        internal void DadosGravados()
        {
            MessageBox.Show("Dados gravados com sucesso");
            txtCodigoPedido.Clear();
            txtCodigoCliente.Clear();
            txtCodigoProduto.Clear();
            txtDescricaoPedido.Clear();
            txtLote.Clear();
            txtQuantidade.Clear();
            dtpDataEmissao.Value = DateTime.Today.AddDays(-1);
            dtpDataEntrega.Value = DateTime.Today.AddDays(1);
            cboStatusPedido.SelectedIndex = -1;
            cboPrioridade.SelectedIndex = -1;
            cboTipoPedido.SelectedIndex = -1;
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

        private void frmCadastrar_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (Application.OpenForms.OfType<frmCadastrar>().Count() == 0)
            {

                if (Application.OpenForms.OfType<FrmMenu>().Count() == 0)
                {
                    FrmMenu frm = new FrmMenu();
                    frm.Show();
                }
                else
                {
                    foreach (Form openForm in Application.OpenForms)
                    {
                        if (openForm is FrmMenu)
                        {
                            openForm.Show();
                        }
                    }
                }
            }


        }

        private void frmCadastrar_Activated(object sender, EventArgs e)
        {
            lbNomeUsuario.Text = GerenciarAcessos.LiberarAcesso();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Mensagem de Saída Padrão
        private void frmCadastrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result_closing = MessageBox.Show("Tem certeza que deseja sair? \nOs dados que não foram enviados não serão salvos!", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result_closing == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }
    }
}
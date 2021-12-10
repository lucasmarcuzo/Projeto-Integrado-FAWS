using FAWS_WMS.Telas;
using interface_wms.Ferramentas;
using Interface_WMS_Recebimento.Ferramentas;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace interface_wms
{
    public partial class FrmPedidos : Form
    {
        private static Control.ControlCollection ControlesPedidos;
        public static Control.ControlCollection getControlesPedidos { get => ControlesPedidos; }
        private static Control.ControlCollection setControlesPedidos { set => ControlesPedidos = value; }

        public FrmPedidos()
        {
            InitializeComponent();

            AbasFormatacoes.PassarCampos(lbNumPedidos, lbProtocAgendamentoPed, lbIDFornecedorPedidos);

            AbasFormatacoes.PassarCampos(btnBuscarPed, btnVertodosPed, btnCancelarPed);

            AbasFormatacoes.PassarCampos(grbPedidos, grbControlesPed);

            AbasFormatacoes.PassarCampos(tsmiRecebimentoPed, tsmiSistemaPed, tsmiUsuarioPed,
                                        tsmiAjudaPed, tsmiConsultarPed, tsmiRelacaoNFsPed, tsmiSairPed,
                                        tsmiPreferenciasPed, tsmiVerMatriculaPed, tsmiManualPed, tsmiSuportePed, tsmiPermissoesPedidos);

            AbasFormatacoes.PassarCampos(picCabecalhoPedidos, picRodapePed, picLogoPedidos);

            AbasFormatacoes.PassarCampos(txtBuscaNumPed, txtBuscaProtocAgenPed, txtIDFornPed);

            AbasFormatacoes.PassarCampos(dgvPedidos);

            AbasFormatacoes.PassarCampos(msMenuPedidos);

            AbasFormatacoes.PassarCamposCabecalho(lbNomeSistemaPedidos, lbDataHoraPedidos, lbUsuarioPedidos, lbNomeMatriculaPedidos);

            setControlesPedidos = Controls;
        }

        //Iniciar formulário na cor e Tamanho desejado
        private void FrmPedidos_Activated(object sender, EventArgs e)
        {
            if (FrmPreferencias.getPadraoEscuro)
            {
                AbasFormatacoes.AtualizarCorDeFundoForm(Controls, "escuro");
            }
            else
            {
                AbasFormatacoes.AtualizarCorDeFundoForm(Controls, "padrao");
            }

            FrmPreferencias.AtualizarTamanhoCampos(FrmPreferencias.getTamanhoFonteValor);

            GerenciarAcessos.LiberarAcesso();
        }

        //Relógio/Datas
        private void tmrHoras_Tick(object sender, EventArgs e)
        {
            this.lbDataHoraPedidos.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        //Limpar Campos (Pedidos)
        private void LimparTodosOsCampos()
        {
            Limpar.LimparCampos(txtBuscaNumPed,
                                 txtBuscaProtocAgenPed,
                                 txtIDFornPed);

            Limpar.LimparErrorProvider(epBusca);

            Limpar.LimparTabelaDeConsulta(dgvPedidos);
        }

        //Cancelar e Sair
        private void btnCancelarPed_Click(object sender, EventArgs e)
        {
            if (btnCancelarPed.Text == "Sair")
            {
                this.Close();
            }
            else if (btnCancelarPed.Text == "Cancelar")
            {
                btnCancelarPed.Text = "Sair";
                btnCancelarPed.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarPed, "Clique para Sair");
                LimparTodosOsCampos();
            }
        }

        //Sair
        private void tsmiSairPed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Fechar formuláro
        private void FrmPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result_closing = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result_closing == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        //Trocar de abas
        private void tsmiRelacaoNFsPed_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmRelacaoNF");
        }
        private void tsmiSuportePed_Click_1(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }

        //Buscar dados de um cadastro pedidos
        private void btnBuscarPed_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();

            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string Procura_Pedidos = "SELECT * FROM Pedidos";

                if (txtBuscaNumPed.Text != "")
                {
                    Procura_Pedidos = "SELECT * FROM Pedidos WHERE Numero_Pedido LIKE '" + txtBuscaNumPed.Text + "'";
                    realizarbusca();
                }
                else if (txtBuscaProtocAgenPed.Text != "")
                {
                    Procura_Pedidos = "SELECT * FROM Pedidos WHERE Protocolo_Agendamento LIKE '" + txtBuscaProtocAgenPed.Text + "'";
                    realizarbusca();
                }
                else if (txtIDFornPed.Text != "")
                {
                    Procura_Pedidos = "SELECT * FROM Pedidos WHERE ID_Fornecedor LIKE '" + txtIDFornPed.Text + "'";
                    realizarbusca();
                }
                else
                {
                    txtBuscaNumPed.BackColor = Color.LightCoral;
                    txtBuscaProtocAgenPed.BackColor = Color.LightCoral;
                    txtIDFornPed.BackColor = Color.LightCoral;

                    var result = MessageBox.Show("Para realizar a pesquisa o campo \"Número do Pedido\", \"Protocolo de Agendamento\" ou \"ID Fornecedor\" deve estar preenchido! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        txtBuscaNumPed.Text = string.Empty;
                        txtBuscaProtocAgenPed.Text = string.Empty;
                        txtIDFornPed.Text = string.Empty;
                        txtBuscaNumPed.BackColor = Color.White;
                        txtBuscaProtocAgenPed.BackColor = Color.White;
                        txtIDFornPed.BackColor = Color.White;
                        txtBuscaNumPed.Focus();
                    }
                    else if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }

                void realizarbusca()
                {
                    DataTable Dados_Pedidos = ConexaoBD.RetornarValoresConsultaBD(Procura_Pedidos);

                    if (Dados_Pedidos.Rows.Count > 0)
                    {
                        foreach (DataRow linha in Dados_Pedidos.Rows)
                        {
                            dgvPedidos.Rows.Add(linha.ItemArray);
                        }
                    }
                    else
                    {
                        if (txtBuscaNumPed.Text != string.Empty)
                        {
                            epBusca.SetError(txtBuscaNumPed, "O número do pedido não foi localizado no banco de dados, informe outra para tentar novamente!");
                            txtBuscaNumPed.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("O número do pedido não foi localizado no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                txtBuscaNumPed.Text = string.Empty;
                                txtBuscaNumPed.BackColor = Color.White;
                                epBusca.Clear();
                                txtBuscaNumPed.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarPed.PerformClick();
                            }
                        }
                        else if (txtBuscaProtocAgenPed.Text != string.Empty)
                        {
                            epBusca.SetError(txtBuscaProtocAgenPed, "O protocolo de agendamento não foi localizado no banco de dados, informe outro para tentar novamente!");
                            txtBuscaProtocAgenPed.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("O protocolo de agendamento não foi localizado no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                txtBuscaProtocAgenPed.Text = string.Empty;
                                txtBuscaProtocAgenPed.BackColor = Color.White;
                                epBusca.Clear();
                                txtBuscaProtocAgenPed.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarPed.PerformClick();
                            }
                        }
                        else if (txtIDFornPed.Text != string.Empty)
                        {
                            epBusca.SetError(txtIDFornPed, "A ID. do fornecedor informada não foi localizada no banco de dados, informe outra para tentar novamente!");
                            txtIDFornPed.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("A ID. do fornecedor informada não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                txtIDFornPed.Text = string.Empty;
                                txtIDFornPed.BackColor = Color.White;
                                epBusca.Clear();
                                txtIDFornPed.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarPed.PerformClick();
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                dgvPedidos.Rows.Clear();
                MessageBox.Show("FAWS WMS" + erro);
            }
        }

        //Ver todos os cadastros pedidos
        private void btnVertodosPed_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();

            try
            {
                string Procura_Pedidos = "SELECT * FROM Pedidos";
                DataTable Dados_Pedidos = ConexaoBD.RetornarValoresConsultaBD(Procura_Pedidos);

                if (Dados_Pedidos.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe nenhum registro de Notas Fiscais no Banco de Dados.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    foreach (DataRow linha in Dados_Pedidos.Rows)
                    {
                        dgvPedidos.Rows.Add(linha.ItemArray);
                    }

                    btnCancelarPed.Text = "Cancelar";
                    btnCancelarPed.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                    TipDicas.SetToolTip(btnCancelarPed, "Clique para Cancelar");
                }

                if (dgvPedidos.Rows.Count > 0)
                {
                    AlterarCancelarSair();
                }
            }
            catch (Exception er)
            {
                dgvPedidos.Rows.Clear();

                MessageBox.Show(Erros.errovertodos(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Limpar campos sem erros
        private void txtBuscaNumPed_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtBuscaNumPed, epBusca);
            AlterarCancelarSair();
        }
        private void txtBuscaProtocAgenPed_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtBuscaProtocAgenPed, epBusca);
            AlterarCancelarSair();
        }
        private void txtIDFornPed_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtIDFornPed, epBusca);
            AlterarCancelarSair();
        }

        //Validação de entrada de dados nos campos
        private void txtBuscaNumPed_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtBuscaProtocAgenPed_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtIDFornPed_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }

        private void tsmiPreferenciasPed_Click(object sender, EventArgs e)
        {
            FrmPreferencias frm = new FrmPreferencias();
            frm.ShowDialog();
        }
        private void tsmiVerMatriculaPed_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A sua matricula é: " + lbNomeMatriculaPedidos.Text, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tsmiPermissoesPedidos_Click(object sender, EventArgs e)
        {
            GerenciarAcessos.VerificarPermissoes(lbNomeMatriculaPedidos);
        }
        private void tsmiSuportePed_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmManualAjuda");
        }

        //Cancelar/Sair
        private void AlterarCancelarSair()
        {
            if (txtBuscaNumPed.Text != "" | txtBuscaProtocAgenPed.Text != "" | txtIDFornPed.Text != "")
            {
                btnCancelarPed.Text = "Cancelar";
                btnCancelarPed.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                TipDicas.SetToolTip(btnCancelarPed, "Clique para Cancelar");
            }
        }

        private void txtBuscaNumPed_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && txtBuscaNumPed.Text == ""
            && txtBuscaProtocAgenPed.Text == ""
            && txtIDFornPed.Text == ""
            && dgvPedidos.Rows.Count == 0)
            {
                btnCancelarPed.Text = "Sair";
                btnCancelarPed.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarPed, "Clique para Sair");
            }
        }

        private void txtBuscaProtocAgenPed_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && txtBuscaNumPed.Text == ""
            && txtBuscaProtocAgenPed.Text == ""
            && txtIDFornPed.Text == ""
            && dgvPedidos.Rows.Count == 0)
            {
                btnCancelarPed.Text = "Sair";
                btnCancelarPed.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarPed, "Clique para Sair");
            }
        }

        private void txtIDFornPed_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && txtBuscaNumPed.Text == ""
            && txtBuscaProtocAgenPed.Text == ""
            && txtIDFornPed.Text == ""
            && dgvPedidos.Rows.Count == 0)
            {
                btnCancelarPed.Text = "Sair";
                btnCancelarPed.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarPed, "Clique para Sair");
            }
        }


    }
}

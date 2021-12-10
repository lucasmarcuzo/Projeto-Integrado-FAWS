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
    public partial class FrmRelacaoNF : Form
    {
        private static Control.ControlCollection ControlesRelacaoNFs;
        public static Control.ControlCollection getControlesRelacaoNFs { get => ControlesRelacaoNFs; }
        private static Control.ControlCollection setControlesRelacaoNFs { set => ControlesRelacaoNFs = value; }

        public FrmRelacaoNF()
        {
            InitializeComponent();

            LimparTodosOsCampos();

            AbasFormatacoes.PassarCampos(lbBuscaNumNFRelNF, lbBucaNumPedRelNF, lbIDFornecedorRelNF);

            AbasFormatacoes.PassarCampos(btnBuscarRelNFs, btnVertodosRel, btnCancelarNF);

            AbasFormatacoes.PassarCampos(grpRelacaoNF, grbControlesRelNF);

            AbasFormatacoes.PassarCampos(tsmiRecebimentoRelNF, tsmiSistemaRelNFs, tsmiUsuarioRelNFs,
                                        tsmiAjudaRelNFs, tsmiConsultarNFs, tsmiPedidosRelNF, tsmiSairRelNFs,
                                        tsmiPreferenciasRelNFs, tsmiVerMatriculaRelNFs, tsmiManualRelNFs, tsmiSuporteRelNFs, tsmiPermissoesRec);

            AbasFormatacoes.PassarCampos(picCabecalhoRelNF, picRodapeRelNF, picLogoRelNF);

            AbasFormatacoes.PassarCampos(txtBuscaNumNFRel, txtBuscarNumPedRel, txtIDFornRelNF);

            AbasFormatacoes.PassarCampos(dgvRelacaoNFs);

            AbasFormatacoes.PassarCampos(msMenuRelNF);

            AbasFormatacoes.PassarCamposCabecalho(lbNomeSistemaRelNF, lbDataHoraRelNF, lbUsuarioRelNF, lbNomeMatriculaRelNF);

            setControlesRelacaoNFs = Controls;
        }

        //Iniciar formulário na cor e Tamanho desejado
        private void FrmRelacaoNF_Activated(object sender, EventArgs e)
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
            this.lbDataHoraRelNF.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        //Cancelar e Sair
        private void btnCancelarNF_Click(object sender, EventArgs e)
        {
            if (btnCancelarNF.Text == "Sair")
            {
                this.Close();
            }
            else if (btnCancelarNF.Text == "Cancelar")
            {
                btnCancelarNF.Text = "Sair";
                btnCancelarNF.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarNF, "Clique para Sair");
                LimparTodosOsCampos();
            }
        }

        //Sair
        private void tsmiSairNFs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Limpar Campos (Relação de NFs)
        private void LimparTodosOsCampos()
        {
            Limpar.LimparCampos(txtBuscaNumNFRel,
                               txtBuscarNumPedRel,
                               txtIDFornRelNF);

            Limpar.LimparErrorProvider(epBusca);

            Limpar.LimparTabelaDeConsulta(dgvRelacaoNFs);
        }

        private void FrmRelacaoNF_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result_closing = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result_closing == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        //Trocar de abas
        private void tsmiPedidosNFs_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmPedidos");
        }
        private void tsmiSuporteRelNFs_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }

        //Buscar dados de um cadastro NFs
        private void btnBuscarRelNFs_Click(object sender, EventArgs e)
        {
            dgvRelacaoNFs.Rows.Clear();

            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string Procura_RelacaoNFs = "SELECT * FROM Relacao_NFs";

                if (txtBuscaNumNFRel.Text != "")
                {
                    Procura_RelacaoNFs = "SELECT * FROM Relacao_NFs WHERE Numero_NF LIKE '" + txtBuscaNumNFRel.Text + "'";
                    realizarbusca();
                }
                else if (txtBuscarNumPedRel.Text != "")
                {
                    Procura_RelacaoNFs = "SELECT * FROM Relacao_NFs WHERE Numero_pedido LIKE '" + txtBuscarNumPedRel.Text + "'";
                    realizarbusca();
                }
                else if (txtIDFornRelNF.Text != "")
                {
                    Procura_RelacaoNFs = "SELECT * FROM Relacao_NFs WHERE ID_fornecedor LIKE '" + txtIDFornRelNF.Text + "'";
                    realizarbusca();
                }
                else
                {
                    txtBuscaNumNFRel.BackColor = Color.LightCoral;
                    txtBuscarNumPedRel.BackColor = Color.LightCoral;
                    txtIDFornRelNF.BackColor = Color.LightCoral;

                    var result = MessageBox.Show("Para realizar a pesquisa o campo \"Número da Nota\", \"Número do Pedido\" ou \"ID do Fornecedor\" deve estar preenchido! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        txtBuscaNumNFRel.Text = string.Empty;
                        txtBuscarNumPedRel.Text = string.Empty;
                        txtIDFornRelNF.Text = string.Empty;
                        txtBuscaNumNFRel.BackColor = Color.White;
                        txtBuscarNumPedRel.BackColor = Color.White;
                        txtIDFornRelNF.BackColor = Color.White;
                        txtBuscaNumNFRel.Focus();
                    }
                    else if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }

                void realizarbusca()
                {
                    DataTable Dados_NFs = ConexaoBD.RetornarValoresConsultaBD(Procura_RelacaoNFs);

                    if (Dados_NFs.Rows.Count > 0)
                    {
                        foreach (DataRow linha in Dados_NFs.Rows)
                        {
                            dgvRelacaoNFs.Rows.Add(linha.ItemArray);
                        }
                    }
                    else
                    {
                        if (txtBuscaNumNFRel.Text != string.Empty)
                        {
                            epBusca.SetError(txtBuscaNumNFRel, "O número da NF não foi localizada no banco de dados, informe outra para tentar novamente!");
                            txtBuscaNumNFRel.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("O número da NF não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                txtBuscaNumNFRel.Text = string.Empty;
                                txtBuscaNumNFRel.BackColor = Color.White;
                                epBusca.Clear();
                                txtBuscaNumNFRel.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarNF.PerformClick();
                            }
                        }
                        else if (txtBuscarNumPedRel.Text != string.Empty)
                        {
                            epBusca.SetError(txtBuscarNumPedRel, "O número do pedido não foi localizado no banco de dados, informe outro para tentar novamente!");
                            txtBuscarNumPedRel.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("O número do pedido não foi localizado no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                txtBuscarNumPedRel.Text = string.Empty;
                                txtBuscarNumPedRel.BackColor = Color.White;
                                epBusca.Clear();
                                txtBuscarNumPedRel.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarNF.PerformClick();
                            }
                        }
                        else if (txtIDFornRelNF.Text != string.Empty)
                        {
                            epBusca.SetError(txtIDFornRelNF, "A ID. do fornecedor informada não foi localizada no banco de dados, informe outra para tentar novamente!");
                            txtIDFornRelNF.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("A ID. do fornecedor informada não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                txtIDFornRelNF.Text = string.Empty;
                                txtIDFornRelNF.BackColor = Color.White;
                                epBusca.Clear();
                                txtIDFornRelNF.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarNF.PerformClick();
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                dgvRelacaoNFs.Rows.Clear();
                MessageBox.Show("FAWS WMS" + erro);
            }
        }

        //Ver todos os cadastros divergencias
        private void btnVertodosRel_Click(object sender, EventArgs e)
        {
            dgvRelacaoNFs.Rows.Clear();

            try
            {
                string Procura_RelacaoNFs = "SELECT * FROM Relacao_NFs";
                DataTable Dados_NFs = ConexaoBD.RetornarValoresConsultaBD(Procura_RelacaoNFs);

                foreach (DataRow linha in Dados_NFs.Rows)
                {
                    dgvRelacaoNFs.Rows.Add(linha.ItemArray);
                }

                btnCancelarNF.Text = "Cancelar";
                btnCancelarNF.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                TipDicas.SetToolTip(btnCancelarNF, "Clique para Cancelar");

                if (dgvRelacaoNFs.Rows.Count > 0)
                {
                    AlterarCancelarSair();
                }

            }
            catch (Exception er)
            {
                dgvRelacaoNFs.Rows.Clear();
                MessageBox.Show(Erros.errovertodos(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Validação de entrada de dados nos campos
        private void txtBuscaNumNFRel_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtBuscarNumPedRel_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtIDFornRel_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }

        //Limpar campos sem erros
        private void txtBuscaNumNFRel_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtBuscaNumNFRel, epBusca);
            AlterarCancelarSair();
        }
        private void txtBuscarNumPedRel_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtBuscarNumPedRel, epBusca);
            AlterarCancelarSair();
        }
        private void txtIDFornRel_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtIDFornRelNF, epBusca);
            AlterarCancelarSair();
        }

        private void tsmiPreferenciasNFs_Click(object sender, EventArgs e)
        {
            FrmPreferencias frm = new FrmPreferencias();
            frm.ShowDialog();
        }
        private void tsmiVerMatriculaNFs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A sua matricula é: " + lbNomeMatriculaRelNF.Text, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tsmiPermissoesRec_Click(object sender, EventArgs e)
        {
            GerenciarAcessos.VerificarPermissoes(lbNomeMatriculaRelNF);
        }
        private void tsmiSuporteNFs_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmManualAjuda");
        }

        //Cancelar/Sair
        private void AlterarCancelarSair()
        {
            if (txtBuscaNumNFRel.Text != "" | txtBuscarNumPedRel.Text != "" | txtIDFornRelNF.Text != "")
            {
                btnCancelarNF.Text = "Cancelar";
                btnCancelarNF.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                TipDicas.SetToolTip(btnCancelarNF, "Clique para Cancelar");
            }
        }

        private void txtBuscaNumNFRel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && txtBuscaNumNFRel.Text == ""
            && txtBuscarNumPedRel.Text == ""
            && txtIDFornRelNF.Text == ""
            && dgvRelacaoNFs.Rows.Count == 0)
            {
                btnCancelarNF.Text = "Sair";
                btnCancelarNF.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarNF, "Clique para Sair");
            }
        }

        private void txtBuscarNumPedRel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && txtBuscaNumNFRel.Text == ""
            && txtBuscarNumPedRel.Text == ""
            && txtIDFornRelNF.Text == ""
            && dgvRelacaoNFs.Rows.Count == 0)
            {
                btnCancelarNF.Text = "Sair";
                btnCancelarNF.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarNF, "Clique para Sair");
            }
        }

        private void txtIDFornRel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && txtBuscaNumNFRel.Text == ""
            && txtBuscarNumPedRel.Text == ""
            && txtIDFornRelNF.Text == ""
            && dgvRelacaoNFs.Rows.Count == 0)
            {
                btnCancelarNF.Text = "Sair";
                btnCancelarNF.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarNF, "Clique para Sair");
            }
        }
    }
}

using FAWS_WMS;
using FAWS_WMS.Telas;
using interface_wms.Ferramentas;
using Interface_WMS_Recebimento.Ferramentas;
using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static Interface_WMS_Recebimento.Recebimento.GerarRelatorioRecebimento;

namespace interface_wms
{
    public partial class FrmRecebimento : Form
    {
        private const string CadastroAtivo = "-1";
        private const string CadastroInativo = "0";
        private static Control.ControlCollection ControlesRecebimento;

        public static Control.ControlCollection getControlesRecebimento { get => ControlesRecebimento; }
        private static Control.ControlCollection setControlesRecebimento { set => ControlesRecebimento = value; }

        public FrmRecebimento()
        {
            InitializeComponent();

            LimparTodosOsCampos();

            btnNovoCadastroRec.Focus();

            AbasFormatacoes.PassarCampos(lbIDRec, lbSenhaRec, lbSatusEntregaRec, lbDocaDescargaRec, lbDataRec, lbIDFornecedorRec,
                                        lbNumNFRec, lbNumPedidoRec, lbCodProdutoRec, lbQtdPecasRec, lbMatriculaConferenteRec,
                                        lbPosicaoArmazenagem, lbSalvarDivergenciaRec, lbIDDevolucao, lbBuscaSenhaRec, lbBuscaIDRec,
                                        lbBuscaDataRec, lbFiltrarRec, lbAtivoRec, lbInativoRec);

            AbasFormatacoes.PassarCampos(btnNovoCadastroRec, btnSalvarAtualizarRec, btnEditarRec, btnAtvInatCadastroRec, btnCancelRec,
                                         btnBuscarRec, btnVertodosRec, btnGerarRelatorioRec);

            AbasFormatacoes.PassarCampos(grbCadastroRec, grbEmitirDivergenciaRec, grbControlesRec, grbPesqRec);

            AbasFormatacoes.PassarCampos(tsmiNavegacaoRec, tsmiSistemaRec, tsmiUsuarioRec, tsmiAjudaRec, tsmiRegistrarRec,
                                        tsmiPortariasRec, tsmiDivergenciasRec, tsmiConsultaRec, tsmiPedidosRec, tsmiRelacaodeNFsRec,
                                        tsmiSairRec, tsmiPreferenciasRec, tsmiVerMatricRec, tsmiManualRec, tsmiSuporteRec, tsmiPermissoesRec);

            AbasFormatacoes.PassarCampos(picCabecalhoRec, picRodapeRec, piclogoRec);

            AbasFormatacoes.PassarCampos(txtDocaRec, txtIDFornRec, txtNumNFRec, txtNumPedRec, txtCodProdRec, txtQtdPecasRec,
                                         txtMatricConfRec, txtPosicArmazRec);

            AbasFormatacoes.PassarCampos(mtbIDRec, mtbIDDevolucaoRec, mtbBuscaSenhaRec, mtbBuscaIDRec);

            AbasFormatacoes.PassarCampos(cboSenhaRec, cboStatusEntregaRec, cboFiltroAtvInatRec);

            AbasFormatacoes.PassarCampos(dgvPesqRec);

            AbasFormatacoes.PassarCampos(msMenuRec);

            AbasFormatacoes.PassarCamposCabecalho(lbNomeSistemaRec, lblDataHoraRec, lbUsuarioRec, lbNomeUsuarioRec);

            setControlesRecebimento = Controls;
        }

        //Iniciar formulário Pai na cor e Tamanho desejado e Verificando o acesso
        private void FrmRecebimento_Activated(object sender, EventArgs e)
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
            txtMatricConfRec.Text = FrmMenu.getUsuario;

        }

        //Ativar/Inativar Campos das Recebimento.
        private void AtivarInativarCamposRecebimento(bool status)
        {
            CamposValidacao.AtivarInativarCadastroRecebimento(status,
                                                            cboSenhaRec,
                                                            cboStatusEntregaRec,
                                                            mtbIDRec,
                                                            dtpDataHoraRec,
                                                            radDiverSim,
                                                            radDiverNao,
                                                            mtbIDDevolucaoRec,
                                                            txtDocaRec,
                                                            txtIDFornRec,
                                                            txtNumNFRec,
                                                            txtNumPedRec,
                                                            txtCodProdRec,
                                                            txtQtdPecasRec,
                                                            txtPosicArmazRec);
        }

        //Verificar e pegar senhas de entrada da portaria.
        private void cb_Senha_DropDown(object sender, EventArgs e)
        {
            cboSenhaRec.Items.Clear();

            string procura_portaria = "SELECT * FROM Portaria WHERE Ativo_Inativo LIKE '" + CadastroAtivo + "'";
            DataTable dados_portaria = ConexaoBD.RetornarValoresConsultaBD(procura_portaria);

            string procura_recebimento = "SELECT * FROM Recebimento";
            DataTable dados_recebimento = ConexaoBD.RetornarValoresConsultaBD(procura_recebimento);

            string[] senha_portaria = new string[dados_portaria.Rows.Count];
            string[] senha_recebimento = new string[dados_recebimento.Rows.Count];

            for (int i = 0; i < dados_portaria.Rows.Count; i++)
            {
                senha_portaria[i] = (string)dados_portaria.Rows[i][1];
            }

            for (int i = 0; i < dados_recebimento.Rows.Count; i++)
            {
                senha_recebimento[i] = (string)dados_recebimento.Rows[i][2];
            }

            foreach (var item in senha_portaria)
            {
                if (senha_recebimento.Contains(item))
                {
                    continue;
                }
                else
                {
                    bool verificarAtvInat = false;
                    if (dados_portaria.Rows.Count > 0)
                    {
                        verificarAtvInat = (bool)dados_portaria.Rows[0][0];
                    }

                    if (!cboSenhaRec.Items.Contains(item) && verificarAtvInat)
                    {
                        cboSenhaRec.Items.Add(item);
                    }
                }
            }
        }

        //Atualizar o formato/horas
        private void AtualizarDataseHoras()
        {
            dtpBuscaDataRec.Format = DateTimePickerFormat.Custom;
            dtpBuscaDataRec.CustomFormat = " ";

            dtpDataHoraRec.Format = DateTimePickerFormat.Custom;
            dtpDataHoraRec.CustomFormat = " ";
        }

        //Verificando se tem foco nos campos data e hora
        private void DtpHorasAtualizar_GotFocus(object sender, EventArgs e)
        {
            if (dtpDataHoraRec.Focused)
            {
                this.dtpDataHoraRec.MaxDate = DateTime.Now;
                this.dtpDataHoraRec.MinDate = DateTime.MinValue;

                dtpDataHoraRec.Format = DateTimePickerFormat.Custom;
                dtpDataHoraRec.CustomFormat = "dd/MM/yyyy HH:mm";
                dtpDataHoraRec.Value = dtpDataHoraRec.MaxDate;
            }
            else if (dtpBuscaDataRec.Focused)
            {
                this.dtpBuscaDataRec.MaxDate = DateTime.Now;
                this.dtpBuscaDataRec.MinDate = DateTime.MinValue;

                dtpBuscaDataRec.Format = DateTimePickerFormat.Custom;
                dtpBuscaDataRec.CustomFormat = "dd/MM/yyyy HH:mm";
                dtpBuscaDataRec.Value = dtpBuscaDataRec.MaxDate;
            }
        }

        private void dtpDataHoraRec_Enter(object sender, EventArgs e)
        {
            dtpDataHoraRec.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        private void dtpBuscaDataRec_Enter(object sender, EventArgs e)
        {
            dtpBuscaDataRec.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        private void dtpDataHoraRec_DropDown(object sender, EventArgs e)
        {
            dtpDataHoraRec.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        private void dtpBuscaDataRec_DropDown(object sender, EventArgs e)
        {
            dtpBuscaDataRec.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        //Relógio/Datas
        private void tmrHoras_Tick(object sender, EventArgs e)
        {
            this.lblDataHoraRec.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");

            this.dtpDataHoraRec.MinDate = DateTime.MinValue;

            this.dtpDataHoraRec.MaxDate = DateTime.Now;
        }

        //Limpar Campos (Recebimento)
        private void LimparTodosOsCampos()
        {
            Limpar.LimparCampos(txtDocaRec,
                                txtIDFornRec,
                                txtNumNFRec,
                                txtNumPedRec,
                                txtCodProdRec,
                                txtQtdPecasRec,
                                txtPosicArmazRec);

            Limpar.LimparCampos(cboSenhaRec,
                                cboStatusEntregaRec);

            Limpar.LimparFiltro(cboFiltroAtvInatRec);

            Limpar.LimparErrorProvider(epBusca,
                                       epErros);

            Limpar.LimparCampos(mtbIDRec,
                                mtbIDDevolucaoRec,
                                mtbBuscaSenhaRec,
                                mtbBuscaIDRec);

            Limpar.LimparTabelaDeConsulta(dgvPesqRec);

            Limpar.DesativarSalvarComoDivergencia(radDiverNao);

            AtivarInativarCamposRecebimento(false);

            btnSalvarAtualizarRec.Enabled = false;
            btnEditarRec.Enabled = false;
            btnAtvInatCadastroRec.Enabled = false;
            btnGerarRelatorioRec.Enabled = false;

            btnAtvInatCadastroRec.Text = "Ativar /\nInativar";
            btnAtvInatCadastroRec.Image = Interface_WMS_Recebimento.Properties.Resources.Inativar;
            TipDicas.SetToolTip(btnAtvInatCadastroRec, "Ativa/Inativa o registro selecionado.");

            btnNovoCadastroRec.Enabled = true;

            AtualizarDataseHoras();
        }

        //Cancelar e menu
        private void btnCancelRec_Click(object sender, EventArgs e)
        {
            if (btnCancelRec.Text == "Sair")
            {
                this.Close();
            }
            else if (btnCancelRec.Text == "Cancelar")
            {
                btnCancelRec.Text = "Sair";
                btnCancelRec.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelRec, "Clique para Sair");
                LimparTodosOsCampos();
            }
        }

        //Sair
        private void tsmiSairRec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Fechar formuláro
        private void FrmRecebimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result_closing = MessageBox.Show("Tem certeza que deseja sair? \nOs dados que não foram enviados não serão salvos!", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result_closing == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        //Trocar de abas
        private void tsmiPortariasRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abas.TrocarAbas("FrmPortarias");
        }
        private void tsmiDivergenciasRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abas.TrocarAbas("FrmDivergencias");
        }
        private void tsmiPedidosRec_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmPedidos");
        }
        private void tsmiRelacaodeNFsRec_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmRelacaoNF");
        }

        //Econtrar ultimo form aberto para da Foco
        private void FrmRecebimento_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<FrmDivergencias>().Count() == 1)
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmDivergencias)
                    {
                        openForm.Show();
                    }
                }
            }
            else if (Application.OpenForms.OfType<FrmPortarias>().Count() == 1)
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmPortarias)
                    {
                        openForm.Show();
                    }
                }
            }

        }

        //Método para mostrar os dados presentes do datagrid nos seus determinados campos
        private void mostrarDados()
        {
            try
            {
                bool verificarAtvInat = (bool)dgvPesqRec.SelectedRows[0].Cells[0].Value;

                if (verificarAtvInat)
                {
                    string cod = (string)dgvPesqRec.SelectedRows[0].Cells[1].Value;
                    string procura_recebimento = "SELECT * FROM Recebimento WHERE ID_Recebimento LIKE '" + cod + "'";

                    DataTable dados_recebimento = ConexaoBD.RetornarValoresConsultaBD(procura_recebimento);

                    mtbIDRec.Text = (string)dados_recebimento.Rows[0][1];

                    cboSenhaRec.Text = (string)dados_recebimento.Rows[0][2];
                    cboStatusEntregaRec.SelectedItem = (string)dados_recebimento.Rows[0][3];
                    txtDocaRec.Text = (string)dados_recebimento.Rows[0][4];
                    dtpDataHoraRec.Text = (string)dados_recebimento.Rows[0][5];
                    txtIDFornRec.Text = (string)dados_recebimento.Rows[0][6];
                    txtNumNFRec.Text = (string)dados_recebimento.Rows[0][7];
                    txtNumPedRec.Text = (string)dados_recebimento.Rows[0][8];
                    txtCodProdRec.Text = (string)dados_recebimento.Rows[0][9];
                    txtQtdPecasRec.Text = (string)dados_recebimento.Rows[0][10];
                    txtMatricConfRec.Text = (string)dados_recebimento.Rows[0][11];
                    txtPosicArmazRec.Text = (string)dados_recebimento.Rows[0][12];

                    if (dados_recebimento.Rows[0][13].ToString() != "_________/________.____")
                    {
                        mtbIDDevolucaoRec.Text = (string)dados_recebimento.Rows[0][13];
                        radDiverSim.Checked = true;
                    }
                    else
                    {
                        radDiverNao.Checked = true;
                        mtbIDDevolucaoRec.ReadOnly = true;
                        mtbIDDevolucaoRec.Enabled = false;
                        mtbIDDevolucaoRec.TabStop = false;
                        mtbIDDevolucaoRec.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Não é permitido editar os dados de um cadastro inativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                dgvPesqRec.Rows.Clear();
                MessageBox.Show(Erros.erroeditar(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //RadioButton salvar como divergências
        private void radDiverSim_CheckedChanged(object sender, EventArgs e)
        {
            if (radDiverSim.Checked)
            {
                mtbIDDevolucaoRec.ReadOnly = false;
                mtbIDDevolucaoRec.Enabled = false;
                mtbIDDevolucaoRec.Text = Gerar.GerarIDDevolução();
            }
            else
            {
                mtbIDDevolucaoRec.ReadOnly = true;
                mtbIDDevolucaoRec.Enabled = false;
                mtbIDDevolucaoRec.TabStop = false;
                mtbIDDevolucaoRec.Text = "";
            }
        }

        //Novo Cadastro Recebimento
        private void btnNovoCadastroRec_Click(object sender, EventArgs e)
        {
            AtivarInativarCamposRecebimento(true);
            mtbIDRec.Text = Gerar.GerarIDRecebimneto();
            mtbIDRec.Enabled = false;
            mtbIDDevolucaoRec.ReadOnly = true;
            mtbIDDevolucaoRec.Enabled = false;
            cboSenhaRec.Focus();

            Limpar.LimparTabelaDeConsulta(dgvPesqRec);

            btnSalvarAtualizarRec.Enabled = true;
            btnEditarRec.Enabled = false;
            btnAtvInatCadastroRec.Enabled = false;
            btnNovoCadastroRec.Enabled = false;

            btnCancelRec.Text = "Cancelar";
            btnCancelRec.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
            TipDicas.SetToolTip(btnCancelRec, "Clique para Cancelar");
        }

        //Salvar/Atualizar dados
        private void btnSalvarRec_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string verifica = "SELECT * FROM Recebimento WHERE ID_Recebimento LIKE '" + mtbIDRec.Text + "'";

                if (CamposValidacao.ValidarPreenchimentoCamposRecebimento(mtbIDRec,
                                                                        epErros,
                                                                        cboSenhaRec,
                                                                        cboStatusEntregaRec,
                                                                        txtDocaRec,
                                                                        txtIDFornRec,
                                                                        txtNumNFRec,
                                                                        txtNumPedRec,
                                                                        txtCodProdRec,
                                                                        txtQtdPecasRec,
                                                                        txtMatricConfRec,
                                                                        txtPosicArmazRec,
                                                                        radDiverSim,
                                                                        mtbIDDevolucaoRec))
                {
                    if (ConexaoBD.VerificarDadoNaoExisteBD(connec, verifica))
                    {
                        string procura_portaria = "SELECT * FROM Portaria WHERE Senha_Entrada LIKE '" + cboSenhaRec.Text + "'";

                        DataTable dados_portaria = ConexaoBD.RetornarValoresConsultaBD(procura_portaria);

                        if ((bool)dados_portaria.Rows[0][0])
                        {
                            //Verificando dalvamento de Duplicata
                            string Verifica_portaria = "SELECT * FROM Recebimento WHERE Numero_NF LIKE '" + txtNumNFRec.Text + "' AND Numero_Pedido LIKE '" + txtNumPedRec.Text + "'";

                            if (!ConexaoBD.VerificarDadoNaoExisteBD(connec, Verifica_portaria))
                            {
                                var result = MessageBox.Show("Não foi possivel salvar, um cadastro com esta Nota Fiscal e Número de Pedido já existe no Banco de Dados, verifique e tente novamente. \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                txtNumNFRec.BackColor = Color.LightCoral;
                                txtNumNFRec.Focus();
                                epErros.SetError(txtNumNFRec, "Informe uma Nota Fiscal ou Número de Pedido diferente.");
                                txtNumPedRec.BackColor = Color.LightCoral;
                                epErros.SetError(txtNumPedRec, "Informe uma Nota Fiscal ou Número de Pedido diferente.");

                                if (result == DialogResult.No)
                                {
                                    LimparTodosOsCampos();
                                    btnCancelRec.Text = "Sair";
                                    btnCancelRec.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                                    TipDicas.SetToolTip(btnCancelRec, "Clique para Sair");
                                }

                            }
                            else
                            {
                                connec.Open();

                                String SQL = "Insert Into Recebimento (Ativo_Inativo, ID_Recebimento, Senha_Entrada, Status_Entrega, Doca_Descarga, DataHora_Recebimento, " +
                                "ID_Fornecedor, Numero_NF, Numero_Pedido,  Cod_Produto, Qtd_pecas," +
                                "Matricula_Conferente, Posicao_Armazenagem, ID_Devolucao) Values ";

                                SQL += "('" + CadastroAtivo + "','" + mtbIDRec.Text + "','" + cboSenhaRec.Text + "','" + cboStatusEntregaRec.SelectedItem.ToString() + "','" + txtDocaRec.Text + "','"
                                + dtpDataHoraRec.Text + "','" + txtIDFornRec.Text + "','" + txtNumNFRec.Text + "','" + txtNumPedRec.Text + "','"
                                + txtCodProdRec.Text + "','" + txtQtdPecasRec.Text + "','" + txtMatricConfRec.Text + "','" + txtPosicArmazRec.Text + "','"
                                + mtbIDDevolucaoRec.Text + "')";

                                OleDbCommand comando = new OleDbCommand(SQL, connec);

                                comando.ExecuteNonQuery();

                                MessageBox.Show("Dados salvos com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LimparTodosOsCampos();

                                connec.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Este cadastro foi INATIVADO, para poder dar entrada no cadastro de recebimento o mesmo deve estar ativado na tabela \"Portarias\"!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        DataTable dados = ConexaoBD.RetornarValoresConsultaBD(verifica);
                        bool verificarAtvInat = false;
                        if (dados.Rows.Count > 0)
                        {
                            verificarAtvInat = (bool)dados.Rows[0][0];
                        }
                        connec.Close();

                        if (verificarAtvInat)
                        {
                            var result = MessageBox.Show("Este cadastro já existe, deseja atualizar os dados?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                try
                                {
                                    if (CamposValidacao.ValidarPreenchimentoCamposRecebimento(mtbIDRec,
                                                                                                    epErros,
                                                                                                    cboSenhaRec,
                                                                                                    cboStatusEntregaRec,
                                                                                                    txtDocaRec,
                                                                                                    txtIDFornRec,
                                                                                                    txtNumNFRec,
                                                                                                    txtNumPedRec,
                                                                                                    txtCodProdRec,
                                                                                                    txtQtdPecasRec,
                                                                                                    txtMatricConfRec,
                                                                                                    txtPosicArmazRec,
                                                                                                    radDiverSim,
                                                                                                    mtbIDDevolucaoRec))
                                    {

                                        if (!ConexaoBD.VerificarDadoNaoExisteBD(connec, verifica))
                                        {
                                            connec.Open();

                                            OleDbCommand comando = new OleDbCommand
                                            {
                                                Connection = connec
                                            };

                                            string ID_Recebimento = mtbIDRec.Text;

                                            string Senha_Entrada = cboSenhaRec.Text;
                                            string Status_Entrega = cboStatusEntregaRec.SelectedItem.ToString();
                                            string Doca_Descarga = txtDocaRec.Text;
                                            string DataHora_Recebimento = dtpDataHoraRec.Text;
                                            string ID_Fornecedor = txtIDFornRec.Text;
                                            string Numero_NF = txtNumNFRec.Text;
                                            string Numero_Pedido = txtNumPedRec.Text;
                                            string Cod_Produto = txtCodProdRec.Text;
                                            string Qtd_pecas = txtQtdPecasRec.Text;
                                            string Matricula_Conferente = txtMatricConfRec.Text;
                                            string Posicao_Armazenagem = txtPosicArmazRec.Text;
                                            string ID_Devolucao = mtbIDDevolucaoRec.Text;

                                            comando.CommandText = "UPDATE Recebimento SET Senha_Entrada = '" + Senha_Entrada +
                                                            "', Status_Entrega = '" + Status_Entrega +
                                                            "', Doca_Descarga = '" + Doca_Descarga +
                                                            "', DataHora_Recebimento = '" + DataHora_Recebimento +
                                                            "', ID_Fornecedor = '" + ID_Fornecedor +
                                                            "', Numero_NF = '" + Numero_NF +
                                                            "', Numero_Pedido = '" + Numero_Pedido +
                                                            "', Cod_Produto = '" + Cod_Produto +
                                                            "', Qtd_pecas = '" + Qtd_pecas +
                                                            "', Matricula_Conferente = '" + Matricula_Conferente +
                                                            "', Posicao_Armazenagem = '" + Posicao_Armazenagem +
                                                            "', ID_Devolucao = '" + ID_Devolucao +
                                                            "' WHERE ID_Recebimento = '" + ID_Recebimento + "'";

                                            comando.ExecuteNonQuery();

                                            MessageBox.Show("Dados alterados com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            LimparTodosOsCampos();

                                            connec.Dispose();

                                            btnVertodosRec.PerformClick();
                                        }
                                    }
                                }
                                catch (Exception er)
                                {
                                    MessageBox.Show(Erros.errosalvarAlt(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                LimparTodosOsCampos();
                                btnCancelRec.Text = "Sair";
                                btnCancelRec.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                                TipDicas.SetToolTip(btnCancelRec, "Clique para Sair");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não é permitido editar os dados de um cadastro inativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(Erros.erroSalvarDadosRecebimento(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Buscar dados de um cadastro recebimento
        private void btnBuscarRec_Click(object sender, EventArgs e)
        {
            dgvPesqRec.Rows.Clear();

            try
            {
                string procura_recebimento = "SELECT * FROM Recebimento";

                if (mtbBuscaSenhaRec.MaskCompleted == true)
                {
                    procura_recebimento = "SELECT * FROM Recebimento WHERE Senha_Entrada LIKE '" + mtbBuscaSenhaRec.Text + "'";
                    realizarbusca();
                }
                else if (mtbBuscaIDRec.MaskCompleted == true)
                {
                    procura_recebimento = "SELECT * FROM Recebimento WHERE ID_Recebimento LIKE '" + mtbBuscaIDRec.Text + "'";
                    realizarbusca();
                }
                else if (dtpBuscaDataRec.Text != " ")
                {
                    procura_recebimento = "SELECT * FROM Recebimento WHERE DataHora_Recebimento LIKE '" + dtpBuscaDataRec.Text + "'";
                    realizarbusca();
                }
                else
                {
                    mtbBuscaSenhaRec.BackColor = Color.LightCoral;
                    mtbBuscaIDRec.BackColor = Color.LightCoral;
                    dtpBuscaDataRec.BackColor = Color.LightCoral;

                    var result = MessageBox.Show("Para realizar a pesquisa o campo \"Senha\", \"ID. do Recebimento\" ou \"Data do recebimento\" deve estar preenchido! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        mtbBuscaSenhaRec.Text = string.Empty;
                        mtbBuscaIDRec.Text = string.Empty;
                        dtpBuscaDataRec.Text = string.Empty;
                        mtbBuscaSenhaRec.BackColor = Color.White;
                        mtbBuscaIDRec.BackColor = Color.White;
                        dtpBuscaDataRec.BackColor = Color.White;
                        mtbBuscaSenhaRec.Focus();
                    }
                    else if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }

                void realizarbusca()
                {
                    DataTable dados_recebimento = ConexaoBD.RetornarValoresConsultaBD(procura_recebimento);

                    if (dados_recebimento.Rows.Count > 0)
                    {
                        foreach (DataRow linha in dados_recebimento.Rows)
                        {
                            dgvPesqRec.Rows.Add(linha.ItemArray);
                        }

                        for (int i = 0; i < dgvPesqRec.Rows.Count; i++)
                        {
                            bool cod = (bool)dgvPesqRec.Rows[i].Cells[0].Value;

                            if (cboFiltroAtvInatRec.SelectedIndex == 1 && !cod)
                            {
                                dgvPesqRec.Rows[i].Visible = false;
                            }
                            else if (cboFiltroAtvInatRec.SelectedIndex == 2 && cod)
                            {
                                dgvPesqRec.Rows[i].Visible = false;
                            }
                        }

                        dgvPesqRec.ClearSelection();
                    }
                    else
                    {
                        if (mtbBuscaSenhaRec.MaskCompleted == true)
                        {
                            epBusca.SetError(mtbBuscaSenhaRec, "A senha informada não foi localizada no banco de dados, informe outra para tentar novamente!");
                            mtbBuscaSenhaRec.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("A senha informada não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                mtbBuscaSenhaRec.Text = string.Empty;
                                mtbBuscaSenhaRec.BackColor = Color.White;
                                epBusca.Clear();
                                mtbBuscaSenhaRec.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelRec.PerformClick();
                            }
                        }
                        else if (mtbBuscaIDRec.MaskCompleted == true)
                        {
                            epBusca.SetError(mtbBuscaIDRec, "A ID. de Recebimento informada não foi localizada no banco de dados, informe outra para tentar novamente!");
                            mtbBuscaIDRec.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("A ID. de Recebimento informada não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                mtbBuscaIDRec.Text = string.Empty;
                                mtbBuscaIDRec.BackColor = Color.White;
                                epBusca.Clear();
                                mtbBuscaIDRec.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelRec.PerformClick();
                            }
                        }
                        else if (dtpBuscaDataRec.Text != string.Empty)
                        {
                            epBusca.SetError(dtpBuscaDataRec, "A data de recebimento informada não foi localizada no banco de dados, informe outra para tentar novamente!");
                            dtpBuscaDataRec.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("A data de recebimento informada não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                dtpBuscaDataRec.Text = string.Empty;
                                dtpBuscaDataRec.BackColor = Color.White;
                                epBusca.Clear();
                                AtualizarDataseHoras();
                                dtpBuscaDataRec.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelRec.PerformClick();
                            }
                        }
                    }
                }

                if (dgvPesqRec.Rows.Count > 0)
                {
                    AlterarCancelarSair();
                    btnEditarRec.Enabled = true;
                    btnAtvInatCadastroRec.Enabled = true;
                    btnGerarRelatorioRec.Enabled = true;
                }
            }
            catch (Exception erro)
            {
                dgvPesqRec.Rows.Clear();
                MessageBox.Show("FAWS WMS" + erro);
            }
        }

        //Ver todos os cadastros recebimento
        private void btnVertodosRec_Click(object sender, EventArgs e)
        {
            dgvPesqRec.Rows.Clear();

            try
            {
                string procura_recebimento = "SELECT * FROM Recebimento";

                if (cboFiltroAtvInatRec.SelectedIndex == 1)
                {
                    procura_recebimento = "SELECT * FROM Recebimento WHERE Ativo_Inativo LIKE '" + CadastroAtivo + "'";
                }
                else if (cboFiltroAtvInatRec.SelectedIndex == 2)
                {
                    procura_recebimento = "SELECT * FROM Recebimento WHERE Ativo_Inativo LIKE '" + CadastroInativo + "'";
                }

                DataTable Dados_Recebimento = ConexaoBD.RetornarValoresConsultaBD(procura_recebimento);

                if (Dados_Recebimento.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe nenhum registro de recebimento no Banco de dados.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnAtvInatCadastroRec.Enabled = false;
                    btnEditarRec.Enabled = false;
                }
                else
                {
                    btnAtvInatCadastroRec.Enabled = true;
                    btnEditarRec.Enabled = true;
                    btnGerarRelatorioRec.Enabled = true;

                    btnCancelRec.Text = "Cancelar";
                    btnCancelRec.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                    TipDicas.SetToolTip(btnCancelRec, "Clique para Cancelar");

                    foreach (DataRow linha in Dados_Recebimento.Rows)
                    {
                        dgvPesqRec.Rows.Add(linha.ItemArray);
                    }

                    dgvPesqRec.ClearSelection();
                }
            }
            catch (Exception er)
            {
                dgvPesqRec.Rows.Clear();
                MessageBox.Show(Erros.errovertodos(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Gerar Relatório de Recebimento
        private void btnGerarRelatorioRec_Click(object sender, EventArgs e)
        {
            var nomeArquivo = GerarRelatorioPDF(RealizarPesquisa().Count);
            var caminhoRel = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);

            var caminho = @"C:\FAWS\Relatorios\";
            if (!File.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            string newCaminho = Path.Combine(caminho + nomeArquivo);
            File.Move(caminhoRel, newCaminho);

            if (File.Exists(newCaminho))
            {
                Process.Start(new ProcessStartInfo()
                {
                    Arguments = $"/c start chrome {newCaminho}",
                    FileName = "cmd.exe",
                    CreateNoWindow = true
                });
            }
        }

        //Editar dados de um cadastro para editar
        private void btnEditarRec_Click(object sender, EventArgs e)
        {
            mostrarDados();
            AtivarInativarCamposRecebimento(true);
            mtbIDRec.Enabled = false;
            cboSenhaRec.Enabled = false;
            if (mtbIDDevolucaoRec.MaskCompleted != false)
            {
                mtbIDDevolucaoRec.Enabled = false;
                radDiverSim.Enabled = false;
                radDiverNao.Enabled = false;
            }
            else
            {
                mtbIDDevolucaoRec.Enabled = false;
            }
            btnSalvarAtualizarRec.Focus();
            AlterarSalvarAtualizar();

            btnNovoCadastroRec.Enabled = false;
            btnSalvarAtualizarRec.Enabled = true;
        }

        //Ver dados de um cadastro para editar
        private void dgvPesqRec_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPesqRec.Rows.Count > 0)
            {
                mostrarDados();
                AtivarInativarCamposRecebimento(true);
                mtbIDRec.Enabled = false;
                cboSenhaRec.Enabled = false;
                if (mtbIDDevolucaoRec.MaskCompleted != false)
                {
                    mtbIDDevolucaoRec.Enabled = false;
                    radDiverSim.Enabled = false;
                    radDiverNao.Enabled = false;
                }
                else
                {
                    mtbIDDevolucaoRec.Enabled = false;
                }
                btnSalvarAtualizarRec.Focus();
                AlterarSalvarAtualizar();

                btnNovoCadastroRec.Enabled = false;
                btnSalvarAtualizarRec.Enabled = true;
            }
        }

        //Ativar/Inativar dados de um cadastro do datagrid
        private void btnAtvInatCadastroRec_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string verifica = "SELECT * FROM Portaria";
                string v = (string)dgvPesqRec.SelectedRows[0].Cells[1].Value;

                verifica = "SELECT * FROM Recebimento WHERE ID_Recebimento LIKE '" + v + "'";

                bool cod = (bool)dgvPesqRec.SelectedRows[0].Cells[0].Value;
                string NF = (string)dgvPesqRec.SelectedRows[0].Cells[7].Value;

                //Pegando linha da tabela de Portarias
                string Procurar_NFRecebimento = "SELECT * FROM Portaria WHERE Numero_NF LIKE '" + NF + "'";
                DataTable Dados_Recebimento = ConexaoBD.RetornarValoresConsultaBD(Procurar_NFRecebimento);
                string nf_port = "";
                if (Dados_Recebimento.Rows.Count > 0)
                {
                    nf_port = (string)Dados_Recebimento.Rows[0][13];
                }
                connec.Close();

                //Pegando linha da tabela de Divergencias
                string Procurar_NFDivergencias = "SELECT * FROM Divergencias WHERE Numero_NF LIKE '" + NF + "'";
                DataTable Dados_Divergencias = ConexaoBD.RetornarValoresConsultaBD(Procurar_NFDivergencias);
                string nf_diverg = "";
                if (Dados_Divergencias.Rows.Count > 0)
                {
                    nf_diverg = (string)Dados_Divergencias.Rows[0][5];
                }
                connec.Close();

                if (!ConexaoBD.VerificarDadoNaoExisteBD(connec, verifica))
                {
                    connec.Open();

                    OleDbCommand comando = new OleDbCommand
                    {
                        Connection = connec
                    };

                    if (!cod)
                    {
                        if (GerenciarAcessos.getUsuario.Equals("RECEBIMENTO@SUPERVISOR") || GerenciarAcessos.getUsuario.Equals("FATEC@PROFESSOR"))
                        {
                            comando.CommandText = "UPDATE Recebimento SET Ativo_Inativo = -1 WHERE ID_Recebimento = '" + v + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Portaria SET Ativo_Inativo = -1 WHERE Numero_NF = '" + nf_port + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Divergencias SET Ativo_Inativo = -1 WHERE Numero_NF = '" + nf_diverg + "'";
                            comando.ExecuteNonQuery();

                            MessageBox.Show("O registro foi ativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparTodosOsCampos();
                            btnVertodosRec.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("O registo só pode ser reativado pelo SUPERVISOR!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        var result_inativar = MessageBox.Show("Essa operação só podera ser desfeita pelo SUPERVISOR. \nTem certeza que deseja inativar o registro? ", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result_inativar == DialogResult.Yes)
                        {
                            comando.CommandText = "UPDATE Recebimento SET Ativo_Inativo = 0 WHERE ID_Recebimento = '" + v + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Portaria SET Ativo_Inativo = 0 WHERE Numero_NF = '" + nf_port + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Divergencias SET Ativo_Inativo = 0 WHERE Numero_NF = '" + nf_diverg + "'";
                            comando.ExecuteNonQuery();

                            MessageBox.Show("O registro foi inativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparTodosOsCampos();
                            btnVertodosRec.PerformClick();
                        }
                    }

                    connec.Dispose();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(Erros.erroAtvInat(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Ativar/Inativar dados de um cadastro pelo datagrid
        private void dgvPesqRec_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                btnAtvInatCadastroRec.PerformClick();
            }
        }

        //Validação de entrada de dados nos campos
        private void mtbIDRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void cb_SenhaRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtDocaRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtIDFornRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtNumNFRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtNumPedRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtCodProdRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtQtdPecasRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtMatricConfRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtPosicArmazRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void mtb_IDDevolucaoRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void mtbBuscaSenhaRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void mtbBuscaIDRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void dtpBuscaDataRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }

        //Limpar campos sem erros
        private void mtbIDRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbIDRec, epErros);
            AlterarSalvarAtualizar();
        }
        private void cb_Senha_TextChanged(object sender, EventArgs e)
        {
            if (cboSenhaRec.Text != string.Empty)
            {
                cboSenhaRec.BackColor = Color.White;
                epErros.Clear();
            }
        }
        private void cboStatusEntregaRec_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboStatusEntregaRec.SelectedItem != null)
            {
                cboStatusEntregaRec.BackColor = Color.White;
                epErros.Clear();
            }
        }
        private void txtDocaRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtDocaRec, epErros);
        }
        private void txtIDFornRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtIDFornRec, epErros);
        }
        private void txtNumNFRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtNumNFRec, epErros);
        }
        private void txtNumPedRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtNumPedRec, epErros);
        }
        private void txtCodProdRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtCodProdRec, epErros);
        }
        private void txtQtdPecasRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtQtdPecasRec, epErros);
        }
        private void txtMatricConfRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtMatricConfRec, epErros);
        }
        private void txtPosicArmazRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtPosicArmazRec, epErros);
        }
        private void mtbBuscaSenhaRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbBuscaSenhaRec, epErros);
            AlterarCancelarSair();
        }
        private void mtbBuscaIDRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbBuscaIDRec, epErros);
            AlterarCancelarSair();
        }
        private void dtpBuscaDataRec_ValueChanged(object sender, EventArgs e)
        {
            AlterarCancelarSair();
        }

        private void tsmiPreferenciasRec_Click(object sender, EventArgs e)
        {
            FrmPreferencias frm = new FrmPreferencias();
            frm.ShowDialog();
        }
        private void tsmiVerMatricRec_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A sua Matricula é: " + lbNomeUsuarioRec.Text, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tsmiPermissoesRec_Click(object sender, EventArgs e)
        {
            GerenciarAcessos.VerificarPermissoes(lbNomeUsuarioRec);
        }
        private void tsmiAjudaRec_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmManualAjuda");
        }
        private void tsmiSuporteRec_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }

        //Mudar a cor de identificação de cadastros Ativos & Inativos.
        private void dgvPesqRec_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AbasFormatacoes.AtualizarCorCadastroAtivoInativo(sender, e, dgvPesqRec);
        }

        //Métodos para alterar nomes/icones botoes
        private void AlterarSalvarAtualizar()
        {
            OleDbConnection connec = ConexaoBD.Conexao();
            string Verifica_IDRecebimento = "SELECT * FROM Recebimento WHERE Senha_Entrada LIKE '" + cboSenhaRec.Text + "'";

            if (cboSenhaRec.Text != "" && !ConexaoBD.VerificarDadoNaoExisteBD(connec, Verifica_IDRecebimento))
            {
                btnSalvarAtualizarRec.Text = "Atualizar";
                btnSalvarAtualizarRec.Image = Interface_WMS_Recebimento.Properties.Resources.salvar_edição;
                TipDicas.SetToolTip(btnSalvarAtualizarRec, "Clique para Atualizar o cadastro");
            }
            else
            {
                btnSalvarAtualizarRec.Text = "Salvar";
                btnSalvarAtualizarRec.Image = Interface_WMS_Recebimento.Properties.Resources.salvar;
                TipDicas.SetToolTip(btnSalvarAtualizarRec, "Clique para Salvar o cadastro");
            }
        }

        //Cancelar/Sair
        private void AlterarCancelarSair()
        {
            if (mtbBuscaSenhaRec.Text != mtbBuscaSenhaRec.Mask
            || mtbBuscaIDRec.Text != mtbBuscaIDRec.Mask
            || dtpBuscaDataRec.Text != "")
            {
                btnCancelRec.Text = "Cancelar";
                btnCancelRec.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                TipDicas.SetToolTip(btnCancelRec, "Clique para Cancelar");
            }
        }

        private void mtbBuscaSenhaRec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && !(mtbBuscaSenhaRec.Text == mtbBuscaSenhaRec.Mask)
            && !(mtbBuscaIDRec.Text == mtbBuscaIDRec.Mask)
            && dtpBuscaDataRec.Text == ""
            && dgvPesqRec.Rows.Count == 0)
            {
                btnCancelRec.Text = "Sair";
                btnCancelRec.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelRec, "Clique para Sair");
            }
        }

        private void mtbBuscaIDRec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && !(mtbBuscaSenhaRec.Text == mtbBuscaSenhaRec.Mask)
            && !(mtbBuscaIDRec.Text == mtbBuscaIDRec.Mask)
            && dtpBuscaDataRec.Text == ""
            && dgvPesqRec.Rows.Count == 0)
            {
                btnCancelRec.Text = "Sair";
                btnCancelRec.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelRec, "Clique para Sair");
            }
        }

        private void dtpBuscaDataRec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && !(mtbBuscaSenhaRec.Text == mtbBuscaSenhaRec.Mask)
            && !(mtbBuscaIDRec.Text == mtbBuscaIDRec.Mask)
            && dtpBuscaDataRec.Text == ""
            && dgvPesqRec.Rows.Count == 0)
            {
                btnCancelRec.Text = "Sair";
                btnCancelRec.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelRec, "Clique para Sair");
            }
        }

        //Ativar/Inativar cadastro pelo datagrid
        private void dgvPesqRec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Verificando se o clique não foi no cabeçalho do datagrid
            {
                if (dgvPesqRec.Rows.Count > 0)
                {
                    bool VerifSelecAtvInat = (bool)dgvPesqRec.SelectedRows[0].Cells[0].Value;

                    if (VerifSelecAtvInat)
                    {
                        btnAtvInatCadastroRec.Text = "Inativar";
                        btnAtvInatCadastroRec.Image = Interface_WMS_Recebimento.Properties.Resources.Inativar;
                        TipDicas.SetToolTip(btnAtvInatCadastroRec, "Clique para Inativar o cadastro.");
                    }
                    else
                    {
                        btnAtvInatCadastroRec.Text = "Ativar";
                        btnAtvInatCadastroRec.Image = Interface_WMS_Recebimento.Properties.Resources.Ativar;
                        TipDicas.SetToolTip(btnAtvInatCadastroRec, "Clique para Ativar o cadastro.");
                    }
                }
            }
        }
    }
}

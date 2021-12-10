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
using static Interface_WMS_Recebimento.Portarias.GerarRelatorioPortaria;

namespace interface_wms
{
    public partial class FrmPortarias : Form
    {
        private const string CadastroAtivo = "-1";
        private const string CadastroInativo = "0";

        private static Control.ControlCollection ControlesPortaria;
        public static Control.ControlCollection getControlesPortaria { get => ControlesPortaria; }
        private static Control.ControlCollection setControlesPortaria { set => ControlesPortaria = value; }

        //Iniciar formulário Pai na cor Padrão
        private void FrmPortarias_Load(object sender, EventArgs e)
        {
            AbasFormatacoes.AtualizarCorDeFundoForm(Controls, "padrao");
        }

        public FrmPortarias()
        {
            FrmRecebimento frmRecebimento = new FrmRecebimento();
            frmRecebimento.Hide();

            FrmDivergencias frmDivergencias = new FrmDivergencias();
            frmDivergencias.Hide();

            FrmRelacaoNF frmRelacaoNF = new FrmRelacaoNF();
            frmRelacaoNF.Hide();

            FrmPedidos frmPedidos = new FrmPedidos();
            frmPedidos.Hide();

            FrmAjuda frmAjuda = new FrmAjuda();
            frmAjuda.Hide();

            InitializeComponent();

            LimparTodosOsCampos();

            AbasFormatacoes.PassarCampos(lbSenhaPortaria, lbNomeMotorista, lbCPFMotorista, lbCNHMotorista, lbPlacaMotorista,
                                        lbCodTransportadora, lbProtocoloAgendamento, lbTipoDeCarga, lbDataHoraEntrada, lbDataHoraSaida,
                                        lbNomeFornecedorPortaria, lbConhecimentoTransp, lbIDFornecedorPortaria, lbNumNFPortaria, lbMatriculaPorteiroPort,
                                        lbProcuraSenhaPort, lbProcuraPlacaPort, lbProcuraMotoristaPort, lbFiltrarPort, lbAtivoPort, lbInativoPort);

            AbasFormatacoes.PassarCampos(btnBuscarPor, btnVertodosPort, btnNovoCadastroPortarias, btnSalvarAtualizarPort,
                                         btnEditarPort, btnAtvInatCadastroPort, btnCancelarPort, btnGerarRelatorioPort);

            AbasFormatacoes.PassarCampos(grbInfoVeicPort, grbInfoEntradaSaidaPort, grbInfEntregaPort, grbPesquisaPort, grbControlesPort);

            AbasFormatacoes.PassarCampos(tsmiNavegacaoPort, tsmiSistemaPort, tsmiUsuarioPort, tsmiAjudaPort, tsmiRegistrarPort,
                                         tsmiConsultarPort, tsmiRecebimentoPort, tsmiDivergPort, tsmiPedidosPort, tsmiRelacaodeNFsPort,
                                         tsmiSairPort, tsmiPreferenciasPort, tsmiVerMatriculaPort, tsmiManualPort, tsmiSuportePort, tsmiPermissoesPort);

            AbasFormatacoes.PassarCampos(picCabecalhoPort, picRodapePort, piclogo);

            AbasFormatacoes.PassarCampos(txtMotorista, txtCodTransp, txtProtocAgendamento, txtConhecTransp, txtBuscaNomeMot, txtMatriculaPorteiroPort);

            AbasFormatacoes.PassarCampos(mtbCPFMot, mtbCNHmot, mtbNumPlaca, mtbSenhaPortarias, mtbBuscaSenhaPort, mtbBuscaPlacaVeic);

            AbasFormatacoes.PassarCampos(cboTipodeCargaPort, cboNomeFornecedorRec, cboIDFornecedor, cboNumNFPort, cboFiltroAtvInatPort);

            AbasFormatacoes.PassarCampos(dgvPesqPort);

            AbasFormatacoes.PassarCampos(msMenuPort);

            AbasFormatacoes.PassarCamposCabecalho(lbNomeSistemaPort, lblDatahoraPort, lbUsuarioPort, lbNomeUsuarioPort);

            setControlesPortaria = Controls;
        }

        //Verificando o acesso
        private void FrmPortarias_Activated(object sender, EventArgs e)
        {
            GerenciarAcessos.LiberarAcesso();
            txtMatriculaPorteiroPort.Text = FrmMenu.getUsuario;
        }

        //Atualizar as formato/horas
        private void AtualizarDataseHoras()
        {
            dtpDataHoraEntr.Format = DateTimePickerFormat.Custom;
            dtpDataHoraEntr.CustomFormat = " ";

            dtpDataHoraSaida.Format = DateTimePickerFormat.Custom;
            dtpDataHoraSaida.CustomFormat = " ";
        }

        //Verificando se tem foco nos campos data e hora
        private void DtpHorasAtualizar_GotFocus(object sender, EventArgs e)
        {
            if (dtpDataHoraEntr.Focused)
            {
                this.dtpDataHoraEntr.MaxDate = DateTime.Now;
                this.dtpDataHoraEntr.MinDate = DateTime.MinValue;

                dtpDataHoraEntr.Format = DateTimePickerFormat.Custom;
                dtpDataHoraEntr.CustomFormat = "dd/MM/yyyy HH:mm";
                dtpDataHoraEntr.Value = dtpDataHoraEntr.MaxDate;
            }
            else if (dtpDataHoraSaida.Focused)
            {
                this.dtpDataHoraSaida.MaxDate = DateTime.Now;
                this.dtpDataHoraSaida.MinDate = DateTime.MinValue;

                dtpDataHoraSaida.Format = DateTimePickerFormat.Custom;
                dtpDataHoraSaida.CustomFormat = "dd/MM/yyyy HH:mm";
                dtpDataHoraSaida.Value = dtpDataHoraSaida.MaxDate;
            }
        }

        private void dtpDataHoraEntr_DropDown(object sender, EventArgs e)
        {
            dtpDataHoraEntr.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        private void dtpDataHoraSaida_DropDown(object sender, EventArgs e)
        {
            dtpDataHoraSaida.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        private void dtpDataHoraEntr_Enter(object sender, EventArgs e)
        {
            dtpDataHoraEntr.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        private void dtpDataHoraSaida_Enter(object sender, EventArgs e)
        {
            dtpDataHoraSaida.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        //Ativar/Inativar Campos das portarias.
        private void AtivarInativarCamposPortarias(bool status)
        {
            CamposValidacao.AtivarInativarCadastroPortarias(status,
                                                            mtbCPFMot,
                                                            mtbCNHmot,
                                                            mtbNumPlaca,
                                                            cboTipodeCargaPort,
                                                            cboNumNFPort,
                                                            cboIDFornecedor,
                                                            cboNomeFornecedorRec,
                                                            dtpDataHoraEntr,
                                                            dtpDataHoraSaida,
                                                            mtbSenhaPortarias,
                                                            txtMotorista,
                                                            txtCodTransp,
                                                            txtProtocAgendamento,
                                                            txtConhecTransp);
        }

        //Verificar e pegar NFs no BD.
        private void cbo_NumNFPort_DropDown(object sender, EventArgs e)
        {
            cboNumNFPort.Items.Clear();

            string Procura_NF = "SELECT * FROM Relacao_NFs";
            DataTable Dados_NFS = ConexaoBD.RetornarValoresConsultaBD(Procura_NF);


            string[] Nums_NF = new string[Dados_NFS.Rows.Count];

            for (int i = 0; i < Dados_NFS.Rows.Count; i++)
            {
                Nums_NF[i] = (string)Dados_NFS.Rows[i][0];
            }

            cboNumNFPort.Items.AddRange(Nums_NF);
        }

        //Verificar e pegar ID. Fornecedor no BD.
        private void cboIDFornecedor_DropDown(object sender, EventArgs e)
        {
            cboIDFornecedor.Items.Clear();

            string Procura_NF = "SELECT * FROM Relacao_NFs";
            DataTable Dados_NFS = ConexaoBD.RetornarValoresConsultaBD(Procura_NF);

            string[] IDs_Fornecedores = new string[Dados_NFS.Rows.Count];

            for (int i = 0; i < Dados_NFS.Rows.Count; i++)
            {
                IDs_Fornecedores[i] = (string)Dados_NFS.Rows[i][5];
            }

            cboIDFornecedor.Items.AddRange(IDs_Fornecedores);

        }

        //Verificar e pegar o Nome do Fornecedor no BD.
        private void cboNomeFornecedorRec_DropDown(object sender, EventArgs e)
        {
            cboNomeFornecedorRec.Items.Clear();

            string Procura_NF = "SELECT * FROM Relacao_NFs";
            DataTable Dados_NFS = ConexaoBD.RetornarValoresConsultaBD(Procura_NF);

            string[] Nomes_Fornecedores = new string[Dados_NFS.Rows.Count];

            for (int i = 0; i < Dados_NFS.Rows.Count; i++)
            {
                Nomes_Fornecedores[i] = (string)Dados_NFS.Rows[i][4];
            }

            cboNomeFornecedorRec.Items.AddRange(Nomes_Fornecedores);
        }

        //Relógio/Datas
        private void tmrHoras_Tick(object sender, EventArgs e)
        {
            lblDatahoraPort.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");

            dtpDataHoraEntr.MinDate = DateTime.MinValue;

            dtpDataHoraEntr.MaxDate = DateTime.Now;

            dtpDataHoraSaida.MinDate = DateTime.MinValue;

            dtpDataHoraSaida.MaxDate = DateTime.Now;
        }


        //Limpar Campos (Portarias)
        private void LimparTodosOsCampos()
        {
            Limpar.LimparCampos(txtCodTransp,
                                txtMotorista,
                                txtProtocAgendamento,
                                txtConhecTransp,
                                txtBuscaNomeMot);

            Limpar.LimparCampos(mtbSenhaPortarias,
                                mtbCNHmot,
                                mtbCPFMot,
                                mtbNumPlaca,
                                mtbBuscaSenhaPort,
                                mtbBuscaPlacaVeic);

            Limpar.LimparCampos(cboTipodeCargaPort,
                                cboNumNFPort,
                                cboIDFornecedor,
                                cboNomeFornecedorRec);

            Limpar.LimparFiltro(cboFiltroAtvInatPort);

            Limpar.LimparErrorProvider(epErroCPF,
                                       epErroCNH,
                                       epBusca,
                                       epDemaisErros);

            Limpar.LimparTabelaDeConsulta(dgvPesqPort);

            AtivarInativarCamposPortarias(false);

            btnSalvarAtualizarPort.Enabled = false;
            btnEditarPort.Enabled = false;
            btnAtvInatCadastroPort.Enabled = false;
            btnGerarRelatorioPort.Enabled = false;

            btnAtvInatCadastroPort.Text = "Ativar /\nInativar";
            btnAtvInatCadastroPort.Image = Interface_WMS_Recebimento.Properties.Resources.Inativar;
            TipDicas.SetToolTip(btnAtvInatCadastroPort, "Ativa/Inativa o registro selecionado.");

            btnNovoCadastroPortarias.Enabled = true;

            AtualizarDataseHoras();

            btnNovoCadastroPortarias.Focus();

        }

        //Limpar/Cancelar e Sair
        private void btnCancelarPort_Click(object sender, EventArgs e)
        {
            if (btnCancelarPort.Text == "Menu\r\nPrincipal")
            {
                this.Close();
            }
            else if (btnCancelarPort.Text == "Cancelar")
            {
                btnCancelarPort.Text = "Menu\r\nPrincipal";
                btnCancelarPort.Image = Interface_WMS_Recebimento.Properties.Resources.menu;
                TipDicas.SetToolTip(btnCancelarPort, "Clique para ir ao Menu Principal");
                LimparTodosOsCampos();
            }
        }

        //Fechar formuláro
        private void FrmPortarias_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result_closing = MessageBox.Show("Tem certeza que deseja sair? \nOs dados que não foram enviados não serão salvos!", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result_closing == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        //Método para mostrar os dados presentes do datagrid nos seus determinados campos
        private void mostrarDados()
        {
            try
            {
                bool verificarAtvInat = (bool)dgvPesqPort.SelectedRows[0].Cells[0].Value;

                if (verificarAtvInat)
                {

                    OleDbConnection connec = ConexaoBD.Conexao();

                    string cod = (string)dgvPesqPort.SelectedRows[0].Cells[1].Value;

                    string procura = "SELECT * FROM Portaria WHERE Senha_Entrada LIKE '" + cod + "'";

                    DataTable dados_portarias = ConexaoBD.RetornarValoresConsultaBD(procura);

                    mtbSenhaPortarias.Text = (string)dados_portarias.Rows[0][1];
                    txtCodTransp.Text = (string)dados_portarias.Rows[0][2];
                    cboIDFornecedor.Text = (string)dados_portarias.Rows[0][3];
                    txtMotorista.Text = (string)dados_portarias.Rows[0][4];
                    mtbCNHmot.Text = (string)dados_portarias.Rows[0][5];
                    mtbCPFMot.Text = (string)dados_portarias.Rows[0][6];
                    mtbNumPlaca.Text = (string)dados_portarias.Rows[0][7];
                    txtProtocAgendamento.Text = (string)dados_portarias.Rows[0][8];
                    dtpDataHoraEntr.CustomFormat = "dd/MM/yyyy HH:mm";
                    dtpDataHoraEntr.Text = (string)dados_portarias.Rows[0][9];
                    dtpDataHoraSaida.CustomFormat = "dd/MM/yyyy HH:mm";
                    dtpDataHoraSaida.Text = (string)dados_portarias.Rows[0][10];
                    cboTipodeCargaPort.SelectedItem = (string)dados_portarias.Rows[0][11];
                    cboNomeFornecedorRec.Text = (string)dados_portarias.Rows[0][12];
                    cboNumNFPort.Text = (string)dados_portarias.Rows[0][13];
                    txtConhecTransp.Text = (string)dados_portarias.Rows[0][14];
                    txtMatriculaPorteiroPort.Text = (string)dados_portarias.Rows[0][15];
                }
                else
                {
                    MessageBox.Show("Não é permitido atualizar os dados de um cadastro inativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                dgvPesqPort.Rows.Clear();
                MessageBox.Show(Erros.erroeditar(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Trocar de abas
        private void tsmiRecebimentoPort_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abas.TrocarAbas("FrmRecebimento");
        }
        private void tsmiDivergPort_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abas.TrocarAbas("FrmDivergencias");
        }
        private void tsmiPedidosPort_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmPedidos");
        }
        private void tsmiRelacaodeNFsPort_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmRelacaoNF");
        }

        //Salvar/Atualizar dados
        private void btnSalvarPort_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string verifica = "SELECT * FROM Portaria WHERE Senha_Entrada LIKE '" + mtbSenhaPortarias.Text + "'";

                if (CamposValidacao.ValidarPreenchimentoCamposPortarias(dtpDataHoraEntr,
                                                                        dtpDataHoraSaida,
                                                                        epDemaisErros,
                                                                        mtbSenhaPortarias,
                                                                        txtMotorista,
                                                                        mtbCPFMot,
                                                                        mtbCNHmot,
                                                                        mtbNumPlaca,
                                                                        epErroCNH,
                                                                        epErroCPF,
                                                                        txtCodTransp,
                                                                        txtProtocAgendamento,
                                                                        cboTipodeCargaPort,
                                                                        cboNomeFornecedorRec,
                                                                        txtConhecTransp,
                                                                        cboIDFornecedor,
                                                                        cboNumNFPort,
                                                                        txtMatriculaPorteiroPort))

                {
                    if (ConexaoBD.VerificarDadoNaoExisteBD(connec, verifica))
                    {
                        string Verifica_portaria = "SELECT * FROM Portaria WHERE ID_Fornecedor LIKE '" + cboIDFornecedor.Text + "' AND Numero_NF LIKE '" + cboNumNFPort.Text + "'";

                        if (!ConexaoBD.VerificarDadoNaoExisteBD(connec, Verifica_portaria))
                        {
                            var result = MessageBox.Show("Não foi possivel salvar, um cadastro com esta Nota Fiscal e Identificação do Fornecedor já existe no Banco de Dados, verifique e tente novamente. \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            cboIDFornecedor.BackColor = Color.LightCoral;
                            cboIDFornecedor.Focus();
                            epDemaisErros.SetError(cboIDFornecedor, "Informe uma ID. do Fornecedor ou Nota Fiscal diferente.");
                            cboNumNFPort.BackColor = Color.LightCoral;
                            epDemaisErros.SetError(cboNumNFPort, "Informe uma Nota Fiscal ou ID. do Fornecedor diferente.");


                            if (result == DialogResult.No)
                            {
                                LimparTodosOsCampos();
                                btnCancelarPort.Text = "Menu\r\nPrincipal";
                                btnCancelarPort.Image = Interface_WMS_Recebimento.Properties.Resources.menu;
                                TipDicas.SetToolTip(btnCancelarPort, "Clique para ir ao Menu Principal");
                            }

                        }
                        else
                        {
                            connec.Open();

                            string SQL = "Insert Into Portaria (Ativo_Inativo, Senha_Entrada, Cod_transportadora, ID_Fornecedor, Nome_motorista, CHN_Motorista, " +
                                                        "CPF_motorista, Placa_veiculo, Protocolo_Agendamento, DataHora_entrada, DataHora_saida, " +
                                                        "Tipo_Carga, Nome_Fornecedor, Numero_NF, Conhe_Transporte, Matricula_Porteiro) Values ";

                            SQL += "('" + CadastroAtivo + "','" + mtbSenhaPortarias.Text + "','" + txtCodTransp.Text + "','" + cboIDFornecedor.Text + "','" + txtMotorista.Text + "','"
                                        + mtbCNHmot.Text + "','" + mtbCPFMot.Text + "','" + mtbNumPlaca.Text + "','" + txtProtocAgendamento.Text + "','"
                                        + dtpDataHoraEntr.Text + "','" + dtpDataHoraSaida.Text + "','" + cboTipodeCargaPort.SelectedItem.ToString() + "','" + cboNomeFornecedorRec.Text + "','"
                                        + cboNumNFPort.SelectedItem.ToString() + "','" + txtConhecTransp.Text + "','" + txtMatriculaPorteiroPort.Text + "')";

                            OleDbCommand comando = new OleDbCommand(SQL, connec);

                            comando.ExecuteNonQuery();

                            MessageBox.Show("Dados salvos com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparTodosOsCampos();

                            connec.Close();
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
                                    if (CamposValidacao.ValidarPreenchimentoCamposPortarias(dtpDataHoraEntr,
                                                                                            dtpDataHoraSaida,
                                                                                            epDemaisErros,
                                                                                            mtbSenhaPortarias,
                                                                                            txtMotorista,
                                                                                            mtbCPFMot,
                                                                                            mtbCNHmot,
                                                                                            mtbNumPlaca,
                                                                                            epErroCNH,
                                                                                            epErroCPF,
                                                                                            txtCodTransp,
                                                                                            txtProtocAgendamento,
                                                                                            cboTipodeCargaPort,
                                                                                            cboNomeFornecedorRec,
                                                                                            txtConhecTransp,
                                                                                            cboIDFornecedor,
                                                                                            cboNumNFPort,
                                                                                            txtMatriculaPorteiroPort))
                                    {
                                        if (!ConexaoBD.VerificarDadoNaoExisteBD(connec, verifica))
                                        {
                                            connec.Open();

                                            OleDbCommand comando = new OleDbCommand
                                            {
                                                Connection = connec
                                            };

                                            string Senha_Entrada = mtbSenhaPortarias.Text;

                                            string Cod_transportadora = txtCodTransp.Text;
                                            string ID_Fornecedor = cboIDFornecedor.SelectedItem.ToString();
                                            string Nome_motorista = txtMotorista.Text;
                                            string CHN_Motorista = mtbCNHmot.Text;
                                            string CPF_motorista = mtbCPFMot.Text;
                                            string Placa_veiculo = mtbNumPlaca.Text;
                                            string Protocolo_Agendamento = txtProtocAgendamento.Text;
                                            string DataHora_entrada = dtpDataHoraEntr.Text;
                                            string DataHora_saida = dtpDataHoraSaida.Text;
                                            string Tipo_Carga = cboTipodeCargaPort.Text;
                                            string Nome_Fornecedor = cboNomeFornecedorRec.Text;
                                            string Numero_NF = cboNumNFPort.Text;
                                            string Conhe_Transporte = txtConhecTransp.Text;
                                            string Matricula_porteiro = txtMatriculaPorteiroPort.Text;

                                            comando.CommandText = "UPDATE Portaria SET Cod_transportadora = '" + Cod_transportadora +
                                                                    "', ID_Fornecedor = '" + ID_Fornecedor +
                                                                    "', Nome_motorista = '" + Nome_motorista +
                                                                    "', CHN_Motorista = '" + CHN_Motorista +
                                                                    "', CPF_motorista = '" + CPF_motorista +
                                                                    "', Placa_veiculo = '" + Placa_veiculo +
                                                                    "', Protocolo_Agendamento = '" + Protocolo_Agendamento +
                                                                    "', DataHora_entrada = '" + DataHora_entrada +
                                                                    "', DataHora_saida = '" + DataHora_saida +
                                                                    "', Tipo_Carga = '" + Tipo_Carga +
                                                                    "', Nome_Fornecedor = '" + Nome_Fornecedor +
                                                                    "', Numero_NF = '" + Numero_NF +
                                                                    "', Conhe_Transporte = '" + Conhe_Transporte +
                                                                    "', Matricula_Porteiro = '" + Matricula_porteiro +
                                                                    "' WHERE Senha_Entrada = '" + Senha_Entrada + "'";

                                            comando.ExecuteNonQuery();

                                            MessageBox.Show("Dados alterados com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            LimparTodosOsCampos();

                                            connec.Dispose();

                                            btnVertodosPort.PerformClick();
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
                                btnCancelarPort.Text = "Menu\r\nPrincipal";
                                btnCancelarPort.Image = Interface_WMS_Recebimento.Properties.Resources.menu;
                                TipDicas.SetToolTip(btnCancelarPort, "Clique para ir ao Menu Principal");
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
                MessageBox.Show(Erros.erroSalvarDadosPortarias(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Buscar dados de um cadastro portarias
        private void btnBuscarPor_Click(object sender, EventArgs e)
        {
            dgvPesqPort.Rows.Clear();

            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string procura = "SELECT * FROM Portaria";

                if (mtbBuscaSenhaPort.MaskCompleted == true)
                {
                    procura = "SELECT * FROM Portaria WHERE Senha_Entrada LIKE '" + mtbBuscaSenhaPort.Text + "'";
                    realizarbusca();
                }
                else if (mtbBuscaPlacaVeic.Text != "")
                {
                    procura = "SELECT * FROM Portaria WHERE Placa_veiculo LIKE '" + mtbBuscaPlacaVeic.Text + "'";
                    realizarbusca();
                }
                else if (txtBuscaNomeMot.Text != "")
                {
                    procura = "SELECT * FROM Portaria WHERE Nome_motorista LIKE '" + txtBuscaNomeMot.Text + "'";
                    realizarbusca();
                }
                else
                {
                    mtbBuscaSenhaPort.BackColor = Color.LightCoral;
                    mtbBuscaPlacaVeic.BackColor = Color.LightCoral;
                    txtBuscaNomeMot.BackColor = Color.LightCoral;

                    var result = MessageBox.Show("Para realizar a pesquisa o campo \"Senha\", \"Placa do Veiculo\" ou \"Motorista\" deve estar preenchido! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        mtbBuscaSenhaPort.Text = string.Empty;
                        mtbBuscaPlacaVeic.Text = string.Empty;
                        txtBuscaNomeMot.Text = string.Empty;
                        mtbBuscaSenhaPort.BackColor = Color.White;
                        mtbBuscaPlacaVeic.BackColor = Color.White;
                        txtBuscaNomeMot.BackColor = Color.White;
                        mtbBuscaSenhaPort.Focus();
                    }
                    else if (result == DialogResult.No)
                    {
                        mtbBuscaSenhaPort.Text = string.Empty;
                        mtbBuscaPlacaVeic.Text = string.Empty;
                        txtBuscaNomeMot.Text = string.Empty;
                        mtbBuscaSenhaPort.BackColor = Color.White;
                        mtbBuscaPlacaVeic.BackColor = Color.White;
                        txtBuscaNomeMot.BackColor = Color.White;
                        Application.Exit();
                    }
                }

                void realizarbusca()
                {
                    DataTable dados_portarias = ConexaoBD.RetornarValoresConsultaBD(procura);

                    if (dados_portarias.Rows.Count > 0)
                    {
                        foreach (DataRow row in dados_portarias.Rows)
                        {
                            dgvPesqPort.Rows.Add(row.ItemArray);
                        }

                        for (int i = 0; i < dgvPesqPort.Rows.Count; i++)
                        {
                            bool cod = (bool)dgvPesqPort.Rows[i].Cells[0].Value;

                            if (cboFiltroAtvInatPort.SelectedIndex == 1 && !cod)
                            {
                                dgvPesqPort.Rows[i].Visible = false;
                            }
                            else if (cboFiltroAtvInatPort.SelectedIndex == 2 && cod)
                            {
                                dgvPesqPort.Rows[i].Visible = false;
                            }
                        }

                        dgvPesqPort.ClearSelection();
                    }
                    else
                    {
                        if (mtbBuscaSenhaPort.MaskCompleted == true)
                        {
                            epBusca.SetError(mtbBuscaSenhaPort, "A senha informada não foi localizada no banco de dados, informe outra para tentar novamente!");
                            mtbBuscaSenhaPort.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("A senha informada não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                mtbBuscaSenhaPort.Text = string.Empty;
                                mtbBuscaSenhaPort.BackColor = Color.White;
                                epBusca.Clear();
                                mtbBuscaSenhaPort.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarPort.PerformClick();
                            }
                        }
                        if (mtbBuscaPlacaVeic.Text != string.Empty)
                        {
                            epBusca.SetError(mtbBuscaPlacaVeic, "A placa informada não foi localizada no banco de dados, informe outra para tentar novamente!");
                            mtbBuscaPlacaVeic.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("A placa informada não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                mtbBuscaPlacaVeic.Text = string.Empty;
                                mtbBuscaPlacaVeic.BackColor = Color.White;
                                epBusca.Clear();
                                mtbBuscaPlacaVeic.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarPort.PerformClick();
                            }
                        }
                        if (txtBuscaNomeMot.Text != string.Empty)
                        {
                            epBusca.SetError(txtBuscaNomeMot, "O nome do motorista informado não foi localizada no banco de dados, informe outra para tentar novamente!");
                            txtBuscaNomeMot.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("O nome do motorista informado não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                txtBuscaNomeMot.Text = string.Empty;
                                txtBuscaNomeMot.BackColor = Color.White;
                                epBusca.Clear();
                                txtBuscaNomeMot.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarPort.PerformClick();
                            }
                        }
                    }
                }

                if (dgvPesqPort.Rows.Count > 0)
                {
                    AlterarCancelarSair();
                    btnEditarPort.Enabled = true;
                    btnAtvInatCadastroPort.Enabled = true;
                    btnGerarRelatorioPort.Enabled = true;
                }
            }
            catch (Exception erro)
            {
                dgvPesqPort.Rows.Clear();
                MessageBox.Show("FAWS WMS" + erro);
            }
        }

        //Ver todos os cadastros portaria
        private void btnVertodosPort_Click(object sender, EventArgs e)
        {
            dgvPesqPort.Rows.Clear();

            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string procura = "SELECT * FROM Portaria";

                if (cboFiltroAtvInatPort.SelectedIndex == 1)
                {
                    procura = "SELECT * FROM Portaria WHERE Ativo_Inativo LIKE '" + CadastroAtivo + "'";
                }
                else if (cboFiltroAtvInatPort.SelectedIndex == 2)
                {
                    procura = "SELECT * FROM Portaria WHERE Ativo_Inativo LIKE '" + CadastroInativo + "'";
                }

                DataTable Dados_Portarias = ConexaoBD.RetornarValoresConsultaBD(procura);

                if (Dados_Portarias.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe nenhum registro de entrada no Banco de dados.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEditarPort.Enabled = false;
                    btnAtvInatCadastroPort.Enabled = false;
                }
                else
                {
                    btnEditarPort.Enabled = true;
                    btnAtvInatCadastroPort.Enabled = true;
                    btnGerarRelatorioPort.Enabled = true;

                    btnCancelarPort.Text = "Cancelar";
                    btnCancelarPort.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                    TipDicas.SetToolTip(btnCancelarPort, "Clique para Cancelar");

                    foreach (DataRow linha in Dados_Portarias.Rows)
                    {
                        dgvPesqPort.Rows.Add(linha.ItemArray);
                    }

                    dgvPesqPort.ClearSelection();
                }
            }
            catch (Exception er)
            {
                dgvPesqPort.Rows.Clear();
                MessageBox.Show(Erros.errovertodos(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Gerar Relatório Portarias
        private void btnGerarRelatorioPort_Click(object sender, EventArgs e)
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

        //Novo Cadastro
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            AtivarInativarCamposPortarias(true);
            Limpar.LimparTabelaDeConsulta(dgvPesqPort);

            btnSalvarAtualizarPort.Enabled = true;
            btnEditarPort.Enabled = false;
            btnAtvInatCadastroPort.Enabled = false;
            btnNovoCadastroPortarias.Enabled = false;

            btnCancelarPort.Text = "Cancelar";
            btnCancelarPort.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
            TipDicas.SetToolTip(btnCancelarPort, "Clique para Cancelar");

            mtbSenhaPortarias.Text = Gerar.GerarNovaSenha();
            mtbSenhaPortarias.Enabled = false;
            txtMotorista.Focus();
        }

        //Ver dados de um cadastro para editar
        private void btnEditarPort_Click(object sender, EventArgs e)
        {
            mostrarDados();
            AtivarInativarCamposPortarias(true);
            mtbSenhaPortarias.Enabled = false;
            btnSalvarAtualizarPort.Focus();
            AlterarSalvarAtualizar();

            btnNovoCadastroPortarias.Enabled = false;
            btnSalvarAtualizarPort.Enabled = true;
        }

        //Ver dados de um cadastro para editar
        private void dgvPesqPort_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPesqPort.Rows.Count > 0)
            {
                mostrarDados();
                AtivarInativarCamposPortarias(true);
                mtbSenhaPortarias.Enabled = false;
                btnSalvarAtualizarPort.Focus();
                AlterarSalvarAtualizar();

                btnNovoCadastroPortarias.Enabled = false;
                btnSalvarAtualizarPort.Enabled = true;
            }
        }

        //Ativar/Inativar dados de um cadastro do datagrid
        private void btnAtvInatCadastroPort_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                bool cod = (bool)dgvPesqPort.SelectedRows[0].Cells[0].Value;
                string NF = (string)dgvPesqPort.SelectedRows[0].Cells[13].Value;

                //Pegando linha da tabela de Portarias
                string Senha = (string)dgvPesqPort.SelectedRows[0].Cells[1].Value;
                string verifica = "SELECT * FROM Portaria WHERE Senha_Entrada LIKE '" + Senha + "'";

                //Pegando linha da tabela de Recebimento
                string Procurar_NFRecebimento = "SELECT * FROM Recebimento WHERE Numero_NF LIKE '" + NF + "'";
                DataTable Dados_NFRec = ConexaoBD.RetornarValoresConsultaBD(Procurar_NFRecebimento);
                string nf_rec = "";
                if (Dados_NFRec.Rows.Count > 0)
                {
                    nf_rec = (string)Dados_NFRec.Rows[0][7];
                }
                connec.Close();

                //Pegando linha da tabela de Divergencias
                string Procurar_NFDivergencias = "SELECT * FROM Divergencias WHERE Numero_NF LIKE '" + NF + "'";
                DataTable Dados_NFDivergencias = ConexaoBD.RetornarValoresConsultaBD(Procurar_NFDivergencias);
                string nf_diverg = "";
                if (Dados_NFDivergencias.Rows.Count > 0)
                {
                    nf_diverg = (string)Dados_NFDivergencias.Rows[0][5];
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
                            comando.CommandText = "UPDATE Portaria SET Ativo_Inativo = -1 WHERE Senha_Entrada = '" + Senha + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Recebimento SET Ativo_Inativo = -1 WHERE Numero_NF = '" + nf_rec + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Divergencias SET Ativo_Inativo = -1 WHERE Numero_NF = '" + nf_diverg + "'";
                            comando.ExecuteNonQuery();

                            MessageBox.Show("O registro foi ativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparTodosOsCampos();
                            btnVertodosPort.PerformClick();
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
                            comando.CommandText = "UPDATE Portaria SET Ativo_Inativo = 0 WHERE Senha_Entrada = '" + Senha + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Recebimento SET Ativo_Inativo = 0 WHERE Numero_NF = '" + nf_rec + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Divergencias SET Ativo_Inativo = 0 WHERE Numero_NF = '" + nf_diverg + "'";
                            comando.ExecuteNonQuery();

                            MessageBox.Show("O registro foi inativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparTodosOsCampos();
                            btnVertodosPort.PerformClick();
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

        //Ativar/Inativar dados de um cadastro pelo datagrid.
        private void dgvPesqPort_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                btnAtvInatCadastroPort.PerformClick();
            }
        }

        //Validação de entrada de dados nos campos
        private void mtbSenhaPortarias_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtMotorista_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_String(sender, e);
        }
        private void mtbCPFMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void mtbCNHmot_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtCodTransp_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void mtbNumPlaca_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Placas(sender, e);
        }
        private void txtProtocAgendamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void cboNomeFornecedorRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_String(sender, e);
        }
        private void txtConhecTransp_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void cboIDFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void cbo_NumNFPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void mtbBuscaSenhaPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void mtbBuscaPlacaVeic_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Placas(sender, e);
        }
        private void txtPesqNomeMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_String(sender, e);
        }

        //Limpar erros dos campos
        private void dtpDataHoraEntr_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataHoraEntr.Value < dtpDataHoraSaida.Value)
            {
                dtpDataHoraEntr.BackColor = Color.White;
                epDemaisErros.Clear();
            }
        }
        private void dtpDataHoraSaida_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDataHoraSaida.Value > dtpDataHoraEntr.Value)
            {
                dtpDataHoraEntr.BackColor = Color.White;
                epDemaisErros.Clear();
            }
        }
        private void mtbSenhaPortarias_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbSenhaPortarias, epDemaisErros);
            AlterarSalvarAtualizar();
        }
        private void txtMotorista_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtMotorista, epDemaisErros);
        }
        private void mtbCPFMot_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbCPFMot, epErroCPF);

            if (mtbCPFMot.MaskCompleted)
            {
                CamposValidacao.Validar_CPF(mtbCPFMot, epErroCPF);
            }
        }
        private void mtbCNHmot_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbCNHmot, epErroCNH);

            if (mtbCNHmot.MaskCompleted)
            {
                CamposValidacao.Validar_CNH(mtbCNHmot, epErroCNH);
            }
        }
        private void mtbNumPlaca_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbNumPlaca, epDemaisErros);
        }
        private void txtCodTransp_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtCodTransp, epDemaisErros);
        }
        private void txtProtocAgendamento_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtProtocAgendamento, epDemaisErros);
        }
        private void cboTipodeCargaPort_SelectedValueChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(cboTipodeCargaPort, epDemaisErros);
        }
        private void cboNomeFornecedorRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(cboNomeFornecedorRec, epDemaisErros);
        }
        private void txtConhecTransp_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtConhecTransp, epDemaisErros);
        }
        private void cboIDFornecedor_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(cboIDFornecedor, epDemaisErros);
        }
        private void cbo_NumNFPort_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(cboNumNFPort, epDemaisErros);
        }
        private void txtMatriculaPorteiroPort_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtMatriculaPorteiroPort, epDemaisErros);
        }
        private void mtbBuscaSenhaPort_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbBuscaSenhaPort, epBusca);
            AlterarCancelarSair();
        }
        private void mtbBuscaPlacaVeic_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbBuscaPlacaVeic, epBusca);
            AlterarCancelarSair();
        }
        private void txtBuscaNomeMot_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtBuscaNomeMot, epBusca);
            AlterarCancelarSair();
        }
        private void ponteiro(MaskedTextBox ponteiro)
        {
            if (!ponteiro.MaskCompleted)
            {
                ponteiro.Select(ponteiro.Text.Length, 0);
            }
        }
        private void mtbCPFMot_Click(object sender, EventArgs e)
        {
            ponteiro(mtbCPFMot);
        }
        private void mtbCNHmot_Click(object sender, EventArgs e)
        {
            ponteiro(mtbCNHmot);
        }
        private void mtbNumPlaca_Click(object sender, EventArgs e)
        {
            ponteiro(mtbNumPlaca);
        }
        private void mtbBuscaPlacaVeic_Click(object sender, EventArgs e)
        {
            ponteiro(mtbBuscaPlacaVeic);
        }
        private void mtbBuscaSenhaPort_Click(object sender, EventArgs e)
        {
            ///
        }

        //Funções sem funcionalidades implantadas
        private void tsmiPreferenciasPort_Click(object sender, EventArgs e)
        {
            FrmPreferencias frm = new FrmPreferencias();
            frm.ShowDialog();
        }
        private void tsmiVerMatriculaPort_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A sua Matricula é: " + lbNomeUsuarioPort.Text, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tsmiPermissoesPort_Click(object sender, EventArgs e)
        {
            GerenciarAcessos.VerificarPermissoes(lbNomeUsuarioPort);
        }
        private void tsmiSairPort_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsmiAjudaPort_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmManualAjuda");
        }
        private void tsmiSuportePort_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }

        //Menu Icones Barra de tarefas
        private void ntiNotiIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void tsmiManual_Click(object sender, EventArgs e)
        {
            tsmiManualPort.PerformClick();
        }

        private void tsmiSuporte_Click(object sender, EventArgs e)
        {
            tsmiSuportePort.PerformClick();
        }
        private void tsmiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void tsmiRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmiVerMatricula_Click(object sender, EventArgs e)
        {
            tsmiVerMatriculaPort.PerformClick();
        }

        private void tsmiPermissoes_Click(object sender, EventArgs e)
        {
            tsmiPermissoesPort.PerformClick();
        }

        //Mudar a cor de identificação de cadastros Ativos & Inativos.
        private void dgvPesqPort_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AbasFormatacoes.AtualizarCorCadastroAtivoInativo(sender, e, dgvPesqPort);
        }

        //Métodos para alterar nomes/icones botoes
        //Salvar/Atualizar
        private void AlterarSalvarAtualizar()
        {
            OleDbConnection connec = ConexaoBD.Conexao();
            string verifica = "SELECT * FROM Portaria WHERE Senha_Entrada LIKE '" + mtbSenhaPortarias.Text + "'";

            if (mtbSenhaPortarias.MaskCompleted == true && !ConexaoBD.VerificarDadoNaoExisteBD(connec, verifica))
            {
                btnSalvarAtualizarPort.Text = "Atualizar";
                btnSalvarAtualizarPort.Image = Interface_WMS_Recebimento.Properties.Resources.salvar_edição;
                TipDicas.SetToolTip(btnSalvarAtualizarPort, "Clique para Atualizar o cadastro");
            }
            else
            {
                btnSalvarAtualizarPort.Text = "Salvar";
                btnSalvarAtualizarPort.Image = Interface_WMS_Recebimento.Properties.Resources.salvar;
                TipDicas.SetToolTip(btnSalvarAtualizarPort, "Clique para Salvar o cadastro");
            }
        }

        //Cancelar/Sair
        private void AlterarCancelarSair()
        {
            if (mtbBuscaSenhaPort.Text != mtbBuscaSenhaPort.Mask
            || mtbBuscaPlacaVeic.Text != mtbBuscaPlacaVeic.Mask
            || txtBuscaNomeMot.Text != "")
            {
                btnCancelarPort.Text = "Cancelar";
                btnCancelarPort.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                TipDicas.SetToolTip(btnCancelarPort, "Clique para Cancelar");
            }
        }
        private void mtbBuscaSenhaPort_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && !(mtbBuscaSenhaPort.Text == mtbBuscaSenhaPort.Mask)
            && !(mtbBuscaPlacaVeic.Text == mtbBuscaPlacaVeic.Mask)
            && txtBuscaNomeMot.Text == ""
            && dgvPesqPort.Rows.Count == 0)
            {
                btnCancelarPort.Text = "Menu\r\nPrincipal";
                btnCancelarPort.Image = Interface_WMS_Recebimento.Properties.Resources.menu;
                TipDicas.SetToolTip(btnCancelarPort, "Clique para ir ao Menu Principal");
            }
        }

        private void mtbBuscaPlacaVeic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && !(mtbBuscaSenhaPort.Text == mtbBuscaSenhaPort.Mask)
            && !(mtbBuscaPlacaVeic.Text == mtbBuscaPlacaVeic.Mask)
            && txtBuscaNomeMot.Text == ""
            && dgvPesqPort.Rows.Count == 0)
            {
                btnCancelarPort.Text = "Menu\r\nPrincipal";
                btnCancelarPort.Image = Interface_WMS_Recebimento.Properties.Resources.menu;
                TipDicas.SetToolTip(btnCancelarPort, "Clique para ir ao Menu Principal");
            }
        }

        private void txtBuscaNomeMot_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && !(mtbBuscaSenhaPort.Text == mtbBuscaSenhaPort.Mask)
            && !(mtbBuscaPlacaVeic.Text == mtbBuscaPlacaVeic.Mask)
            && txtBuscaNomeMot.Text == ""
            && dgvPesqPort.Rows.Count == 0)
            {
                btnCancelarPort.Text = "Menu\r\nPrincipal";
                btnCancelarPort.Image = Interface_WMS_Recebimento.Properties.Resources.menu;
                TipDicas.SetToolTip(btnCancelarPort, "Clique para ir ao Menu Principal");
            }
        }

        //Ativar/Inativar cadastro pelo datagrid
        private void dgvPesqPort_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Verificando se o clique não foi no cabeçalho do datagrid
            {
                if (dgvPesqPort.Rows.Count > 0)
                {
                    bool VerifSelecAtvInat = (bool)dgvPesqPort.SelectedRows[0].Cells[0].Value;

                    if (VerifSelecAtvInat)
                    {
                        btnAtvInatCadastroPort.Text = "Inativar";
                        btnAtvInatCadastroPort.Image = Interface_WMS_Recebimento.Properties.Resources.Inativar;
                        TipDicas.SetToolTip(btnAtvInatCadastroPort, "Clique para Inativar o cadastro.");
                    }
                    else
                    {
                        btnAtvInatCadastroPort.Text = "Ativar";
                        btnAtvInatCadastroPort.Image = Interface_WMS_Recebimento.Properties.Resources.Ativar;
                        TipDicas.SetToolTip(btnAtvInatCadastroPort, "Clique para Ativar o cadastro.");
                    }
                }
            }
        }

        //Sair para o Menu
        private void FrmPortarias_FormClosed(object sender, FormClosedEventArgs e)
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
}

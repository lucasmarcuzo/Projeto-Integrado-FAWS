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
using static Interface_WMS_Recebimento.Divergencias.GerarRelatorioDivergencia;

namespace interface_wms
{
    public partial class FrmDivergencias : Form
    {
        private const string CadastroAtivo = "-1";
        private const string CadastroInativo = "0";
        private static Control.ControlCollection ControlesDivergencias;

        public static Control.ControlCollection getControlesDivergencias { get => ControlesDivergencias; }
        private static Control.ControlCollection setControlesDivergencias { set => ControlesDivergencias = value; }

        public FrmDivergencias()
        {
            InitializeComponent();

            LimparTodosOsCampos();

            btnNovoCadastroDivergencias.Focus();

            AbasFormatacoes.PassarCampos(lbIDDevolucaoDIverg, lbMatricInspetorDiverg, lbNumPedidoDiverg, lbNumNFDiverg, lbCodProdutoDiverg,
                                         lbDescricaoProdutoDiverg, lbQtdNotasDiverg, lbCodMotivoDiverg, lbQtdDevolvidaDiverg, lbDataDevolucaoDirverg,
                                         lbBuscaIDDevolucaoDiverg, lbBuscaNumPedidoDiverg, lbDataDevolucaoDiverg, lbFiltrarDiverg, lbAtivoDiverg, lbInativoDiverg);

            AbasFormatacoes.PassarCampos(btnNovoCadastroDivergencias, btnSalvarAtualizarDiverg, btnEditarDiverg, btnAtvInatCadastroDiverg,
                                         btnCancelarDiverg, btnBuscarDiverg, btnVertodosDiverg, btnGerarRelatorioDiverg);

            AbasFormatacoes.PassarCampos(grbDivergencias, grbControleDiverg, grbPesqDiverg);

            AbasFormatacoes.PassarCampos(tsmiNavegacaoDiverg, tsmiSistemaDiverg, tsmiUsuarioDiverg, tsmiAjudaDiverg, tsmiRegistrarDiverg,
                                        tsmiPortariasDiverg, tsmiRecebimentoDirveg, tsmiConsultaDirveg, tsmiPedidosDiverg, tsmiRelacaodeNFsDiverg,
                                        tsmiSairDiverg, tsmiPreferenciasDiverg, tsmiVerMatricDiverg, tsmiManualDiverg, tsmiSuporteDiverg, tsmiPermissoesDiverg);

            AbasFormatacoes.PassarCampos(picCabecalhoDiverg, picRodapeDiverg, picLogoDiverg);

            AbasFormatacoes.PassarCampos(txtMatricInspetorDiverg, txtNumPedDiverg, txtNumNFDiverg, txtCodProdDiverg, txtDescProdDiverg, txtQtdNotasDiverg,
                                         txtCodMotivoDiverg, txtQtdDevolvidaDiverg, txtBuscaNumPedDiverg);

            AbasFormatacoes.PassarCampos(mtbBuscaIDDevolucaoRec);

            AbasFormatacoes.PassarCampos(cboFiltroAtvInatDiverg);

            AbasFormatacoes.PassarCampos(dgvPesqDiverg);

            AbasFormatacoes.PassarCampos(msMenuDiverg);

            AbasFormatacoes.PassarCamposCabecalho(lbNomeSistemaDiverg, lblDataHoraDiverg, lbUsuarioDiverg, lbNomeUsuarioDiverg);

            setControlesDivergencias = Controls;
        }

        //Iniciar formulário Pai na cor Desejada e Verificando o acesso
        private void FrmDivergencias_Activated(object sender, EventArgs e)
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
            txtMatricInspetorDiverg.Text = FrmMenu.getUsuario;
        }

        //Ativar/Inativar Campos das Divergencias.
        private void AtivarInativarCamposDivergencias(bool status)
        {
            CamposValidacao.AtivarInativarCadastroDivergencias(status,
                                                                cboIDDevolucaoDiverg,
                                                                dtpDataDevolDiverg,
                                                                txtNumPedDiverg,
                                                                txtNumNFDiverg,
                                                                txtCodProdDiverg,
                                                                txtDescProdDiverg,
                                                                txtQtdNotasDiverg,
                                                                txtCodMotivoDiverg,
                                                                txtQtdDevolvidaDiverg);
        }

        //Verificar e pegar senhas de entrada da Divergencias.
        private void cbo_IDDevolucaoDiverg_DropDown(object sender, EventArgs e)
        {
            cboIDDevolucaoDiverg.Items.Clear();

            string Procura_Recebimento = "SELECT * FROM Recebimento WHERE Ativo_Inativo LIKE '" + CadastroAtivo + "'";
            DataTable Dados_Recebimento = ConexaoBD.RetornarValoresConsultaBD(Procura_Recebimento);

            string Procura_Divergencias = "SELECT * FROM Divergencias";
            DataTable Dados_Divergencias = ConexaoBD.RetornarValoresConsultaBD(Procura_Divergencias);

            string[] IDDevolucao_Rec = new string[Dados_Recebimento.Rows.Count];
            string[] IDDevolucao_Diverg = new string[Dados_Divergencias.Rows.Count];

            for (int i = 0; i < Dados_Recebimento.Rows.Count; i++)
            {
                IDDevolucao_Rec[i] = (string)Dados_Recebimento.Rows[i][13];
            }

            for (int i = 0; i < Dados_Divergencias.Rows.Count; i++)
            {
                IDDevolucao_Diverg[i] = (string)Dados_Divergencias.Rows[i][1];
            }

            foreach (var item in IDDevolucao_Rec)
            {
                if (IDDevolucao_Diverg.Contains(item) || item == "_________/________.____")
                {
                    continue;
                }
                else
                {
                    bool verificarAtvInat = false;
                    if (Dados_Recebimento.Rows.Count > 0)
                    {
                        verificarAtvInat = (bool)Dados_Recebimento.Rows[0][0];
                    }

                    if (!cboIDDevolucaoDiverg.Items.Contains(item) && verificarAtvInat)
                    {
                        cboIDDevolucaoDiverg.Items.Add(item);
                    }
                }
            }
        }

        //Novo Cadastro Divergencias
        private void btnNovoCadastroDivergencias_Click(object sender, EventArgs e)
        {
            AtivarInativarCamposDivergencias(true);

            Limpar.LimparTabelaDeConsulta(dgvPesqDiverg);

            btnSalvarAtualizarDiverg.Enabled = true;
            btnEditarDiverg.Enabled = false;
            btnAtvInatCadastroDiverg.Enabled = false;
            btnNovoCadastroDivergencias.Enabled = false;

            btnCancelarDiverg.Text = "Cancelar";
            btnCancelarDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
            TipDicas.SetToolTip(btnCancelarDiverg, "Clique para Cancelar");

            cboIDDevolucaoDiverg.Focus();
        }

        //Atualizar as formato/horas
        private void AtualizarDataseHoras()
        {
            dtpBuscaDataDev.Format = DateTimePickerFormat.Custom;
            dtpBuscaDataDev.CustomFormat = " ";

            dtpDataDevolDiverg.Format = DateTimePickerFormat.Custom;
            dtpDataDevolDiverg.CustomFormat = " ";
        }

        //Verificando se tem foco nos campos data e hora
        private void DtpHorasAtualizar_GotFocus(object sender, EventArgs e)
        {
            if (dtpDataDevolDiverg.Focused)
            {
                this.dtpDataDevolDiverg.MaxDate = DateTime.Now;
                this.dtpDataDevolDiverg.MinDate = DateTime.MinValue;

                dtpDataDevolDiverg.Format = DateTimePickerFormat.Custom;
                dtpDataDevolDiverg.CustomFormat = "dd/MM/yyyy HH:mm";
                dtpDataDevolDiverg.Value = dtpDataDevolDiverg.MaxDate;
            }
            else if (dtpBuscaDataDev.Focused)
            {
                this.dtpBuscaDataDev.MaxDate = DateTime.Now;
                this.dtpBuscaDataDev.MinDate = DateTime.MinValue;

                dtpBuscaDataDev.Format = DateTimePickerFormat.Custom;
                dtpBuscaDataDev.CustomFormat = "dd/MM/yyyy HH:mm";
                dtpBuscaDataDev.Value = dtpBuscaDataDev.MaxDate;
            }
        }

        private void dtpBuscaDataDev_Enter(object sender, EventArgs e)
        {
            dtpBuscaDataDev.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        private void dtpDataDevolDiverg_Enter(object sender, EventArgs e)
        {
            dtpDataDevolDiverg.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        private void dtpBuscaDataDev_DropDown(object sender, EventArgs e)
        {
            dtpBuscaDataDev.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        private void dtpDataDevolDiverg_DropDown(object sender, EventArgs e)
        {
            dtpDataDevolDiverg.GotFocus += DtpHorasAtualizar_GotFocus;
        }

        //Relógio/Datas
        private void tmrHoras_Tick(object sender, EventArgs e)
        {
            this.lblDataHoraDiverg.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");

            this.dtpDataDevolDiverg.MinDate = DateTime.MinValue;

            this.dtpDataDevolDiverg.MaxDate = DateTime.Now;
        }

        //Limpar Campos (Dievergencias)
        private void LimparTodosOsCampos()
        {
            Limpar.LimparCampos(txtNumPedDiverg,
                                txtNumNFDiverg,
                                txtCodProdDiverg,
                                txtDescProdDiverg,
                                txtQtdNotasDiverg,
                                txtCodMotivoDiverg,
                                txtQtdDevolvidaDiverg,
                                txtBuscaNumPedDiverg);

            Limpar.LimparFiltro(cboFiltroAtvInatDiverg);

            Limpar.LimparCampos(mtbBuscaIDDevolucaoRec);

            Limpar.LimparCampos(cboIDDevolucaoDiverg);

            Limpar.LimparErrorProvider(epBusca, epErros);

            Limpar.LimparTabelaDeConsulta(dgvPesqDiverg);

            AtivarInativarCamposDivergencias(false);

            btnSalvarAtualizarDiverg.Enabled = false;
            btnEditarDiverg.Enabled = false;
            btnAtvInatCadastroDiverg.Enabled = false;
            btnGerarRelatorioDiverg.Enabled = false;

            btnAtvInatCadastroDiverg.Text = "Ativar /\nInativar";
            btnAtvInatCadastroDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.Inativar;
            TipDicas.SetToolTip(btnAtvInatCadastroDiverg, "Ativa/Inativa o registro selecionado.");

            btnNovoCadastroDivergencias.Enabled = true;

            AtualizarDataseHoras();
        }


        //Cancelar e Sair
        private void btnCancelarDiverg_Click(object sender, EventArgs e)
        {
            if (btnCancelarDiverg.Text == "Sair")
            {
                this.Close();
            }
            else if (btnCancelarDiverg.Text == "Cancelar")
            {
                btnCancelarDiverg.Text = "Sair";
                btnCancelarDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarDiverg, "Clique para Sair");
                LimparTodosOsCampos();
            }
        }

        //Sair
        private void tsmiSairDiverg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Fechar formuláro
        private void FrmDivergencias_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result_closing = MessageBox.Show("Tem certeza que deseja sair? \nOs dados que não foram enviados não serão salvos!", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result_closing == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        //Trocar de abas
        private void tsmiPortariasDiverg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abas.TrocarAbas("FrmPortarias");
        }
        private void tsmiRecebimentoDiverg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Abas.TrocarAbas("FrmRecebimento");
        }
        private void tsmiPedidosDiverg_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmPedidos");
        }
        private void tsmiRelacaodeNFsDiverg_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmRelacaoNF");
        }
        private void tsmiSuporteDiverg_Click_1(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }

        //Econtrar ultimo form aberto para da Foco
        private void FrmDivergencias_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<FrmRecebimento>().Count() == 1)
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmRecebimento)
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
                bool verificarAtvInat = (bool)dgvPesqDiverg.SelectedRows[0].Cells[0].Value;

                if (verificarAtvInat)
                {
                    string cod = (string)dgvPesqDiverg.SelectedRows[0].Cells[1].Value;
                    string Procura_Divergencias = "SELECT * FROM Divergencias WHERE ID_Devolucao LIKE '" + cod + "'";

                    DataTable Dados_Divergencias = ConexaoBD.RetornarValoresConsultaBD(Procura_Divergencias);

                    cboIDDevolucaoDiverg.Text = (string)Dados_Divergencias.Rows[0][1];

                    txtMatricInspetorDiverg.Text = (string)Dados_Divergencias.Rows[0][2];
                    txtNumPedDiverg.Text = (string)Dados_Divergencias.Rows[0][3];
                    txtNumNFDiverg.Text = (string)Dados_Divergencias.Rows[0][4];
                    txtCodProdDiverg.Text = (string)Dados_Divergencias.Rows[0][5];
                    txtDescProdDiverg.Text = (string)Dados_Divergencias.Rows[0][6];
                    txtQtdNotasDiverg.Text = (string)Dados_Divergencias.Rows[0][7];
                    txtCodMotivoDiverg.Text = (string)Dados_Divergencias.Rows[0][8];
                    txtQtdDevolvidaDiverg.Text = (string)Dados_Divergencias.Rows[0][9];
                    dtpDataDevolDiverg.Text = (string)Dados_Divergencias.Rows[0][10];
                }
                else
                {
                    MessageBox.Show("Não é permitido editar os dados de um cadastro inativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                dgvPesqDiverg.Rows.Clear();
                MessageBox.Show(Erros.erroeditar(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Salvar/Atualizar dados
        private void btnSalvarDiverg_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string Procurar_Divergencias = "SELECT * FROM Divergencias WHERE ID_Devolucao LIKE '" + cboIDDevolucaoDiverg.Text + "'";

                if (CamposValidacao.ValidarPreenchimentoCamposDivergencias(cboIDDevolucaoDiverg,
                                                                                 txtMatricInspetorDiverg,
                                                                                 txtNumPedDiverg,
                                                                                 txtNumNFDiverg,
                                                                                 txtCodProdDiverg,
                                                                                 txtDescProdDiverg,
                                                                                 txtQtdNotasDiverg,
                                                                                 txtCodMotivoDiverg,
                                                                                 txtQtdDevolvidaDiverg,
                                                                                 epErros))
                {
                    if (ConexaoBD.VerificarDadoNaoExisteBD(connec, Procurar_Divergencias))
                    {
                        string Procurar_Recebimento = "SELECT * FROM Recebimento WHERE ID_Devolucao LIKE '" + cboIDDevolucaoDiverg.Text + "'";
                        DataTable Dados_Recebimento = ConexaoBD.RetornarValoresConsultaBD(Procurar_Recebimento);

                        string Procurar_Portarias = "SELECT * FROM Portaria WHERE Numero_NF LIKE '" + txtNumNFDiverg.Text + "'";
                        DataTable Dados_Portarias = ConexaoBD.RetornarValoresConsultaBD(Procurar_Portarias);

                        if ((bool)Dados_Recebimento.Rows[0][0] || (bool)Dados_Portarias.Rows[0][0])
                        {
                            connec.Open();

                            string SQL = "Insert Into Divergencias (Ativo_Inativo, ID_Devolucao, Matricula_Conferente, Numero_Pedido, Numero_NF, Cod_Produto, " +
                                                        "Descricao_Produto, Qtd_NFs, Cod_Motivo, Qtd_Devolvida, Data_Devolucao) Values ";

                            SQL += "('" + CadastroAtivo + "','" + cboIDDevolucaoDiverg.Text + "','" + txtMatricInspetorDiverg.Text + "','" + txtNumPedDiverg.Text + "','" + txtNumNFDiverg.Text + "','"
                                        + txtCodProdDiverg.Text + "','" + txtDescProdDiverg.Text + "','" + txtQtdNotasDiverg.Text + "','" + txtCodMotivoDiverg.Text + "','"
                                        + txtQtdDevolvidaDiverg.Text + "','" + dtpDataDevolDiverg.Text + "')";

                            OleDbCommand comando = new OleDbCommand(SQL, connec);

                            comando.ExecuteNonQuery();

                            MessageBox.Show("Dados salvos com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparTodosOsCampos();

                            connec.Close();
                        }
                        else
                        {
                            MessageBox.Show("Este cadastro foi INATIVADO, para poder dar entrada no cadastro de divergência o mesmo deve estar ativado na tabela \"Recebimento\"!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        string Procura_Divergencias = "SELECT * FROM Divergencias WHERE ID_Devolucao LIKE '" + cboIDDevolucaoDiverg.Text + "'";
                        DataTable Dados_Divergencias = ConexaoBD.RetornarValoresConsultaBD(Procura_Divergencias);

                        bool verificarAtvInat = false;
                        if (Dados_Divergencias.Rows.Count > 0)
                        {
                            verificarAtvInat = (bool)Dados_Divergencias.Rows[0][0];
                        }
                        connec.Close();

                        if (verificarAtvInat)
                        {
                            var result = MessageBox.Show("Este cadastro já existe, deseja atualizar os dados?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                            if (result == DialogResult.Yes)
                            {
                                try
                                {

                                    if (CamposValidacao.ValidarPreenchimentoCamposDivergencias(cboIDDevolucaoDiverg,
                                                                                                     txtMatricInspetorDiverg,
                                                                                                     txtNumPedDiverg,
                                                                                                     txtNumNFDiverg,
                                                                                                     txtCodProdDiverg,
                                                                                                     txtDescProdDiverg,
                                                                                                     txtQtdNotasDiverg,
                                                                                                     txtCodMotivoDiverg,
                                                                                                     txtQtdDevolvidaDiverg,
                                                                                                     epErros))
                                    {


                                        if (!ConexaoBD.VerificarDadoNaoExisteBD(connec, Procura_Divergencias))
                                        {
                                            connec.Open();

                                            OleDbCommand comando = new OleDbCommand
                                            {
                                                Connection = connec
                                            };

                                            string ID_Devolucao = cboIDDevolucaoDiverg.Text;

                                            string Matricula_Conferente = txtMatricInspetorDiverg.Text;
                                            string Numero_Pedido = txtNumPedDiverg.Text;
                                            string Numero_NF = txtNumNFDiverg.Text;
                                            string Cod_Produto = txtCodProdDiverg.Text;
                                            string Descricao_Produto = txtDescProdDiverg.Text;
                                            string Qtd_NFs = txtQtdNotasDiverg.Text;
                                            string Cod_Motivo = txtCodMotivoDiverg.Text;
                                            string Qtd_Devolvida = txtQtdDevolvidaDiverg.Text;
                                            string Data_Devolucao = dtpDataDevolDiverg.Text;

                                            comando.CommandText = "UPDATE Divergencias SET Matricula_Conferente = '" + Matricula_Conferente +
                                                                    "', Numero_Pedido = '" + Numero_Pedido +
                                                                    "', Numero_NF = '" + Numero_NF +
                                                                    "', Cod_Produto = '" + Cod_Produto +
                                                                    "', Descricao_Produto = '" + Descricao_Produto +
                                                                    "', Qtd_NFs = '" + Qtd_NFs +
                                                                    "', Cod_Motivo = '" + Cod_Motivo +
                                                                    "', Qtd_Devolvida = '" + Qtd_Devolvida +
                                                                    "', Data_Devolucao = '" + Data_Devolucao +
                                                                    "' WHERE ID_Devolucao = '" + ID_Devolucao + "'";

                                            comando.ExecuteNonQuery();

                                            MessageBox.Show("Dados alterados com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            connec.Dispose();

                                            btnVertodosDiverg.PerformClick();
                                        }
                                        else
                                        {
                                            epErros.SetError(cboIDDevolucaoDiverg, "A ID. de devolução informada não existe no banco de dados para ser editada!");
                                            cboIDDevolucaoDiverg.BackColor = Color.LightCoral;

                                            var result_ID = MessageBox.Show("A ID. de devolução informada não existe no banco de dados para ser editada, informe outra e tente novamente!! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                                            if (result_ID == DialogResult.Yes)
                                            {
                                                cboIDDevolucaoDiverg.Text = string.Empty;
                                                cboIDDevolucaoDiverg.BackColor = Color.White;
                                                epErros.Clear();
                                                cboIDDevolucaoDiverg.Focus();
                                            }
                                            else if (result_ID == DialogResult.No)
                                            {
                                                cboIDDevolucaoDiverg.BackColor = Color.White;
                                                epErros.Clear();
                                                btnCancelarDiverg.PerformClick();
                                            }
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
                MessageBox.Show(Erros.erroSalvarDadosDivergencias(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Buscar dados de um cadastro divergencias
        private void btnBuscarDiverg_Click(object sender, EventArgs e)
        {
            dgvPesqDiverg.Rows.Clear();

            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string Verificar_Divergencias = "SELECT * FROM Divergencias";

                if (mtbBuscaIDDevolucaoRec.MaskCompleted == true)
                {
                    Verificar_Divergencias = "SELECT * FROM Divergencias WHERE ID_Devolucao LIKE '" + mtbBuscaIDDevolucaoRec.Text + "'";
                    realizarbusca();
                }
                else if (txtBuscaNumPedDiverg.Text != "")
                {
                    Verificar_Divergencias = "SELECT * FROM Divergencias WHERE Numero_Pedido LIKE '" + txtBuscaNumPedDiverg.Text + "'";
                    realizarbusca();
                }
                else if (dtpBuscaDataDev.Text != " ")
                {
                    Verificar_Divergencias = "SELECT * FROM Divergencias WHERE Data_Devolucao LIKE '" + dtpBuscaDataDev.Text + "'";
                    realizarbusca();
                }
                else
                {
                    mtbBuscaIDDevolucaoRec.BackColor = Color.LightCoral;
                    txtBuscaNumPedDiverg.BackColor = Color.LightCoral;
                    dtpBuscaDataDev.BackColor = Color.LightCoral;

                    var result = MessageBox.Show("Para realizar a pesquisa o campo \"ID. de Devolução\", \"Num. do Pedido\" ou \"Data da devolução\" deve estar preenchido! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        mtbBuscaIDDevolucaoRec.Text = string.Empty;
                        txtBuscaNumPedDiverg.Text = string.Empty;
                        dtpBuscaDataDev.Text = string.Empty;
                        mtbBuscaIDDevolucaoRec.BackColor = Color.White;
                        txtBuscaNumPedDiverg.BackColor = Color.White;
                        dtpBuscaDataDev.BackColor = Color.White;
                        mtbBuscaIDDevolucaoRec.Focus();
                    }
                    else if (result == DialogResult.No)
                    {
                        mtbBuscaIDDevolucaoRec.Text = string.Empty;
                        txtBuscaNumPedDiverg.Text = string.Empty;
                        dtpBuscaDataDev.Text = string.Empty;
                        mtbBuscaIDDevolucaoRec.BackColor = Color.White;
                        txtBuscaNumPedDiverg.BackColor = Color.White;
                        dtpBuscaDataDev.BackColor = Color.White;
                        Application.Exit();
                    }
                }

                void realizarbusca()
                {
                    DataTable Dados_Divergencias = ConexaoBD.RetornarValoresConsultaBD(Verificar_Divergencias);

                    if (Dados_Divergencias.Rows.Count > 0)
                    {
                        foreach (DataRow linha in Dados_Divergencias.Rows)
                        {
                            dgvPesqDiverg.Rows.Add(linha.ItemArray);
                        }

                        for (int i = 0; i < dgvPesqDiverg.Rows.Count; i++)
                        {
                            bool cod = (bool)dgvPesqDiverg.Rows[i].Cells[0].Value;

                            if (cboFiltroAtvInatDiverg.SelectedIndex == 1 && !cod)
                            {
                                dgvPesqDiverg.Rows[i].Visible = false;
                            }
                            else if (cboFiltroAtvInatDiverg.SelectedIndex == 2 && cod)
                            {
                                dgvPesqDiverg.Rows[i].Visible = false;
                            }
                        }

                        dgvPesqDiverg.ClearSelection();
                    }
                    else
                    {
                        if (mtbBuscaIDDevolucaoRec.MaskCompleted == true)
                        {
                            epBusca.SetError(mtbBuscaIDDevolucaoRec, "A ID. de devolução não foi localizada no banco de dados, informe outra para tentar novamente!");
                            mtbBuscaIDDevolucaoRec.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("A ID. de devolução não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                mtbBuscaIDDevolucaoRec.Text = string.Empty;
                                mtbBuscaIDDevolucaoRec.BackColor = Color.White;
                                epBusca.Clear();
                                mtbBuscaIDDevolucaoRec.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarDiverg.PerformClick();
                            }
                        }
                        else if (txtBuscaNumPedDiverg.Text != string.Empty)
                        {
                            epBusca.SetError(txtBuscaNumPedDiverg, "O número do pedido não foi localizado no banco de dados, informe outro para tentar novamente!");
                            txtBuscaNumPedDiverg.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("O número do pedido não foi localizado no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                txtBuscaNumPedDiverg.Text = string.Empty;
                                txtBuscaNumPedDiverg.BackColor = Color.White;
                                epBusca.Clear();
                                txtBuscaNumPedDiverg.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarDiverg.PerformClick();
                            }
                        }
                        else if (dtpBuscaDataDev.Text != string.Empty)
                        {
                            epBusca.SetError(dtpBuscaDataDev, "A data de devolução informada não foi localizada no banco de dados, informe outra para tentar novamente!");
                            dtpBuscaDataDev.BackColor = Color.LightCoral;

                            var result = MessageBox.Show("A data de devolução informada não foi localizada no banco de dados! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                            if (result == DialogResult.Yes)
                            {
                                dtpBuscaDataDev.Text = string.Empty;
                                dtpBuscaDataDev.BackColor = Color.White;
                                epBusca.Clear();
                                AtualizarDataseHoras();
                                dtpBuscaDataDev.Focus();
                            }
                            else if (result == DialogResult.No)
                            {
                                btnCancelarDiverg.PerformClick();
                            }
                        }
                    }
                }

                if (dgvPesqDiverg.Rows.Count > 0)
                {
                    AlterarCancelarSair();
                    btnEditarDiverg.Enabled = true;
                    btnAtvInatCadastroDiverg.Enabled = true;
                    btnGerarRelatorioDiverg.Enabled = true;
                }
            }
            catch (Exception erro)
            {
                dgvPesqDiverg.Rows.Clear();
                MessageBox.Show("Erro " + erro);
            }
        }

        //Ver todos os cadastros divergencias
        private void btnVertodosDiverg_Click(object sender, EventArgs e)
        {
            dgvPesqDiverg.Rows.Clear();

            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string Procura_Divergencias = "SELECT * FROM Divergencias";

                if (cboFiltroAtvInatDiverg.SelectedIndex == 1)
                {
                    Procura_Divergencias = "SELECT * FROM Divergencias WHERE Ativo_Inativo LIKE '" + CadastroAtivo + "'";
                }
                else if (cboFiltroAtvInatDiverg.SelectedIndex == 2)
                {
                    Procura_Divergencias = "SELECT * FROM Divergencias WHERE Ativo_Inativo LIKE '" + CadastroInativo + "'";
                }

                DataTable Dados_Divergencias = ConexaoBD.RetornarValoresConsultaBD(Procura_Divergencias);

                if (Dados_Divergencias.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe nenhum registro de divergencia no Banco de dados.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEditarDiverg.Enabled = false;
                    btnAtvInatCadastroDiverg.Enabled = false;
                }
                else
                {
                    btnEditarDiverg.Enabled = true;
                    btnAtvInatCadastroDiverg.Enabled = true;
                    btnGerarRelatorioDiverg.Enabled = true;

                    btnCancelarDiverg.Text = "Cancelar";
                    btnCancelarDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                    TipDicas.SetToolTip(btnCancelarDiverg, "Clique para Cancelar");

                    foreach (DataRow linha in Dados_Divergencias.Rows)
                    {
                        dgvPesqDiverg.Rows.Add(linha.ItemArray);
                    }

                    dgvPesqDiverg.ClearSelection();
                }
            }
            catch (Exception er)
            {
                dgvPesqDiverg.Rows.Clear();
                MessageBox.Show(Erros.errovertodos(er), "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Emitir Relatório de Divergências
        private void btnGerarRelatorioDiverg_Click(object sender, EventArgs e)
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

        //Ver dados de um cadastro para editar
        private void btnEditarDiverg_Click(object sender, EventArgs e)
        {
            mostrarDados();
            AtivarInativarCamposDivergencias(true);
            cboIDDevolucaoDiverg.Enabled = false;
            btnSalvarAtualizarDiverg.Focus();
            AlterarSalvarAtualizar();

            btnNovoCadastroDivergencias.Enabled = false;
            btnSalvarAtualizarDiverg.Enabled = true;
        }

        //Ver dados de um cadastro para editar
        private void dgvPesqDiverg_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPesqDiverg.Rows.Count > 0)
            {
                mostrarDados();
                AtivarInativarCamposDivergencias(true);
                cboIDDevolucaoDiverg.Enabled = false;
                btnSalvarAtualizarDiverg.Focus();
                AlterarSalvarAtualizar();

                btnNovoCadastroDivergencias.Enabled = false;
                btnSalvarAtualizarDiverg.Enabled = true;
            }
        }

        //Ativar/Inativar dados de um cadastro do datagrid
        private void btnAtvInatCadastroDiverg_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connec = ConexaoBD.Conexao();

                string Valor_IDDevolucao = (string)dgvPesqDiverg.SelectedRows[0].Cells[1].Value;
                string Procura_Divergencias = "SELECT * FROM Divergencias WHERE ID_Devolucao LIKE '" + Valor_IDDevolucao + "'";

                bool cod = (bool)dgvPesqDiverg.SelectedRows[0].Cells[0].Value;
                string NF = (string)dgvPesqDiverg.SelectedRows[0].Cells[4].Value;

                //Pegando linha da tabela de Portarias
                string Procurar_NFPortari = "SELECT * FROM Portaria WHERE Numero_NF LIKE '" + NF + "'";
                DataTable Dados_Portaria = ConexaoBD.RetornarValoresConsultaBD(Procurar_NFPortari);
                string nf_port = "";
                if (Dados_Portaria.Rows.Count > 0)
                {
                    nf_port = (string)Dados_Portaria.Rows[0][13];
                }
                connec.Close();

                //Pegando linha da tabela de Recebimento
                string Procurar_NFRecebimento = "SELECT * FROM Recebimento WHERE Numero_NF LIKE '" + NF + "'";
                DataTable Dados_Recebimento = ConexaoBD.RetornarValoresConsultaBD(Procurar_NFRecebimento);
                string nf_rec = "";
                if (Dados_Recebimento.Rows.Count > 0)
                {
                    nf_rec = (string)Dados_Recebimento.Rows[0][7];
                }
                connec.Close();

                if (!ConexaoBD.VerificarDadoNaoExisteBD(connec, Procura_Divergencias))
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
                            comando.CommandText = "UPDATE Divergencias SET Ativo_Inativo = -1 WHERE ID_Devolucao = '" + Valor_IDDevolucao + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Recebimento SET Ativo_Inativo = -1 WHERE Numero_NF = '" + nf_rec + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Portaria SET Ativo_Inativo = -1 WHERE Numero_NF = '" + nf_port + "'";
                            comando.ExecuteNonQuery();

                            MessageBox.Show("O registro foi ativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparTodosOsCampos();
                            btnVertodosDiverg.PerformClick();
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
                            comando.CommandText = "UPDATE Divergencias SET Ativo_Inativo = 0 WHERE ID_Devolucao = '" + Valor_IDDevolucao + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Recebimento SET Ativo_Inativo = 0 WHERE Numero_NF = '" + nf_rec + "'";
                            comando.ExecuteNonQuery();
                            comando.CommandText = "UPDATE Portaria SET Ativo_Inativo = 0 WHERE Numero_NF = '" + nf_port + "'";
                            comando.ExecuteNonQuery();

                            MessageBox.Show("O registro foi inativado!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparTodosOsCampos();
                            btnVertodosDiverg.PerformClick();
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
        private void dgvPesqDiverg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                btnAtvInatCadastroDiverg.PerformClick();
            }
        }

        //Validação de entrada de dados nos campos
        private void cbo_IDDevolucaoDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtMatricConfDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtNumPedDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtNumNFDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtCodProdDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtDescProdDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_String(sender, e);
        }
        private void txtQtdNotasDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtCodMotivoDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtQtdDevolvidaDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void mtb_IDDevolucaoRec_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }
        private void txtBuscaNumPedDiverg_KeyPress(object sender, KeyPressEventArgs e)
        {
            CamposValidacao.Validar_Int(sender, e);
        }

        //Limpar campos sem erros
        private void cbo_IDDevolucaoDiverg_TextChanged(object sender, EventArgs e)
        {
            if (cboIDDevolucaoDiverg.Text != string.Empty)
            {
                cboIDDevolucaoDiverg.BackColor = Color.White;
                epErros.Clear();
            }

            AlterarSalvarAtualizar();
        }
        private void txtMatricConfDiverg_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtMatricInspetorDiverg, epErros);
        }
        private void txtNumPedDiverg_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtNumPedDiverg, epErros);
        }
        private void txtNumNFDiverg_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtNumNFDiverg, epErros);
        }
        private void txtCodProdDiverg_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtCodProdDiverg, epErros);
        }
        private void txtDescProdDiverg_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtDescProdDiverg, epErros);
        }
        private void txtQtdNotasDiverg_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtQtdNotasDiverg, epErros);
        }
        private void txtCodMotivoDiverg_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtCodMotivoDiverg, epErros);
        }
        private void txtQtdDevolvidaDiverg_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtQtdDevolvidaDiverg, epErros);
        }
        private void dtpDataDevolDiverg_ValueChanged(object sender, EventArgs e)
        {
            ///---///
        }
        private void mtb_IDDevolucaoRec_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(mtbBuscaIDDevolucaoRec, epBusca);
            AlterarCancelarSair();
        }
        private void txtBuscaNumPedDiverg_TextChanged(object sender, EventArgs e)
        {
            Limpar.LimparErros(txtBuscaNumPedDiverg, epBusca);
            AlterarCancelarSair();
        }
        private void dtpBuscaDataDev_ValueChanged(object sender, EventArgs e)
        {
            AlterarCancelarSair();
        }

        private void tsmiPreferDiverg_Click(object sender, EventArgs e)
        {
            FrmPreferencias frm = new FrmPreferencias();
            frm.ShowDialog();
        }
        private void tsmiVerMatricDiverg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A sua Matricula é: " + lbNomeUsuarioDiverg.Text, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tsmiPermissoesDiverg_Click(object sender, EventArgs e)
        {
            GerenciarAcessos.VerificarPermissoes(lbNomeUsuarioDiverg);
        }
        private void tsmiSuporteDiverg_Click(object sender, EventArgs e)
        {
            Abas.TrocarAbas("FrmManualAjuda");
        }

        //Mudar a cor de identificação de cadastros Ativos & Inativos.
        private void dgvPesqPort_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            AbasFormatacoes.AtualizarCorCadastroAtivoInativo(sender, e, dgvPesqDiverg);
        }

        //Métodos para alterar nomes/icones botoes
        private void AlterarSalvarAtualizar()
        {
            OleDbConnection connec = ConexaoBD.Conexao();

            string Verifica_IDDevolucao = "SELECT * FROM Divergencias WHERE ID_Devolucao LIKE '" + cboIDDevolucaoDiverg.Text + "'";

            if (cboIDDevolucaoDiverg.Text != "" && !ConexaoBD.VerificarDadoNaoExisteBD(connec, Verifica_IDDevolucao))
            {
                btnSalvarAtualizarDiverg.Text = "Atualizar";
                btnSalvarAtualizarDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.salvar_edição;
                TipDicas.SetToolTip(btnSalvarAtualizarDiverg, "Clique para Atualizar o cadastro");
            }
            else
            {
                btnSalvarAtualizarDiverg.Text = "Salvar";
                btnSalvarAtualizarDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.salvar;
                TipDicas.SetToolTip(btnSalvarAtualizarDiverg, "Clique para Salvar o cadastro");
            }
        }

        //Cancelar/Sair
        private void AlterarCancelarSair()
        {
            if (mtbBuscaIDDevolucaoRec.Text != mtbBuscaIDDevolucaoRec.Mask
            || txtBuscaNumPedDiverg.Text != ""
            || dtpBuscaDataDev.Text != "")
            {
                btnCancelarDiverg.Text = "Cancelar";
                btnCancelarDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.cancelar;
                TipDicas.SetToolTip(btnCancelarDiverg, "Clique para Cancelar");
            }
        }

        private void mtb_BuscaIDDevolucaoRec_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && !(mtbBuscaIDDevolucaoRec.Text == mtbBuscaIDDevolucaoRec.Mask)
            && !(txtBuscaNumPedDiverg.Text == txtBuscaNumPedDiverg.Text)
            && dtpBuscaDataDev.Text == ""
            && dgvPesqDiverg.Rows.Count == 0)
            {
                btnCancelarDiverg.Text = "Sair";
                btnCancelarDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarDiverg, "Clique para Sair");
            }
        }

        private void txtBuscaNumPedDiverg_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && !(mtbBuscaIDDevolucaoRec.Text == mtbBuscaIDDevolucaoRec.Mask)
            && !(txtBuscaNumPedDiverg.Text == txtBuscaNumPedDiverg.Text)
            && dtpBuscaDataDev.Text == ""
            && dgvPesqDiverg.Rows.Count == 0)
            {
                btnCancelarDiverg.Text = "Sair";
                btnCancelarDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarDiverg, "Clique para Sair");
            }
        }

        private void dtpBuscaDataDev_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back
            && !(mtbBuscaIDDevolucaoRec.Text == mtbBuscaIDDevolucaoRec.Mask)
            && !(txtBuscaNumPedDiverg.Text == txtBuscaNumPedDiverg.Text)
            && dtpBuscaDataDev.Text == ""
            && dgvPesqDiverg.Rows.Count == 0)
            {
                btnCancelarDiverg.Text = "Sair";
                btnCancelarDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.sair;
                TipDicas.SetToolTip(btnCancelarDiverg, "Clique para Sair");
            }
        }

        //Ativar/Inativar cadastro pelo datagrid
        private void dgvPesqDiverg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) //Verificando se o clique não foi no cabeçalho do datagrid
            {
                if (dgvPesqDiverg.Rows.Count > 0)
                {
                    bool VerifSelecAtvInat = (bool)dgvPesqDiverg.SelectedRows[0].Cells[0].Value;

                    if (VerifSelecAtvInat)
                    {
                        btnAtvInatCadastroDiverg.Text = "Inativar";
                        btnAtvInatCadastroDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.Inativar;
                        TipDicas.SetToolTip(btnAtvInatCadastroDiverg, "Clique para Inativar o cadastro.");
                    }
                    else
                    {
                        btnAtvInatCadastroDiverg.Text = "Ativar";
                        btnAtvInatCadastroDiverg.Image = Interface_WMS_Recebimento.Properties.Resources.Ativar;
                        TipDicas.SetToolTip(btnAtvInatCadastroDiverg, "Clique para Ativar o cadastro.");
                    }
                }
            }
        }
    }
}

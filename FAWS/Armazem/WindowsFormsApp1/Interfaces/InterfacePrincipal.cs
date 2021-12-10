using FAWS_WMS;
using FAWS_WMS.Telas;
using Interface_WMS_Armazem.Classes;
using Interface_WMS_Armazem.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static ProjetoIntegradoArmazem.GerarPDF;

namespace ProjetoIntegradoArmazem
{
    public partial class frminterfaceWMS_Armazem : Form
    {
        //declaração de variáveis.
        static ConexaoBD conexao = new ConexaoBD();
        private static OleDbConnection connect = conexao.conexaoBD(conexao.StrConexao());
        string SQL;
        public static Metodos metodos = new Metodos();
        public static MetodosBD metodosBD = new MetodosBD();
        private static Control.ControlCollection ControlesPrincipal;
        public static Control.ControlCollection getControlesPrincipal { get => ControlesPrincipal; }
        private static Control.ControlCollection setControlesPrincipal { set => ControlesPrincipal = value; }

        public frminterfaceWMS_Armazem()
        {
            frmMapa fmapa = new frmMapa();
            fmapa.Hide();

            InitializeComponent();

            List<TextBox> tList = new List<TextBox>() {txtNome_Prod, txtCodigo_Prod, txtCodigo_Ean, txtFornecedor, txtQuantidade
                                                       , txtLote, txtStatus, txtArea_Prod, txtAltura_Prod, txtLargura_Prod
                                                       , txtComprimento_Prod, txtVolume_Prod, txtPeso_Prod, txtCorredor, txtVao
                                                       , txtModulo, txtNivel, txtEndereco_Prod, txtConsulta_Prod, txtID_Endereco};
            List<string> sList = new List<string>() {"Ex. Papel Higiênico", "Ex. 03457899-8", "Ex. 5901234123457", "Ex. 1345678"
                                                     , "Ex. 12 caixas", "Ex. CM91384811Z4", "Ex. Ativo/Inativo", "Ex. 01"
                                                     , "Ex. 10cm", "Ex. 13cm", "Ex. 11cm", "Ex. 4cm³", "Ex. 20kg", "Ex. 02"
                                                     , "Ex. 03", "Ex. 04", "Ex. 05", "Ex. 12345", " 🔍", "Ex. 3467812"};
            SetCueBanner(ref tList, sList);

            MetodosPreferencia.PassarCampos(lblCodigo, lblNomeProduto, lblCodigoProduto, lblEan, lblID_fornecedor,
                                            lblQuantidade, lblLote, lblStatus, lblAltura, lblLargura, lblComprimento,
                                            lblVolume, lblPesoBruto, lblArea, lblCorredor, lblVao, lblModulo, lblNivel,
                                            lblEnderecoProduto, lblConsultaProdutos);
            MetodosPreferencia.PassarCampos(btnMostrarDados, btnMenu, btnLimpar, btnBuscar, btnBalancoInventario, btnAdicionarNovo,
                                            btnEditar, btnSalvar, btnRelatorioMensal, btnVisualizarMapa);
            MetodosPreferencia.PassarCampos(gpbInformacoes, gpbDimensoes, gpbEnderecamento, gpbConsulta, gpbControles);
            MetodosPreferencia.PassarCampos(tmsiSistemaPRINC, tmsiUsuarioPRINC, tmsiAjudaPRINC, tmsiOptionSairPRINC, tmsioptionPreferenciasPRNC,
                                            tmsioptionVerMatriculaPRINC, tmsioptionPermissoesPRINC, tmsiOptionSairPRINC);
            MetodosPreferencia.PassarCampos(picCabecalho, picLogo);
            MetodosPreferencia.PassarCampos(txtNome_Prod, txtCodigo_Prod, txtCodigo_Ean, txtFornecedor, txtQuantidade
                                            , txtLote, txtStatus, txtArea_Prod, txtAltura_Prod, txtLargura_Prod
                                            , txtComprimento_Prod, txtVolume_Prod, txtPeso_Prod, txtCorredor, txtVao
                                            , txtModulo, txtNivel, txtEndereco_Prod, txtConsulta_Prod, txtID_Endereco);
            MetodosPreferencia.PassarCampos(DtGrdArmazem);
            MetodosPreferencia.PassarCampos(msOpcoes);
            MetodosPreferencia.PassarCamposCabecalho(lblFatecWMS, lblDataeHora, lblNomeEmpresa, lblUsuario, lbNomeUsuarioPrincipal);

            setControlesPrincipal = Controls;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr i, string str);
        public void SetCueBanner(ref List<TextBox> txts, List<string> description)
        {
            for (int i = 0; i < txts.Count; i++)
            {
                SendMessage(txts[i].Handle, 0x1501, (IntPtr)1, description[i]);
            }
        }

        //Código começa aqui
        private void frminterfaceWMS_Armazem_Load(object sender, EventArgs e) //inicia o forms com alguns controles desabilitados
        {
            metodos.DisableTextBox(txtNome_Prod);
            metodos.DisableTextBox(txtCodigo_Prod);
            metodos.DisableTextBox(txtCodigo_Ean);
            metodos.DisableTextBox(txtFornecedor);
            metodos.DisableTextBox(txtQuantidade);
            metodos.DisableTextBox(txtLote);
            metodos.DisableTextBox(txtStatus);
            metodos.DisableTextBox(txtArea_Prod);
            metodos.DisableTextBox(txtAltura_Prod);
            metodos.DisableTextBox(txtLargura_Prod);
            metodos.DisableTextBox(txtComprimento_Prod);
            metodos.DisableTextBox(txtVolume_Prod);
            metodos.DisableTextBox(txtPeso_Prod);
            metodos.DisableTextBox(txtCorredor);
            metodos.DisableTextBox(txtVao);
            metodos.DisableTextBox(txtModulo);
            metodos.DisableTextBox(txtNivel);
            metodos.DisableTextBox(txtEndereco_Prod);
            metodos.DisableTextBox(txtID_Endereco);
            metodos.DisableButton(btnSalvar);
            metodos.DisableButton(btnEditar);
            MetodosPreferencia.MudarCorDeFundo(Controls, "padrao");
        }
        private void timerDataHora_Tick(object sender, EventArgs e) //preenche a label com data e horas atuais
        {
            lblDataeHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        //botoes
        private void btnAdicionarNovo_Click(object sender, EventArgs e) //Botao para adicionar novos produtos
        {
            metodos.EnableTextBox(txtNome_Prod); //habilita a textbox
            metodos.EnableTextBox(txtCodigo_Prod);
            metodos.EnableTextBox(txtCodigo_Ean);
            metodos.EnableTextBox(txtFornecedor);
            metodos.EnableTextBox(txtQuantidade);
            metodos.EnableTextBox(txtLote);
            metodos.EnableTextBox(txtStatus);
            metodos.EnableTextBox(txtArea_Prod);
            metodos.EnableTextBox(txtAltura_Prod);
            metodos.EnableTextBox(txtLargura_Prod);
            metodos.EnableTextBox(txtComprimento_Prod);
            metodos.EnableTextBox(txtVolume_Prod);
            metodos.EnableTextBox(txtPeso_Prod);
            metodos.EnableTextBox(txtCorredor);
            metodos.EnableTextBox(txtVao);
            metodos.EnableTextBox(txtModulo);
            metodos.EnableTextBox(txtNivel);
            metodos.EnableTextBox(txtEndereco_Prod);
            metodos.EnableTextBox(txtID_Endereco);
            metodos.EnableButton(btnSalvar); //habilita o botao
            txtID_Endereco.Focus(); //Poe o foco do tab para a primeira textbox do forms

        }
        private void btnEditar_Click(object sender, EventArgs e) //botao para editar as informações de algum produto
        {
            connect.Close();
            try
            {
                if (txtID_Endereco.Text != "" && txtNome_Prod.Text != "" && txtCodigo_Prod.Text != "" && txtCodigo_Ean.Text != "" && txtArea_Prod.Text != "" && txtCorredor.Text != "" && txtModulo.Text != "" && txtNivel.Text != "" && txtVao.Text != "" && txtEndereco_Prod.Text != "" && txtPeso_Prod.Text != "" && txtAltura_Prod.Text != "" && txtLargura_Prod.Text != "" && txtComprimento_Prod.Text != "" && txtVolume_Prod.Text != "" && txtStatus.Text != "" && txtFornecedor.Text != "" && txtQuantidade.Text != "" && txtLote.Text != "")
                {
                    connect.Open();

                    OleDbCommand comando = new OleDbCommand()
                    {
                        Connection = connect
                    };

                    comando.CommandText = $"UPDATE Armazenagem SET nome_produto = '{txtNome_Prod.Text}', Codigo_produto = '{txtCodigo_Prod.Text}', CodigoEan = '{txtCodigo_Ean.Text}', " +
                        $"area = '{txtArea_Prod.Text}', corredor = '{txtCorredor.Text}', modulo = '{txtModulo.Text}', nivel = '{txtNivel.Text}', vao = '{txtVao.Text}', Endereco_produto = '{txtEndereco_Prod.Text}', " +
                        $"PesoBruto = '{txtPeso_Prod.Text}', altura_produto = '{txtAltura_Prod.Text}', largura_produto = '{txtLargura_Prod.Text}', comprimento_produto = '{txtComprimento_Prod.Text}', " +
                        $"volume_produto = '{txtVolume_Prod.Text}', status_produto = '{txtStatus.Text}', ID_fornecedor = '{txtFornecedor.Text}', quantidade = '{txtQuantidade.Text}', lote = '{txtLote.Text} +' WHERE ID_Endereco = '{txtConsulta_Prod.Text}'";

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados alterados com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                try
                {
                    connect.Open();
                    //Cria comando e adapta os datos para o datagrid.
                    metodosBD.CreateCommand();
                    DataGrid newDtGrid = new DataGrid();
                    newDtGrid.MostrarDados(metodosBD.CreateCommand(), DtGrdArmazem);

                    connect.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e) //botão para buscar algum dado no banco de dados
        {
            connect.Close();
            try
            {
                if (txtConsulta_Prod.Text != "")
                {
                    SQL = $"SELECT * FROM Armazenagem WHERE ID_endereco LIKE '{txtConsulta_Prod.Text}' OR nome_produto LIKE '{txtConsulta_Prod.Text}'";

                    DataTable dt = metodosBD.DataTable(SQL);

                    txtID_Endereco.Text = (string)dt.Rows[0][0].ToString();
                    txtNome_Prod.Text = (string)dt.Rows[0][1];
                    txtCodigo_Prod.Text = (string)dt.Rows[0][2];
                    txtCodigo_Ean.Text = (string)dt.Rows[0][3];
                    txtArea_Prod.Text = (string)dt.Rows[0][4];
                    txtCorredor.Text = (string)dt.Rows[0][5];
                    txtModulo.Text = (string)dt.Rows[0][6];
                    txtNivel.Text = (string)dt.Rows[0][7];
                    txtVao.Text = (string)dt.Rows[0][8];
                    txtEndereco_Prod.Text = (string)dt.Rows[0][9];
                    txtPeso_Prod.Text = (string)dt.Rows[0][10].ToString();
                    txtAltura_Prod.Text = (string)dt.Rows[0][11].ToString();
                    txtLargura_Prod.Text = (string)dt.Rows[0][12].ToString();
                    txtComprimento_Prod.Text = (string)dt.Rows[0][13].ToString();
                    txtVolume_Prod.Text = (string)dt.Rows[0][14].ToString();
                    txtStatus.Text = (string)dt.Rows[0][15];
                    txtFornecedor.Text = (string)dt.Rows[0][16];
                    txtQuantidade.Text = (string)dt.Rows[0][17].ToString();
                    txtLote.Text = (string)dt.Rows[0][18];
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("O campo de consulta precisa ser preenchido corretamente", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Produto inexistente, verifique se o código foi digitado corretamente", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e) //botão para limpar os dados da tela
        {
            var resposta = MessageBox.Show("Deseja limpar os campos?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == resposta)
            {
                metodos.ClearTextBox(txtNome_Prod);
                metodos.ClearTextBox(txtCodigo_Prod);
                metodos.ClearTextBox(txtCodigo_Ean);
                metodos.ClearTextBox(txtFornecedor);
                metodos.ClearTextBox(txtQuantidade);
                metodos.ClearTextBox(txtLote);
                metodos.ClearTextBox(txtStatus);
                metodos.ClearTextBox(txtArea_Prod);
                metodos.ClearTextBox(txtAltura_Prod);
                metodos.ClearTextBox(txtLargura_Prod);
                metodos.ClearTextBox(txtComprimento_Prod);
                metodos.ClearTextBox(txtVolume_Prod);
                metodos.ClearTextBox(txtPeso_Prod);
                metodos.ClearTextBox(txtCorredor);
                metodos.ClearTextBox(txtVao);
                metodos.ClearTextBox(txtModulo);
                metodos.ClearTextBox(txtNivel);
                metodos.ClearTextBox(txtEndereco_Prod);
                metodos.ClearTextBox(txtConsulta_Prod);
                metodos.ClearTextBox(txtID_Endereco);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e) //botão para salvar as informações do produto no banco de dados
        {
            connect.Close();
            try
            {
                if (txtID_Endereco.Text != "" && txtNome_Prod.Text != "" && txtCodigo_Prod.Text != "" && txtCodigo_Ean.Text != "" && txtArea_Prod.Text != "" && txtCorredor.Text != "" && txtModulo.Text != "" && txtNivel.Text != "" && txtVao.Text != "" && txtEndereco_Prod.Text != "" && txtPeso_Prod.Text != "" && txtAltura_Prod.Text != "" && txtLargura_Prod.Text != "" && txtComprimento_Prod.Text != "" && txtVolume_Prod.Text != "" && txtStatus.Text != "" && txtFornecedor.Text != "" && txtQuantidade.Text != "" && txtLote.Text != "")
                {
                    connect.Open();

                    OleDbCommand comando = new OleDbCommand()
                    {
                        Connection = connect
                    };

                    comando.CommandText = SQL = "Insert Into Armazenagem (ID_endereco, nome_produto, Codigo_produto, CodigoEan, area, corredor, modulo, nivel, vao, Endereco_produto, PesoBruto, altura_produto, largura_produto, comprimento_produto, volume_produto, status_produto, ID_fornecedor, quantidade, lote) Values";
                    comando.CommandText = SQL += $"('{txtID_Endereco.Text}', '{txtNome_Prod.Text}', '{txtCodigo_Prod.Text}', '{txtCodigo_Ean.Text}', '{txtArea_Prod.Text}', '{txtCorredor.Text}', '{txtModulo.Text}', '{txtNivel.Text}', '{txtVao.Text}', '{txtEndereco_Prod.Text}', '{txtPeso_Prod.Text}', '{txtAltura_Prod.Text}', '{txtLargura_Prod.Text}', '{txtComprimento_Prod.Text }', '{txtVolume_Prod.Text}', '{txtStatus.Text.ToUpper()}', '{txtFornecedor.Text}', '{txtQuantidade.Text}', '{txtLote.Text}')";

                    comando.ExecuteNonQuery();
                    connect.Close();

                    MessageBox.Show("Dados gravados com sucesso!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                btnEditar.Enabled = true;

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                connect.Open();
                //Cria comando e adapta os dados para o datagrid.
                metodosBD.CreateCommand();
                DataGrid newDtGrid = new DataGrid();
                newDtGrid.MostrarDados(metodosBD.CreateCommand(), DtGrdArmazem);

                connect.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnVisualizarMapa_Click(object sender, EventArgs e) //abre o mapa do armazém
        {
            this.Hide();
            if (Application.OpenForms.OfType<frmMapa>().Count() == 0)
            {
                frmMapa frm = new frmMapa();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is frmMapa)
                    {
                        openForm.Show();
                    }
                }
            }
        }

        private void btnBalancoInventario_Click(object sender, EventArgs e) //faz o balanço de inventário do estoque
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRelatorioMensal_Click(object sender, EventArgs e) //gera um pdf com os dados do relatório mensal do estoque
        {
            var nomeArquivo = GerarRelatorioPDF(RealizarPesquisa().Count);
            var caminhoPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nomeArquivo);

            //novo codigo
            var caminho = @"C:\FAWS\Relatorios\";
            if (!File.Exists(caminho))
            {
                Directory.CreateDirectory(caminho);
            }
            string newCaminho = Path.Combine(caminho + nomeArquivo);
            File.Move(caminhoPDF, newCaminho);
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

        private void btnMostrarDados_Click(object sender, EventArgs e)
        {
            connect.Close();
            try
            {
                connect.Open();
                //Cria comando e adapta os datos para o datagrid.
                metodosBD.CreateCommand();
                DataGrid newDtGrid = new DataGrid();
                newDtGrid.MostrarDados(metodosBD.CreateCommand(), DtGrdArmazem);

                connect.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//botes acabam aqui.

        //opções do menuStrip
        private void optionSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void optionPreferencias_Click(object sender, EventArgs e)
        {
            frmPreferencias fPreferencias = new frmPreferencias();
            fPreferencias.ShowDialog();
        }
        private void optionVerMatricula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua matrícula é 00000000", "Matrícula de funcionário", MessageBoxButtons.OK);
        }
        private void optionPermissoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void optionSuporte_Click(object sender, EventArgs e)
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
        }//opções acabam aqui.

        //e.handled
        private void txtID_Endereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtCodigo_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtCodigo_Ean_KeyPress(object sender, KeyPressEventArgs e)
        {

            metodos.ApenasNumeros(e);
        }
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.LetraeNumero(e);
        }
        private void txtAltura_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtLargura_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtComprimento_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtVolume_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtPeso_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtArea_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtCorredor_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtVao_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtModulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtEndereco_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtNome_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasLetras(e);
        }
        private void txtFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasNumeros(e);
        }
        private void txtStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            metodos.ApenasLetras(e);
        }//e.handled acaba aqui.

        private void grdArmazem_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //abastece as textbox com os dados do datagrid/bd
        {
            connect.Close();
            if (DtGrdArmazem.CurrentCell.ColumnIndex == 0)
            {
                txtID_Endereco.Text = Convert.ToString(DtGrdArmazem.CurrentCell.Value);
            }
            try
            {
                SQL = $"SELECT * FROM Armazenagem WHERE ID_endereco LIKE '{txtID_Endereco.Text}'";

                DataTable dt = metodosBD.DataTable(SQL);

                txtID_Endereco.Text = (string)dt.Rows[0][0].ToString();
                txtNome_Prod.Text = (string)dt.Rows[0][1];
                txtCodigo_Prod.Text = (string)dt.Rows[0][2];
                txtCodigo_Ean.Text = (string)dt.Rows[0][3];
                txtArea_Prod.Text = (string)dt.Rows[0][4];
                txtCorredor.Text = (string)dt.Rows[0][5];
                txtModulo.Text = (string)dt.Rows[0][6];
                txtNivel.Text = (string)dt.Rows[0][7];
                txtVao.Text = (string)dt.Rows[0][8];
                txtEndereco_Prod.Text = (string)dt.Rows[0][9];
                txtPeso_Prod.Text = (string)dt.Rows[0][10].ToString();
                txtAltura_Prod.Text = (string)dt.Rows[0][11].ToString();
                txtLargura_Prod.Text = (string)dt.Rows[0][12].ToString();
                txtComprimento_Prod.Text = (string)dt.Rows[0][13].ToString();
                txtVolume_Prod.Text = (string)dt.Rows[0][14].ToString();
                txtStatus.Text = (string)dt.Rows[0][15];
                txtFornecedor.Text = (string)dt.Rows[0][16];
                txtQuantidade.Text = (string)dt.Rows[0][17].ToString();
                txtLote.Text = (string)dt.Rows[0][18];

                connect.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frminterfaceWMS_Armazem_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frminterfaceWMS_Armazem_FormClosed(object sender, FormClosedEventArgs e)
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

        private void frminterfaceWMS_Armazem_Activated(object sender, EventArgs e)
        {
            GerenciarAcessos.LiberarAcesso(btnBalancoInventario, btnRelatorioMensal);
            lbNomeUsuarioPrincipal.Text = FrmMenu.getUsuario;
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }

        //Icone barra de tarefas
        private void ntiNotiIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void tsmiVerMatricula_Click(object sender, EventArgs e)
        {
            tmsioptionVerMatriculaPRINC.PerformClick();
        }

        private void tsmiPermissoes_Click(object sender, EventArgs e)
        {
            tmsioptionPermissoesPRINC.PerformClick();
        }

        private void tsmiRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void tsmiManual_Click(object sender, EventArgs e)
        {
            tmsioptionManualPRINC.PerformClick();
        }

        private void tsmiSuporte_Click(object sender, EventArgs e)
        {
            suporteToolStripMenuItem.PerformClick();
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
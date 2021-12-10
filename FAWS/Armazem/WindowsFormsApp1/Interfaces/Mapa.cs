using FAWS_WMS;
using FAWS_WMS.Telas;
using Interface_WMS_Armazem.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProjetoIntegradoArmazem
{
    public partial class frmMapa : Form
    {
        static ConexaoBD conexao = new ConexaoBD();
        private static OleDbConnection connect = conexao.conexaoBD(conexao.StrConexao());
        private static Control.ControlCollection ControlesMapa;
        public static Control.ControlCollection getControlesMapa { get => ControlesMapa; }
        private static Control.ControlCollection setControlesMapa { set => ControlesMapa = value; }
        string SQL;
        static MetodosBD metodosBD = new MetodosBD();
        static Metodos metodos = new Metodos();

        public frmMapa()
        {
            InitializeComponent();



            List<TextBox> txtList = new List<TextBox>() { txtNome_do_Produto, txtCodigo_do_Produto, txtEAN };
            List<string> setList = new List<string>() { "Ex. Papel Higiênico", "Ex. 03457899 - 8", "Ex. 5901234123457" };
            SetCueBanner(ref txtList, setList);

            MetodosPreferencia.PassarCampos(lblCodigoProduto, lblDadosLocalizacao, lblEan, lblNomeProduto);
            MetodosPreferencia.PassarCampos(btnVisualizar, btnVoltar);
            MetodosPreferencia.PassarCampos(txtNome_do_Produto, txtCodigo_do_Produto, txtEAN);
            MetodosPreferencia.PassarCampos(msOpcoes);
            MetodosPreferencia.PassarCampos(picCabecalho, picLogo, picMapaArmazem);
            MetodosPreferencia.PassarCampos(tmsiAjudaMAPA, tmsiSistemaMAPA, tmsiUsuarioMAPA,
                                            tmsiopcaoPermissoesMAPA, tmsiopcaoPreferenciasMAPA,
                                            tmsiopcaoSairMAPA, tmsiopcaoManualMAPA, tmsiopcaoVerMatriculaMAPA);
            MetodosPreferencia.PassarCamposCabecalho(lblFatecWMS, lblDataeHora, lblNomeEmpresa, lblUsuario, lbNomeUsuarioMapa);

            setControlesMapa = Controls;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr i, string str);
        void SetCueBanner(ref List<TextBox> txts, List<string> description)
        {
            for (int i = 0; i < txts.Count; i++)
            {
                SendMessage(txts[i].Handle, 0x1501, (IntPtr)1, description[i]);
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Close();
                if (txtCodigo_do_Produto.Text != "" || txtEAN.Text != "" || txtNome_do_Produto.Text != "")
                {
                    metodos.AposOClcik(lblNome);
                    metodos.AposOClcik(lblCod);
                    metodos.AposOClcik(lblCodEan);
                    metodos.AposOClcik(lblStatus);
                    metodos.AposOClcik(lblEndereco);
                    metodos.AposOClcik(lblFornec);
                    metodos.AposOClcik(lblQTD);
                    metodos.AposOClcik(lblLote);
                    metodos.AposOClcik(nome);
                    metodos.AposOClcik(cod);
                    metodos.AposOClcik(ean);
                    metodos.AposOClcik(status);
                    metodos.AposOClcik(endereco);
                    metodos.AposOClcik(fornecedor);
                    metodos.AposOClcik(quantidade);
                    metodos.AposOClcik(lote);
                    SQL = $"SELECT * FROM Armazenagem WHERE nome_produto LIKE '{txtNome_do_Produto.Text}' OR Codigo_produto LIKE '{txtCodigo_do_Produto.Text}' OR CodigoEAN LIKE '{txtEAN.Text}'";
                    DataTable dt = metodosBD.DataTable(SQL);

                    lblDadosLocalizacao.ForeColor = Color.White;
                    lblNome.Text = (string)dt.Rows[0][1].ToString();
                    lblCod.Text = (string)dt.Rows[0][2].ToString();
                    lblCodEan.Text = (string)dt.Rows[0][3].ToString();
                    lblStatus.Text = (string)dt.Rows[0][15].ToString();
                    lblEndereco.Text = (string)dt.Rows[0][9].ToString();
                    lblFornec.Text = (string)dt.Rows[0][16].ToString();
                    lblQTD.Text = (string)dt.Rows[0][17].ToString();
                    lblLote.Text = (string)dt.Rows[0][18].ToString();
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("O campo de consulta precisa ser preenchido corretamente", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("O campo de consulta precisa ser preenchido corretamente", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            lblDataeHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }
        private void txtNome_do_Produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas letras", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtCodigo_do_Produto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtEAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void opcaoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void opcaoPreferencias_Click(object sender, EventArgs e)
        {
            frmPreferencias fPreferecias = new frmPreferencias();
            fPreferecias.ShowDialog();
        }
        private void opcaoVerMatricula_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sua matrícula é 00000000", "Matrícula de funcionário", MessageBoxButtons.OK);
        }
        private void opcaoPermissoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidade indisponível temporariamente.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void opcaoSuporte_Click(object sender, EventArgs e)
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
        private void frmMapa_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja sair?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
        private void frmMapa_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Environment.Exit(0);
            if (Application.OpenForms.OfType<frminterfaceWMS_Armazem>().Count() == 0)
            {
                frminterfaceWMS_Armazem frm = new frminterfaceWMS_Armazem();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is frminterfaceWMS_Armazem)
                    {
                        openForm.Show();
                    }
                }
            }
        }
        private void frmMapa_Load(object sender, EventArgs e)
        {
            MetodosPreferencia.MudarCorDeFundo(Controls, "padrao");
            metodos.AntesDoClcik(lblNome);
            metodos.AntesDoClcik(lblCod);
            metodos.AntesDoClcik(lblCodEan);
            metodos.AntesDoClcik(lblStatus);
            metodos.AntesDoClcik(lblEndereco);
            metodos.AntesDoClcik(lblFornec);
            metodos.AntesDoClcik(lblQTD);
            metodos.AntesDoClcik(lblLote);
            metodos.AntesDoClcik(nome);
            metodos.AntesDoClcik(cod);
            metodos.AntesDoClcik(ean);
            metodos.AntesDoClcik(status);
            metodos.AntesDoClcik(endereco);
            metodos.AntesDoClcik(fornecedor);
            metodos.AntesDoClcik(quantidade);
            metodos.AntesDoClcik(lote);
        }

        private void frmMapa_Activated(object sender, EventArgs e)
        {
            lbNomeUsuarioMapa.Text = FrmMenu.getUsuario;
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }
    }
}


using baseCF;
using FAWS_WMS.Telas;
using interface_wms;
using ProjetoIntegradoArmazem;
using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FAWS_WMS
{
    public partial class FrmMenu : Form
    {
        private static string Usuario = FrmLogin.getUser;
        private static string ResultLogin = FrmLogin.getResultLogin;

        public static string getUsuario { get => Usuario; }
        public static string getResultLogin { get => ResultLogin; }

        public FrmMenu()
        {
            InitializeComponent();

            Usuario = FrmLogin.getUser;
            ResultLogin = FrmLogin.getResultLogin;

            lblUser.Text += Usuario;
            if (ResultLogin.Equals("FATEC"))
            {
                tsmiLimparBD.Enabled = true;
            }
            else if (ResultLogin.Equals("PROFESSOR"))
            {
                btnClientes.Enabled = true;
                btnProdutos.Enabled = true;
                btnRecebimento.Enabled = true;
                btnArmazem.Enabled = true;
                btnExpedicao.Enabled = true;
            }
            else if (ResultLogin.Equals("CLIENTESEFORNECEDORES"))
            {
                btnClientes.Enabled = true;
            }
            else if (ResultLogin.Equals("PRODUTOS"))
            {
                btnProdutos.Enabled = true;
            }
            else if (ResultLogin.Equals("RECEBIMENTO"))
            {
                btnRecebimento.Enabled = true;
            }
            else if (ResultLogin.Equals("ARMAZEM"))
            {
                btnArmazem.Enabled = true;
            }
            else if (ResultLogin.Equals("EXPEDICAO"))
            {
                btnExpedicao.Enabled = true;
            }
        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        //Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Fechar menu e ir para tela de Login.
        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<FrmLogin>().Count() == 0)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmLogin)
                    {
                        //FrmLogin.LimparCampos();
                        openForm.Show();
                    }
                }
            }
        }

        //Botões Menu

        //Abrir módulo de Clientes e Fornecedores.
        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenuCadastro frm = new formMenuCadastro();
            frm.Show();
        }

        //Abrir módulo de Produtos.
        private void btnProdutos_Click(object sender, EventArgs e)
        {
            bool LoginProdutos;
            if (getUsuario.Equals("PRODUTOS@ADMINISTRADOR") || getUsuario.Equals("FATEC@PROFESSOR"))
            {
                LoginProdutos = true;
            }
            else
            {
                LoginProdutos = false;
            }
            this.Hide();
            frmProdutos frm = new frmProdutos(LoginProdutos);
            frm.Show();
        }

        //Abrir módulo de Recebimento.
        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPortarias frm = new FrmPortarias();
            frm.Show();
        }

        //Abrir módulo de Armazém.
        private void btnArmazem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frminterfaceWMS_Armazem frm = new frminterfaceWMS_Armazem();
            frm.Show();
        }

        //Abrir módulo de Expedição.
        private void btnExpedicao_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastrar frm = new frmCadastrar();
            frm.Show();
        }

        //Abir opção de limpar BD
        private void tsmiLimparBD_Click(object sender, EventArgs e)
        {
            FrmLimpar frm = new FrmLimpar();
            frm.ShowDialog();
        }


        //Abrir manual
        private void tsmiManualUsuarioMenu_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FrmManualAjuda>().Count() == 0)
            {
                FrmManualAjuda frm = new FrmManualAjuda();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmManualAjuda)
                    {
                        openForm.Show();
                    }
                }
            }
        }

        private void tsmiSuporteMenu_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }
    }
}

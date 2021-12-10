using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoIntegradoArmazem
{
    public partial class frmPreferencias : Form
    {
        private static int trbTamanhoFonteValor = 8;
        private static bool PadraoEscuro = false;

        public static bool getPadraoEscuro { get => PadraoEscuro; }
        private static bool setPadraoEscuro { set => PadraoEscuro = value; }
        public static int getTamanhoFonteValor { get => trbTamanhoFonteValor; }

        public frmPreferencias()
        {
            InitializeComponent();

            MetodosPreferencia.PassarCampos(lbTamanho8, lbTamanho9, lbTamanho10, lbTamanho11);
            MetodosPreferencia.PassarCampos(gpbTamanhoFonte, gpbEstiloCores);

            trbTamanhoFonte.Value = (int)MetodosPreferencia.Labels[3].Font.Size;
            trbTamanhoFonteValor = trbTamanhoFonte.Value;

            if (MetodosPreferencia.Labels[0].ForeColor == Color.White)
            {
                radEscuro.Checked = true;
                this.BackColor = Color.FromArgb(25, 25, 25);
                this.ForeColor = Color.Black;
            }
            else
            {
                radPadrao.Checked = true;
                this.BackColor = Color.FromName("Window");
                this.ForeColor = DefaultForeColor;
            }
        }
        private void trbTamanhoFonte_Scroll(object sender, EventArgs e)
        {
            AlterarTamanhoCampos(trbTamanhoFonte.Value);
        }
        private void radEscuro_CheckedChanged(object sender, EventArgs e)
        {
            MetodosPreferencia.PassarCampos(gpbTamanhoFonte, gpbEstiloCores);
            MetodosPreferencia.MudarCorDeFundo(frminterfaceWMS_Armazem.getControlesPrincipal, "escuro");
            MetodosPreferencia.MudarCorDeFundo(frmMapa.getControlesMapa, "escuro");

            this.BackColor = Color.FromArgb(25, 25, 25);
            this.ForeColor = Color.White;

            setPadraoEscuro = true;
        }
        private void radPadrao_CheckedChanged(object sender, EventArgs e)
        {
            MetodosPreferencia.PassarCampos(gpbTamanhoFonte, gpbEstiloCores);
            MetodosPreferencia.MudarCorDeFundo(frminterfaceWMS_Armazem.getControlesPrincipal, "padrao");
            MetodosPreferencia.MudarCorDeFundo(frmMapa.getControlesMapa, "padrao");

            this.BackColor = Color.FromName("Window");
            this.ForeColor = DefaultForeColor;

            setPadraoEscuro = false;
        }
        public static void AlterarTamanhoCampos(int tamanhoFonte)
        {
            foreach (var item in MetodosPreferencia.Labels)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            foreach (var item in MetodosPreferencia.Botoes)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            foreach (var item in MetodosPreferencia.Groupboxes)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            foreach (var item in MetodosPreferencia.Toolstripmenuitens)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            foreach (var item in MetodosPreferencia.Labelscabecalho)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            trbTamanhoFonteValor = tamanhoFonte;
        }


    }
}

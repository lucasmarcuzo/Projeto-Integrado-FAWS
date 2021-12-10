using Interface_WMS_Recebimento.Ferramentas;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interface_wms.Ferramentas
{
    public partial class FrmPreferencias : Form
    {
        private static int trbTamanhoFonteValor = 8;
        private static bool PadraoEscuro = false;

        public static bool getPadraoEscuro { get => PadraoEscuro; }
        private static bool setPadraoEscuro { set => PadraoEscuro = value; }
        public static int getTamanhoFonteValor { get => trbTamanhoFonteValor; }

        public FrmPreferencias()
        {
            InitializeComponent();

            AbasFormatacoes.PassarCampos(lbTamanho8, lbTamanho9, lbTamanho10, lbTamanho11);
            AbasFormatacoes.PassarCampos(gpbTamanhoFonte, gpbEstiloCores);

            trbTamanhoFonte.Value = (int)AbasFormatacoes.Labels[5].Font.Size;
            trbTamanhoFonteValor = trbTamanhoFonte.Value;

            if (AbasFormatacoes.Labels[0].ForeColor == Color.White)
            {
                radEscuro.Checked = true;
                this.BackColor = Color.FromArgb(25, 25, 25);
                this.ForeColor = Color.White;
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
            AtualizarTamanhoCampos(trbTamanhoFonte.Value);
        }

        //Modo de Cor Escuro
        private void radInvertido_CheckedChanged(object sender, EventArgs e)
        {
            AbasFormatacoes.PassarCampos(gpbTamanhoFonte, gpbEstiloCores);
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmPortarias.getControlesPortaria, "escuro");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmRecebimento.getControlesRecebimento, "escuro");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmDivergencias.getControlesDivergencias, "escuro");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmRelacaoNF.getControlesRelacaoNFs, "escuro");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmPedidos.getControlesPedidos, "escuro");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmAjuda.getControlesManual, "escuro");

            this.BackColor = Color.FromArgb(25, 25, 25);
            this.ForeColor = Color.White;

            setPadraoEscuro = true;
        }

        //Modo de Cor Padrão
        private void radPadrao_CheckedChanged(object sender, EventArgs e)
        {
            AbasFormatacoes.PassarCampos(gpbTamanhoFonte, gpbEstiloCores);
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmPortarias.getControlesPortaria, "padrao");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmRecebimento.getControlesRecebimento, "padrao");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmDivergencias.getControlesDivergencias, "padrao");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmRelacaoNF.getControlesRelacaoNFs, "padrao");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmPedidos.getControlesPedidos, "padrao");
            AbasFormatacoes.AtualizarCorDeFundoForm(FrmAjuda.getControlesManual, "padrao");

            this.BackColor = Color.FromName("Window");
            this.ForeColor = DefaultForeColor;

            setPadraoEscuro = false;
        }

        public static void AtualizarTamanhoCampos(int tamanhoFonte)
        {
            foreach (var item in AbasFormatacoes.Labels)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            foreach (var item in AbasFormatacoes.Botoes)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            foreach (var item in AbasFormatacoes.Groupboxes)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            foreach (var item in AbasFormatacoes.Toolstripmenuitens)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            foreach (var item in AbasFormatacoes.Labelscabecalho)
            {
                item.Font = new Font(item.Font.FontFamily, tamanhoFonte, item.Font.Style);
            }

            trbTamanhoFonteValor = tamanhoFonte;
        }

    }


}

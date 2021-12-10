using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace interface_wms.Ferramentas
{
    internal class AbasFormatacoes
    {
        private static List<Label> labels = new List<Label>();
        private static List<Button> botoes = new List<Button>();
        private static List<GroupBox> groupboxes = new List<GroupBox>();
        private static List<ToolStripMenuItem> toolstripmenuitens = new List<ToolStripMenuItem>();
        private static List<PictureBox> picturesbox = new List<PictureBox>();
        private static List<TextBox> txtboxes = new List<TextBox>();
        private static List<MaskedTextBox> maskedtxtboxs = new List<MaskedTextBox>();
        private static List<ComboBox> comboboxes = new List<ComboBox>();
        private static List<DataGridView> datagridviews = new List<DataGridView>();
        private static List<MenuStrip> msitens = new List<MenuStrip>();
        private static List<Label> labelscabecalho = new List<Label>();
        private static List<TreeView> treesviews = new List<TreeView>();

        public static List<Label> Labels { get => labels; set => labels = value; }
        public static List<Button> Botoes { get => botoes; set => botoes = value; }
        public static List<GroupBox> Groupboxes { get => groupboxes; set => groupboxes = value; }
        public static List<ToolStripMenuItem> Toolstripmenuitens { get => toolstripmenuitens; set => toolstripmenuitens = value; }
        public static List<PictureBox> Picturesbox { get => picturesbox; set => picturesbox = value; }
        public static List<TextBox> Txtboxes { get => txtboxes; set => txtboxes = value; }
        public static List<MaskedTextBox> Maskedtxtboxs { get => maskedtxtboxs; set => maskedtxtboxs = value; }
        public static List<ComboBox> Comboboxes { get => comboboxes; set => comboboxes = value; }
        public static List<DataGridView> Datagridviews { get => datagridviews; set => datagridviews = value; }
        public static List<MenuStrip> Msitens { get => msitens; set => msitens = value; }
        public static List<Label> Labelscabecalho { get => labelscabecalho; set => labelscabecalho = value; }
        public static List<TreeView> Treesviews { get => treesviews; set => treesviews = value; }


        //Método para mudar a cor de identificação de cadastros Ativos & Inativos.
        internal static void AtualizarCorCadastroAtivoInativo(object sender, DataGridViewCellFormattingEventArgs e, DataGridView Tabela)
        {
            if (Tabela.Columns[e.ColumnIndex].Name == "Ativo_Inativo")
            {
                if (e.Value != null && !(bool)e.Value)
                {
                    //alterar cor da linha inteira
                    //DataGridViewRow row = Tabela.Rows[e.RowIndex];
                    //row.DefaultCellStyle.BackColor = Color.FromArgb(51, 153, 255);
                    e.CellStyle.BackColor = Color.FromArgb(192, 192, 192);
                }
                else
                {
                    e.CellStyle.BackColor = Color.FromName("DeepSkyBlue");
                }
            }
        }

        //Método para Iniciar Form Pai na cor de fundo desejada.
        internal static void AtualizarCorDeFundoForm(Control.ControlCollection Controls, string tipo)
        {
            if (tipo.ToLower().Equals("padrao"))
            {
                foreach (Control control in Controls)
                {
                    control.BackColor = Color.White;
                }

                foreach (var item in AbasFormatacoes.Labels)
                {
                    item.BackColor = Color.FromName("White");
                    item.ForeColor = Color.FromName("ControlText");
                }

                foreach (var item in AbasFormatacoes.Botoes)
                {
                    item.BackColor = Color.FromName("White");
                    item.ForeColor = Color.FromName("ActiveCaptionText");
                    item.FlatAppearance.BorderColor = Color.FromName("MenuHighlight");
                }

                foreach (var item in AbasFormatacoes.Groupboxes)
                {
                    item.BackColor = Color.FromName("White");
                    item.ForeColor = Color.FromName("ControlText");
                }

                foreach (var item in AbasFormatacoes.Toolstripmenuitens)
                {
                    item.BackColor = Color.FromName("Window");
                    item.ForeColor = Color.FromName("ControlText");
                }

                foreach (var item in AbasFormatacoes.Picturesbox)
                {
                    item.BackColor = Color.FromName("ButtonFace");
                    item.ForeColor = Color.FromName("ControlText");
                }

                foreach (var item in AbasFormatacoes.Txtboxes)
                {
                    item.BackColor = Color.FromName("Window");
                    item.ForeColor = Color.FromName("WindowText");
                }

                foreach (var item in AbasFormatacoes.Maskedtxtboxs)
                {
                    item.BackColor = Color.FromName("Window");
                    item.ForeColor = Color.FromName("WindowText");
                }

                foreach (var item in AbasFormatacoes.Comboboxes)
                {
                    item.BackColor = Color.FromName("Window");
                    item.ForeColor = Color.FromName("WindowText");
                }

                foreach (var item in AbasFormatacoes.Datagridviews)
                {
                    item.BackgroundColor = Color.FromName("ButtonHighlight");
                    item.BackColor = Color.FromName("ButtonHighlight");
                    item.ForeColor = Color.FromName("WindowText");
                }

                foreach (var item in AbasFormatacoes.Msitens)
                {
                    item.BackColor = Color.FromName("Window");
                }

                foreach (var item in AbasFormatacoes.Labelscabecalho)
                {
                    item.BackColor = Color.FromName("ButtonFace");
                    item.ForeColor = Color.FromName("ControlText");
                }

            }
            else if (tipo.ToLower().Equals("escuro"))
            {

                foreach (Control control in Controls)
                {
                    control.BackColor = Color.FromName("ControlText");
                }

                foreach (var item in AbasFormatacoes.Labels)
                {
                    item.BackColor = Color.FromArgb(63, 63, 70);
                    item.ForeColor = Color.White;
                }

                foreach (var item in AbasFormatacoes.Botoes)
                {
                    item.BackColor = Color.FromArgb(25, 25, 25);
                    item.ForeColor = Color.White;
                }

                foreach (var item in AbasFormatacoes.Groupboxes)
                {
                    item.BackColor = Color.FromArgb(63, 63, 66);
                    item.ForeColor = Color.White;
                }

                foreach (var item in AbasFormatacoes.Toolstripmenuitens)
                {
                    item.BackColor = Color.FromArgb(25, 25, 25);
                    item.ForeColor = Color.White;
                }

                foreach (var item in AbasFormatacoes.Picturesbox)
                {
                    item.BackColor = Color.FromArgb(63, 63, 66);
                    item.ForeColor = Color.White;
                }

                foreach (var item in AbasFormatacoes.Txtboxes)
                {
                    item.BackColor = Color.FromArgb(25, 25, 25);
                    item.ForeColor = Color.Black;
                }

                foreach (var item in AbasFormatacoes.Maskedtxtboxs)
                {
                    item.BackColor = Color.FromArgb(25, 25, 25);
                    item.ForeColor = Color.Black;
                }

                foreach (var item in AbasFormatacoes.Comboboxes)
                {
                    item.BackColor = Color.FromArgb(25, 25, 25);
                    item.ForeColor = Color.Black;
                }

                foreach (var item in AbasFormatacoes.Datagridviews)
                {
                    item.BackgroundColor = Color.FromArgb(63, 63, 66);
                    item.ForeColor = Color.Black;
                    item.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(63, 63, 66);
                    item.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromName("Window");
                    item.DefaultCellStyle.BackColor = Color.FromArgb(63, 63, 66);
                    item.DefaultCellStyle.ForeColor = Color.FromName("Window");
                }

                foreach (var item in AbasFormatacoes.Labelscabecalho)
                {
                    item.BackColor = Color.FromArgb(63, 63, 66);
                    item.ForeColor = Color.White;
                }

                foreach (var item in AbasFormatacoes.Treesviews)
                {
                    item.BackColor = Color.FromArgb(63, 63, 66);
                    item.ForeColor = Color.White;
                }

            }
        }


        //Pegando campos Labels
        internal static void PassarCampos(params Label[] lbs)
        {
            Labels.AddRange(lbs);
        }

        //Pegando campos Botoes
        internal static void PassarCampos(params Button[] btns)
        {
            Botoes.AddRange(btns);
        }

        //Pegando campos GroupBox
        internal static void PassarCampos(params GroupBox[] grbs)
        {
            Groupboxes.AddRange(grbs);
        }

        //Pegando campos Tsmi
        internal static void PassarCampos(params ToolStripMenuItem[] tsmis)
        {
            Toolstripmenuitens.AddRange(tsmis);
        }

        //Pegando campos Pics
        internal static void PassarCampos(params PictureBox[] pics)
        {
            Picturesbox.AddRange(pics);
        }

        //Pegando campos Txtboxes
        internal static void PassarCampos(params TextBox[] txtbs)
        {
            Txtboxes.AddRange(txtbs);
        }

        //Pegando campos Maskedtxtboxs
        internal static void PassarCampos(params MaskedTextBox[] mtbs)
        {
            Maskedtxtboxs.AddRange(mtbs);
        }

        //Pegando campos Comboboxes
        internal static void PassarCampos(params ComboBox[] cbos)
        {
            Comboboxes.AddRange(cbos);
        }

        //Pegando campos Datagridviews
        internal static void PassarCampos(params DataGridView[] dgvs)
        {
            Datagridviews.AddRange(dgvs);
        }

        //Pegando campos MenuStrip
        internal static void PassarCampos(params MenuStrip[] msis)
        {
            Msitens.AddRange(msis);
        }

        //Pegando campos Cabeçalho
        internal static void PassarCamposCabecalho(params Label[] lbs)
        {
            Labelscabecalho.AddRange(lbs);
        }

        //Pegando campos Treeview
        internal static void PassarCampos(params TreeView[] trees)
        {
            Treesviews.AddRange(trees);
        }



    }
}

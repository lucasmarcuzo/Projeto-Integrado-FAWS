using System.Drawing;
using System.Windows.Forms;

namespace interface_wms.Ferramentas
{
    internal class Limpar
    {
        //Limpando os Campos das guias.

        //Limpar campos com erros.
        internal static void LimparErros(TextBox TxtBoxCampo, ErrorProvider Error)
        {
            if (TxtBoxCampo.Text != string.Empty)
            {
                TxtBoxCampo.BackColor = Color.White;
                Error.Clear();
            }
        }
        internal static void LimparErros(MaskedTextBox MTBCampo, ErrorProvider Error)
        {
            if (MTBCampo.Text != string.Empty)
            {
                MTBCampo.BackColor = Color.White;
                Error.Clear();
            }
        }

        internal static void LimparErros(ComboBox MTBCampo, ErrorProvider Error)
        {
            if (MTBCampo.Text != "")
            {
                MTBCampo.BackColor = Color.White;
                Error.Clear();
            }
        }

        //Limpar alerta de erro nos campos.
        internal static void LimparErrorProvider(params ErrorProvider[] Erros)
        {
            foreach (var erros in Erros)
            {
                erros.Clear();
            }
        }

        //Métodos para limpar todos os Campos.
        internal static void LimparCampos(params TextBox[] TxtBoxCampos)
        {
            foreach (var txtboxcampos in TxtBoxCampos)
            {
                txtboxcampos.Clear();
                txtboxcampos.BackColor = Color.White;
            }
        }
        internal static void LimparCampos(params MaskedTextBox[] MtBoxCampos)
        {
            foreach (var mtboxcampos in MtBoxCampos)
            {
                mtboxcampos.Clear();
                mtboxcampos.BackColor = Color.White;
            }
        }
        internal static void LimparCampos(params ComboBox[] ComboBoxCampos)
        {
            foreach (var cboxcampos in ComboBoxCampos)
            {
                cboxcampos.Text = "";
                cboxcampos.SelectedIndex = -1;
                cboxcampos.BackColor = Color.White;
            }
        }

        //Colocar filtro em default.
        internal static void LimparFiltro(ComboBox CboFiltro)
        {
            CboFiltro.SelectedIndex = 0;
        }

        //Método para limpar o datagrid.
        internal static void LimparTabelaDeConsulta(DataGridView TabelaDeConsulta)
        {
            TabelaDeConsulta.Rows.Clear();
        }

        //Método para Desativar Salvar como Divergencia.
        internal static void DesativarSalvarComoDivergencia(RadioButton radDiverNao)
        {
            radDiverNao.Checked = true;
        }
    }
}

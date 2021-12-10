using System.Windows.Forms;

namespace baseCF
{
    class UserI
    {
        public void limparCampos(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control item in controles)
            {
                //Se o contorle for um TextBox...
                if (item.GetType() == typeof(TextBox))
                {
                    item.Text = string.Empty;

                }
                if (item.GetType() == typeof(ComboBox))
                {

                    item.Enabled = true;
                    item.Text = string.Empty; //limpa todos os controles do tipo TextBox              
                }

            }
        }

        public void abrirFecharForm(Form formFechar, Form formAbrir)
        {
            formFechar.Hide();
            formAbrir.Closed += (s, args) => formFechar.Close();
            formAbrir.Focus();

        }
    }
}

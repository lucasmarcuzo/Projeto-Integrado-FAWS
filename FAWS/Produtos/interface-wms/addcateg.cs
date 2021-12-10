using System;
using System.Drawing;
using System.Windows.Forms;
using static interface_wms.conexao;

namespace interface_wms
{
    public partial class frmAddCateg : Form
    {
        //método que vai executar a consulta. É necessário chamar o método onde deseja que ele seja executado passando o parâmetro de uma string que possui a consulta SQL desejada.
        //Importante: A string precisa ter o nome SQL pois o comando só executará a Query da string com nome de SQL.
        public frmAddCateg()
        {
            InitializeComponent();
        }

        private void txtDescriptCateg_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtDescriptCateg.Text == "Escreva uma breve descrição desta categoria")
            {
                txtDescriptCateg.Text = " ";
                txtDescriptCateg.ForeColor = Color.Black;
            }
        }

        private void txtNameCateg_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtNameCateg.Text == "Insira o nome da nova categoria")
            {
                txtNameCateg.Text = " ";
                txtNameCateg.ForeColor = Color.Black;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string SQL = "INSERT INTO g5_Categoria (Nome, Descricao) VALUES ('" + txtNameCateg.Text + "','" + txtDescriptCateg.Text + "')";
                executaConsulta(SQL);
                MessageBox.Show($"Categoria {txtNameCateg.Text} adicionada com sucesso!", "FAWS WMS");
                this.Close();
            }
            catch (Exception erroCadastro)
            {
                MessageBox.Show(erroCadastro.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static interface_wms.conexao;

namespace interface_wms
{
    public partial class frmAddSubCateg : Form
    {

        public frmAddSubCateg()
        {
            InitializeComponent();
        }

        private void txtNameSubCateg_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtNameSubCateg.Text == "Insira o nome da nova sub categoria")
            {
                txtNameSubCateg.Text = " ";
                txtNameSubCateg.ForeColor = Color.Black;
            }
        }

        private void txtDescriptSubCateg_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtDescriptSubCateg.Text == "Escreva uma breve descrição desta sub categoria")
            {
                txtDescriptSubCateg.Text = " ";
                txtDescriptSubCateg.ForeColor = Color.Black;
            }
        }

        private void txtCateg_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                string SQL = "SELECT ID,NOME FROM g5_Categoria";
                DataTable categoria = retornaTable(SQL);
                txtCateg.DataSource = categoria;
                txtCateg.ValueMember = "ID";
                txtCateg.DisplayMember = "Nome";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string SQL = "INSERT INTO G5_SUBCATEGORIA (NOME, idCATEGORIA, DESCRICAO) VALUES ('" + txtNameSubCateg.Text + "'," + txtCateg.SelectedValue + ",'" + txtDescriptSubCateg.Text + "')";
                executaConsulta(SQL);
                MessageBox.Show($"Sub categoria {txtNameSubCateg.Text} adicionada com sucesso!", "FAWS WMS");
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

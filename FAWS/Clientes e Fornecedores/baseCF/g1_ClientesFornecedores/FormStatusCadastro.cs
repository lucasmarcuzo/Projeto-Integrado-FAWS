using FAWS_WMS;
using FAWS_WMS.Telas;
using Interface_WMS_ClientesFornecedores.g1_ClientesFornecedores;
using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace baseCF
{
    public partial class FormStatusCadastro : Form
    {
        public FormStatusCadastro()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentCell.Value.ToString() != null)
            {
                button7.Enabled = true;
                button8.Enabled = true;
            }
            else
            {
                button7.Enabled = false;
                button8.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormStatusCadastroInserir abrirFormStatusCadastroInserir = new FormStatusCadastroInserir();

            abrirFormStatusCadastroInserir.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormStatusCadastroInserir frm = new FormStatusCadastroInserir();

            frm.codigo.Text = dataGridView2.SelectedCells[0].Value.ToString();
            frm.Status.Text = dataGridView2.SelectedCells[1].Value.ToString();


            frm.btnSalvar.Visible = false;
            frm.btnAlterar.Visible = true;

            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)

                try
                {
                    var selectedCells = this.dataGridView2.SelectedCells;

                    OleDbConnection con = new OleDbConnection(Globals.ConnString);
                    con.Open();

                    OleDbCommand comando = new OleDbCommand();
                    comando.Connection = con;

                    var selectedrowindex = selectedCells[0].RowIndex;

                    var rowdata = this.dataGridView2.Rows[selectedrowindex];

                    var id = (int)rowdata.Cells[0].Value;

                    comando.CommandText = "delete from g1_tblstatuscadastro where idstatuscadastro = " + id;

                    comando.Connection = con;

                    comando.CommandType = CommandType.Text;

                    int rowaffected = comando.ExecuteNonQuery();

                    if (rowaffected == 0)
                    {
                        MessageBox.Show("nenhuma linha encontrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("dados excluídos com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                string busca = "SELECT * FROM g1_tblStatusCadastro";

                OleDbDataAdapter adapter = new OleDbDataAdapter(busca, con);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "g1_tblStatusCadastro");

                dataGridView2.DataSource = DS.Tables["g1_tblStatusCadastro"];

                con.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UserI fechar = new UserI();
            fechar.abrirFecharForm(this, formMenuCadastro.ActiveForm);

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                if (codigo.Text != "")
                {
                    string consulta = "SELECT * FROM g1_tblStatusCadastro WHERE idStatusCadastro LIKE '" + codigo.Text + "'";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, con);

                    DataSet DS = new DataSet();

                    adapter.Fill(DS, "g1_tblStatusCadastro");

                    dataGridView2.DataSource = DS.Tables["g1_tblStatusCadastro"];

                    con.Close();
                }

                if (status.Text != "")
                {
                    string consulta = "SELECT * FROM g1_tblStatusCadastro WHERE descStatusCadastro LIKE '" + status.Text + "'";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, con);

                    DataSet DS = new DataSet();

                    adapter.Fill(DS, "g1_tblStatusCadastro");

                    dataGridView2.DataSource = DS.Tables["g1_tblStatusCadastro"];

                    con.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormStatusCadastro_Activated(object sender, EventArgs e)
        {
            lbNomeUsuarioPrincipal.Text = FrmMenu.getUsuario;
        }

        private void optionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormManual>().Count() == 0)
            {
                FormManual frm = new FormManual();
                frm.Show();
            }
            else
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FormManual)
                    {
                        openForm.Show();
                    }
                }
            }
        }

        private void suporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContatoLogin frm = new FormContatoLogin();
            frm.ShowDialog();
        }
    }
}

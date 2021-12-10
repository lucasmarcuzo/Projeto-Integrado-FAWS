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
    public partial class FormCadastroBancos : Form
    {
        public FormCadastroBancos()
        {
            InitializeComponent();
        }

        public string idBanco;

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button7_Click(object sender, EventArgs e)
        {
            FormCadastroBancosInserir frm = new FormCadastroBancosInserir();

            frm.idBanco.Text = dataGridView1.SelectedCells[0].Value.ToString();
            frm.codigoBanco.Text = dataGridView1.SelectedCells[1].Value.ToString();
            frm.descricaoBanco.Text = dataGridView1.SelectedCells[2].Value.ToString();

            frm.btnSalvar.Visible = false;
            frm.btnAlterar.Visible = true;

            frm.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();


                string SQL = "SELECT * FROM g1_tblBanco";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);

                DataSet DS = new DataSet();

                adapter.Fill(DS, "g1_tblBanco");

                dataGridView1.DataSource = DS.Tables["g1_tblBanco"];

                con.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCadastroBancosInserir abrirFormCadastroBancosInserir = new FormCadastroBancosInserir();

            abrirFormCadastroBancosInserir.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //DialogResult res = MessageBox.Show("Confirma exclusão?", "", MessageBoxButtons.YesNo);

            //if(res == DialogResult.Yes)

            //try
            //{
            //    var selectedCells = this.dataGridView1.SelectedCells;

            //        OleDbConnection con = new OleDbConnection(Globals.ConnString);
            //        con.Open();

            //        OleDbCommand comando = new OleDbCommand();
            //    comando.Connection = con;

            //    var selectedRowIndex = selectedCells[0].RowIndex;

            //    var rowData = this.dataGridView1.Rows[selectedRowIndex];

            //    var id = (int)rowData.Cells[0].Value;

            //    comando.CommandText = "DELETE from g1_tblBanco WHERE idBanco = " + id;

            //    comando.Connection = con;

            //    comando.CommandType = CommandType.Text;

            //    int rowAffected = comando.ExecuteNonQuery();

            //    if (rowAffected == 0)
            //    {
            //        MessageBox.Show("Nenhuma linha encontrada!");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Dados excluídos com sucesso!");
            //    }
            //    con.Close();
            //    }
            //catch (Exception erro)
            //{
            //    MessageBox.Show(erro.Message);
            //}

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();



                if (codigoBanco.Text != "")
                {
                    string consulta = "SELECT * FROM g1_tblBanco WHERE descBanco LIKE '" + codigoBanco.Text + "'";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, con);

                    DataSet DS = new DataSet();

                    adapter.Fill(DS, "g1_tblBanco");

                    dataGridView1.DataSource = DS.Tables["g1_tblBanco"];

                    con.Close();
                }

                if (descricaoBanco.Text != "")
                {
                    string consulta = "SELECT * FROM g1_tblBanco WHERE codBanco LIKE '" + descricaoBanco.Text + "'";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(consulta, con);

                    DataSet DS = new DataSet();

                    adapter.Fill(DS, "g1_tblBanco");

                    dataGridView1.DataSource = DS.Tables["g1_tblBanco"];

                    con.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void FormCadastroBancos_Activated(object sender, EventArgs e)
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

using FAWS_WMS;
using FAWS_WMS.Telas;
using Interface_WMS_ClientesFornecedores.g1_ClientesFornecedores;
using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;

namespace baseCF
{
    public partial class FormCadastroBancosInserir : Form
    {
        public FormCadastroBancosInserir()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string validardescricao = descricaoBanco.Text;
                string validarcodigo = codigoBanco.Text;

                if (validardescricao == "" || validarcodigo == "")
                {
                    MessageBox.Show("Todos os campos são obrigatórios!");
                }
                else


                {
                    OleDbConnection con = new OleDbConnection(Globals.ConnString);
                    con.Open();

                    string SQL;
                    SQL = "Insert Into g1_tblBanco (codBanco, descBanco) Values";
                    SQL += "('" + descricaoBanco.Text + "','" + codigoBanco.Text + "')";

                    OleDbCommand comando = new OleDbCommand(SQL, con);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados gravados com sucesso!");

                    descricaoBanco.Clear();
                    codigoBanco.Clear();

                    con.Close();
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


        private void interfaceWMS_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            descricaoBanco.Clear();
            codigoBanco.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string validardescricao = descricaoBanco.Text;
                string validarcodigo = codigoBanco.Text;

                if (validardescricao == "" || validarcodigo == "")
                {
                    MessageBox.Show("Todos os campos são obrigatórios!");
                }
                else
                {
                    OleDbConnection con = new OleDbConnection(Globals.ConnString);
                    con.Open();

                    string SQL;

                    SQL = "UPDATE g1_tblBanco SET codBanco = '" + codigoBanco.Text + "', ";
                    SQL += "descBanco = '" + descricaoBanco.Text + "' ";
                    SQL += "WHERE idBanco = " + idBanco.Text;

                    OleDbCommand comando = new OleDbCommand(SQL, con);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Dados alterados com sucesso!");

                    codigoBanco.Clear();
                    descricaoBanco.Clear();

                    con.Close();
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormCadastroBancosInserir_Activated(object sender, EventArgs e)
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


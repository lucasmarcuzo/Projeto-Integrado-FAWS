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
    public partial class formBairroInserir : Form
    {
        public formBairroInserir()
        {
            InitializeComponent();
            fillCidade();
            cboCidade.SelectedIndex = -1;
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())

                try
                {


                    OleDbConnection con = new OleDbConnection(Globals.ConnString);
                    con.Open();

                    String SQL;
                    SQL = "Insert Into g1_tblBairro (idCidade, descBairro) values ";
                    SQL += "('" + cboCidade.SelectedValue + "','" + txtdescBairro.Text + "')";


                    OleDbCommand cmd = new OleDbCommand(SQL, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dados gravados com sucesso.");

                    UserI LC = new UserI();

                    LC.limparCampos(tabIdentTributo.Controls);

                    con.Close();

                    UserI fecharForm = new UserI();
                    fecharForm.abrirFecharForm(this, formEstado.ActiveForm);




                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }


            else
                MessageBox.Show("Favor preencher todos os campos.");
        }

        private bool ValidarForm()
        {
            bool FormValido;

            if (txtdescBairro.Text == "")
                FormValido = false;
            else if (txtdescBairro.Text == "")
                FormValido = false;
            else if (cboCidade.SelectedValue.ToString() == "")
                FormValido = false;
            else
                FormValido = true;
            return FormValido;
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            UserI fechar = new UserI();
            fechar.abrirFecharForm(this, formEstado.ActiveForm);

        }

        void fillCidade()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "Select * from g1_tblCidade";

                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboCidade.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboCidade.DisplayMember = "descCidade";
                cboCidade.ValueMember = "IdCidade";
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        private void formBairroInserir_Activated(object sender, EventArgs e)
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

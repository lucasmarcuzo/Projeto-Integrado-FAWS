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
    public partial class formTributoInserir : Form
    {
        public formTributoInserir()
        {
            InitializeComponent();
            fillCboCidade();
            fillCboTributo();
        }
        void fillCboCidade()

        {
            try
            {


                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "Select idCidade, descCidade from g1_tblCidade ORDER BY descCidade ";


                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "g1_tblCidade");


                cboCidade.Items.Clear();
                cboCidade.DataSource = DS.Tables["g1_tblCidade"];
                cboCidade.SelectedItem = "";
                cboCidade.DisplayMember = "descCidade";
                cboCidade.ValueMember = "idCidade";




            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        void fillCboTributo()

        {
            try
            {


                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "Select * from g1_tblTipoTributo ORDER BY codTributo";

                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboTipoTributo.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboTipoTributo.DisplayMember = "codTributo";
                cboTipoTributo.ValueMember = "idTipoTributo";
                cboTipoTributo.SelectedItem = "";

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }




        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void tmrDataHora_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())

            {

                if (ValidarDuplicidade() < 1)

                {
                    bool blnflagEditar;

                    blnflagEditar = flagEditar.Checked;

                    if (blnflagEditar == true)

                    {

                        try
                        {


                            OleDbConnection con = new OleDbConnection(Globals.ConnString);
                            con.Open();




                            String SQL;
                            SQL = "UPDATE g1_tblTributo SET ";
                            SQL += "idCidade = '" + cboCidade.SelectedValue + "',";
                            SQL += "idTipoTributo= '" + cboTipoTributo.SelectedValue + "',";
                            SQL += "aliquota= '" + txtAliquota.Text + "',";
                            SQL += "vigente= " + chkVigente.Checked + " WHERE IdTributo = " + txtIdTributo.Text;


                            OleDbCommand cmd = new OleDbCommand(SQL, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Dados gravados com sucesso.");

                            UserI LC = new UserI();

                            LC.limparCampos(tabIdentTributo1.Controls);

                            con.Close();


                        }

                        catch (Exception erro)
                        {

                            MessageBox.Show(erro.Message);
                        }
                    }

                    else


                        try
                        {


                            OleDbConnection con = new OleDbConnection(Globals.ConnString);
                            con.Open();

                            String SQL;
                            SQL = "Insert Into g1_tblTributo (idCidade, idTipoTributo, aliquota) values ";
                            SQL += "('" + cboCidade.SelectedValue + "','" + cboTipoTributo.SelectedValue + "','" + txtAliquota.Text + "')";


                            OleDbCommand cmd = new OleDbCommand(SQL, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Dados gravados com sucesso.");

                            UserI LC = new UserI();

                            LC.limparCampos(tabIdentTributo1.Controls);

                            con.Close();


                        }

                        catch (Exception erro)
                        {

                            MessageBox.Show(erro.Message);
                        }
                }



                else
                {
                    MessageBox.Show("O registro já existe no Banco de Dados");

                }
            }



            else
            {
                MessageBox.Show("Favor preencher todos os campos.");

            }
        }






        private bool ValidarForm()
        {
            bool FormValido;

            if (cboCidade.Text == "")
                FormValido = false;
            else if (cboTipoTributo.Text == "")
                FormValido = false;
            else if (txtAliquota.Text == "")
                FormValido = false;
            else
                FormValido = true;
            return FormValido;
        }

        private int ValidarDuplicidade()
        {

            try
            {


                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT COUNT (*) ";
                SQL += "FROM g1_tblTributo ";
                SQL += "WHERE g1_tblTributo.idCidade = " + cboCidade.SelectedValue + " And g1_tblTributo.idTipoTributo = " + cboTipoTributo.SelectedValue;
                SQL += "AND g1_tblTributo.vigente=" + chkVigente.Checked;


                //+ "And g1_tblTributo.idTipoTributo = " + cboTipoTributo.SelectedValue ;


                OleDbCommand cmd = new OleDbCommand(SQL, con);

                int teste = (Int32)cmd.ExecuteScalar();

                con.Close();

                return teste;

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.Message);
                return 1;

            }

        }



        private void cboCidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //chama procedimento para alterar popular a cboTipoTributo baseado no valor campo cidade
            //fillCboTributo();

        }

        private void formTributoInserir_Load(object sender, EventArgs e)
        {

        }

        private void formTributoInserir_Activated(object sender, EventArgs e)
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

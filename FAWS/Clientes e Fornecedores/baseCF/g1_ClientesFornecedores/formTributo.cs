using FAWS_WMS;
using FAWS_WMS.Telas;
using Interface_WMS_ClientesFornecedores.g1_ClientesFornecedores;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace baseCF
{
    public partial class formTributo : Form
    {
        public formTributo()
        {
            InitializeComponent();
            fillCboCidade();

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

        private void button6_Click(object sender, EventArgs e)
        {
            formTributoInserir abrirFormTributoInserir = new formTributoInserir();
            abrirFormTributoInserir.ShowDialog();

        }



        private void button2_Click(object sender, EventArgs e)
        {

            UserI fechar2 = new UserI();
            fechar2.abrirFecharForm(this, formMenuCadastro.ActiveForm);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void formTributo_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

        }

        void fillCboCidade()

        {
            try
            {


                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT g1_tblCidade.IdCidade , g1_tblCidade.descCidade FROM ";

                SQL += "g1_tblCidade INNER JOIN g1_tblTributo ON ";
                SQL += "g1_tblCidade.idCidade = g1_tblTributo.IdCidade GROUP BY ";
                SQL += "g1_tblCidade.idCidade , g1_tblCidade.descCidade ORDER BY g1_tblCidade.descCidade  ";


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
                cboCidade.ValueMember = "idCidade";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void Consultar()
        {

            try
            {


                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                bool blnvig;
                blnvig = true;

                SQL = "SELECT g1_tblTributo.idTributo, g1_tblTributo.idCidade, g1_tblTributo.idTipoTributo, g1_tblTributo.aliquota , g1_tblTributo.vigente, g1_tblTipoTributo.codTributo,  ";
                SQL += "g1_tblCidade.descCidade FROM ";
                SQL += "g1_tblCidade INNER JOIN(g1_tblTipoTributo INNER JOIN g1_tblTributo ON g1_tblTipoTributo.idTipoTributo = g1_tblTributo.idTipoTributo) ";
                SQL += "ON g1_tblCidade.idCidade = g1_tblTributo.idCidade ";
                SQL += "WHERE g1_tblCidade.idCidade=" + cboCidade.SelectedValue;
                SQL += " And g1_tblTributo.idTipoTributo=" + cboCodTributo.SelectedValue;
                SQL += " And g1_tblTributo.vigente=" + blnvig;


                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, con);
                DataSet DS = new DataSet();
                adapter.Fill(DS, "g1_tblTributo");


                dgCnsTipoTributo.DataSource = DS.Tables["g1_tblTributo"];

                dgCnsTipoTributo.Columns[0].HeaderText = "IdTributo";
                dgCnsTipoTributo.Columns[0].Visible = false;
                dgCnsTipoTributo.Columns[1].HeaderText = "IdCidade";
                dgCnsTipoTributo.Columns[1].Visible = false;
                dgCnsTipoTributo.Columns[2].HeaderText = "IdTipoTributo";
                dgCnsTipoTributo.Columns[2].Visible = false;
                dgCnsTipoTributo.Columns[3].HeaderText = "Alíquota";
                dgCnsTipoTributo.Columns[3].DisplayIndex = 6;
                dgCnsTipoTributo.Columns[4].HeaderText = "Vigente";
                dgCnsTipoTributo.Columns[4].Visible = false;
                dgCnsTipoTributo.Columns[6].HeaderText = "Município";
                dgCnsTipoTributo.Columns[6].DisplayIndex = 4;
                dgCnsTipoTributo.Columns[5].HeaderText = "Código do tributo";
                dgCnsTipoTributo.Columns[5].DisplayIndex = 5;


                dgCnsTipoTributo.Columns[3].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgCnsTipoTributo.Columns[6].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dgCnsTipoTributo.Columns[5].HeaderCell.Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);


                dgCnsTipoTributo.Columns[3].Width = 100;
                dgCnsTipoTributo.Columns[6].Width = 200;
                dgCnsTipoTributo.Columns[5].Width = 150;


                int V = dgCnsTipoTributo.RowCount;

                if (V > 0)
                {
                    btnExcluir.Enabled = true;
                    btnEditar.Enabled = true;

                }

                else
                {

                    btnExcluir.Enabled = false;
                    btnEditar.Enabled = false;

                }

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
                SQL = "SELECT g1_tblTipoTributo.IdTipoTributo , g1_tblTipoTributo.codTributo FROM g1_tblTipoTributo INNER JOIN g1_tblTributo ON g1_tblTributo.IdTipoTributo =  g1_tblTipoTributo.IdTipoTributo WHERE g1_tblTributo.idCidade =" + cboCidade.SelectedValue + "And g1_tblTributo.vigente =" + -1;


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cboCodTributo.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cboCodTributo.DisplayMember = "codTributo";
                cboCodTributo.ValueMember = "IdTipoTributo";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void cboCidade_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillCboTributo();
            Consultar();
        }

        private void cboCodTributo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Consultar();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //if (RespUsuario() == "Yes")

            //{

            //    try
            //    {


            //        OleDbConnection con = new OleDbConnection(Globals.ConnString);
            //        con.Open();

            //        String cod = dgCnsTipoTributo.SelectedCells[0].Value.ToString();
            //        String SQL = "Delete from g1_tblTributo WHERE idTributo =" + cod;

            //        OleDbCommand cmd = new OleDbCommand(SQL, con);

            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Dados excluídos com sucesso");

            //        Consultar();


            //    }
            //    catch (Exception erro)
            //    {

            //        MessageBox.Show(erro.Message);
            //    }
            //}

            //else
            //{


            //}
        }

        public string RespUsuario()
        {

            DialogResult RespUsuario = MessageBox.Show("Deseja excluir o item selecionado", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            return RespUsuario.ToString();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            formTributoInserir formTributo = new formTributoInserir();

            formTributo.txtIdTributo.Text = dgCnsTipoTributo.SelectedCells[0].Value.ToString();
            formTributo.cboCidade.SelectedValue = dgCnsTipoTributo.SelectedCells[1].Value.ToString();
            formTributo.cboTipoTributo.SelectedValue = dgCnsTipoTributo.SelectedCells[2].Value.ToString();
            formTributo.txtAliquota.Text = dgCnsTipoTributo.SelectedCells[3].Value.ToString();

            formTributo.cboCidade.Enabled = false;
            formTributo.cboTipoTributo.Enabled = false;
            formTributo.txtAliquota.Enabled = false;


            if (dgCnsTipoTributo.SelectedCells[4].Value.ToString() == "True")
            {
                formTributo.chkVigente.Checked = true;
            }
            else
            {
                formTributo.chkVigente.Checked = false;
            }

            formTributo.flagEditar.Checked = true;

            formTributo.ShowDialog();
        }

        private void groupBox1_Move(object sender, EventArgs e)
        {
            ttlAviso.SetToolTip(this.groupBox1, "Informe os parâmetros para iniciar a pesquisa.");
        }

        private void formTributo_Activated(object sender, EventArgs e)
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baseCF
{
    public class Fill
    {
        public void fillCboCidade(ComboBox cidade)
        {
            formCliente FC = new formCliente();
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT g1_tblCidade.IdCidade , g1_tblCidade.descCidade FROM ";

                SQL += "g1_tblCidade INNER JOIN g1_tblClientes ON ";
                SQL += "g1_tblCidade.idCidade = g1_tblClientes.IdCidade GROUP BY ";
                SQL += "g1_tblCidade.idCidade , g1_tblCidade.descCidade ORDER BY g1_tblCidade.descCidade  ";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cidade.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cidade.DisplayMember = "descCidade";
               cidade.ValueMember = "idCidade";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void fillCidade(ComboBox cidade)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblCidade";

                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cidade.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cidade.DisplayMember = "descCidade";
                cidade.ValueMember = "idCidade";
                cidade.Text = "Selecione uma cidade";
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        public void fillCidade(ComboBox estado,ComboBox cidade)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblCidade WHERE g1_tblCidade.idEstado="+estado.SelectedValue;

                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                cidade.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                cidade.DisplayMember = "descCidade";
                cidade.ValueMember = "idCidade";
                cidade.Text = "Selecione uma cidade";
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        public void fillEstado(ComboBox estado)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "Select * from g1_tblEstado";

                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                estado.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                estado.DisplayMember = "siglaEstado";
                estado.ValueMember = "IdEstado";

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        public void fillBairro(ComboBox bairro) 
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "Select * from g1_tblBairro";

                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                bairro.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                bairro.DisplayMember = "siglaEstado";
                bairro.ValueMember = "IdEstado";

            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        public void fillBairro(ComboBox bairro, ComboBox cidade)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                string SQL;
                SQL = "Select * from g1_tblBairro WHERE idCidade =" + cidade.SelectedValue;

                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Load(dr);

                bairro.DataSource = (dt);

                bairro.DisplayMember = "descBairro";
                bairro.ValueMember = "idBairro";
            }
            catch (Exception erro)
            {

                MessageBox.Show(erro.ToString());
            }
        }

        public void fillCboStatus(ComboBox statusCad)

        {
            try
            {

                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblStatusCadastro";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                statusCad.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                statusCad.DisplayMember = "descStatusCadastro";
                statusCad.ValueMember = "idStatusCadastro";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void fillBanco(ComboBox banco)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblBanco ORDER BY g1_tblBanco.descBanco";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                banco.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                banco.DisplayMember = "descBanco";
                banco.ValueMember = "idBanco";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void fillSegmento(ComboBox segmento)

        {
            try
            {


                OleDbConnection con = new OleDbConnection(Globals.ConnString);
                con.Open();

                String SQL;
                SQL = "SELECT * FROM g1_tblSegmento ORDER BY g1_tblSegmento.descSegmento";


                OleDbCommand cmd = new OleDbCommand(SQL, con);
                cmd.Connection = con;

                OleDbDataReader dr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(SQL, con);
                //DataSet DS = new DataSet();

                dt.Load(dr);

                segmento.DataSource = (dt);
                //cboTipoTributo.Items.Clear();
                segmento.DisplayMember = "descSegmento";
                segmento.ValueMember = "idSegmento";


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

    }
}

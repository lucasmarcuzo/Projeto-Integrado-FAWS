
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace interface_wms.Classes
{

    internal class ConexaoBD
    {

        //Método para fazer a conexão com o BD.
        internal static OleDbConnection Conexao()
        {
            string pasta = Application.StartupPath + @"\DB\BDP3-WMSV3.mdb";

            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

            OleDbConnection connec = new OleDbConnection(StrConexao);

            return connec;
        }

        //Método para retornar dados do BD.
        internal static DataTable RetornarValoresConsultaBD(string procura)
        {
            OleDbConnection connec = Conexao();

            DataTable dados = new DataTable();

            OleDbDataAdapter adpt = new OleDbDataAdapter(procura, connec);

            connec.Open();

            adpt.Fill(dados);

            return dados;
        }

        internal static void ModificaBD(string text)
        {
            OleDbConnection connec = Conexao();
            connec.Open();
            OleDbCommand comando = new OleDbCommand(text, connec);
            comando.ExecuteNonQuery();
            connec.Dispose();
        }

        internal static DataTable ConsultaBD(string BD, string coluna, string text)
        {

            string procura_Expedicao = "SELECT * FROM " + BD + " WHERE " + coluna + " LIKE '" + text + "'";

            DataTable Dados_Expedicao = RetornarValoresConsultaBD(procura_Expedicao);

            return Dados_Expedicao;
        }

        internal static DataTable ConsultaBD(string BD)
        {

            string procura_Expedicao = "SELECT * FROM " + BD + "'";

            DataTable Dados_Expedicao = RetornarValoresConsultaBD(procura_Expedicao);

            return Dados_Expedicao;
        }

        internal static void ExibirValoresBD(DataGridView dgv, DataTable Dados_Expedicao)
        {
            dgv.Rows.Clear();
            if (Dados_Expedicao.Rows.Count == 0)
            {
                MessageBox.Show("Não foi encontrado nenhum registro no Banco de dados.", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataRow linha in Dados_Expedicao.Rows)
                {
                    dgv.Rows.Add(linha.ItemArray);
                }
                dgv.ClearSelection();
            }
        }

    }
}

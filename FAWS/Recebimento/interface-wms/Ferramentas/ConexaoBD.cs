using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace interface_wms.Ferramentas
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


        //Método para verificar se existe campo no BD
        internal static bool VerificarDadoNaoExisteBD(OleDbConnection connec, string verifica)
        {

            DataTable dados = new DataTable();

            OleDbDataAdapter adpt = new OleDbDataAdapter(verifica, connec);

            connec.Open();

            adpt.Fill(dados);

            connec.Close();

            return dados.Rows.Count <= 0;
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



    }
}

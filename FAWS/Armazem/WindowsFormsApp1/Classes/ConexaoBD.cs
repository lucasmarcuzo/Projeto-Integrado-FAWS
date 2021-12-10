using System.Data.OleDb;
using System.Windows.Forms;

namespace ProjetoIntegradoArmazem
{
    public class ConexaoBD
    {
        public ConexaoBD() { }

        public static string Caminho = Application.StartupPath + @"\DB\BDP3-WMSV3.mdb";

        //Criação da string de conexão com o banco de dados.
        public string StrConexao()
        {
            return $@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = {Caminho}";
        }

        //Conexão com o banco de dados.
        public OleDbConnection conexaoBD(string StrConexao)
        {
            OleDbConnection connect = new OleDbConnection(StrConexao);
            return connect;
        }
    }
}

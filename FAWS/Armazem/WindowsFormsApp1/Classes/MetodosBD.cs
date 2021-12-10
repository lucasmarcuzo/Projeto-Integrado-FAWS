using System.Data;
using System.Data.OleDb;

namespace ProjetoIntegradoArmazem
{
    public class MetodosBD : frminterfaceWMS_Armazem
    {
        //construtor
        public MetodosBD() { }

        static ConexaoBD conexao = new ConexaoBD();
        private static OleDbConnection connect = conexao.conexaoBD(conexao.StrConexao());
        public OleDbCommand CreateCommand()
        {
            OleDbCommand command = connect.CreateCommand();
            command.CommandText = "SELECT * FROM Armazenagem";
            command.Connection = connect;
            command.CommandType = CommandType.Text;
            return command;
        }

        public DataTable DataTable(string SQL)
        {
            connect.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter adpt = new OleDbDataAdapter(SQL, connect);
            adpt.Fill(dt);
            connect.Close();
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interface_wms
{
    public static class conexao
    {
        public static string strConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\DB\BDP3-WMSV3.mdb";

        public static OleDbConnection connect = new OleDbConnection(strConexao);
        
        public static void executaConsulta(string SQL)
        {
            connect.Open();
            OleDbCommand comando = new OleDbCommand(SQL, connect);
            comando.ExecuteNonQuery();
            connect.Close();
        }

        public static DataTable retornaTable(string SQL)
        {
            connect.Open();
            OleDbDataAdapter adpt = new OleDbDataAdapter(SQL, connect);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            connect.Close();
            return dt;
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using static interface_wms.conexao;


namespace interface_wms
{
    public static class metodos
    {

        public static string converteDate(DateTime data)
        {
            string var = Convert.ToString(data);
            return var;
        }
        public static string converteInt(int valor)
        {
            string var = Convert.ToString(valor);
            return var;
        }

        public static string converteDouble(double valor)
        {
            string var = Convert.ToString(valor);
            return var;
        }

        public static void apenasNum(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita apenas números", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static int procuraCateg(string categ)
        {
            string SQL = "SELECT ID from g5_categoria WHERE nome = '" + categ + "'";
            DataTable tableCat = retornaTable(SQL);

            int codigoCategoria = Convert.ToInt32(tableCat.Rows[0][0]);

            return codigoCategoria;

        }

        public static int procuraID()
        {

            string SQL = "SELECT ID FROM g5_Produto ORDER BY id DESC;";
            var Tableid = retornaTable(SQL);

            int id = Convert.ToInt32(Tableid.Rows[0][0]);
            return id;
        }

        public static int procuraFornecedor(string fornecedor)
        {

            string SQL = "SELECT idFornecedores FROM g1_tblFornecedores WHERE nomeFantasia LIKE '" + fornecedor + "';";
            DataTable tableForn = retornaTable(SQL);
            int codigoFornecedor = Convert.ToInt32(tableForn.Rows[0][0]);

            return codigoFornecedor;
        }

        public static int procuraSubCateg(string subCateg)
        {
            string SQL = "SELECT ID from g5_Subcategoria WHERE nome = '" + subCateg + "'";
            DataTable tableSubCat = retornaTable(SQL);
            int codigoSubCategoria = Convert.ToInt32(tableSubCat.Rows[0][0]);
            return codigoSubCategoria;

        }
    }
}

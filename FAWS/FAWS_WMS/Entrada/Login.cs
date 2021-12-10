using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAWS_WMS.Entrada
{
    class Login : ListaUsuarios
    {
        private static DialogResult ResultLogin;

        internal protected static bool RealizarLogin(string user, string senha, out string result)
        {
            if (getUsuariosFatec.ContainsKey(user) && getUsuariosFatec[user].Equals(senha))
            {
                result = "FATEC";
                return true;
            }
            else if (getUsuariosProfessor.ContainsKey(user) && getUsuariosProfessor[user].Equals(senha))
            {
                result = "PROFESSOR";
                return true;
            }
            else if (getUsuariosClientesForncedores.ContainsKey(user) && getUsuariosClientesForncedores[user].Equals(senha))
            {
                result = "CLIENTESEFORNECEDORES";
                return true;
            }
            else if (getUsuariosProdutos.ContainsKey(user) && getUsuariosProdutos[user].Equals(senha))
            {
                result = "PRODUTOS";
                return true;
            }
            else if (getUsuariosRecebimento.ContainsKey(user) && getUsuariosRecebimento[user].Equals(senha))
            {
                result = "RECEBIMENTO";
                return true;
            }
            else if (getUsuariosArmazem.ContainsKey(user) && getUsuariosArmazem[user].Equals(senha))
            {
                result = "ARMAZEM";
                return true;
            }
            else if (getUsuariosExpedicao.ContainsKey(user) && getUsuariosExpedicao[user].Equals(senha))
            {
                result = "EXPEDICAO";
                return true;
            }
            else if (getUsuariosFatec.ContainsKey(user) || getUsuariosProfessor.ContainsKey(user)
            || getUsuariosClientesForncedores.ContainsKey(user) || getUsuariosProdutos.ContainsKey(user)
            || getUsuariosRecebimento.ContainsKey(user) || getUsuariosArmazem.ContainsKey(user) || getUsuariosExpedicao.ContainsKey(user))
            {
                ResultLogin = MessageBox.Show("Senha incorreta! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                result = "password";
            }
            else
            {
                ResultLogin = MessageBox.Show("Usuário e senha incorretos! \n\nDeseja tentar novamente?", "FAWS WMS", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                result = "user&password";
            }

            if (ResultLogin == DialogResult.No)
            {
                Application.Exit();
            }
            return false;
        }
    }
}

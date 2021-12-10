using FAWS_WMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_WMS_ClientesFornecedores.g1_Classes
{
    class GerenciarAcessos
    {
        private static string Usuario;
        private static string ResultLogin;

        public static string getUsuario { get => Usuario; }

        //Liberar o acesso dos campos de determinado Login
        internal static void LiberarAcesso()
        {

            Usuario = FrmMenu.getUsuario;
            ResultLogin = FrmMenu.getResultLogin;


            switch (Usuario)
            {
                case "FATEC@PROFESSOR":
                case "CLIENTESEFORNECEDORES@GESTOR":
                    break;

                case "CLIENTESEFORNECEDORES@OPERADOR01":
                    break;
            }


        }
    }
}

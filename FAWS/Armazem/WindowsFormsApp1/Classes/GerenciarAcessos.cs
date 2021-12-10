using FAWS_WMS;
using System.Windows.Forms;

namespace Interface_WMS_Armazem.Classes
{
    class GerenciarAcessos
    {
        private static string Usuario;
        private static string ResultLogin;

        public static string getUsuario { get => Usuario; }

        //Liberar o acesso dos campos de determinado Login
        internal static void LiberarAcesso(Button btnBalancoInventario, Button btnRelatorioMensal)
        {
            Usuario = FrmMenu.getUsuario;
            ResultLogin = FrmMenu.getResultLogin;


            switch (Usuario)
            {
                case "FATEC@PROFESSOR":
                case "ARMAZEM@GESTOR":
                    btnBalancoInventario.Enabled = true;
                    btnRelatorioMensal.Enabled = true;
                    break;

                case "ARMAZEM@OPERADOR01":
                    btnBalancoInventario.Enabled = false;
                    btnRelatorioMensal.Enabled = false;
                    break;
            }
        }

    }
}

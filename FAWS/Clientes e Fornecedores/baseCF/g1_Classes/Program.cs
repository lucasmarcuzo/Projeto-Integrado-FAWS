using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baseCF
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetupDataDirectory();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMenuCadastro());
        }

        private static void SetupDataDirectory()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = System.IO.Path.GetDirectoryName(executable).Replace("\\baseCF\\bin\\Debug", "")
                                                                     .Replace("\\baseCF\\bin\\Release", "");
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }
    }
}

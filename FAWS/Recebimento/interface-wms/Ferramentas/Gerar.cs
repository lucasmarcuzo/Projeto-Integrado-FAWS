using System;
using System.Data;
using System.Windows.Forms;

namespace interface_wms.Ferramentas
{
    internal class Gerar
    {
        private static string SenhaEntrada;
        private static string IDRecebimento;
        private static string IDDivergencia;

        //Gerando nova senha de Entrada
        internal static string GerarNovaSenha()
        {
            try
            {
                string procura_portaria = "SELECT * FROM Portaria";

                DataTable dados_portaria = ConexaoBD.RetornarValoresConsultaBD(procura_portaria);
                SenhaEntrada = (Convert.ToUInt64(dados_portaria.Rows.Count + 1) + DateTime.Now.ToString("/ddMMyyyy.HHmm")).PadLeft(23, '0');
            }
            catch (Exception erro)
            {
                MessageBox.Show("FAWS WMS" + erro);
            }

            return SenhaEntrada;
        }

        //Gerando nova ID de Recebimento.
        internal static string GerarIDRecebimneto()
        {
            try
            {
                string procura_recebimento = "SELECT * FROM Recebimento";

                DataTable dados_recebimento = ConexaoBD.RetornarValoresConsultaBD(procura_recebimento);
                IDRecebimento = (Convert.ToUInt64(dados_recebimento.Rows.Count + 1) + DateTime.Now.ToString("/ddMMyyyy.HHmm")).PadLeft(23, '0');
            }
            catch (Exception erro)
            {
                MessageBox.Show("FAWS WMS" + erro);
            }

            return IDRecebimento;
        }


        //Gerando nova ID de Devolução.
        internal static string GerarIDDevolução()
        {
            try
            {
                string Procura_Divergencia = "SELECT * FROM Divergencias";

                DataTable Dados_Divergencia = ConexaoBD.RetornarValoresConsultaBD(Procura_Divergencia);
                IDDivergencia = (Convert.ToUInt64(Dados_Divergencia.Rows.Count + 1) + DateTime.Now.ToString("/ddMMyyyy.HHmm")).PadLeft(23, '0');
            }
            catch (Exception erro)
            {
                MessageBox.Show("FAWS WMS" + erro);
            }

            return IDDivergencia;
        }
    }
}

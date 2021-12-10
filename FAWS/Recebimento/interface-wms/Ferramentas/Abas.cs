using Interface_WMS_Recebimento.Ferramentas;
using System.Linq;
using System.Windows.Forms;

namespace interface_wms.Ferramentas
{
    internal class Abas
    {
        //Método para trocar de Abas do Módulo de Recebimento.
        internal static void TrocarAbas(string Aba)
        {
            switch (Aba)
            {
                case "FrmPortarias":
                    if (Application.OpenForms.OfType<FrmPortarias>().Count() == 0)
                    {
                        FrmPortarias frm = new FrmPortarias();
                        frm.Show();
                        frm.mtbSenhaPortarias.Focus();
                    }
                    else
                    {
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is FrmPortarias)
                            {
                                openForm.Show();
                            }
                        }
                    }
                    break;

                case "FrmRecebimento":
                    if (Application.OpenForms.OfType<FrmRecebimento>().Count() == 0)
                    {
                        FrmRecebimento frm = new FrmRecebimento();
                        frm.Show();
                        frm.mtbIDRec.Focus();
                    }
                    else
                    {
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is FrmRecebimento)
                            {
                                openForm.Show();
                            }
                        }
                    }
                    break;

                case "FrmDivergencias":
                    if (Application.OpenForms.OfType<FrmDivergencias>().Count() == 0)
                    {
                        FrmDivergencias frm = new FrmDivergencias();
                        frm.Show();
                        frm.cboIDDevolucaoDiverg.Focus();
                    }
                    else
                    {
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is FrmDivergencias)
                            {
                                openForm.Show();
                            }
                        }
                    }
                    break;

                case "FrmPedidos":
                    if (Application.OpenForms.OfType<FrmPedidos>().Count() == 0)
                    {
                        FrmPedidos frm = new FrmPedidos();
                        frm.Show();
                        frm.txtBuscaNumPed.Focus();
                    }
                    else
                    {
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is FrmPedidos)
                            {
                                openForm.Show();
                            }
                        }
                    }
                    break;

                case "FrmRelacaoNF":
                    if (Application.OpenForms.OfType<FrmRelacaoNF>().Count() == 0)
                    {
                        FrmRelacaoNF frm = new FrmRelacaoNF();
                        frm.Show();
                        frm.txtBuscaNumNFRel.Focus();
                    }
                    else
                    {
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is FrmRelacaoNF)
                            {
                                openForm.Show();
                            }
                        }
                    }
                    break;

                case "FrmManualAjuda":
                    if (Application.OpenForms.OfType<FrmAjuda>().Count() == 0)
                    {
                        FrmAjuda frm = new FrmAjuda();
                        frm.Show();
                    }
                    else
                    {
                        foreach (Form openForm in Application.OpenForms)
                        {
                            if (openForm is FrmAjuda)
                            {
                                openForm.Show();
                            }
                        }
                    }
                    break;
            }
        }
    }
}

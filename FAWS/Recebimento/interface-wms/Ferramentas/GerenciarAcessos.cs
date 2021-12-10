using FAWS_WMS;
using interface_wms.Ferramentas;
using System.Windows.Forms;

namespace Interface_WMS_Recebimento.Ferramentas
{
    internal class GerenciarAcessos : AbasFormatacoes
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
                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg"
                        || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                            item.Left = 1280;
                            item.Top = 70;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatriculaPorteiroPort" || item.Name == "txtMatricConfRec" || item.Name == "txtMatricInspetorDiverg")
                        {
                            item.Text = FrmMenu.getUsuario;
                        }
                    }
                    break;

                case "RECEBIMENTO@SUPERVISOR":
                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg"
                        || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                            item.Left = 1250;
                            item.Top = 70;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatriculaPorteiroPort" || item.Name == "txtMatricConfRec" || item.Name == "txtMatricInspetorDiverg")
                        {
                            item.Text = FrmMenu.getUsuario;
                        }
                    }
                    break;

                case "RECEBIMENTO@PORTEIRO01":
                    foreach (var item in Groupboxes)
                    {
                        if (item.Name == "grbCadastroRec" || item.Name == "grbControlesRec" || item.Name == "grbEmitirDivergenciaRec"
                        || item.Name == "grbDivergencias" || item.Name == "grbControleDiverg")
                        {
                            item.Enabled = false;
                        }
                    }

                    foreach (var item in Datagridviews)
                    {
                        if (item.Name == "dgvPesqRec" || item.Name == "dgvPesqDiverg")
                        {
                            item.ReadOnly = true;
                        }
                    }

                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg"
                        || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                            item.Left = 1250;
                            item.Top = 70;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatriculaPorteiroPort")
                        {
                            item.Text = FrmMenu.getUsuario;
                            break;
                        }
                    }
                    break;

                case "RECEBIMENTO@CONFERENTE01":
                    foreach (var item in Groupboxes)
                    {
                        if (item.Name == "grbInfoVeicPort" || item.Name == "grbInfoEntradaSaidaPort" || item.Name == "grbInfEntregaPort"
                        || item.Name == "grbControlesPort" || item.Name == "grbDivergencias" || item.Name == "grbControleDiverg")
                        {
                            item.Enabled = false;
                        }
                    }

                    foreach (var item in Datagridviews)
                    {
                        if (item.Name == "dgvPesqPort" || item.Name == "dgvPesqDiverg")
                        {
                            item.ReadOnly = true;
                            break;
                        }
                    }

                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg"
                         || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                            item.Left = 1250;
                            item.Top = 70;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatricConfRec")
                        {
                            item.Text = FrmMenu.getUsuario;
                            break;
                        }
                    }
                    break;

                case "RECEBIMENTO@INSPETORDEQUALIDADE01":
                    foreach (var item in Groupboxes)
                    {
                        if (item.Name == "grbInfoVeicPort" || item.Name == "grbInfoEntradaSaidaPort" || item.Name == "grbInfEntregaPort"
                         || item.Name == "grbControlesPort" || item.Name == "grbCadastroRec" || item.Name == "grbControlesRec" || item.Name == "grbEmitirDivergenciaRec")
                        {
                            item.Enabled = false;
                        }
                    }

                    foreach (var item in Datagridviews)
                    {
                        if (item.Name == "dgvPesqRec" || item.Name == "dgvPesqPort")
                        {
                            item.ReadOnly = true;
                            break;
                        }
                    }

                    foreach (var item in Labelscabecalho)
                    {
                        if (item.Name == "lbNomeUsuarioPort" || item.Name == "lbNomeUsuarioRec" || item.Name == "lbNomeUsuarioDiverg"
                         || item.Name == "lbNomeMatriculaRelNF" || item.Name == "lbNomeMatriculaPedidos")
                        {
                            item.Text = FrmMenu.getUsuario;
                            item.Left = 1215;
                            item.Top = 70;
                        }
                    }

                    foreach (var item in Txtboxes)
                    {
                        if (item.Name == "txtMatricInspetorDiverg")
                        {
                            item.Text = FrmMenu.getUsuario;
                            break;
                        }
                    }
                    break;
            }
        }

        //Ver Permissões do Usuário
        internal static void VerificarPermissoes(Label usuario)
        {
            switch (usuario.Text)
            {
                case "FATEC@PROFESSOR":
                case "RECEBIMENTO@SUPERVISOR":

                    MessageBox.Show($"Suas permissões:\n{ usuario.Text}\n\n" +
                    $"\n[ ✓ ]\tVisualizar Cadastros criados em todas as abas" +
                    $"\n[ ✓ ]\tCriar Cadastros em todas as abas" +
                    $"\n[ ✓ ]\tEditar Cadastros em todas as abas" +
                    $"\n[ ✓ ]\tEmitir Relatórios em todas as abas" +
                    $"\n[ ✓ ]\tAtivar/Inativar Cadastros em todas as abas", "FAWS WMS");
                    break;

                case "RECEBIMENTO@PORTEIRO01":

                    MessageBox.Show($"Suas permissões:\n{ usuario.Text}\n\n" +
                    $"\n[ ✓ ]\tVisualizar Cadastros criados em todas as abas" +
                    $"\n[ ✓ ]\tCriar Cadastros na aba de Portaria" +
                    $"\n[ ✕ ]\tEditar Cadastros em todas as abas" +
                    $"\n[ ✕ ]\tEmitir Relatórios em todas as abas" +
                    $"\n[ ✕ ]\tAtivar/Inativar Cadastros em todas as abas", "FAWS WMS");
                    break;

                case "RECEBIMENTO@CONFERENTE01":

                    MessageBox.Show($"Suas permissões:\n{ usuario.Text}\n\n" +
                    $"\n[ ✓ ]\tVisualizar Cadastros criados em todas as abas" +
                    $"\n[ ✓ ]\tCriar Cadastros na tabela de Recebimento" +
                    $"\n[ ✕ ]\tEditar Cadastros em todas as abas" +
                    $"\n[ ✕ ]\tEmitir Relatórios em todas as abas" +
                    $"\n[ ✕ ]\tAtivar/Inativar Cadastros em todas as abas", "FAWS WMS");
                    break;

                case "RECEBIMENTO@INSPETORDEQUALIDADE01":

                    MessageBox.Show($"Suas permissões:\n{ usuario.Text}\n\n" +
                    $"\n[ ✓ ]\tVisualizar Cadastros criados em todas as abas" +
                    $"\n[ ✓ ]\tCriar Cadastros na tabela de Divergências" +
                    $"\n[ ✕ ]\tEditar Cadastros em todas as abas" +
                    $"\n[ ✕ ]\tEmitir Relatórios em todas as abas" +
                    $"\n[ ✕ ]\tAtivar/Inativar Cadastros em todas as abas", "FAWS WMS");
                    break;
            }
        }




    }
}

using DocumentosBrasileiros;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace interface_wms.Ferramentas
{
    //Validação de entrada de dados nos campos
    internal class CamposValidacao
    {
        //Validar campos com Entrada de String.
        internal static void Validar_String(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita este tipo de dados!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Validar campos com Entrada de Inteiros.
        internal static void Validar_Int(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita este tipo de dados!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Validar campos com Entrada dos dois tipos de placas de veiculos.
        internal static void Validar_Placas(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
                MessageBox.Show("Este campo não aceita este tipo de dados!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Validar Documentos
        //(CNH).
        internal static void Validar_CNH(MaskedTextBox mtbValidarCNH, ErrorProvider epErroCNH)
        {
            if (!mtbValidarCNH.MaskCompleted)
            {
                mtbValidarCNH.BackColor = Color.Empty;
                epErroCNH.Clear();
            }
            else
            {
                var cnh = new Cnh(mtbValidarCNH.Text);

                bool valido = cnh.DocumentoValido();

                if (!valido)
                {

                    mtbValidarCNH.BackColor = Color.LightCoral;
                    epErroCNH.SetError(mtbValidarCNH, "A CNH é Inválida!");
                }
            }
        }

        //(CPF).
        internal static void Validar_CPF(MaskedTextBox mtbox_cpf, ErrorProvider ep_ErroCPF)
        {
            string cpf = mtbox_cpf.Text;

            int verificar = 0, verificar2 = 0, teste1 = 10, teste2 = 11;
            int[] cpf_ver = new int[9];
            int[] cpf_ver2 = new int[10];
            int[] cpf_completo = new int[11];

            if (!mtbox_cpf.MaskCompleted)
            {
                mtbox_cpf.BackColor = Color.Empty;
                ep_ErroCPF.Clear();
            }
            else
            {
                for (int i = 0; i < cpf_completo.Length; i++)
                {
                    cpf_completo[i] = Convert.ToInt32(cpf.Substring(i, 1));
                }

                for (int i = 0; i < cpf_ver.Length; i++)
                {
                    cpf_ver[i] = Convert.ToInt32(cpf.Substring(i, 1));
                    verificar += cpf_ver[i] * teste1;
                    teste1--;
                }

                verificar *= 10;
                verificar %= 11;

                if (verificar == 10)
                {
                    verificar = 0;
                }

                for (int j = 0; j < cpf_ver2.Length; j++)
                {
                    cpf_ver2[j] = Convert.ToInt32(cpf.Substring(j, 1));
                    verificar2 += cpf_ver2[j] * teste2;
                    teste2--;
                }

                verificar2 *= 10;
                verificar2 %= 11;

                if (verificar2 == 10)
                {
                    verificar2 = 0;
                }

                for (int i = 0, k = 1, x = 0; k < cpf_completo.Length; i++, k++)
                {

                    if (cpf_completo[i] == cpf_completo[k])
                    {
                        x++;

                        if (x == 10)
                        {
                            mtbox_cpf.BackColor = Color.LightCoral;
                            ep_ErroCPF.SetError(mtbox_cpf, "O CPF é Inválido!");
                            return;
                        }
                    }
                    else if (cpf_completo[9] == verificar && cpf_completo[10] == verificar2)
                    {
                        mtbox_cpf.BackColor = Color.White;
                        ep_ErroCPF.Clear();
                    }
                    else
                    {
                        mtbox_cpf.BackColor = Color.LightCoral;
                        ep_ErroCPF.SetError(mtbox_cpf, "O CPF é Inválido!");
                        break;
                    }
                }
            }
        }


        //Validação de Preenchimento dos Campos da Portarias.
        internal static bool ValidarPreenchimentoCamposPortarias(DateTimePicker dtpDataHoraEntr, DateTimePicker dtpDataHoraSaida, ErrorProvider epErros, MaskedTextBox mtbSenhaPortarias, TextBox txtMotorista, MaskedTextBox mtbCPFMot,
            MaskedTextBox mtbCNHmot, MaskedTextBox mtbNumPlaca, ErrorProvider epErroCNH, ErrorProvider epErroCPF, TextBox txtCodTransp, TextBox txtProtocAgendamento, ComboBox cboTipodeCargaPort,
            ComboBox cboNomeFornecedorRec, TextBox txtConhecTransp, ComboBox cboIDFornecedor, ComboBox cbo_NumNFPort, TextBox txtMatriculaPorteiroPort)
        {
            if (dtpDataHoraEntr.CustomFormat == " ")
            {
                MessageBox.Show("O campo DATA E HORA DE ENTRADA não pode ficar vazio!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDataHoraEntr.CalendarTitleBackColor = Color.LightCoral;
                epErros.SetError(dtpDataHoraEntr, "A data e hora de entrada não pode ficar vazio.");
                return false;
            }
            else if (dtpDataHoraSaida.CustomFormat == " ")
            {
                MessageBox.Show("O campo DATA E HORA DE SAÍDA não pode ficar vazio!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDataHoraSaida.CalendarTitleBackColor = Color.LightCoral;
                epErros.SetError(dtpDataHoraSaida, "A data e hora de saída não pode ficar vazio.");
                return false;
            }
            else if (dtpDataHoraEntr.Text == dtpDataHoraSaida.Text)
            {
                MessageBox.Show("Os campos DATA E HORA DE ENTRADA & DATA E HORA DE SAÍDA não podem ser iguais!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDataHoraEntr.CalendarTitleBackColor = Color.LightCoral;
                dtpDataHoraSaida.CalendarTitleBackColor = Color.LightCoral;
                epErros.SetError(dtpDataHoraEntr, "As datas e horas de entrada e de saída não podem ser iguais.");
                epErros.SetError(dtpDataHoraSaida, "As datas e horas de entrada e de saída não podem ser iguais.");
                return false;
            }
            else if (dtpDataHoraSaida.Value < dtpDataHoraEntr.Value)
            {
                MessageBox.Show("O campo DATA E HORA DE SAÍDA não pode ter o seu valor menor do que o de entrada!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpDataHoraSaida.CalendarTitleBackColor = Color.LightCoral;
                epErros.Clear();
                epErros.SetError(dtpDataHoraSaida, "A data e hora de saída não pode ser menor que a de entrada.");
                return false;
            }
            else if (!mtbSenhaPortarias.MaskCompleted)
            {
                MessageBox.Show("O campo SENHA precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbSenhaPortarias.BackColor = Color.LightCoral;
                mtbSenhaPortarias.Focus();
                epErros.SetError(mtbSenhaPortarias, "Informe a senha de agendamento.");
                return false;
            }
            else if (txtMotorista.Text == string.Empty)
            {
                MessageBox.Show("O campo MOTORISTA precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMotorista.BackColor = Color.LightCoral;
                txtMotorista.Focus();
                epErros.SetError(txtMotorista, "Informe o nome do motorista.");
                return false;
            }
            else if (!mtbCPFMot.MaskCompleted)
            {
                MessageBox.Show("O campo CPF precisa ser totalmente preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCPFMot.BackColor = Color.LightCoral;
                mtbCPFMot.Focus();
                epErros.SetError(mtbCPFMot, "Informe o CPF do motorista.");
                return false;
            }
            else if (epErroCPF.GetError(mtbCPFMot) == "O CPF é Inválido!")
            {
                MessageBox.Show("O CPF digitado é inválido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCPFMot.BackColor = Color.LightCoral;
                epErros.SetError(mtbCPFMot, "Informe o CPF do motorista.");
                mtbCPFMot.Focus();
                return false;
            }
            else if (!mtbCNHmot.MaskCompleted)
            {
                MessageBox.Show("O campo CNH precisa ser totalmente preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCNHmot.BackColor = Color.LightCoral;
                mtbCNHmot.Focus();
                epErros.SetError(mtbCNHmot, "Informe a CNH do motorista.");
                return false;
            }
            else if (epErroCNH.GetError(mtbCNHmot) == "A CNH é Inválida!")
            {
                MessageBox.Show("A CNH digitada é inválida!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCNHmot.BackColor = Color.LightCoral;
                epErros.SetError(mtbCNHmot, "Informe a CNH do motorista.");
                mtbCNHmot.Focus();
                return false;
            }
            else if (!mtbNumPlaca.MaskCompleted)
            {
                MessageBox.Show("O campo PLACA precisa ser totalmente preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbNumPlaca.BackColor = Color.LightCoral;
                mtbNumPlaca.Focus();
                epErros.SetError(mtbNumPlaca, "Informe a Placa do veículo.");
                return false;
            }
            else if (txtCodTransp.Text == string.Empty)
            {
                MessageBox.Show("O campo COD. DA TRANSPORTADORA precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodTransp.BackColor = Color.LightCoral;
                txtCodTransp.Focus();
                epErros.SetError(txtCodTransp, "Informe a código da transportadora.");
                return false;
            }
            else if (txtProtocAgendamento.Text == string.Empty)
            {
                MessageBox.Show("O campo PROTOCOLO DE AGENDAMENTO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProtocAgendamento.BackColor = Color.LightCoral;
                txtProtocAgendamento.Focus();
                epErros.SetError(txtProtocAgendamento, "Informe o protocolo de agendamento de entrega.");
                return false;
            }
            else if (cboTipodeCargaPort.SelectedItem == null)
            {
                MessageBox.Show("O campo TIPO DE CARGA precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboTipodeCargaPort.Focus();
                cboTipodeCargaPort.BackColor = Color.LightCoral;
                cboTipodeCargaPort.DroppedDown = true;
                epErros.SetError(cboTipodeCargaPort, "Informe o tipo da carga que será entregue.");
                return false;
            }
            else if (cboNomeFornecedorRec.Text == string.Empty)
            {
                MessageBox.Show("O campo NOME DO FORNECEDOR precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboNomeFornecedorRec.BackColor = Color.LightCoral;
                cboNomeFornecedorRec.Focus();
                epErros.SetError(cboNomeFornecedorRec, "Informe o nome do fornecedor.");
                return false;
            }
            else if (txtConhecTransp.Text == string.Empty)
            {
                MessageBox.Show("O campo CONHECIMENTO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConhecTransp.BackColor = Color.LightCoral;
                txtConhecTransp.Focus();
                epErros.SetError(txtConhecTransp, "Informe o conhecimento do tranporte.");
                return false;
            }
            else if (cboIDFornecedor.SelectedItem == null)
            {
                MessageBox.Show("O campo ID. DO FORNECEDOR precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboIDFornecedor.BackColor = Color.LightCoral;
                cboIDFornecedor.Focus();
                epErros.SetError(cboIDFornecedor, "Informe a ID. do fornecedor.");
                return false;
            }
            else if (cbo_NumNFPort.SelectedItem == null)
            {
                MessageBox.Show("O campo NUM. DA NF precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_NumNFPort.BackColor = Color.LightCoral;
                cbo_NumNFPort.Focus();
                epErros.SetError(cbo_NumNFPort, "Selecione o número da NF.");
                return false;
            }
            else if (txtMatriculaPorteiroPort.Text == string.Empty)
            {
                MessageBox.Show("O campo MATRÍCULA DO PORTEIRO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMatriculaPorteiroPort.BackColor = Color.LightCoral;
                txtMatriculaPorteiroPort.Focus();
                epErros.SetError(txtMatriculaPorteiroPort, "Informe o Matrícula do Porteiro do tranporte.");
                return false;
            }
            else
            {
                return true;
            }
        }


        //Validação de Preenchimento dos Campos da Recebimento.
        internal static bool ValidarPreenchimentoCamposRecebimento(MaskedTextBox mtbIDRec,
                                                                 ErrorProvider epErros,
                                                                 ComboBox cb_SenhaRec,
                                                                 ComboBox cboStatusEntregaRec,
                                                                 TextBox txtDocaRec,
                                                                 TextBox txtIDFornRec,
                                                                 TextBox txtNumNFRec,
                                                                 TextBox txtNumPedRec,
                                                                 TextBox txtCodProdRec,
                                                                 TextBox txtQtdPecasRec,
                                                                 TextBox txtMatricConfRec,
                                                                 TextBox txtPosicArmazRec,
                                                                 RadioButton radDiverSim,
                                                                 MaskedTextBox mtb_IDDevolucaoRec)
        {
            if (!mtbIDRec.MaskCompleted)
            {
                MessageBox.Show("O campo ID. DO RECEBIMENTO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbIDRec.BackColor = Color.LightCoral;
                mtbIDRec.Focus();
                epErros.SetError(mtbIDRec, "Informe o ID. do recebimento.");
                return false;
            }
            else if (cb_SenhaRec.Text == string.Empty)
            {
                MessageBox.Show("O campo SENHA precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cb_SenhaRec.Focus();
                cb_SenhaRec.BackColor = Color.LightCoral;
                //cb_SenhaRec.DroppedDown = true;
                epErros.SetError(cb_SenhaRec, "Digite ou Selecione a SENHA de entrada.");
                return false;
            }
            else if (cboStatusEntregaRec.SelectedItem == null)
            {
                MessageBox.Show("O campo STATUS DA ENTREGA deve ter uma opção selecionada!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboStatusEntregaRec.Focus();
                cboStatusEntregaRec.BackColor = Color.LightCoral;
                cboStatusEntregaRec.DroppedDown = true;
                epErros.SetError(cboStatusEntregaRec, "Selecione o status da entrega.");
                return false;
            }
            else if (txtDocaRec.Text == string.Empty)
            {
                MessageBox.Show("O campo DOCA DE RECEBIMENTO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocaRec.BackColor = Color.LightCoral;
                txtDocaRec.Focus();
                epErros.SetError(txtDocaRec, "Informe a doca de recebimento.");
                return false;
            }
            else if (txtIDFornRec.Text == string.Empty)
            {
                MessageBox.Show("O campo ID. DO FORNECEDOR precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtIDFornRec.BackColor = Color.LightCoral;
                txtIDFornRec.Focus();
                epErros.SetError(txtIDFornRec, "Informe a ID. do fornecedor.");
                return false;
            }
            else if (txtNumNFRec.Text == string.Empty)
            {
                MessageBox.Show("O campo NUM. DA NF precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumNFRec.BackColor = Color.LightCoral;
                txtNumNFRec.Focus();
                epErros.SetError(txtNumNFRec, "Informe o número da NF.");
                return false;
            }
            else if (txtNumPedRec.Text == string.Empty)
            {
                MessageBox.Show("O campo NUM. DO PEDIDO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumPedRec.BackColor = Color.LightCoral;
                txtNumPedRec.Focus();
                epErros.SetError(txtNumPedRec, "Informe o número do pedido.");
                return false;
            }
            else if (txtCodProdRec.Text == string.Empty)
            {
                MessageBox.Show("O campo COD. DO PRODUTO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodProdRec.BackColor = Color.LightCoral;
                txtCodProdRec.Focus();
                epErros.SetError(txtCodProdRec, "Informe o código do produto.");
                return false;
            }
            else if (txtQtdPecasRec.Text == string.Empty)
            {
                MessageBox.Show("O campo QTD. DE PEÇAS precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQtdPecasRec.BackColor = Color.LightCoral;
                txtQtdPecasRec.Focus();
                epErros.SetError(txtQtdPecasRec, "Informe a quantidade de peças.");
                return false;
            }
            else if (txtMatricConfRec.Text == string.Empty)
            {
                MessageBox.Show("O campo MATRíCULA DO CONFERENTE precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMatricConfRec.BackColor = Color.LightCoral;
                txtMatricConfRec.Focus();
                epErros.SetError(txtMatricConfRec, "Informe a matrícula do conferente.");
                return false;
            }
            else if (txtPosicArmazRec.Text == string.Empty)
            {
                MessageBox.Show("O campo POSIÇÃO DE ARMAZENAGEM precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPosicArmazRec.BackColor = Color.LightCoral;
                txtPosicArmazRec.Focus();
                epErros.SetError(txtPosicArmazRec, "Informe a posição de armazenagem.");
                return false;
            }
            else if (radDiverSim.Checked)
            {
                if (mtb_IDDevolucaoRec.Text == string.Empty)
                {
                    MessageBox.Show("O campo ID. DA DEVOLUÇÃO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mtb_IDDevolucaoRec.BackColor = Color.LightCoral;
                    mtb_IDDevolucaoRec.Focus();
                    epErros.SetError(mtb_IDDevolucaoRec, "Informe a ID. da devolução.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }
        }


        //Validação de Preenchimento dos Campos da Divergencias.
        internal static bool ValidarPreenchimentoCamposDivergencias(ComboBox cbo_IDDevolucaoDiverg,
                                                                    TextBox txtMatricConfDiverg,
                                                                    TextBox txtNumPedDiverg,
                                                                    TextBox txtNumNFDiverg,
                                                                    TextBox txtCodProdDiverg,
                                                                    TextBox txtDescProdDiverg,
                                                                    TextBox txtQtdNotasDiverg,
                                                                    TextBox txtCodMotivoDiverg,
                                                                    TextBox txtQtdDevolvidaDiverg,
                                                                    ErrorProvider epErros)
        {
            if (cbo_IDDevolucaoDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo ID. DE DEVOLUÇÃO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_IDDevolucaoDiverg.BackColor = Color.LightCoral;
                cbo_IDDevolucaoDiverg.Focus();
                epErros.SetError(cbo_IDDevolucaoDiverg, "Informe a ID. da devolução.");
                return false;
            }
            else if (txtMatricConfDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo MATRÍCULA DO CONFERENTE precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMatricConfDiverg.BackColor = Color.LightCoral;
                txtMatricConfDiverg.Focus();
                epErros.SetError(txtMatricConfDiverg, "Informe a matrícula do conferente.");
                return false;
            }
            else if (txtNumPedDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo NUM. DO PEDIDO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumPedDiverg.BackColor = Color.LightCoral;
                txtNumPedDiverg.Focus();
                epErros.SetError(txtNumPedDiverg, "Informe o número do pedido.");
                return false;
            }
            else if (txtNumNFDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo NÚMERO DA NF precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumNFDiverg.BackColor = Color.LightCoral;
                txtNumNFDiverg.Focus();
                epErros.SetError(txtNumNFDiverg, "Informe o número da NF.");
                return false;
            }
            else if (txtCodProdDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo COD. DO PRODUTO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodProdDiverg.BackColor = Color.LightCoral;
                txtCodProdDiverg.Focus();
                epErros.SetError(txtCodProdDiverg, "Informe o código do produto.");
                return false;
            }
            else if (txtDescProdDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo DESCRIÇÃO DO PRODDUTO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescProdDiverg.BackColor = Color.LightCoral;
                txtDescProdDiverg.Focus();
                epErros.SetError(txtDescProdDiverg, "Informe a descrição do produto.");
                return false;
            }
            else if (txtQtdNotasDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo QTD. DE NOTAS precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQtdNotasDiverg.BackColor = Color.LightCoral;
                txtQtdNotasDiverg.Focus();
                epErros.SetError(txtQtdNotasDiverg, "Informe a quantidade de notas.");
                return false;
            }
            else if (txtQtdNotasDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo QTD. DE NOTAS precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQtdNotasDiverg.BackColor = Color.LightCoral;
                txtQtdNotasDiverg.Focus();
                epErros.SetError(txtQtdNotasDiverg, "Informe a quantidade de notas.");
                return false;
            }
            else if (txtCodMotivoDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo COD. DO MOTIVO  precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodMotivoDiverg.BackColor = Color.LightCoral;
                txtCodMotivoDiverg.Focus();
                epErros.SetError(txtCodMotivoDiverg, "Informe o código do motivo da devolução.");
                return false;
            }
            else if (txtQtdDevolvidaDiverg.Text == string.Empty)
            {
                MessageBox.Show("O campo QTD. DEVOLUÇÃO precisa ser preenchido!", "FAWS WMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQtdDevolvidaDiverg.BackColor = Color.LightCoral;
                txtQtdDevolvidaDiverg.Focus();
                epErros.SetError(txtQtdDevolvidaDiverg, "Informe a quantidade que será devolvida.");
                return false;
            }
            else
            {
                return true;
            }
        }

        //Ativar/Inativar Campos das Tabelas
        //Portarias
        internal static void AtivarInativarCadastroPortarias(bool status,
                                                           MaskedTextBox mtbCPFMot,
                                                           MaskedTextBox mtbCNHmot,
                                                           MaskedTextBox mtbNumPlaca,
                                                           ComboBox cboTipodeCargaPort,
                                                           ComboBox cboNumNFPort,
                                                           ComboBox cboIDFornecedor,
                                                           ComboBox cboNomeFornecedorRec,
                                                           DateTimePicker dtpDataHoraEntr,
                                                           DateTimePicker dtpDataHoraSaida,
                                                           MaskedTextBox mtbSenhaPortarias,
                                                           params TextBox[] TxtBoxCampos)
        {

            mtbCPFMot.Enabled = status;
            mtbCNHmot.Enabled = status;
            mtbNumPlaca.Enabled = status;
            cboTipodeCargaPort.Enabled = status;
            cboNumNFPort.Enabled = status;
            cboIDFornecedor.Enabled = status;
            cboNomeFornecedorRec.Enabled = status;
            dtpDataHoraEntr.Enabled = status;
            dtpDataHoraSaida.Enabled = status;
            mtbSenhaPortarias.Enabled = status;

            foreach (var txtboxcampos in TxtBoxCampos)
            {
                txtboxcampos.Enabled = status;
            }
        }

        //Recebimento
        internal static void AtivarInativarCadastroRecebimento(bool status,
                                                             ComboBox cb_SenhaRec,
                                                             ComboBox cboStatusEntregaRec,
                                                             MaskedTextBox mtbIDRec,
                                                             DateTimePicker dtpDataHoraRec,
                                                             RadioButton radDiverSim,
                                                             RadioButton radDiverNao,
                                                             MaskedTextBox mtb_IDDevolucaoRec,
                                                             params TextBox[] TxtBoxCampos)
        {

            cb_SenhaRec.Enabled = status;
            cboStatusEntregaRec.Enabled = status;
            mtbIDRec.Enabled = status;
            dtpDataHoraRec.Enabled = status;
            radDiverSim.Enabled = status;
            radDiverNao.Enabled = status;
            mtb_IDDevolucaoRec.Enabled = status;

            foreach (var txtboxcampos in TxtBoxCampos)
            {
                txtboxcampos.Enabled = status;
            }
        }

        //Divergencias
        internal static void AtivarInativarCadastroDivergencias(bool status,
                                                              ComboBox cbo_IDDevolucaoDiverg,
                                                              DateTimePicker dtpDataDevolDiverg,
                                                              params TextBox[] TxtBoxCampos)
        {

            cbo_IDDevolucaoDiverg.Enabled = status;
            dtpDataDevolDiverg.Enabled = status;

            foreach (var txtboxcampos in TxtBoxCampos)
            {
                txtboxcampos.Enabled = status;
            }
        }



    }
}

using FAWS_WMS;
using Interface_WMS_Recebimento.Ferramentas;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Interface_WMS_Recebimento.Portarias
{
    internal static class GerarRelatorioPortaria
    {
        static BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        public static string strConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\DB\BDP3-WMSV3.mdb";
        public static OleDbConnection connect = new OleDbConnection(strConexao);

        public static string GerarRelatorioPDF(int qtdProdutos)
        {
            var tabela2 = RealizarPesquisa();
            var produtosSelecionados = tabela2.Take(qtdProdutos).ToList();

            //contagem do total de paginas
            int totalPaginas = 1;
            int totalLinhas = produtosSelecionados.Count;
            if (totalLinhas > 24)
            {
                totalPaginas += (int)Math.Ceiling((totalLinhas - 24) / 29F);
            }

            //Configuração do PDF
            var PixelPorMm = 72 / 25.2F;
            var pdf = new Document(PageSize.A4.Rotate(), 10 * PixelPorMm, 10 * PixelPorMm, 10 * PixelPorMm, 20 * PixelPorMm);
            var nomeArquivo = $"Relatorio_Portaria-{DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss")}.pdf";
            var arquivo = new FileStream(nomeArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);
            writer.PageEvent = new EventosDaPagina(totalPaginas);
            pdf.Open();

            fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

            //adição do título
            var fonteParagrafo = new Font(fonteBase, 26, Font.NORMAL, BaseColor.BLACK);
            var titulo = new Paragraph("Relatório de Portarias", fonteParagrafo);
            titulo.Alignment = Element.ALIGN_LEFT;
            titulo.SpacingAfter = 4;
            pdf.Add(titulo);

            var fonteUsuario = new Font(fonteBase, 9, Font.ITALIC, BaseColor.BLACK);
            var tituloUsuario = new Paragraph($"Emitido por: {FrmMenu.getUsuario}\n\n", fonteUsuario);
            tituloUsuario.Alignment = Element.ALIGN_LEFT;
            tituloUsuario.SpacingAfter = 4;
            pdf.Add(tituloUsuario);

            //adição da imagem
            var CaminhoImagem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img\\logo.png");
            if (File.Exists(CaminhoImagem))
            {
                Image logo = Image.GetInstance(CaminhoImagem);
                float razaoAlturaLargura = logo.Width / logo.Height;
                float alturaLogo = 32;
                float larguraLogo = alturaLogo * razaoAlturaLargura;
                logo.ScaleToFit(larguraLogo, alturaLogo);
                var MargemEsquerda = pdf.PageSize.Width - pdf.RightMargin - larguraLogo;
                var MargemTopo = pdf.PageSize.Height - pdf.TopMargin - 54;
                logo.SetAbsolutePosition(MargemEsquerda, MargemTopo);
                writer.DirectContent.AddImage(logo, false);
            }

            //adição da tabela de dados
            var tabela = new PdfPTable(16);
            float[] largurasColunas = { 1f, 1.1f, 1.5f, 1.1f, 1.1f, 1.1f, 1f, 1f, 1f, 1f, 1.1f, 1.1f, 1f, 1f, 1.1f, 1f };
            tabela.SetWidths(largurasColunas);
            tabela.DefaultCell.BorderWidth = 0;
            tabela.WidthPercentage = 100;

            CriarCelulaTexto(tabela, "Cadastro Atv./Inat.", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Senha de Entrada", PdfPCell.ALIGN_LEFT, true);
            CriarCelulaTexto(tabela, "Código da Transportadora", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Fornecedor", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "ID. do Fornecedor", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Motorista", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "CNH", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "CPF", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Placa", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Protc. Agendamento", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Data/Hora Entrada", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Data/Hora Saída", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Tipo de Carga", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "NF", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Conhec. do Transporte", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Matricula do Porteiro", PdfPCell.ALIGN_CENTER, true);

            foreach (var prod in produtosSelecionados)
            {
                CriarCelulaTexto(tabela, prod.Ativo_Inativo == true ? "Ativo" : "Inativo", PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Senha_Entrada);
                CriarCelulaTexto(tabela, prod.Cod_transportadora.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Nome_Fornecedor.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.ID_Fornecedor.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Nome_motorista.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, Convert.ToUInt64(prod.CHN_Motorista).ToString(@"000\.000\.000\-00"), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, Convert.ToUInt64(prod.CPF_motorista).ToString(@"000\.000\.000\-00"), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Placa_veiculo.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Protocolo_Agendamento.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.DataHora_entrada.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.DataHora_saida.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Tipo_Carga.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Numero_NF.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Conhe_Transporte.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Matricula_Porteiro.ToString(), PdfPCell.ALIGN_CENTER);
            }

            pdf.Add(tabela);

            pdf.Close();
            arquivo.Close();

            MessageBox.Show($"Relatório criado com sucesso!", "FAWS WMS",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            return nomeArquivo;
        }

        public static void CriarCelulaTexto(PdfPTable tabela, string texto,
                                    int allinhamentoHorz = PdfPCell.ALIGN_LEFT,
                                    bool negrito = false, bool italico = false,
                                    int tamanhoFonte = 9, int alturaCelula = 40)
        {
            int estilo = Font.NORMAL;
            if (negrito && italico)
            {
                estilo = Font.BOLDITALIC;
            }
            else if (negrito)
            {
                estilo = Font.BOLD;
            }
            else if (italico)
            {
                estilo = Font.ITALIC;
            }
            var FonteCelula = new Font(fonteBase, tamanhoFonte,
                               estilo, BaseColor.BLACK);

            var BackgroundColor = BaseColor.WHITE;
            if (tabela.Rows.Count % 2 == 1)
            {
                BackgroundColor = new BaseColor(173, 216, 230);
            }

            var celula = new PdfPCell(new Phrase(texto, FonteCelula));
            celula.HorizontalAlignment = allinhamentoHorz;
            celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            celula.Border = 0;
            celula.BorderWidthBottom = 1;
            celula.FixedHeight = alturaCelula;
            celula.PaddingBottom = 5;
            celula.BackgroundColor = BackgroundColor;
            tabela.AddCell(celula);
        }

        public static List<CamposDGPortaria> RealizarPesquisa()
        {
            string SQL = "SELECT Ativo_Inativo, Senha_Entrada, Cod_transportadora, ID_Fornecedor, Nome_motorista, CHN_Motorista, CPF_motorista, Placa_veiculo, Protocolo_Agendamento," +
                "DataHora_entrada, DataHora_saida, Tipo_Carga, Nome_Fornecedor, Numero_NF, Conhe_Transporte, Matricula_Porteiro FROM Portaria";
            OleDbCommand comando = new OleDbCommand(SQL, connect);

            connect.Open();

            OleDbDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection);
            List<CamposDGPortaria> produtoLista = new List<CamposDGPortaria>();
            while (reader.Read())
            {
                CamposDGPortaria prod = new CamposDGPortaria();
                prod.Ativo_Inativo = (bool)reader["Ativo_Inativo"];
                prod.Senha_Entrada = (string)reader["Senha_Entrada"];
                prod.Cod_transportadora = (string)reader["Cod_transportadora"];
                prod.ID_Fornecedor = (string)reader["ID_Fornecedor"];
                prod.Nome_motorista = (string)reader["Nome_motorista"];
                prod.CHN_Motorista = (string)reader["CHN_Motorista"];
                prod.CPF_motorista = (string)reader["CPF_motorista"];
                prod.Placa_veiculo = (string)reader["Placa_veiculo"];
                prod.Protocolo_Agendamento = (string)reader["Protocolo_Agendamento"];
                prod.DataHora_entrada = (string)reader["DataHora_entrada"];
                prod.DataHora_saida = (string)reader["DataHora_saida"];
                prod.Tipo_Carga = (string)reader["Tipo_Carga"];
                prod.Nome_Fornecedor = (string)reader["Nome_Fornecedor"];
                prod.Numero_NF = (string)reader["Numero_NF"];
                prod.Conhe_Transporte = (string)reader["Conhe_Transporte"];
                prod.Matricula_Porteiro = (string)reader["Matricula_Porteiro"];
                produtoLista.Add(prod);
            }
            connect.Close();
            return produtoLista;
        }
    }
}

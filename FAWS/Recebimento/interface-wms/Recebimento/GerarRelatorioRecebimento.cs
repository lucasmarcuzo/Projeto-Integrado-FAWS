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

namespace Interface_WMS_Recebimento.Recebimento
{
    internal static class GerarRelatorioRecebimento
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
            var pdf = new Document(PageSize.A4.Rotate(), 10 * PixelPorMm, 10 * PixelPorMm,
                                   10 * PixelPorMm, 20 * PixelPorMm);
            var nomeArquivo = $"Relatorio_Recebimento-{DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss")}.pdf";
            var arquivo = new FileStream(nomeArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);
            writer.PageEvent = new EventosDaPagina(totalPaginas);
            pdf.Open();

            fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

            //adição do título
            var fonteParagrafo = new Font(fonteBase, 26, Font.NORMAL,
                                                          BaseColor.BLACK);
            var titulo = new Paragraph("Relatório de Recebimentos", fonteParagrafo);
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
            var tabela = new PdfPTable(14);
            float[] largurasColunas = { 1f, 1.1f, 1f, 1f, 1f, 1.1f, 1f, 1f, 1f, 1f, 1f, 1.2f, 1f, 1f };
            tabela.SetWidths(largurasColunas);
            tabela.DefaultCell.BorderWidth = 0;
            tabela.WidthPercentage = 100;

            CriarCelulaTexto(tabela, "Cadastro Atv./Inat.", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "ID. do Recebimento", PdfPCell.ALIGN_LEFT, true);
            CriarCelulaTexto(tabela, "Senha de Estrada", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Status de Entrega", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Doca de Descarga", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Data e Hora Recebimento", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "ID. do Fornecedor", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "NF", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Pedido", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Cod. do Produto", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Qtd. de Peças", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Posição de Armazenagem", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Matrícula do Conferente", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "ID. de Devolução", PdfPCell.ALIGN_CENTER, true);

            foreach (var prod in produtosSelecionados)
            {
                CriarCelulaTexto(tabela, prod.Ativo_Inativo == true ? "Ativo" : "Inativo", PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.ID_Recebimento.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Senha_Entrada.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Status_Entrega.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Doca_Descarga.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.DataHora_Recebimento.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.ID_Fornecedor.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Numero_NF.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Numero_Pedido.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Cod_Produto.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Qtd_pecas.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Posicao_Armazenagem.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Matricula_Conferente.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.ID_Devolucao.ToString(), PdfPCell.ALIGN_CENTER);
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

        public static List<CamposDGRecebimento> RealizarPesquisa()
        {
            string SQL = "SELECT Ativo_Inativo, ID_Recebimento, Senha_Entrada, Status_Entrega, Doca_Descarga, DataHora_Recebimento, ID_Fornecedor, Numero_NF, Numero_Pedido," +
                "Cod_Produto, Qtd_pecas, Matricula_Conferente, Posicao_Armazenagem, ID_Devolucao FROM Recebimento";
            OleDbCommand comando = new OleDbCommand(SQL, connect);

            connect.Open();

            OleDbDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection);
            List<CamposDGRecebimento> produtoLista = new List<CamposDGRecebimento>();
            while (reader.Read())
            {
                CamposDGRecebimento prod = new CamposDGRecebimento();
                prod.Ativo_Inativo = (bool)reader["Ativo_Inativo"];
                prod.ID_Recebimento = (string)reader["ID_Recebimento"];
                prod.Senha_Entrada = (string)reader["Senha_Entrada"];
                prod.Status_Entrega = (string)reader["Status_Entrega"];
                prod.Doca_Descarga = (string)reader["Doca_Descarga"];
                prod.DataHora_Recebimento = (string)reader["DataHora_Recebimento"];
                prod.ID_Fornecedor = (string)reader["ID_Fornecedor"];
                prod.Numero_NF = (string)reader["Numero_NF"];
                prod.Numero_Pedido = (string)reader["Numero_Pedido"];
                prod.Cod_Produto = (string)reader["Cod_Produto"];
                prod.Qtd_pecas = (string)reader["Qtd_pecas"];
                prod.Matricula_Conferente = (string)reader["Matricula_Conferente"];
                prod.Posicao_Armazenagem = (string)reader["Posicao_Armazenagem"];
                prod.ID_Devolucao = (string)reader["ID_Devolucao"];
                produtoLista.Add(prod);
            }
            connect.Close();
            return produtoLista;
        }
    }
}

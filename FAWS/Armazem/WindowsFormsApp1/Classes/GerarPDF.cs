using FAWS_WMS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoIntegradoArmazem
{
    public static class GerarPDF
    {
        public static ConexaoBD conexao = new ConexaoBD();
        public static OleDbConnection connect = conexao.conexaoBD(conexao.StrConexao());
        static BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

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
            var pdf = new Document(PageSize.A4.Rotate(), 15 * PixelPorMm, 15 * PixelPorMm,
                                   15 * PixelPorMm, 20 * PixelPorMm);
            var nomeArquivo = $"Produtos_Em_Estoque-{DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss")}.pdf";
            var arquivo = new FileStream(nomeArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);
            writer.PageEvent = new EventosDaPagina(totalPaginas);
            pdf.Open();

            fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

            //adição do título
            var fonteParagrafo = new iTextSharp.text.Font(fonteBase, 26, iTextSharp.text.Font.NORMAL,
                                                          BaseColor.BLACK);
            var titulo = new Paragraph("Relatório Mensal", fonteParagrafo);
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
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(CaminhoImagem);
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
            var tabela = new PdfPTable(9);
            float[] largurasColunas = { 0.6f, 2f, 1f, 1f, 1f, 1f, 1f, 1f, 1f };
            tabela.SetWidths(largurasColunas);
            tabela.DefaultCell.BorderWidth = 0;
            tabela.WidthPercentage = 100;

            CriarCelulaTexto(tabela, "Identif.", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Nome", PdfPCell.ALIGN_LEFT, true);
            CriarCelulaTexto(tabela, "Código", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Ean", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Endereço", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Status", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Fornec.", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Qtd.", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Lote", PdfPCell.ALIGN_CENTER, true);

            foreach (var prod in produtosSelecionados)
            {
                CriarCelulaTexto(tabela, prod.ID_endereco.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.nome_produto);
                CriarCelulaTexto(tabela, prod.Codigo_Produto.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.CodigoEAN.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Endereco_produto.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.status_produto, PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.ID_fornecedeor.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.quantidade.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.lote.ToString(), PdfPCell.ALIGN_CENTER);
            }

            pdf.Add(tabela);

            pdf.Close();
            arquivo.Close();

            MessageBox.Show($"Relatório com {qtdProdutos} produtos foi criado com sucesso", "FAWS WMS",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return nomeArquivo;
        }

        public static void CriarCelulaTexto(PdfPTable tabela, string texto,
                                    int allinhamentoHorz = PdfPCell.ALIGN_LEFT,
                                    bool negrito = false, bool italico = false,
                                    int tamanhoFonte = 12, int alturaCelula = 25)
        {
            int estilo = iTextSharp.text.Font.NORMAL;
            if (negrito && italico)
            {
                estilo = iTextSharp.text.Font.BOLDITALIC;
            }
            else if (negrito)
            {
                estilo = iTextSharp.text.Font.BOLD;
            }
            else if (italico)
            {
                estilo = iTextSharp.text.Font.ITALIC;
            }
            var FonteCelula = new iTextSharp.text.Font(fonteBase, tamanhoFonte,
                               estilo, BaseColor.BLACK);

            var BackgroundColor = iTextSharp.text.BaseColor.WHITE;
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

        public static System.Collections.Generic.List<Produtos> RealizarPesquisa()
        {
            string SQL = "SELECT ID_endereco, nome_produto, Codigo_produto, CodigoEan, Endereco_produto, status_produto, ID_fornecedor, quantidade, lote FROM Armazenagem";
            OleDbCommand comando = new OleDbCommand(SQL, connect);

            connect.Open();

            OleDbDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection);
            List<Produtos> produtoLista = new List<Produtos>();
            while (reader.Read())
            {
                Produtos prod = new Produtos();
                prod.ID_endereco = (string)reader["ID_endereco"];
                prod.nome_produto = (string)reader["nome_produto"];
                prod.Codigo_Produto = (string)reader["Codigo_produto"];
                prod.CodigoEAN = (string)reader["CodigoEAN"];
                prod.Endereco_produto = (string)reader["Endereco_produto"];
                prod.status_produto = (string)reader["status_produto"];
                prod.ID_fornecedeor = (string)reader["ID_fornecedor"];
                prod.quantidade = (int)reader["quantidade"];
                prod.lote = (string)reader["lote"];
                produtoLista.Add(prod);
            }
            connect.Close();
            return produtoLista;
        }
    }
}

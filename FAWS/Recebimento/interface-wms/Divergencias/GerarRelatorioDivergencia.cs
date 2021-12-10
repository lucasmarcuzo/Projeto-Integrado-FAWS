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

namespace Interface_WMS_Recebimento.Divergencias
{
    internal static class GerarRelatorioDivergencia
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
            var nomeArquivo = $"Relatorio_Divergencia-{DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss")}.pdf";
            var arquivo = new FileStream(nomeArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);
            writer.PageEvent = new EventosDaPagina(totalPaginas);
            pdf.Open();

            fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

            //adição do título
            var fonteParagrafo = new Font(fonteBase, 26, Font.NORMAL,
                                                          BaseColor.BLACK);
            var titulo = new Paragraph("Relatório de Divergências", fonteParagrafo);
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
            var tabela = new PdfPTable(11);
            float[] largurasColunas = { 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1.1f };
            tabela.SetWidths(largurasColunas);
            tabela.DefaultCell.BorderWidth = 0;
            tabela.WidthPercentage = 100;

            CriarCelulaTexto(tabela, "Cadastro Atv./Inat.", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "ID. de Devolução", PdfPCell.ALIGN_LEFT, true);
            CriarCelulaTexto(tabela, "Num. do Pedido", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Num. da NF", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Cod. do Produto", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Descrição do Produto", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Qtd. de NFs", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Cod. do Motivo", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Qtd. Devolvida", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Data de Devolução", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Matricula do Inspetor", PdfPCell.ALIGN_CENTER, true);

            foreach (var prod in produtosSelecionados)
            {
                CriarCelulaTexto(tabela, prod.Ativo_Inativo == true ? "Ativo" : "Inativo", PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.ID_Devolucao.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Numero_Pedido.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Numero_NF.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Cod_Produto.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Descricao_Produto.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Qtd_NFs.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Cod_Motivo.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Qtd_Devolvida.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Data_Devolucao.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, prod.Matricula_Conferente.ToString(), PdfPCell.ALIGN_CENTER);
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

        public static List<CamposDGDivergencias> RealizarPesquisa()
        {
            string SQL = "SELECT Ativo_Inativo, ID_Devolucao, Matricula_Conferente, " +
                "Numero_Pedido, Numero_NF, Cod_Produto, Descricao_Produto, Qtd_NFs, Cod_Motivo, Qtd_Devolvida, Data_Devolucao FROM Divergencias";
            OleDbCommand comando = new OleDbCommand(SQL, connect);

            connect.Open();

            OleDbDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection);
            List<CamposDGDivergencias> produtoLista = new List<CamposDGDivergencias>();
            while (reader.Read())
            {
                CamposDGDivergencias prod = new CamposDGDivergencias();
                prod.Ativo_Inativo = (bool)reader["Ativo_Inativo"];
                prod.ID_Devolucao = (string)reader["ID_Devolucao"];
                prod.Matricula_Conferente = (string)reader["Matricula_Conferente"];
                prod.Numero_Pedido = (string)reader["Numero_Pedido"];
                prod.Numero_NF = (string)reader["Numero_NF"];
                prod.Cod_Produto = (string)reader["Cod_Produto"];
                prod.Descricao_Produto = (string)reader["Descricao_Produto"];
                prod.Qtd_NFs = (string)reader["Qtd_NFs"];
                prod.Cod_Motivo = (string)reader["Cod_Motivo"];
                prod.Qtd_Devolvida = (string)reader["Qtd_Devolvida"];
                prod.Data_Devolucao = (string)reader["Data_Devolucao"];
                produtoLista.Add(prod);
            }
            connect.Close();
            return produtoLista;
        }
    }
}

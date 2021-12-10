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

namespace interface_wms
{
    public static class relatorio
    {
        static BaseFont fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        public static string strConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\DB\BDP3-WMSV3.mdb";
        public static OleDbConnection connect = new OleDbConnection(strConexao);

        //metodo para gerar relatorio
        public static string gerarRelatorio(int val)
        {
            var tabela2 = pesquisaProdutos();
            var produtosSelecionados = tabela2.Take(val).ToList();

            var pormm = 72 / 25.2F;
            Document relatorio = new Document(PageSize.A4.Rotate(), 15 * pormm, 15 * pormm, 15 * pormm, 20 * pormm);
            var nomeArquivo = $"produtos_bd-{DateTime.Now.ToString("dd.MM.yyyy-HH.mm.ss")}.pdf";
            var arquivo = new FileStream(nomeArquivo, FileMode.Create);
            var escrita = PdfWriter.GetInstance(relatorio, arquivo);
            relatorio.Open();

            fonteBase = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);

            //adicionando o titulo
            var fonteParagrafo = new iTextSharp.text.Font(fonteBase, 32, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            var titulo = new Paragraph("Relatório de produtos", fonteParagrafo);
            titulo.Alignment = Element.ALIGN_LEFT;
            relatorio.Add(titulo);

            var fonteUsuario = new Font(fonteBase, 9, Font.ITALIC, BaseColor.BLACK);
            var tituloUsuario = new Paragraph($"Emitido por: {FrmMenu.getUsuario}\n\n", fonteUsuario);
            tituloUsuario.Alignment = Element.ALIGN_LEFT;
            tituloUsuario.SpacingAfter = 4;
            relatorio.Add(tituloUsuario);

            //adicionando a logo
            var caminhoImagem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "material\\logo.png");
            if (File.Exists(caminhoImagem))
            {

                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoImagem);
                float razaoAlturaLargura = logo.Width / logo.Height;
                float altura = 32;
                float largura = altura * razaoAlturaLargura;
                logo.ScaleToFit(largura, altura);
                var margemEsq = relatorio.PageSize.Width - relatorio.RightMargin - largura;
                var margemTopo = relatorio.PageSize.Height - relatorio.TopMargin - 48;
                logo.SetAbsolutePosition(margemEsq, margemTopo);
                escrita.DirectContent.AddImage(logo, false);
            }

            //criar tabela
            var tabela = new PdfPTable(11);
            float[] larguraColunas = { 0.8f, 2f, 1f, 1f, 1.5f, 0.8f, 0.8f, 0.8f, 0.5f, 1.5f, 0.5f };
            tabela.SetWidths(larguraColunas);
            tabela.DefaultCell.BorderWidth = 0;
            tabela.WidthPercentage = 100;

            //adicionando celulas
            CriarCelulaTexto(tabela, "Código", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Nome", PdfPCell.ALIGN_LEFT, true);
            CriarCelulaTexto(tabela, "Categ", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "SubCateg", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Fornecedor", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Qtd", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "QtdDisp", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Preço", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Tipo", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "EAN", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaTexto(tabela, "Ativo", PdfPCell.ALIGN_CENTER, true);

            foreach (var i in produtosSelecionados)
            {
                CriarCelulaTexto(tabela, i.codigoProduto.ToString("D7"), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, i.nome);
                CriarCelulaTexto(tabela, i.categoria, PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, i.subCategoria, PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, i.fornecedor, PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, i.quantidade, PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, i.quantidadeDisp.ToString(), PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, "R$" + i.preco.ToString(), PdfPCell.ALIGN_RIGHT);
                CriarCelulaTexto(tabela, i.precoTipo.ToString(), PdfPCell.ALIGN_RIGHT);
                CriarCelulaTexto(tabela, i.ean, PdfPCell.ALIGN_CENTER);
                CriarCelulaTexto(tabela, i.ativo ? "Sim" : "Não", PdfPCell.ALIGN_CENTER);
            }

            relatorio.Add(tabela);

            relatorio.Close();
            arquivo.Close();

            MessageBox.Show("Relatório com " + val + " produtos criado com sucesso.");
            return nomeArquivo;
        }

        static void CriarCelulaTexto(PdfPTable tabela, string texto, int alinhamentoHorz = PdfPCell.ALIGN_LEFT, bool negrito = false, bool italico = false, int tamanhoFonte = 10, int alturaCelula = 25)
        {
            int estilo = iTextSharp.text.Font.NORMAL;
            if (negrito && italico)
            {
                estilo = iTextSharp.text.Font.BOLDITALIC;
            }
            else if (negrito)
                estilo = iTextSharp.text.Font.BOLD;
            else if (italico)
                estilo = iTextSharp.text.Font.ITALIC;


            var fonteCelula = new iTextSharp.text.Font(fonteBase, tamanhoFonte, estilo, BaseColor.BLACK);
            var celula = new PdfPCell(new Phrase(texto, fonteCelula));
            celula.HorizontalAlignment = alinhamentoHorz;
            celula.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            celula.Border = 0;
            celula.BorderWidthBottom = 1;
            celula.FixedHeight = alturaCelula;
            tabela.AddCell(celula);

        }


        //metodo para pesquisar dados p/ relatorio
        public static System.Collections.Generic.List<produtos> pesquisaProdutos()
        {
            string SQL = "SELECT g5_produto.CodigoProduto,g5_produto.Nome,g5_categoria.Nome as categoria,g5_subcategoria.Nome as subcateg,g1_tblFornecedores.nomeFantasia as fornecedor,g5_produto.Quantidade as qtd,g5_produto.QtdeDisponivel, g5_produto.precoProduto, g5_produto.precotipo as PrecoTipo,g5_produto.CodigoEAN, g5_produto.ativo FROM (g1_tblFornecedores INNER JOIN(g5_subcategoria INNER JOIN(g5_categoria inner join g5_produto on g5_produto.categoria = g5_categoria.ID) on g5_produto.SubCategoria = g5_subcategoria.ID) on g1_tblFornecedores.idFornecedores = g5_Produto.Fornecedor)";
            OleDbCommand comando = new OleDbCommand(SQL, connect);

            connect.Open();

            OleDbDataReader reader = comando.ExecuteReader(CommandBehavior.CloseConnection);

            List<produtos> produtosLista = new List<produtos>();
            while (reader.Read())
            {
                produtos prod = new produtos();
                prod.codigoProduto = (int)reader["CodigoProduto"];
                prod.nome = (string)reader["Nome"];
                prod.categoria = (string)reader["categoria"];
                prod.subCategoria = (string)reader["subcateg"];
                prod.fornecedor = (string)reader["fornecedor"];
                prod.quantidade = reader["qtd"].ToString();
                prod.quantidadeDisp = Convert.ToInt32(reader["QtdeDisponivel"]);
                prod.preco = Convert.ToDouble(reader["precoProduto"]);
                prod.precoTipo = (string)reader["PrecoTipo"];
                prod.ean = (string)reader["CodigoEAN"];
                prod.ativo = (bool)reader["ativo"];
                produtosLista.Add(prod);
            }
            connect.Close();
            return produtosLista;
        }


    }
}

using iTextSharp.text;
using iTextSharp.text.pdf;
using System;

namespace Interface_WMS_Recebimento.Ferramentas
{
    public class EventosDaPagina : PdfPageEventHelper
    {
        private BaseFont fonteBaseRodape { get; set; }
        private iTextSharp.text.Font fonteRodape { get; set; }
        private PdfContentByte wdc;
        public int totalPaginas { get; set; }

        //construtor
        public EventosDaPagina(int totalPaginas)
        {
            fonteBaseRodape = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
            fonteRodape = new iTextSharp.text.Font(fonteBaseRodape, 8f,
                              iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            this.totalPaginas = totalPaginas;
        }

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            base.OnOpenDocument(writer, document);
            this.wdc = writer.DirectContent;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);
            AdicionarMomentoDeGeracaoRelatorio(writer, document);
            AdicionarNumerosDePagina(writer, document);
        }

        private void AdicionarMomentoDeGeracaoRelatorio(PdfWriter writer, Document document)
        {
            var textoMomentoGerado = $"Gerado em {DateTime.Now.ToShortDateString()} às " +
                            $"{DateTime.Now.ToShortTimeString()}";

            wdc.BeginText();
            wdc.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
            wdc.SetTextMatrix(document.LeftMargin, document.BottomMargin * 0.75f);
            wdc.ShowText(textoMomentoGerado);
            wdc.EndText();
        }

        private void AdicionarNumerosDePagina(PdfWriter writer, Document document)
        {
            int paginaAtual = writer.PageNumber;
            var textoPaginacao = $"Pagina {paginaAtual} de {totalPaginas}";

            float larguraTextoPaginacao =
                fonteBaseRodape.GetWidthPoint(textoPaginacao, fonteRodape.Size);
            var tamanhoPagina = document.PageSize;

            wdc.BeginText();
            wdc.SetFontAndSize(fonteRodape.BaseFont, fonteRodape.Size);
            wdc.SetTextMatrix(tamanhoPagina.Width - document.RightMargin - larguraTextoPaginacao,
                              document.BottomMargin * 0.75f);
            wdc.ShowText(textoPaginacao);
            wdc.EndText();
        }

    }
}

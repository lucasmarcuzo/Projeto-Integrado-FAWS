namespace interface_wms
{
    public class produtos
    {
        public int codigoProduto { get; set; }
        public string nome { get; set; }
        public string categoria { get; set; }
        public string subCategoria { get; set; }
        public string fornecedor { get; set; }
        public string quantidade { get; set; }
        public int quantidadeDisp { get; set; }
        public double preco { get; set; }
        public string precoTipo { get; set; }
        public string ean { get; set; }
        public bool ativo { get; set; }
    }
}

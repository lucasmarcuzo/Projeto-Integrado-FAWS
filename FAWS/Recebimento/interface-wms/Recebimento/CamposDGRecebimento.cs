namespace Interface_WMS_Recebimento.Recebimento

{
    class CamposDGRecebimento
    {
        public bool Ativo_Inativo { get; set; }
        public string ID_Recebimento { get; set; }
        public string Senha_Entrada { get; set; }
        public string Status_Entrega { get; set; }
        public string Doca_Descarga { get; set; }
        public string DataHora_Recebimento { get; set; }
        public string ID_Fornecedor { get; set; }
        public string Numero_NF { get; set; }
        public string Numero_Pedido { get; set; }
        public string Cod_Produto { get; set; }
        public string Qtd_pecas { get; set; }
        public string Matricula_Conferente { get; set; }
        public string Posicao_Armazenagem { get; set; }
        public string ID_Devolucao { get; set; }

    }
}

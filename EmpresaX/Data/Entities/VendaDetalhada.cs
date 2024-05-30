namespace EmpresaX.Data.Entities
{
    public class VendaDetalhada
    {
        public VendaDetalhada() { }
        public VendaDetalhada(int vendaId, string nomeCliente, DateTime dataVenda, string nomeProduto, int quantidade, decimal precoUnitario, decimal subtotal)
        {
            VendaId = vendaId;
            NomeCliente = nomeCliente;
            DataVenda = dataVenda;
            NomeProduto = nomeProduto;
            Quantidade = quantidade;
            PrecoUnitario = precoUnitario;
            Subtotal = subtotal;
        }
        public int VendaId { get; set; }
        public string NomeCliente { get; set; }
        public DateTime DataVenda { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }
}

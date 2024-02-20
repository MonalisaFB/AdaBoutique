namespace AdaBoutique.Request
{
    public class VendaRequest
    {
        public int NumeroNFe { get; }
        public string NomeCliente { get; }
        public string FormaDePagamento { get; }
        public decimal ValorCompra { get; }
        public DateTime DataCompra { get; }
    }
}

namespace AdaBoutique.Request
{
    public class TrocaRequest
    {
        public int NumeroNFe { get; }
        public string NomeCliente { get; }
        public decimal ValorCompraInicial { get; }
        public decimal DiferencaValorTroca { get; }
        public DateTime DataTroca { get; }
    }
}

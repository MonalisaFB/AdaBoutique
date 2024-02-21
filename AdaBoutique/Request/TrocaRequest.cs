using System.ComponentModel.DataAnnotations;

namespace AdaBoutique.Request
{
    public class TrocaRequest
    {
        [Required(ErrorMessage = "O número da Nota Fiscal Eletrônica é obrigatoria para garantir a devolução dos produtos!")]
        public int NumeroNFe { get; }
        public string? NomeCliente { get; }
        public decimal ValorCompraInicial { get; }
        public decimal DiferencaValorTroca { get; }
        public DateTime DataTroca { get; }
    }
}

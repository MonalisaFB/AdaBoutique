using System.ComponentModel.DataAnnotations;

namespace AdaBoutique.Request
{
    public class VendaRequest
    {
        [Required(ErrorMessage = "O número da Nota Fiscal Eletrônica é obrigatoria!")]
        public int NumeroNFe { get; }
        public string? NomeCliente { get; }
        public string? FormaDePagamento { get; }
        public decimal ValorCompra { get; }
        public DateTime DataCompra { get; }
    }
}

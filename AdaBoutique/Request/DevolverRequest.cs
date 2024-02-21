using System.ComponentModel.DataAnnotations;

namespace AdaBoutique.Request
{
    public class DevolverRequest
    {
        [Required(ErrorMessage = "O número da Nota Fiscal Eletrônica é obrigatoria para garantir a devolução dos produtos!")]
        public int NumeroNFe { get; }
        public string? NomeCliente { get; }
        public decimal ValorCreditoEmLoja { get; }
        public DateTime DataDevolucao { get; }
    }
}

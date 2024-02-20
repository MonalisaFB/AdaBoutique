using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Models.VendaModel
{
    public class Venda
    {
        private static int _idVenda = 1;
        public Venda(int numeroNfe,
                     string nomeCliente,
                     string formaDePagamento,
                     decimal valorCompra,
                     DateTime dataCompra)
        {
            IdVenda = _idVenda++;
            NumeroNFe = numeroNfe;
            NomeCliente = nomeCliente;
            FormaDePagamento = formaDePagamento;
            ValorCompra = valorCompra;
            DataCompra = dataCompra;
        }
        public int IdVenda { get; }
        public int NumeroNFe { get; }
        public string NomeCliente { get; }
        public string FormaDePagamento { get; }
        public decimal ValorCompra {  get; }
        public DateTime DataCompra { get; }
    }
}

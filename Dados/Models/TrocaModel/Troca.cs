using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Models.TrocaModel
{
    public class Troca
    {
        private static int _idTroca = 1;
        public Troca(int numeroNfe,
                     string nomeCliente,
                     decimal valorCompraInicial,
                     decimal diferencaValorTroca,
                     DateTime dataTroca)
        {
            IdTroca = _idTroca++;
            NumeroNFe = numeroNfe;
            NomeCliente = nomeCliente;
            ValorCompraInicial = valorCompraInicial;
            DiferencaValorTroca = diferencaValorTroca;
            DataTroca = dataTroca;

            
        }
        public int IdTroca { get; }
        public int NumeroNFe { get; }
        public string NomeCliente { get; }
        public decimal ValorCompraInicial { get; }  
        public decimal DiferencaValorTroca { get; }
        public DateTime DataTroca { get; }

    }
}

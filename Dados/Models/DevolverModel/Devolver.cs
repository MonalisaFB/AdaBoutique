using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Models.DevolverModel
{
    public class Devolver
    {
        private static int _idDevolver = 1;
        public Devolver(int numeroNfe,
                     string nomeCliente,
                     decimal valorCreditoEmLoja,
                     DateTime dataDevolucao)
        {
            IdDevolver = _idDevolver++;
            NumeroNFe = numeroNfe;
            NomeCliente = nomeCliente;
            ValorCreditoEmLoja = valorCreditoEmLoja;
            DataDevolucao = dataDevolucao;
            
        }
        public int IdDevolver { get; }
        public int NumeroNFe { get; }
        public string NomeCliente { get; }
        public decimal ValorCreditoEmLoja { get; }
        public DateTime DataDevolucao { get; }
    }
}

using Dados.CustomExceptions;
using Dados.Models.VendaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio.VendaRepositorio
{
    public class VendaRepositorio : IVendaRepositorio
    {
        private readonly List<Venda> _vendas = new List<Venda>();

        public Venda? BuscarNfe(int nfe)
        {
            var vendaNfe = _vendas.FirstOrDefault(x => x.NumeroNFe == nfe);
            if (vendaNfe != null)
            {
                throw new BoutiqueApiException($"A Nota Fiscal de número {nfe} não foi encontrada!", 404);
            }
            return vendaNfe;
        }

        public List<Venda> ListarVendas()
        {
            return _vendas;
        }

        public Venda RegistrarVenda(Venda venda)
        {
            _vendas.Add(venda);
            return venda;
        }

        

    }
}

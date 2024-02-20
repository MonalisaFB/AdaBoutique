using Dados.Models.VendaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio.VendaRepositorio
{
    public interface IVendaRepositorio
    {
        Venda VendaRoupa(Venda venda);
    }
}

using Dados.Models.TrocaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio.TrocaRepositorio
{
    public class TrocaRepositorio : ITrocaRepositorio
    {
        private readonly List<Troca> _trocas = new List<Troca>();

        public Troca RegistrarTroca(Troca troca)
        {
            _trocas.Add(troca);
            return troca;
        }

        public List<Troca> ListarTroca()
        {
            return _trocas;
        }
    }
}

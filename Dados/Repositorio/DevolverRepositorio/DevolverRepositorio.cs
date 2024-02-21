using Dados.Models.DevolverModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio.DevolverRepositorio
{
    public class DevolverRepositorio : IDevolverRepositorio
    {
        private readonly List<Devolver> _devolucao =  new List<Devolver>();
        public List<Devolver> ListarDevolucao()
        {
            return _devolucao;
        }

        public Devolver RegistarDevolucao(Devolver devolver)
        {
            _devolucao.Add(devolver);
            return devolver;
        }
    }
}

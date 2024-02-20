using Dados.Models.DevolverModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio.DevolverRepositorio
{
    public interface IDevolverRepositorio
    {
        Devolver DevolverRoupas(Devolver devolver);
    }
}

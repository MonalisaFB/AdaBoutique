﻿using Dados.Models.TrocaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Repositorio.TrocaRepositorio
{
    public interface ITrocaRepositorio
    {
        Troca RegistrarTroca(Troca troca);
        List<Troca> ListarTroca();
    }
}

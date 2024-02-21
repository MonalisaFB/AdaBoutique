using Dados.Models.DevolverModel;
using Dados.Models.TrocaModel;
using Dados.Models.VendaModel;
using Dados.Repositorio.DevolverRepositorio;
using Dados.Repositorio.TrocaRepositorio;
using Dados.Repositorio.VendaRepositorio;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AdaBoutique.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoutiqueController : ControllerBase
    {
        private readonly IVendaRepositorio _vendaRepositorio;
        private readonly IDevolverRepositorio _devolverRepositorio;
        private readonly ITrocaRepositorio _trocaRepositorio;

        public BoutiqueController(IVendaRepositorio vendaRepositorio,
                                  IDevolverRepositorio devolverRepositorio,
                                  ITrocaRepositorio trocaRepositorio)
        {
            _vendaRepositorio = vendaRepositorio;
            _devolverRepositorio = devolverRepositorio;
            _trocaRepositorio = trocaRepositorio;
        }


        [HttpPost]
        public IActionResult RegistrarVenda([FromBody] Venda venda)
        {
            var registrarVenda = _vendaRepositorio.RegistrarVenda(venda);
            return Ok(registrarVenda);
        }

        [HttpGet]

        public IActionResult ListarVendas()
        {
            var vendas = _vendaRepositorio.ListarVendas();
            return Ok(vendas);
        }


        /*[HttpPost]
        public IActionResult RegistrarDevolucao([FromBody] Devolver devolver)
        {
            var registrarDevolucao = _devolverRepositorio.RegistarDevolucao(devolver);
            return Ok(registrarDevolucao);
        }
        [HttpGet]
        public IActionResult ListarDevolucao()
        {
            var devolucoes = _devolverRepositorio.ListarDevolucao();
            return Ok(devolucoes);
        }

        [HttpPost]
        public IActionResult RegistrarTroca([FromBody] Troca troca)
        {
            var registrarTroca = _trocaRepositorio.RegistrarTroca(troca);
            return Ok(registrarTroca);
        }

        [HttpGet]
        public IActionResult ListarTroca()
        {
            var trocas = _trocaRepositorio.ListarTroca();
            return Ok(trocas);
        }*/

    }
}

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
    //[Route("[controller]")]
    public class BoutiqueController : ControllerBase
    {
        private readonly IVendaRepositorio _vendaRepositorio;
        private readonly IDevolverRepositorio _devolverRepositorio;
        private readonly ITrocaRepositorio _trocaRepositorio;

        private readonly ILogger<BoutiqueController> _logger;

        public BoutiqueController(IVendaRepositorio vendaRepositorio,
                                  IDevolverRepositorio devolverRepositorio,
                                  ITrocaRepositorio trocaRepositorio,
                                  ILogger<BoutiqueController> logger)
        {
            _vendaRepositorio = vendaRepositorio;
            _devolverRepositorio = devolverRepositorio;
            _trocaRepositorio = trocaRepositorio;
            _logger = logger;
        }


        [HttpPost("registrarvenda")]
        public IActionResult RegistrarVenda([FromBody] Venda venda)
        {
            _logger.LogInformation($"{nameof(RegistrarVenda)} inicializado");
            var registrarVenda = _vendaRepositorio.RegistrarVenda(venda);
            _logger.LogInformation($"{nameof(RegistrarVenda)} finalizado");

            return Ok(registrarVenda);

        }

        [HttpGet("listarvenda")]

        public IActionResult ListarVendas()
        {
            _logger.LogInformation($"{nameof(ListarVendas)} inicializado");
            var vendas = _vendaRepositorio.ListarVendas();
            _logger.LogInformation($"{nameof(ListarVendas)} finalizado");
            return Ok(vendas);
        }


        [HttpPost("registrardevolucao")]
        public IActionResult RegistrarDevolucao([FromBody] Devolver devolver)
        {
            _logger.LogInformation($"{nameof(RegistrarDevolucao)} inicializado");
            var registrarDevolucao = _devolverRepositorio.RegistarDevolucao(devolver);
            _logger.LogInformation($"{nameof(RegistrarDevolucao)} finalizado");

            return Ok(registrarDevolucao);
        }

        [HttpGet("listarevolucao")]
        public IActionResult ListarDevolucao()
        {
            _logger.LogInformation($"{nameof(ListarDevolucao)} inicializado");
            var devolucoes = _devolverRepositorio.ListarDevolucao();
            _logger.LogInformation($"{nameof(ListarDevolucao)} finalizado");

            return Ok(devolucoes);
        }

        [HttpPost("registrartroca")]
        public IActionResult RegistrarTroca([FromBody] Troca troca)
        {
            _logger.LogInformation($"{nameof(RegistrarTroca)} inicializado");
            var registrarTroca = _trocaRepositorio.RegistrarTroca(troca);
            _logger.LogInformation($"{nameof(RegistrarTroca)} finalizado");

            return Ok(registrarTroca);
        }

        [HttpGet("listartroca")]
        public IActionResult ListarTroca()
        {
            _logger.LogInformation($"{nameof(ListarTroca)} inicializado");
            var trocas = _trocaRepositorio.ListarTroca();
            _logger.LogInformation($"{nameof(ListarTroca)} finalizado");
            return Ok(trocas);
        }

    }
}

using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace AdaBoutique.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoutiqueController : ControllerBase
    {

        [HttpPost]
        //registra vendas
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpGet]
        //retorna lista de vendas
        public IActionResult Get()
        {
            return Ok();
        }

        /*[HttpPost]
        //registra devolução ou troca
        public IActionResult Post()
        {
            return Ok();
        }*/
    }
}

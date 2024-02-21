using AdaBoutique.ResponseModel;
using Dados.CustomExceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AdaBoutique.Filters
{
    public class FiltroExcecao : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is BoutiqueApiException boutiqueApiException)
            {
                var errorResult = new ErrorResponse
                {
                    Titulo = "Erro Boutique Api",
                    ErroMensagem = context.Exception.Message,
                    StatusCode = 500
                };

                context.Result = new JsonResult(errorResult)
                {
                    StatusCode = errorResult.StatusCode
                };
            }
            else
            {
                var errorResult = new ErrorResponse
                {
                    Titulo = "Erro Boutique Api",
                    ErroMensagem = "Erro interno do servidor!",
                    StatusCode = StatusCodes.Status500InternalServerError
                };
                context.Result = new JsonResult(errorResult)
                {
                    StatusCode = errorResult.StatusCode
                };

            }
        }
    }
}

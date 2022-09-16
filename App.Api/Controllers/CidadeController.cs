using App.Domain.DTO;
using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : Controller
    {

        private ICidadeService _service;

        public CidadeController(ICidadeService service)
        {
            _service = service;
        }

        [HttpPost("BuscaPorCep")]
        [AllowAnonymous]

        public JsonResult BuscaPorCep(string cep)
        {
            try
            {
                var obj = _service.BuscaPorCep(cep);
                return Json(RetornoApi.Sucesso(obj));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }

        [HttpGet("ListaCidades")]
        [AllowAnonymous]
        public JsonResult ListaCidades(string? cep, string? nome)
        {
            try
            {
                var obj = _service.ListaCidades(cep, nome);
                return Json(RetornoApi.Sucesso(obj));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));

            }
        }

        [HttpPost("Salvar")]
        [AllowAnonymous]

        public JsonResult Salvar([FromBody] Cidade obj)
        {
            try
            {
             
                _service.Salvar(obj);
                return Json(RetornoApi.Sucesso(true));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }

        }

        [HttpDelete("Remover")]

        public JsonResult Remover(Guid id)

        {
            _service.Remover(id);
            return Json(true);
        }
    }
}
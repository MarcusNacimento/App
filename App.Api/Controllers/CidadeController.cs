using App.Domain.Entities;
using App.Domain.Interfaces.Application;
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
        public JsonResult BuscaPorCep(String cep)
        {
            var minhaCidade = _service.BuscaPorCep(cep);
            return Json(minhaCidade);
        }

        [HttpGet("ListaCidades")]
            public JsonResult ListaCidades(string? cep, string? nome)
        {
            var listaCidades = _service.ListaCidades(cep, nome);
            return Json(listaCidades);
        }



        [HttpPost("Salvar")]

        public JsonResult Salvar(string cep, string nome, string estado)
        {
            var objCidade = new Cidade
            {
                Cep = cep,
                Estado = estado,
                Nome = nome
            };
            _service.Salvar(objCidade);
            return Json(true);
        }
        
        [HttpDelete("Remover")]

        public JsonResult Remover(Guid id)
        
        {
            _service.Remover(id);
            return Json(true);
        }
    }
}
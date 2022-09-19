using App.Domain.DTO;
using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {

        private IPessoaService _service;

        public PessoaController(IPessoaService service)
        {
            _service = service;
        }

        [HttpPost("BuscaPorNome")]
        [AllowAnonymous]
        public JsonResult BuscaPorNome(string nome)
        {
            try

            {
                var obj = _service.BuscaPorNome(nome);
                return Json(RetornoApi.Sucesso(obj));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }
        [HttpGet("ListaPessoas")]
        [AllowAnonymous]

        public JsonResult ListaCidades(string? nome)
        {
            try
            {
                var obj = _service.ListaPessoas(nome);
                return Json(RetornoApi.Sucesso(obj));
            }
            catch (Exception ex)
            {
                return Json(RetornoApi.Erro(ex.Message));
            }
        }


        [HttpPost("Salvar")]
        [AllowAnonymous]

        public JsonResult Salvar([FromBody] Pessoa obj)
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
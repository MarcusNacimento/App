using App.Domain.Entities;
using App.Domain.Interfaces.Application;
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
        public JsonResult BuscaPorNome(string nome)
        {
            var minhaPessoa = _service.BuscaPorNome(nome);
            return Json(minhaPessoa);
        }


        [HttpGet("ListaPessoas")]
        public JsonResult ListaCidades(string? nome)
        {
            var listaPessoas = _service.ListaPessoas(nome);
            return Json(listaPessoas);
        }


        [HttpPost("Salvar")]

        public JsonResult Salvar(string nome, int idade, string telefone, string endereco, string email)
        {
            var objPessoa = new Pessoa
            {
                Nome = nome,
                Idade = idade,
                Telefone = telefone,
                Endereco = endereco,
                Email = email
            };
            _service.Salvar(objPessoa);
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
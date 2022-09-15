using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Aplicattion.Services
{
    public class PessoaService : IPessoaService
    {
        private IRepositoryBase<Pessoa> _repository { get; set; }

        public PessoaService (IRepositoryBase<Pessoa> repository)
        {
            _repository = repository;
        }
    
        public Pessoa BuscaPorNome(string nome )
        {
            var retornoPessoa = _repository.Query(pessoa => pessoa.Nome ==nome).FirstOrDefault();

            return retornoPessoa ;
        }

        public List<Pessoa> ListaPessoas(string nome )
        {
            
           var listaPessoas = _repository.Query
                (x => x.Nome.Contains(nome)
               


           ).ToList();

            return listaPessoas;
        }

        public void Remover(Guid id)
        {
            _repository.Delete(id);
        }

        public void Salvar(Pessoa obj)
        {
            _repository.Save(obj);
            _repository.SaveChanges();
        }

        Cidade IPessoaService.BuscaPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> ListaPessoas(string nome, int idade, string telefone, string endereco, string email)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class CidadeService : ICidadeService
    {
        private IRepositoryBase<Cidade> _repository { get; set; }

        public CidadeService (IRepositoryBase<Cidade> repository)
        {
            _repository = repository;
        }
    
        public Cidade BuscaPorCep(string cep)
        {
            var retornoCidade = _repository.Query(cidade => cidade.Cep == cep).FirstOrDefault();

            return retornoCidade ;
        }

        public List<Cidade> ListaCidades(string cep, string nome)
        {
            
           var listaCidades = _repository.Query
                (x => x.Cep.Contains(cep)
                && x.Cep.Contains(nome)
           
           ).ToList();

            return listaCidades;
        }

        public void Remover(Guid id)
        {
            _repository.Delete(id);
        }

        public void Salvar(Cidade obj)
        {
            _repository.Save(obj);
            _repository.SaveChanges();
        }
    }
}

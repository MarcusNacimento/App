using System.ComponentModel.DataAnnotations;

namespace App.Domain.Entities
{
    public class Pessoa
    {
        [Key]
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }
        public string Telefone { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }
    }
}
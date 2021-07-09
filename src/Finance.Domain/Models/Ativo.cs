using System;
namespace Finance.Domain.Models
{
    public class Ativo : BaseEntity
    {
        public Ativo(string nome, int idCategoria)
        {
            ValidaAtivo(nome, idCategoria);
            Nome = nome;
            DataInclusao = DateTime.Now;
            IdCategoria = idCategoria;
        }
        public string Nome { get; private set; }
        public DateTime DataInclusao { get; set; }   
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public void Update(string nome, int idCategoria)
        {
             ValidaAtivo(nome, idCategoria);
        }

        private void ValidaAtivo(string nome, int idCategoria)
        {
            if(string.IsNullOrEmpty(nome))
               throw new InvalidOperationException("O nome é inválido");
               if(idCategoria == 0)
               throw new InvalidOperationException("A categoria é inválida");
        }
    }
}
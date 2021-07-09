using System;
namespace Finance.Domain.Models
{
    public class Cliente : BaseEntity
    {
        public Cliente()
        {
            
        }
        public string Nome { get; set; } 
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace Finance.Domain.Models
{
    public class Categoria : BaseEntity
    {
        public Categoria()
        {
            
        }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
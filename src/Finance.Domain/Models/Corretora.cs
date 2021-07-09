using System;
using System.Collections.Generic;

namespace Finance.Domain.Models
{
    public class Corretora : BaseEntity
    {
        public Corretora()
        {
            
        }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
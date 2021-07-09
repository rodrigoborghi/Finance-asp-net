using System;
using System.Collections.Generic;

namespace Finance.Domain.Models
{
    public class Carteira : BaseEntity
    {
        public Carteira()
        {
            
        }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataCriacao { get; set; }
        public int IdCorretora { get; set; }
        public Corretora Corretora { get; set; }
        public ICollection<AtivosCarteira> AtivosCarteira { get; set; }
    }
}
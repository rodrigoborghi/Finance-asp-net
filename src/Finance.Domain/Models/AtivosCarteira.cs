using System;
using System.Collections.Generic;

namespace Finance.Domain.Models
{
    public class AtivosCarteira : BaseEntity
    {
        public AtivosCarteira()
        {
            
        }
        public Carteira Carteira { get; set; }
        public int CarteiraId { get; set; } 
        public int AtivoId { get; set; }
        public Ativo Ativo { get; set; }

        public decimal Valor{ get; set; }

        public int Quantidade { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataVenda { get; set; }
        public bool delete { get; set; }    
    }
}
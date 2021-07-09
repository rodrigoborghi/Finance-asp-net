
using System.ComponentModel.DataAnnotations;
namespace Finance.Web.DTOs
{
    public class FinanceDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public decimal Valor{ get; private set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MulherPart1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime Data { get; set; }
        public string Servico { get; set; }

         [DataType(DataType.Currency)]
         [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }

    }
}

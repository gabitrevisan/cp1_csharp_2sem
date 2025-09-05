using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Checkpoint.Model
{
    public class RM99500_Produto
    {
        [Key]
        public int idProduto { get; set; }
        public required string nmProduto { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal preco { get; set; }
    }
}
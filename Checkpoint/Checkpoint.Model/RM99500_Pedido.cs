using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Checkpoint.Model
{
    public class RM99500_Pedido
    {
        [Key]
        public int idPedido { get; set; }
        public DateTime dataPedido { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal valorTotal { get; set; }
    }
}
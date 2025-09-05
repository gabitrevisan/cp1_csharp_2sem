using System.ComponentModel.DataAnnotations;

namespace Checkpoint.Model
{
    public class RM99500_Fornecedor
    {
        [Key]
        public int idFornecedor { get; set; }
        public string? nrCEP { get; set; }
        public string? dsEndereco { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }
    }
}
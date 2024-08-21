using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoquei.Models
{
    [Table("TipoProduto")]
    public class TipoProduto
    {
        [Column("TipoProdutoId")]
        [Display(Name = "Código do TipoProduto")]
        public int TipoProdutoId { get; set; }

        [Column("NomeTipoProduto")]
        [Display(Name = "Nome Tipo Produto")]
        public string NomeTipoProduto { get; set; } = string.Empty;
    }
}

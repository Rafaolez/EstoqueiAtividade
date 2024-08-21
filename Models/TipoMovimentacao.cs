using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoquei.Models
{
    [Table("TipoMovimentacao")]
    public class TipoMovimentacao
    {
        [Column("TipoMovimentacaoId")]
        [Display(Name = "Código do TipoMovimentação")]
        public int TipoMovimentacaoId { get; set; }

        [Column("NomeTipomovimentacao")]
        [Display(Name = "Nome Tipo movimentacao")]
        public string NomeTipomovimentacao { get; set; } = string.Empty;

    }
}

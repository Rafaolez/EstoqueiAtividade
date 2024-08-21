using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoquei.Models
{
    [Table("EntradaSaida")]
    public class EntradaSaida
    {
        [Column("EntradaSaidaId")]
        [Display(Name = "Código do Entrada&Saida")]
        public int EntradaSaidaId { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        public Produto? Produto { get; set; }

        [Column("QuantidadeMovimentação")]
        [Display(Name = "Numero Quantidade Movimentação")]
        public int QuantidadeMovimentação { get; set; }

        [ForeignKey("TipoMovimentacaoId")]
        [Display(Name = "TipoMovimentacao")]
        public int TipoMovimentacaoId { get; set; }
        public TipoMovimentacao? TipoMovimentacao { get; set; }

        [Column("DataMovimentaçãoId")]
        [Display(Name = "Data Movimentação")]
        public DateTime DataMovimentaçãoId { get; set; }
    }
}

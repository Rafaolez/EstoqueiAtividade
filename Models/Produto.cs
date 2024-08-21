using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoquei.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        [Display(Name = "Código do Produto")]
        public int ProdutoId { get; set; }

        [Column("NomeProduto")]
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; } = string.Empty;

        [Column("PesoProduto")]
        [Display(Name = "Peso do Produto")]
        public int PesoProduto { get; set; }

        [Column("QuantidadeEstoque")]
        [Display(Name = "Quantidade do Estoque")]
        public int QuantidadeEstoque { get; set; }

        [Column("Status")]
        [Display(Name = "Status")]
        public bool Status { get; set; }

        [ForeignKey("TipoProdutoId")]
        [Display(Name = "TipoProduto")]
        public int TipoProdutoId { get; set; }

        public TipoProduto? TipoProduto { get; set; }

    }
}

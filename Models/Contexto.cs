using Microsoft.EntityFrameworkCore;

namespace Estoquei.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<EntradaSaida> EntradaSaida { get; set; }
        public DbSet<TipoProduto> TipoProduto { get; set; }
        public DbSet<TipoMovimentacao> TipoMovimentacao { get; set; }

    }
}

using ApiWallet.Models;

namespace ApiWallet.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Fundo> Fundos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fundo>().Property(p => p.FundoId).HasColumnName("FundoId");
            modelBuilder.Entity<Fundo>().HasKey(p => p.FundoId);
            modelBuilder.Entity<Fundo>().Property(p => p.Name).HasColumnName("Name");
            modelBuilder.Entity<Fundo>().Property(p => p.Value).HasColumnName("Value");
            modelBuilder.Entity<Fundo>().Property(p => p.Qty).HasColumnName("Qty");
            modelBuilder.Entity<Fundo>().Property(p => p.Qty).HasColumnType("Decimal(10,2)");
            modelBuilder.Entity<Fundo>().Property(p => p.Value).HasColumnType("Decimal(10,2)");
            base.OnModelCreating(modelBuilder);
        }
    }
}

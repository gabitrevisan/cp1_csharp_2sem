using Checkpoint.Model;
using Microsoft.EntityFrameworkCore;

namespace Checkpoint.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<RM99500_Fornecedor> Fornecedores { get; set; }
        public DbSet<RM99500_Produto> Produtos { get; set; }
        public DbSet<RM99500_Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RM99500_Fornecedor>().ToTable("RM99500_Fornecedor");
            modelBuilder.Entity<RM99500_Produto>().ToTable("RM99500_Produto");
            modelBuilder.Entity<RM99500_Pedido>().ToTable("RM99500_Pedido");
        }
    }
}
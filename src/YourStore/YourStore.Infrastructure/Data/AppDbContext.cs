using Microsoft.EntityFrameworkCore;
using YourStore.Core.Entities;

namespace YourStore.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoPagamento> TiposPagamento { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaProduto> VendaProdutos { get; set; }
        public DbSet<VendaPagamento> VendaPagamentos { get; set; }
        public DbSet<FornecedorPagamento> FornecedorPagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações adicionais das entidades podem ser feitas aqui
            // Exemplo: Chaves compostas, índices, etc.
            
            // Configuração para a entidade VendaProduto
            modelBuilder.Entity<VendaProduto>()
                .HasOne(vp => vp.Venda)
                .WithMany(v => v.VendaProdutos)
                .HasForeignKey(vp => vp.VendaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VendaProduto>()
                .HasOne(vp => vp.Produto)
                .WithMany()
                .HasForeignKey(vp => vp.ProdutoId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<VendaProduto>()
                .HasOne(vp => vp.User)
                .WithMany()
                .HasForeignKey(vp => vp.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

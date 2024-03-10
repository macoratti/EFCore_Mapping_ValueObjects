using EFCoreDomain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsole.Data;

public class AppDbContext : DbContext
{
    public DbSet<Produto> Produtos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DK57UNP\sqlexpress;Initial Catalog=DemoMapDB;Integrated Security=True;TrustServerCertificate=True;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasKey(p => p.Id);

        modelBuilder.Entity<Produto>().Property(p => p.Id)
                                      .HasConversion(produtoId => produtoId!.Valor,
                                       value => new ProdutoId(value));

        modelBuilder.Entity<Produto>().OwnsOne(p => p.Nome, nomeBuilder =>
        {
            nomeBuilder.Property(n => n.Valor).HasMaxLength(ProdutoNome.MaxLength)
                                              .HasColumnName("Nome");
        });

        modelBuilder.Entity<Produto>().Property(p => p.CodigoProduto)
                                      .HasConversion(codigoProduto => codigoProduto!.Valor,
                                      value => CodigoProduto.Create(value)!);

        modelBuilder.Entity<Produto>().OwnsOne(p => p.Preco, precoBuilder =>
        {
            precoBuilder.Property(m => m.Moeda).HasMaxLength(3);
            precoBuilder.Property(m => m.Valor).HasColumnType("decimal(10,2)");
        });
    }
}
using Microsoft.EntityFrameworkCore;
using Products.Domain.Entities;
namespace Products.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(15, 2);
    }
    public DbSet<Product> Products => Set<Product>();

}

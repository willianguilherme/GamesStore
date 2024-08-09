using GamesStore.Persistence.Entities;
using GamesStore.Persistence.IdTypes;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Persistence.Context;

public class GamesStoreDbContext : DbContext
{
    public GamesStoreDbContext(DbContextOptions<GamesStoreDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        }

        modelBuilder.Entity<User>(user =>
        {
            user.Property(u => u.Id)
                .HasConversion(
                    id => id.ToGuid(),
                    id => new UserId(id));
        });
    }
}

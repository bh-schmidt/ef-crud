using Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Models.Caminhoes;
using SystemConfig;

namespace Data.Context
{
    public class EfCrudContext : DbContext
    {
        public DbSet<Caminhao> Caminhoes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(AppSettings.SqliteConnection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            BaseModelMap.Map(modelBuilder);
            modelBuilder.Entity<Caminhao>().ToTable("Caminhoes");
        }
    }
}

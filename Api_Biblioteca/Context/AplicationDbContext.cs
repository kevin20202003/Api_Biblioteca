using Api_Biblioteca.Model;
using Microsoft.EntityFrameworkCore;

namespace Api_Biblioteca.Context
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Libro>().HasIndex(c => c.titulo).IsUnique();
        }
    }
}

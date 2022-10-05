using Microsoft.EntityFrameworkCore;

namespace TpTeoEF.Models
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Labo4_TpEf2;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        public DbSet<Libro> libros { get; set; }

        public DbSet<Autor> Autores { get; set; }

        public DbSet<Genero> Generos { get; set; }
    }
}

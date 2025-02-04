using LojaLivrosASPNET.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaLivrosASPNET.Data
{
    // meio de campo entre o sql e o c#
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }

        public DbSet<LivroModel> Livros { get; set; }   

        // tem valores padroes ao iniciar 
        public DbSet<CategoriaModel> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaModel>().HasData(
                new CategoriaModel { Id = 1, Nome = "Ficção" },
                new CategoriaModel { Id = 2, Nome = "Não-ficção" },
                new CategoriaModel { Id = 3, Nome = "Literatura infantil e juvenil" },
                new CategoriaModel { Id = 4, Nome = "Poesia e teatro" },
                new CategoriaModel { Id = 5, Nome = "Acadêmico e educacional" },
                new CategoriaModel { Id = 6, Nome = "Arte e fotografia" }
                );
        }



    }
}

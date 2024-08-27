using Microsoft.EntityFrameworkCore;

namespace Cinemapravc.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Diretor> Diretores { get; set; }

    }
}

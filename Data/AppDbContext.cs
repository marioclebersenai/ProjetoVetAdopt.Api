using Microsoft.EntityFrameworkCore;
using ProjetoVetAdopt.Api.Models;

namespace ProjetoVetAdopt.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Abrigo> Abrigos { get; set; }
        public DbSet<Historico> Historicos { get; set; }
    }
}
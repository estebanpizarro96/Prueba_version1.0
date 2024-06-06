using Microsoft.EntityFrameworkCore;
using Prueba_version1._0.Models;

namespace Prueba_version1._0.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        public DbSet<GestionPersona> GestionPersonas  { get; set; } //colecciones

    }
}

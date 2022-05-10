using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class RegistryContext : DbContext
    {
        public RegistryContext(DbContextOptions<RegistryContext> options)
            : base(options)
        {
        }

        public DbSet<Registry> Registries { get; set; } = null!;
    }
}

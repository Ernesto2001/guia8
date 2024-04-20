using Microsoft.EntityFrameworkCore;
namespace guia8.Models
{
    public class GuiaDbContext : DbContext
    {
        public GuiaDbContext(DbContextOptions<GuiaDbContext> options) : base(options) { }

        public DbSet<formulario> formulario { get; set; }
    }
}

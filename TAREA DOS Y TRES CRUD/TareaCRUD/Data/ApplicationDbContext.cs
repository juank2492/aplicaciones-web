using Microsoft.EntityFrameworkCore;
using TareaCRUD.Models;

namespace TareaCRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes => Set<Cliente>();
    }
}

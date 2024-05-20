using Microsoft.EntityFrameworkCore;
using User_Shield.Domain.Entities;

namespace User_Shield.Infrastructure.Data.EntityFramework.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }

}

using MicroServices.Auth.EntityConfigurations;
using MicroServices.Auth.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroServices.Auth.Infrastructure
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityTypeConfiguration());
        }
    }
}

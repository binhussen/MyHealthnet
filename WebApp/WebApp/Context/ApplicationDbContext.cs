using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace WebApp.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Content> Content { get; set; }
        // public DbSet<sp_GetItemDetail> sp_GetItemDetail { get; set; }        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

    }
}

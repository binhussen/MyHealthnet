using CoreWebApi.Context;
using Microsoft.EntityFrameworkCore;
using Model.Models;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }       
        public DbSet<Application> Application { get; set; }
        public DbSet<Content> Content { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

    }
}

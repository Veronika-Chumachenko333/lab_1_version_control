using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lab2.Models;

namespace Lab2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }


        //new public DbSet<User> Users { get; set; }
        //public DbSet<RegisterInputModel> RegisterData { get; set; }
        //public DbSet<LoginInputModel> LoginData { get; set; }

    }
}
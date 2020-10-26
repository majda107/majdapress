using App.Database.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Database
{
    public class DatabaseContenxt : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public DbSet<Domain> Domains { get; set; }

        public DatabaseContenxt(DbContextOptions o) : base(o)
        {
        }
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ogrodnik_lab4_zad2.Components.Entities;

namespace Ogrodnik_lab4_zad2.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Ogrodnik_lab4_zad2.Components.Entities.Movie> Movie { get; set; } = default!;
    }
}

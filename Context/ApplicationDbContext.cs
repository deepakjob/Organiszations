using Horus.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Horus.Data.Entities
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options)
            : base(options)
        {
        }
        DbSet<Organiszation> Organiszations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 
            modelBuilder.Entity<Organiszation>()
                .Property(org => org.IsEnabled)
                .HasDefaultValue(false);

            modelBuilder.Entity<Organiszation>()
                    .Property(org => org.IsDeleted)
                    .HasDefaultValue(false);


        }

    }

}


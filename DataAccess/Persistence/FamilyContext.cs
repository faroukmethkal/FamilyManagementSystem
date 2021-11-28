using Entitiy;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence
{
    public class FamilyContext : DbContext
    {
        
        public DbSet<Family> Families { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source= F:/VIA/Third Semester/C#/ThierdAssignment/FamilyRegistration/DataAccess/Family.db");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Family>()
                .HasKey(fam => new {fam.StreetName, fam.HouseNumber});
           
            
        }
    }
}
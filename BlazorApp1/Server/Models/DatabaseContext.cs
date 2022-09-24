using BlazorApp1.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}
        public virtual DbSet<User>? Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("userdetails");
                entity.Property(e => e.Userid).HasColumnName("Userid");
                entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
                entity.Property(e => e.Address)
                   .HasMaxLength(500)
                   .IsUnicode(false);
                entity.Property(e => e.Cellnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Emailid)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}

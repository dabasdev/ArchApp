using Microsoft.EntityFrameworkCore;

namespace ArchApp.Models;

public partial class ArchDbContext : DbContext
{
    public ArchDbContext()
    {
    }

    public ArchDbContext(DbContextOptions<ArchDbContext> options) : base(options)
    {
    }

    public virtual DbSet<Store> Stores { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.;Database=ArchDb;Encrypt=False;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Store>(entity =>
        {
            entity.ToTable("Store");

            entity.Property(e => e.FileEx).HasMaxLength(5);
            entity.Property(e => e.TheFileName).HasColumnName("TheFileName");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    private static void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        //throw new NotImplementedException();
    }
}

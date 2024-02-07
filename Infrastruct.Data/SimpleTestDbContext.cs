using Microsoft.EntityFrameworkCore;
using OnionArcProject.Domain.Models;

namespace Infrastruct.Data;
public partial class SimpleTestDbContext : DbContext
{
    public SimpleTestDbContext()
    {
    }

    public SimpleTestDbContext(DbContextOptions<SimpleTestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Gpu> Gpus { get; set; }

    public virtual DbSet<Vender> Venders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=SimpleTestDB;Username=postgres;Password=vitalya122");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Gpu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("gpus_pkey");
             
            entity.ToTable("gpus");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Vender).WithMany(p => p.Gpus)
                .HasForeignKey(d => d.VenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("gpus_VenderId_fkey");
        });

        modelBuilder.Entity<Vender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("venders_pkey");

            entity.ToTable("venders");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MarketShare).HasColumnName("Market share");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

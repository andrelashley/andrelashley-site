using AndreLashley.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

public class DataContext : IdentityDbContext<ApplicationUser>
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Author>()
            .HasOne(a => a.ApplicationUser)
            .WithOne()
            .HasForeignKey<Author>(a => a.ApplicationUserId)
            .IsRequired(false);

        modelBuilder.Entity<Author>()
            .HasIndex(a => a.Slug)
            .IsUnique();
    }
}

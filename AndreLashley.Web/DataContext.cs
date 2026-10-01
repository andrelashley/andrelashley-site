using AndreLashley.Web.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<Skill> Skill { get; set; } = default!;
}

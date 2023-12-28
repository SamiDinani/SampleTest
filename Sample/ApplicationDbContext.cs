using Microsoft.EntityFrameworkCore;
using Sample.Models;

namespace Sample;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }

    // Seed data
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "1984", Author = "George Orwell", YearPublished = 1949 },
            new Book { Id = 2, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", YearPublished = 1925 }
        );
    }
}


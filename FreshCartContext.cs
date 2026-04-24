using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class FreshCartContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<GroceryItem> GroceryItems { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User
        {
            UserId = 1,
            FirstName = "System",
            LastName = "Admin",
            Address = "Office",
            UserName = "admin", // Use this to log in
            Password = "123"    // Use this to log in
        });

        modelBuilder.Entity<Category>().HasData(new Category
        {
            CategoryId = 1,
            CategoryName = "General",
            CategoryDescription = "Default Category"
        });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // This tells the app to use a simple file named GroceryDb.db instead of a complex SQL Server
        optionsBuilder.UseSqlite("Data Source=GroceryDb.db");
    }
    public FreshCartContext()
    {
        // This line forces the creation of the database and tables if they are missing
        this.Database.EnsureCreated();
    }

}

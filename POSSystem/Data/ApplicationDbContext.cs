using Microsoft.EntityFrameworkCore;
using POSSystem.Models.Address;
using POSSystem.Models.Customer_Management;
using POSSystem.Models.Enum;
using POSSystem.Models.Enum.Item;
using POSSystem.Models.Item_Management;
using POSSystem.Models.User_Management;
using System.Collections.Generic;

namespace POSSystem.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> User { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<Country> Country { get; set; }
    public DbSet<Picture> Picture { get; set; }
    public DbSet<Customer> Customer { get; set; }    
    public DbSet<Category> Categorys { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Vendor> Vendor { get; set; }
}

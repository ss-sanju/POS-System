using Microsoft.EntityFrameworkCore;
using POSSystem.Models.User_Management;
using System.Collections.Generic;

namespace POSSystem.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<User> User { get; set; }
    public DbSet<Roles> Roles { get; set; }
}

using GymDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace GymDataAccess;
public class GymDbContext : DbContext
{
    public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) { }
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
}

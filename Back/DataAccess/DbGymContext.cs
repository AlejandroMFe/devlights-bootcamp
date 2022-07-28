using GymDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace GymDataAccess;
public class DbGymContext : DbContext
{
    public DbGymContext(DbContextOptions<DbGymContext> options) : base(options)
    {        
    }
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    // No mapea esta entidad DaysAndHours
    //    // Sirve para hacer consultas
    //    modelBuilder.Entity<Activity>().Ignore(a => a.DaysAndHours); 
        
    //    // La entidad DayAndHour no tiene Id
    //    //modelBuilder.Entity<DayAndHour>().HasNoKey();
    //}
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Student> Students { get; set; }
}

using GymDataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace GymDataAccess;
public class GymDbContext : IdentityDbContext<
    AppUser, AppRole, int,
    IdentityUserClaim<int>,AppUserRole, IdentityUserLogin<int>,
    IdentityRoleClaim<int>, IdentityUserToken<int>>
{
    private readonly IConfiguration _configuration;
    public GymDbContext(DbContextOptions<GymDbContext> options) : base(options) { }
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Student> Students { get; set; }
    //public DbSet<AppUser> AppUsers { get; set; }

    public GymDbContext(DbContextOptions<GymDbContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<AppUser>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .IsRequired();

        builder.Entity<AppRole>()
            .HasMany(ur => ur.UserRoles)
            .WithOne(r => r.Role)
            .HasForeignKey(r => r.RoleId)
            .IsRequired();

        builder.Entity<AppRole>().HasData(
                new AppRole { Id = 1, Name = "Admin", NormalizedName = "ADMINISTRATOR"},
                new AppRole { Id = 2, Name = "Student", NormalizedName = "STUDENT"}
            );

        var user = new AppUser()
        {
            Id = 1,
            UserName = "Admin",
            NormalizedUserName = "ADMIN",
            Email = "admin@admin.com",
            NormalizedEmail = "ADMIN@ADMIN.COM"
        };

        builder.Entity<AppUser>().HasData(user);

        var passwordHasher = new PasswordHasher<AppUser>();
        user.PasswordHash = passwordHasher.HashPassword(user, "Admin123$");

        var userRole = new AppUserRole() { UserId = 1 , RoleId = 1};
        builder.Entity<AppUserRole>().HasData(userRole);
    }
}

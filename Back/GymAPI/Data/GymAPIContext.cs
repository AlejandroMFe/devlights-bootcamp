namespace GymAPI.Data
{
    public class GymAPIContext : DbContext
    {
        public GymAPIContext(DbContextOptions<GymAPIContext> options)
            : base(options)
        {
        }

        public DbSet<GymDataAccess.Models.Activity> Activity { get; set; } = default!;
    }
}

using GymDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace GymDataAccess.Repositories;
public class ActivityRepository : IActivityRepository
{
    private readonly GymDbContext _context;

    public ActivityRepository(GymDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Activity>> GetActivities()
    {
        return await _context.Activities.ToListAsync();
    }
}

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

    public async Task<bool> DeleteAsync(int Id)
    {
        var activity = await _context.Activities.FindAsync(Id);

        if (activity == null) return false;

        _context.Activities.Remove(activity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Activity>> GetActivities()
    {
        return await _context.Activities.Include(o => o.DaysAndHours).ToListAsync();
    }

    public Activity GetbyId(int Id)
    {
        throw new NotImplementedException();
    }

    public Activity Update(int Id, Activity activity)
    {
        throw new NotImplementedException();
    }
}

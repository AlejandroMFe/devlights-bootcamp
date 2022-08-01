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

    public async Task<Activity> AddAsync(Activity activity)
    {
        try
        {
            await _context.Activities.AddAsync(activity);
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }

        return activity;
    }

    public async Task<bool> DeleteAsync(int Id)
    {
        var activity = await _context.Activities.FindAsync(Id);

        if (activity == null) return false;

        _context.Activities.Remove(activity);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Activity>> GetActivitiesAsync()
    {
        return await _context.Activities.Include(o => o.DaysAndHours).ToListAsync();
    }

    public async Task<Activity> GetbyIdAsync(int Id)
    {
        var activity = await _context.Activities.Include(o => o.DaysAndHours).FirstOrDefaultAsync(o => o.Id == Id);
        return activity;
    }

    public async Task<IEnumerable<Student>> GetStudentsAsync(int activityId)
    {
        var activity = await _context.Activities.Include(s => s.Students).FirstOrDefaultAsync(a => a.Id == activityId);
        return  activity.Students.ToList();
    }

    public Activity Update(Activity UpdatedActivity)
    {
        try
        {
            _context.Update(UpdatedActivity);
            _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }

        return UpdatedActivity;
    }
}

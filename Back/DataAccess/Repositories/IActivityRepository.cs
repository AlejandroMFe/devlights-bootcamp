using GymDataAccess.Models;

namespace GymDataAccess.Repositories;
public interface IActivityRepository
{
    public Task<Activity> GetbyIdAsync(int id);
    public Task<IEnumerable<Activity>> GetActivitiesAsync();
    public Activity Update(Activity updateActivity);
    public Task<bool> DeleteAsync(int id);
    public Task<Activity> AddAsync(Activity activity);
    
    //TODO get list of Students
}

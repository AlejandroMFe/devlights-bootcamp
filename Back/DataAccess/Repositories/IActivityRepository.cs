using GymDataAccess.Models;

namespace GymDataAccess.Repositories;
public interface IActivityRepository
{
    public Activity Update(Activity updateActivity);
    public Task<bool> DeleteAsync(int id);
    public Task<Activity> GetbyIdAsync(int id);
    public Task<Activity> AddAsync(Activity activity);
    public Task<IEnumerable<Activity>> GetActivitiesAsync();
    public Task<IEnumerable<Student>> GetStudentsAsync(int activityId);
}

using GymDataAccess.Models;

namespace GymDataAccess.Repositories;
public interface IActivityRepository
{
    public Activity GetbyId(int Id);
    public Task<IEnumerable<Activity>> GetActivities();
    public Activity Update(int Id, Activity activity);
    public Task<bool> DeleteAsync(int Id);
}

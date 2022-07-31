using GymDataAccess.Models;

namespace GymDataAccess.Repositories;
public interface IActivityRepository
{
    public Task<IEnumerable<Activity>> GetActivities();
}

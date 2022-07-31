using GymDataAccess.DTOs;
using GymDataAccess.Models;

namespace GymBusiness.Services;

public interface IActivityService
{
    // CreateActivity
    public void AddActivity(ActivityDTO activity);

    // GetAll
    public Task<IEnumerable<ActivityDTO>> GetAllAsync();

    // GetById
    public Task<ActivityDTO> GetByIdAsync(int Id);

    // GetAllStudents
    public Task<IEnumerable<Student>> GetAllStudentsAsync(int ActivityId);

    // Update
    public Task<ActivityDTO> UpdateAsync(int Id, ActivityDTO UpdatedActivity);

    // Delete
    public Task<bool> DeleteActivityAsync(int Id);
}
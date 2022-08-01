using GymDataAccess.DTOs;

namespace GymBusiness.Services;

public interface IActivityService
{
    // CreateActivity
    public Task AddActivityAsync(ActivityDTO activity);

    // GetAll
    public Task<IEnumerable<ActivityDTO>> GetAllAsync();

    // GetById
    public Task<ActivityDTO> GetByIdAsync(int Id);

    // GetAllStudents
    public Task<IEnumerable<StudentDTO>> GetStudentsAsync(int ActivityId);

    // Update
    public Task<ActivityDTO> UpdateAsync(int Id, ActivityDTO UpdatedActivity);

    // Delete
    public Task<bool> DeleteActivityAsync(int Id);
}
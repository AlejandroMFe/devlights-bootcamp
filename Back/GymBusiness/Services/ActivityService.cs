using AutoMapper;
using GymDataAccess.DTOs;
using GymDataAccess.Models;
using GymDataAccess.Repositories;

namespace GymBusiness.Services;
public class ActivityService : IActivityService
{
    private readonly IActivityRepository _repository;
    private readonly IMapper _mapper;

    public ActivityService(IActivityRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<IEnumerable<ActivityDTO>> GetAllAsync()
    {
        var activites = await _repository.GetActivitiesAsync();
        var result = _mapper.Map<IEnumerable<ActivityDTO>>(activites);
        return result;
    }

    public async Task AddActivityAsync(ActivityDTO activity)
    {
        var newActivity = _mapper.Map<ActivityDTO, Activity>(activity);
        await _repository.AddAsync(newActivity);
    }

    public async Task<bool> DeleteActivityAsync(int Id)
    {
        try
        {
            await _repository.DeleteAsync(Id);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<IEnumerable<StudentDTO>> GetStudentsAsync(int ActivityId)
    {
        var students = await _repository.GetStudentsAsync(ActivityId);
        var result = _mapper.Map<IEnumerable<Student>, IEnumerable<StudentDTO>>(students);
        return result;
    }

    public async Task<ActivityDTO> GetByIdAsync(int Id)
    {
        var activity = await _repository.GetbyIdAsync(Id);
        return _mapper.Map<ActivityDTO>(activity);
    }

    public async Task<ActivityDTO> UpdateAsync(int Id, ActivityDTO UpdatedActivity)
    {
        var oldActivity = await _repository.GetbyIdAsync(Id);

        if (oldActivity == null) return null;

        oldActivity.Name = UpdatedActivity.Name;
        oldActivity.Price = UpdatedActivity.Price;
        oldActivity.Capacity = UpdatedActivity.Capacity;
        oldActivity.Professor = UpdatedActivity.Professor;
        oldActivity.DaysAndHours = oldActivity.DaysAndHours;

        _repository.Update(oldActivity);
        return UpdatedActivity;
    }
}

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
        var activites = await _repository.GetActivities();
        var result = _mapper.Map<IEnumerable<ActivityDTO>>(activites);
        return result;
    }

    public void AddActivity(ActivityDTO activity)
    {
        throw new NotImplementedException();
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

    public Task<IEnumerable<Student>> GetAllStudentsAsync(int ActivityId)
    {
        throw new NotImplementedException();
    }

    public Task<ActivityDTO> GetByIdAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<ActivityDTO> UpdateAsync(int Id, ActivityDTO UpdatedActivity)
    {
        throw new NotImplementedException();
    }
}

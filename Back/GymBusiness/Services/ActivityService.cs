using AutoMapper;
using GymDataAccess;
using GymDataAccess.DTOs;
using GymDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace GymBusiness.Services;
public class ActivityService : IActivityService
{
    private readonly GymDbContext _context;
    private readonly IMapper _mapper;

    public ActivityService(GymDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public void AddActivity(ActivityDTO activity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ActivityDTO>> GetAllAsync()
    {
        var activites = await _context.Activities.ToListAsync();
        var result = _mapper.Map<IEnumerable<ActivityDTO>>(activites);
        return result;
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

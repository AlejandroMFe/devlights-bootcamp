﻿using GymDataAccess.Models;

namespace GymDataAccess.Repositories;
public interface IActivityRepository
{
    public Task<Activity> GetbyIdAsync(int Id);
    public Task<IEnumerable<Activity>> GetActivitiesAsync();
    public Activity Update(Activity UpdateActivity);
    public Task<bool> DeleteAsync(int Id);
}

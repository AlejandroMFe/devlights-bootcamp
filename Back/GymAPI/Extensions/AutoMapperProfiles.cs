using AutoMapper;

namespace GymAPI.Extensions;

public class AutoMapperProfiles:Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Activity, ActivityDTO>();
        CreateMap<DayAndHour, DayAndHourDTO>();
    }
}

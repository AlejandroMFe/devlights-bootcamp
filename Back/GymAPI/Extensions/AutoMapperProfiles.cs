namespace GymAPI.Extensions;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Activity, ActivityDTO>().ReverseMap();
        CreateMap<DayAndHour, DayAndHourDTO>().ReverseMap();
    }
}

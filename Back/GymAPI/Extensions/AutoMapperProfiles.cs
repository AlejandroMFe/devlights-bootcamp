namespace GymAPI.Extensions;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Student, StudentDTO>().ReverseMap();
        CreateMap<Activity, ActivityDTO>().ReverseMap();
        CreateMap<DayAndHour, DayAndHourDTO>().ReverseMap();
    }
}

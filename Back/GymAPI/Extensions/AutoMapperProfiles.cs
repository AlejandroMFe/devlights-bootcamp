namespace GymAPI.Extensions;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Student, StudentDTO>().ReverseMap();
        CreateMap<Activity, ActivityDTO>().ReverseMap();
        CreateMap<DayAndHour, DayAndHourDTO>().ReverseMap();
        CreateMap<AppUser, UserDTO>().ReverseMap();
        CreateMap<AppUser, StudentDTO>().ReverseMap();
        CreateMap<AppUser, RegisterDTO>().ReverseMap();
        CreateMap<Student, RegisterDTO>().ReverseMap();
    }
}

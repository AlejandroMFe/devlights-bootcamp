namespace GymDataAccess.DTOs;

public record UserDTO(string UserName, string Token);
public record LoginDTO(string UserName, string Password);
public record RegisterDTO(
    string UserName,
    string Password,
    string Name,
    string PhoneNumber,
    string Email,
    DateTime Birthday);
public record DayAndHourDTO(DayOfWeek Day, string HourStart, string HourEnd);
//public record StudentDTO(
//    string Email, 
//    //string Password, 
//    string Name,
//    DateTime Birthday,
//    string PhoneNumber,
//    string Token);
public record ActivityDTO(string Name, string Professor, int Capacity, float Price, List<DayAndHourDTO> DaysAndHours);
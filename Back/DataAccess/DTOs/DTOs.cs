namespace GymDataAccess.DTOs;

public record UserDTO(string UserName, string Token);
public record LoginDTO(string Username, string Password);
public record RegisterDTO(string Username, string Password);
public record DayAndHourDTO(DayOfWeek Day, string HourStart, string HourEnd);
public record StudentDTO(string Email, string Password, string Name, DateTime Birthday, string PhoneNumber);
public record ActivityDTO(string Name, string Professor, int Capacity, float Price, List<DayAndHourDTO> DaysAndHours);
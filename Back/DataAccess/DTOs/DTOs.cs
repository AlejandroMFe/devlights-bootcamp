namespace GymDataAccess.DTOs;

public record StudentDTO(string Email, string Password, string Name, DateTime Birthday, string PhoneNumber);
public record DayAndHourDTO(DayOfWeek Day, string HourStart, string HourEnd);
public record ActivityDTO(string Name, string Professor, int Capacity, float Price, List<DayAndHourDTO> DaysAndHours);
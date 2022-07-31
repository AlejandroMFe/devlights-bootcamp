namespace GymDataAccess.DTOs;


public record DayAndHourDTO(DayOfWeek Day, string HourStart, string HourEnd);
public record ActivityDTO(string Name, string Professor, string Capacity, float Price, List<DayAndHourDTO> DaysAndHours);
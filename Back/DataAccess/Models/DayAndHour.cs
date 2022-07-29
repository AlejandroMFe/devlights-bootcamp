namespace GymDataAccess.Models;
public class DayAndHour
{
    public int Id { get; set; }
    public DayOfWeek Day { get; set; }
    public string HourStart { get; set; }
    public string HourEnd { get; set; }

    // Relations
    public ICollection<Activity> Activties { get; set; } // many-to-many
}

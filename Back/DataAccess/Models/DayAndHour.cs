namespace GymDataAccess.Models;
public class DayAndHour
{
    public DayAndHour()
    {
        Activties = new HashSet<Activity>();
    }
    public int Id { get; set; }
    public DayOfWeek Day { get; set; }
    public string HourStart { get; set; }
    public string HourEnd { get; set; }

    // Relations
    // many-to-many
    public ICollection<Activity> Activties { get; set; }
}

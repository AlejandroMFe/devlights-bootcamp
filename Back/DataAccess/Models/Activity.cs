namespace GymDataAccess.Models;


public class Activity
{
    public Activity()
    {
        Students = new HashSet<Student>();
        DaysAndHours = new HashSet<DayAndHour>();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string Professor { get; set; }
    public int Capacity { get; set; }
    public float Price { get; set; }

    // Relations
    // many-to-many
    public ICollection<Student> Students { get; set; }
    public ICollection<DayAndHour> DaysAndHours { get; set; }
}

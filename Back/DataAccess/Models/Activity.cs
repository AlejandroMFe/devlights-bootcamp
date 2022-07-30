namespace GymDataAccess.Models;


public class Activity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Professor { get; set; }
    public int Capacity { get; set; }
    public float Price { get; set; }

    // Relations
    public ICollection<Student> Students { get; set; }  // many-to-many
    public ICollection<DayAndHour> DaysAndHours { get; set; }
}

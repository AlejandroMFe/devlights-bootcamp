using Microsoft.EntityFrameworkCore;

namespace GymDataAccess.Models;


public class Activity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Professor { get; set; }
    public int Capacity { get; set; }
    public string Hour { get; set; }
    public List<DayAndHour> DaysAndHours { get; set; }
    public float Price { get; set; }

    // Relations
    public int StudentId { get; set; }
    public IEnumerable<Student> Students { get; set; } = Enumerable.Empty<Student>();
}

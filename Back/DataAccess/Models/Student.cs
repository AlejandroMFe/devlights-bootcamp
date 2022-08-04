namespace GymDataAccess.Models;
public class Student : AppUser
{
    public Student()
    {
        Activities = new HashSet<Activity>();
    }
    //public int Id { get; set; }
    public string Email { get; set; }
    //public string Password { get; set; }
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public string PhoneNumber { get; set; }

    // Relations
    public ICollection<Activity> Activities { get; set; }
}

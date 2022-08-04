using GymDataAccess;
using GymDataAccess.Models;

namespace GymBusiness.Services;
public class DataSeedService
{
    private readonly GymDbContext _context;

    public DataSeedService(GymDbContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        // create five object from GymDataAccess.Models.Activity class
        // and add them to the GymDbContext.Activities collection
        // and save the changes to the database
        if (!_context.Activities.Any())
        {
            _context.Activities.AddRange(
                new Activity
                {

                    Name = "Running",
                    Capacity = 10,
                    Professor = "Usaint Bolt",
                    Price = 150,
                    DaysAndHours = new List<DayAndHour>(new[]
                    {
                        new DayAndHour { Day = DayOfWeek.Monday, HourStart = "08:00", HourEnd="09:30" },
                        new DayAndHour { Day = DayOfWeek.Tuesday, HourStart = "08:00", HourEnd="09:30" },
                        new DayAndHour { Day = DayOfWeek.Wednesday, HourStart = "08:00", HourEnd="09:30" },
                        new DayAndHour { Day = DayOfWeek.Thursday, HourStart = "08:00", HourEnd="09:30" },
                        new DayAndHour { Day = DayOfWeek.Friday, HourStart = "08:00", HourEnd="09:30" },
                        new DayAndHour { Day = DayOfWeek.Saturday, HourStart = "08:00", HourEnd="09:30" },
                        new DayAndHour { Day = DayOfWeek.Sunday, HourStart = "08:00", HourEnd="09:30" }
                    })
                },
                new Activity
                {

                    Name = "Basketball",
                    Capacity = 10,
                    Professor = "Michael Jordan",
                    Price = 500,
                    DaysAndHours = new List<DayAndHour>(new[]
                    {
                        new DayAndHour { Day = DayOfWeek.Monday, HourStart = "21:30", HourEnd="23:00" },
                        new DayAndHour { Day = DayOfWeek.Wednesday, HourStart = "21:30", HourEnd="23:00" },
                        new DayAndHour { Day = DayOfWeek.Friday, HourStart = "21:30", HourEnd="23:00" }
                    })
                },
                new Activity
                {

                    Name = "Swiming",
                    Capacity = 7,
                    Professor = "Michael Phelps",
                    Price = 750,
                    DaysAndHours = new List<DayAndHour>(new[]
                    {
                        new DayAndHour { Day = DayOfWeek.Monday, HourStart = "06:30", HourEnd="09:00" },
                        new DayAndHour { Day = DayOfWeek.Tuesday, HourStart = "06:30", HourEnd="09:00" },
                        new DayAndHour { Day = DayOfWeek.Wednesday, HourStart = "06:30", HourEnd="09:00" },
                        new DayAndHour { Day = DayOfWeek.Thursday, HourStart = "06:30", HourEnd="09:00" },
                        new DayAndHour { Day = DayOfWeek.Friday, HourStart = "06:30", HourEnd="09:00" },
                        new DayAndHour { Day = DayOfWeek.Saturday, HourStart = "06:30", HourEnd="09:00" },
                        new DayAndHour { Day = DayOfWeek.Sunday, HourStart = "06:30", HourEnd="09:00" }
                    })
                },
                new Activity
                {

                    Name = "CrossFit",
                    Capacity = 5,
                    Professor = "Jolie Gentry",
                    Price = 150,
                    DaysAndHours = new List<DayAndHour>(new[]
                    {
                        new DayAndHour { Day = DayOfWeek.Wednesday, HourStart = "14:00", HourEnd="15:00" },
                        new DayAndHour { Day = DayOfWeek.Thursday, HourStart = "14:00", HourEnd="15:00" },
                        new DayAndHour { Day = DayOfWeek.Friday, HourStart = "14:00", HourEnd="15:00" },
                        new DayAndHour { Day = DayOfWeek.Saturday, HourStart = "14:00", HourEnd="15:00" }
                    })
                },
                new Activity
                {

                    Name = "Weightlifting",
                    Capacity = 10,
                    Professor = "Popeye",
                    Price = 435,
                    DaysAndHours = new List<DayAndHour>(new[]
                    {
                        new DayAndHour { Day = DayOfWeek.Monday, HourStart = "18:00", HourEnd="19:30" },
                        new DayAndHour { Day = DayOfWeek.Tuesday, HourStart = "18:00", HourEnd="19:30" },
                        new DayAndHour { Day = DayOfWeek.Wednesday, HourStart = "18:00", HourEnd="19:30" },
                        new DayAndHour { Day = DayOfWeek.Thursday, HourStart = "18:00", HourEnd="19:30" },
                        new DayAndHour { Day = DayOfWeek.Friday, HourStart = "18:00", HourEnd="19:30" }
                    })
                }
            );
            _context.SaveChanges();
        }

        // generate a list of students and add them to the GymDbContext.Students collection
        // and save the changes to the database
        if (!_context.Students.Any())
        {
            _context.Students.AddRange(
                // basket
                new Student
                {
                    Name = "John",
                    Email = "john@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>(new[]
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 2),
                        _context.Activities.FirstOrDefault(a => a.Id == 3)
                    })
                },
                new Student
                {
                    Name = "Mary",
                    Email = "mary@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>(new[]
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 2),
                        _context.Activities.FirstOrDefault(a => a.Id == 3)
                    })
                },
                new Student
                {
                    Name = "Bob",
                    Email = "bob@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>(new[]
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 2),
                        _context.Activities.FirstOrDefault(a => a.Id == 3)
                    })
                },
                new Student
                {
                    Name = "Jane",
                    Email = "jane@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>(new[]
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 2),
                        _context.Activities.FirstOrDefault(a => a.Id == 3)
                    })
                },
                new Student
                {
                    Name = "Tom",
                    Email = "tom@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>(new[]
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 2),
                        _context.Activities.FirstOrDefault(a => a.Id == 3)
                    })

                }, new Student
                {
                    Name = "John",
                    Email = "john@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>(new[]
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 2),
                        _context.Activities.FirstOrDefault(a => a.Id == 5)
                    })
                },
                new Student
                {
                    Name = "Mary",
                    Email = "mary@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>()
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 2),
                        _context.Activities.FirstOrDefault(a => a.Id == 4)
                    }
                },
                new Student
                {
                    Name = "Bob",
                    Email = "bob@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>()
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 4),
                        _context.Activities.FirstOrDefault(a => a.Id == 5)
                    }
                },
                new Student
                {
                    Name = "Jane",
                    Email = "jane@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>()
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 4),
                        _context.Activities.FirstOrDefault(a => a.Id == 5)
                    }
                },
                new Student
                {
                    Name = "Tom",
                    Email = "tom@gmail.com",
                    PhoneNumber = "123456789",
                    Birthday = new DateTime(2000, 1, 1),
                    //Password = "123456",
                    Activities = new List<Activity>()
                    {
                        _context.Activities.FirstOrDefault(a => a.Id == 1),
                        _context.Activities.FirstOrDefault(a => a.Id == 2),
                        _context.Activities.FirstOrDefault(a => a.Id == 5)
                    }
                }
            );
            _context.SaveChanges();
        }

    }
}

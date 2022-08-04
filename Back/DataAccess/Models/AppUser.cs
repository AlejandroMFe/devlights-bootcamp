using Microsoft.AspNetCore.Identity;

namespace GymDataAccess.Models
{
    public class AppUser : IdentityUser<int>
    {
        //public int ID { get; set; }
        //public string UserName { get; set; }
        //public byte[] PasswordHash { get; set; }
        //public byte[] PasswordSalt { get; set; }

        public IEnumerable<AppUserRole> UserRoles { get; set; }

    }
}

using GymDataAccess.Models;

namespace GymBusiness.Services
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}

using GymDataAccess.Models;

namespace GymBusiness.Services
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}

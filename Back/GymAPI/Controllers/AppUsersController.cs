using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly GymDbContext _context;

        public AppUsersController(GymDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return Ok(_context.AppUsers.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return Ok(_context.AppUsers.Find(id));
        }
    }
}

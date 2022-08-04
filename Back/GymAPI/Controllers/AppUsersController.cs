using Microsoft.AspNetCore.Authorization;

namespace GymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppUsersController : ControllerBase
    {
        private readonly GymDbContext _context;

        public AppUsersController(GymDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return Ok(_context.Users.ToList());
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUser(int id)
        {
            return Ok(_context.Users.Find(id));
        }
    }
}

using System.Security.Cryptography;
using System.Text;

namespace GymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly GymDbContext _context;
        private readonly ITokenService _tokenService;

        public AccountController(GymDbContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public ActionResult<UserDTO> Login(LoginDTO login)
        {
            var user = _context.AppUsers.SingleOrDefault(x => x.UserName == login.Username);

            if (user == null) return Unauthorized("Invalid");

            using var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(login.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid");
            }

            var token = _tokenService.CreateToken(user);
            var userDto = new UserDTO(login.Username, token);

            return Ok(userDto);
        }

        [HttpPost("register")]
        public ActionResult<UserDTO> Register(RegisterDTO user)
        {
            if (UserExist(user.Username)) return BadRequest("Username is already taken");

            using var hmac = new HMACSHA512();

            var newUser = new AppUser()
            {
                UserName = user.Username,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password)),
                PasswordSalt = hmac.Key
            };

            _context.AppUsers.Add(newUser);
            _context.SaveChanges();

            var token = _tokenService.CreateToken(newUser);
            var userDto = new UserDTO(user.Username, token);

            return Ok(userDto);
        }

        private bool UserExist(string username)
        {
            return _context.AppUsers.Any(x => x.UserName == username);
        }
    }
}

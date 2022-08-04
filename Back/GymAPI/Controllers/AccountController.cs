using Microsoft.AspNetCore.Identity;
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
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public AccountController(GymDbContext context, ITokenService tokenService, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager,IMapper mapper)
        {
            _context = context;
            _tokenService = tokenService;
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<ActionResult<StudentDTO>> Login(LoginDTO login)
        {
            var user = _userManager.Users.SingleOrDefault(x => x.UserName == login.UserName);

            if (user == null) return Unauthorized("Invalid username or password");

            //using var hmac = new HMACSHA512(user.PasswordSalt);

            //var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(login.Password));

            //for (int i = 0; i < computedHash.Length; i++)
            //{
            //    if (computedHash[i] != user.PasswordHash[i]) return Unauthorized("Invalid");
            //}

            var result = await _signInManager.CheckPasswordSignInAsync(user, login.Password,false);
            if (!result.Succeeded) return Unauthorized("Invalid");

            var token = await _tokenService.CreateToken(user);
            
            //var userDto = new UserDTO(login.Username, token);

            var studentDto = _mapper.Map<StudentDTO>(user);
            
            studentDto.Token = token;
            
            return Ok(studentDto);
        }

        [HttpPost("register")]
        public async Task<ActionResult<StudentDTO>> Register(RegisterDTO user)
        {
            if (UserExist(user.Username)) return BadRequest("Username is already taken");

            //using var hmac = new HMACSHA512();

            //var newUser = new AppUser()
            //{
            //    UserName = user.Username,
            //    PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password)),
            //    PasswordSalt = hmac.Key
            //};

            //_context.AppUsers.Add(newUser);
            //_context.SaveChanges();

            var newStudent = _mapper.Map<Student>(user);
            newStudent.UserName = user.Username;

            var result = await _userManager.CreateAsync(newStudent, user.Password);
            if(!result.Succeeded) return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(newStudent, "Student");
            Console.WriteLine(_userManager.GetRolesAsync(newStudent));
            if(!roleResult.Succeeded) return BadRequest(roleResult.Errors);

            var token = await _tokenService.CreateToken(newStudent);
            var studentDto = _mapper.Map<StudentDTO>(newStudent);
            studentDto.Token = token;

            return Ok(studentDto);
        }

        private bool UserExist(string username)
        {
            return _userManager.Users.Any(x => x.UserName == username);
        }
    }
}

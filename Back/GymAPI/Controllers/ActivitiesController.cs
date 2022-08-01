namespace GymAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivitiesController : ControllerBase
    {
        private readonly IActivityService _activityService;
        private readonly GymDbContext _context;

        public ActivitiesController(IActivityService activityService, GymDbContext context)
        {
            _activityService = activityService;
            _context = context;
        }

        // GET: api/Activities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActivityDTO>>> GetActivity()
        {
            var result = await _activityService.GetAllAsync();

            if (result == null) return NotFound();

            return Ok(result);
        }

        // GET: api/Activities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Activity>> GetActivity(int id)
        {
            var activity = await _activityService.GetByIdAsync(id);

            if (activity == null) return NotFound();

            return Ok(activity);
        }

        // GET: api/Activities/5/Students
        [HttpGet("{id}/Students")]
        public async Task<ActionResult<Activity>> GetStudentsByActivity(int id)
        {
            //TODO get all students name from the id activity

            var activity = await _activityService.GetByIdAsync(id);

            if (activity == null) return NotFound();

            return Ok(activity);
        }


        // PUT: api/Activities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActivity(int id, ActivityDTO activity)
        {
            await _activityService.UpdateAsync(id, activity);
            return NoContent();
        }

        // POST: api/Activities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Activity>> PostActivity(ActivityDTO activity)
        {
            await _activityService.AddActivityAsync(activity);

            return CreatedAtAction("GetActivity", new { name = activity.Name }, activity);
        }

        // DELETE: api/Activities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(int id)
        {
            var result = await _activityService.DeleteActivityAsync(id);

            if (!result) return NotFound();

            return NoContent();
        }

        //private bool ActivityExists(int id)
        //{
        //    return (_context.Activities?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}

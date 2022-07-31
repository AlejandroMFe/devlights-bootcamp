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
        public async Task<ActionResult<Activity>> PostActivity(Activity activity)
        {
            if (_context.Activities == null)
            {
                return Problem("Entity set 'GymAPIContext.Activities'  is null.");
            }
            _context.Activities.Add(activity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActivity", new { id = activity.Id }, activity);
        }

        // DELETE: api/Activities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(int id)
        {
            var result = await _activityService.DeleteActivityAsync(id);

            if (!result) return NotFound();

            return NoContent();
        }

        private bool ActivityExists(int id)
        {
            return (_context.Activities?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PlaylistService.Model;
using PlaylistServices.Data;
namespace PlaylistService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistController : ControllerBase
    {
        private readonly AppDbContext _context;
        public PlaylistController(AppDbContext context) => _context = context;

        [HttpGet]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<PlaylistItem>> GetAll() => Ok(_context.PlaylistItems.ToList());

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public ActionResult<PlaylistItem> Get(int id)
        {
            var item = _context.PlaylistItems.Find(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult Create(PlaylistItem item)
        {
            _context.PlaylistItems.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult Update(int id, PlaylistItem item)
        {
            if (!_context.PlaylistItems.Any(e => e.Id == id)) return NotFound();
            item.Id = id;
            _context.Update(item);
            _context.SaveChanges();
            return Ok(item);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult Delete(int id)
        {
            var item = _context.PlaylistItems.Find(id);
            if (item == null) return NotFound();
            _context.Remove(item);
            _context.SaveChanges();
            return Ok();
        }
    }
}

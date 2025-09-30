using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using primer_parcialAPI.Data;
using primer_parcialAPI.Models;

namespace primer_parcialAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EventsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return await _context.Events.ToListAsync();
        }

        // GET: api/events/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var evento = await _context.Events.FindAsync(id);
            if (evento == null) return NotFound();
            return evento;
        }

        // POST: api/events
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(Event evento)
        {
            _context.Events.Add(evento);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEvent), new { id = evento.Id }, evento);
        }

        // PUT: api/events/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent(int id, Event evento)
        {
            if (id != evento.Id) return BadRequest();

            _context.Entry(evento).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/events/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var evento = await _context.Events.FindAsync(id);
            if (evento == null) return NotFound();

            _context.Events.Remove(evento);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
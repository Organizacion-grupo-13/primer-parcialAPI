using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using primer_parcialAPI.Data;
using primer_parcialAPI.Models;

namespace primer_parcialAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupportTicketsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SupportTicketsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/supporttickets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportTicket>>> GetSupportTickets()
        {
            return await _context.SupportTickets.ToListAsync();
        }

        // GET: api/supporttickets/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportTicket>> GetSupportTicket(int id)
        {
            var ticket = await _context.SupportTickets.FindAsync(id);
            if (ticket == null) return NotFound();
            return ticket;
        }

        // POST: api/supporttickets
        [HttpPost]
        public async Task<ActionResult<SupportTicket>> PostSupportTicket(SupportTicket ticket)
        {
            _context.SupportTickets.Add(ticket);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSupportTicket), new { id = ticket.Id }, ticket);
        }

        // PUT: api/supporttickets/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupportTicket(int id, SupportTicket ticket)
        {
            if (id != ticket.Id) return BadRequest();

            _context.Entry(ticket).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/supporttickets/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupportTicket(int id)
        {
            var ticket = await _context.SupportTickets.FindAsync(id);
            if (ticket == null) return NotFound();

            _context.SupportTickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

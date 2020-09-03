using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LMSStudent.Models;

namespace LMSStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly AttendeeContext _context;

        public AttendeesController(AttendeeContext context)
        {
            _context = context;
        }

        // GET: api/Attendees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Attendee>>> GetAttendees()
        {
            return await _context.Attendees.ToListAsync();
        }

        // GET: api/Attendees/5/3
        [HttpGet("{idstudent}/{idevent}")]
        public async Task<ActionResult<Attendee>> GetAttendee(long idstudent, int idevent)
        {
            var attendee = await _context.Attendees.FindAsync(idstudent, idevent);

            if (attendee == null)
            {
                return NotFound();
            }

            return attendee;
        }

        // PUT: api/Attendees/5/3
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{idstudent}/{idevent}")]
        public async Task<IActionResult> PutAttendee(long idstudent, int idevent, Attendee attendee)
        {
            if (idstudent != attendee.IdStudent || idevent != attendee.IdEvent)
            {
                return BadRequest();
            }

            _context.Entry(attendee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttendeeExists(idstudent, idevent))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Attendees
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Attendee>> PostAttendee(Attendee attendee)
        {
            _context.Attendees.Add(attendee);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AttendeeExists(attendee.IdStudent, attendee.IdEvent))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAttendee", new { idstudent = attendee.IdStudent, idevent = attendee.IdEvent }, attendee);
        }

        // DELETE: api/Attendees/5/3
        [HttpDelete("{idstudent}/{idevent}")]
        public async Task<ActionResult<Attendee>> DeleteAttendee(long idstudent, int idevent)
        {
            var attendee = await _context.Attendees.FindAsync(idstudent, idevent);
            if (attendee == null)
            {
                return NotFound();
            }

            _context.Attendees.Remove(attendee);
            await _context.SaveChangesAsync();

            return attendee;
        }

        private bool AttendeeExists(long _idstudent, int _idevent)
        {
            return _context.Attendees.Any(e => e.IdStudent == _idstudent && e.IdEvent == _idevent);
        }
    }
}

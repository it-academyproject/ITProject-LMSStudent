using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMSStudent.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LMSStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItinerariesController : ControllerBase
    {
        private readonly LMSStudentContext _context;

        public ItinerariesController(LMSStudentContext context)
        {
            _context = context;
        }

        // GET: api/Itineraries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Itinerary>>> GetItineraries()
        {
            return await _context.Itineraries
                .ToListAsync();
        }
    }
}

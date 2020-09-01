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
    public class TeachingMaterialsController : ControllerBase
    {
        private readonly LMSStudentDBContext _context;

        public TeachingMaterialsController(LMSStudentDBContext context)
        {
            _context = context;
        }

        // GET: api/TeachingMaterials
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeachingMaterial>>> GetTeachingMaterials()
        {
            return await _context.TeachingMaterials
                .Include(t => t.Resource)
                .ThenInclude(r => r.Topic)
                .ToListAsync();
        }

        // GET: api/TeachingMaterials/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeachingMaterial>> GetTeachingMaterial(int id)
        {
            var teachingMaterial = await _context.TeachingMaterials.FindAsync(id);

            if (teachingMaterial == null)
            {
                return NotFound();
            }

            return teachingMaterial;
        }

        // PUT: api/TeachingMaterials/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeachingMaterial(int id, TeachingMaterial teachingMaterial)
        {
            if (id != teachingMaterial.Id)
            {
                return BadRequest();
            }

            _context.Entry(teachingMaterial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeachingMaterialExists(id))
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

        // POST: api/TeachingMaterials
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TeachingMaterial>> PostTeachingMaterial(TeachingMaterial teachingMaterial)
        {
            _context.TeachingMaterials.Add(teachingMaterial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeachingMaterial", new { id = teachingMaterial.Id }, teachingMaterial);
        }

        // DELETE: api/TeachingMaterials/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeachingMaterial>> DeleteTeachingMaterial(int id)
        {
            var teachingMaterial = await _context.TeachingMaterials.FindAsync(id);
            if (teachingMaterial == null)
            {
                return NotFound();
            }

            _context.TeachingMaterials.Remove(teachingMaterial);
            await _context.SaveChangesAsync();

            return teachingMaterial;
        }

        private bool TeachingMaterialExists(int id)
        {
            return _context.TeachingMaterials.Any(e => e.Id == id);
        }
    }
}

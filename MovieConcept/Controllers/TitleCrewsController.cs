using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieConcept;
using MovieConcept.Data;

namespace MovieConcept.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TitleCrewsController : ControllerBase
    {
        private readonly imdbOriginalContext _context;

        public TitleCrewsController(imdbOriginalContext context)
        {
            _context = context;
        }

        // GET: api/TitleCrews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TitleCrew>>> GetTitleCrew()
        {
          if (_context.TitleCrew == null)
          {
              return NotFound();
          }
            return await _context.TitleCrew.ToListAsync();
        }

        // GET: api/TitleCrews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TitleCrew>> GetTitleCrew(string id)
        {
          if (_context.TitleCrew == null)
          {
              return NotFound();
          }
            var titleCrew = await _context.TitleCrew.FindAsync(id);

            if (titleCrew == null)
            {
                return NotFound();
            }

            return titleCrew;
        }

        // PUT: api/TitleCrews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTitleCrew(string id, TitleCrew titleCrew)
        {
            if (id != titleCrew.CrewId)
            {
                return BadRequest();
            }

            _context.Entry(titleCrew).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TitleCrewExists(id))
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

        // POST: api/TitleCrews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TitleCrew>> PostTitleCrew(TitleCrew titleCrew)
        {
          if (_context.TitleCrew == null)
          {
              return Problem("Entity set 'imdbOriginalContext.TitleCrew'  is null.");
          }
            _context.TitleCrew.Add(titleCrew);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TitleCrewExists(titleCrew.CrewId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTitleCrew", new { id = titleCrew.CrewId }, titleCrew);
        }

        // DELETE: api/TitleCrews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTitleCrew(string id)
        {
            if (_context.TitleCrew == null)
            {
                return NotFound();
            }
            var titleCrew = await _context.TitleCrew.FindAsync(id);
            if (titleCrew == null)
            {
                return NotFound();
            }

            _context.TitleCrew.Remove(titleCrew);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TitleCrewExists(string id)
        {
            return (_context.TitleCrew?.Any(e => e.CrewId == id)).GetValueOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieConcept;

namespace MovieConcept.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TConstSearchController : ControllerBase
    {
        private readonly imdbOriginalContext _context;

        public TConstSearchController(imdbOriginalContext context)
        {
            _context = context;
        }

        // GET: api/TConstSearch
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TitleBasics>>> GetTitleBasics()
        {
          if (_context.TitleBasics == null)
          {
              return NotFound();
          }
            return await _context.TitleBasics.ToListAsync();
        }

        // GET: api/TConstSearch/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TitleBasics>> GetTitleBasics(string id)
        {
          if (_context.TitleBasics == null)
          {
              return NotFound();
          }
            var titleBasics = await _context.TitleBasics.FindAsync(id);

            if (titleBasics == null)
            {
                return NotFound();
            }

            return titleBasics;
        }

        // PUT: api/TConstSearch/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTitleBasics(string id, TitleBasics titleBasics)
        {
            if (id != titleBasics.Tconst)
            {
                return BadRequest();
            }

            _context.Entry(titleBasics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TitleBasicsExists(id))
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

        // POST: api/TConstSearch
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TitleBasics>> PostTitleBasics(TitleBasics titleBasics)
        {
          if (_context.TitleBasics == null)
          {
              return Problem("Entity set 'imdbOriginalContext.TitleBasics'  is null.");
          }
            _context.TitleBasics.Add(titleBasics);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TitleBasicsExists(titleBasics.Tconst))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTitleBasics", new { id = titleBasics.Tconst }, titleBasics);
        }

        // DELETE: api/TConstSearch/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTitleBasics(string id)
        {
            if (_context.TitleBasics == null)
            {
                return NotFound();
            }
            var titleBasics = await _context.TitleBasics.FindAsync(id);
            if (titleBasics == null)
            {
                return NotFound();
            }

            _context.TitleBasics.Remove(titleBasics);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TitleBasicsExists(string id)
        {
            return (_context.TitleBasics?.Any(e => e.Tconst == id)).GetValueOrDefault();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieConcept;
using MovieConcept.Model;

namespace MovieConcept.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieTitles1Controller : ControllerBase
    {
        private readonly imdbOriginalContext _context;

        public MovieTitles1Controller(imdbOriginalContext context)
        {
            _context = context;
        }

        // GET: api/MovieTitles1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieTitle>>> GetMovieTitles()
        {
            return await _context.MovieTitles.ToListAsync();
        }

        // GET: api/MovieTitles1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieTitle>> GetMovieTitle(string id)
        {
            var movieTitle = await _context.MovieTitles.FindAsync(id);

            if (movieTitle == null)
            {
                return NotFound();
            }

            return movieTitle;
        }

        // PUT: api/MovieTitles1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovieTitle(string id, MovieTitle movieTitle)
        {
            if (id != movieTitle.Tconst)
            {
                return BadRequest();
            }

            _context.Entry(movieTitle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieTitleExists(id))
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

        // POST: api/MovieTitles1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MovieTitle>> PostMovieTitle(MovieTitle movieTitle)
        {
            _context.MovieTitles.Add(movieTitle);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MovieTitleExists(movieTitle.Tconst))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMovieTitle", new { id = movieTitle.Tconst }, movieTitle);
        }

        // DELETE: api/MovieTitles1/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieTitle(string id)
        {
            var movieTitle = await _context.MovieTitles.FindAsync(id);
            if (movieTitle == null)
            {
                return NotFound();
            }

            _context.MovieTitles.Remove(movieTitle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MovieTitleExists(string id)
        {
            return _context.MovieTitles.Any(e => e.Tconst == id);
        }
    }
}

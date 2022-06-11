using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentManagement.Domain.Models;
using RentManagement.Infrastructure.Contrct;

namespace RentManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertsController : ControllerBase
    {
        private readonly RentDbContext _context;

        public AdvertsController(RentDbContext context)
        {
            _context = context;
        }

        // GET: api/Adverts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Advert>>> GetAdverts()
        {
          if (_context.Adverts == null)
          {
              return NotFound();
          }
            return await _context.Adverts.ToListAsync();
        }

        // GET: api/Adverts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Advert>> GetAdvert(Guid id)
        {
          if (_context.Adverts == null)
          {
              return NotFound();
          }
            var advert = await _context.Adverts.FindAsync(id);

            if (advert == null)
            {
                return NotFound();
            }

            return advert;
        }

        // PUT: api/Adverts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdvert(Guid id, Advert advert)
        {
            if (id != advert.AdvartID)
            {
                return BadRequest();
            }

            _context.Entry(advert).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch 
            {
                StatusCode(StatusCodes.Status500InternalServerError, "Something want Wrong!");
            }

            return NoContent();
        }

        // POST: api/Adverts
        [HttpPost]
        public async Task<ActionResult<Advert>> PostAdvert(Advert advert)
        {
          if (_context.Adverts == null)
          {
              return Problem("Entity set 'RentDbContext.Adverts'  is null.");
          }
            _context.Adverts.Add(advert);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdvert", new { id = advert.AdvartID }, advert);
        }

        // DELETE: api/Adverts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdvert(Guid id)
        {
            if (_context.Adverts == null)
            {
                return NotFound();
            }
            var advert = await _context.Adverts.FindAsync(id);
            if (advert == null)
            {
                return NotFound();
            }

            _context.Adverts.Remove(advert);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AdvertExists(Guid id)
        {
            return (_context.Adverts?.Any(e => e.AdvartID == id)).GetValueOrDefault();
        }
    }
}

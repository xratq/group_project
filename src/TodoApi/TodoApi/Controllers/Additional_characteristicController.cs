using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Additional_characteristicController : ControllerBase
    {
        private readonly TodoContext _context;

        public Additional_characteristicController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/Additional_characteristic
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Additional_characteristic>>> GetAdditional_characteristic()
        {
          if (_context.Additional_characteristic == null)
          {
              return NotFound();
          }
            return await _context.Additional_characteristic.ToListAsync();
        }

        // GET: api/Additional_characteristic/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Additional_characteristic>> GetAdditional_characteristic(int id)
        {
          if (_context.Additional_characteristic == null)
          {
              return NotFound();
          }
            var additional_characteristic = await _context.Additional_characteristic.FindAsync(id);

            if (additional_characteristic == null)
            {
                return NotFound();
            }

            return additional_characteristic;
        }

        // PUT: api/Additional_characteristic/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdditional_characteristic(int id, Additional_characteristic additional_characteristic)
        {
            if (id != additional_characteristic.ID)
            {
                return BadRequest();
            }

            _context.Entry(additional_characteristic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Additional_characteristicExists(id))
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

        // POST: api/Additional_characteristic
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Additional_characteristic>> PostAdditional_characteristic(Additional_characteristic additional_characteristic)
        {
          if (_context.Additional_characteristic == null)
          {
              return Problem("Entity set 'TodoContext.Additional_characteristic'  is null.");
          }
            _context.Additional_characteristic.Add(additional_characteristic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdditional_characteristic", new { id = additional_characteristic.ID }, additional_characteristic);
        }

        // DELETE: api/Additional_characteristic/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdditional_characteristic(int id)
        {
            if (_context.Additional_characteristic == null)
            {
                return NotFound();
            }
            var additional_characteristic = await _context.Additional_characteristic.FindAsync(id);
            if (additional_characteristic == null)
            {
                return NotFound();
            }

            _context.Additional_characteristic.Remove(additional_characteristic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Additional_characteristicExists(int id)
        {
            return (_context.Additional_characteristic?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

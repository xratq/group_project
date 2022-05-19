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
    public class Equipment_listController : ControllerBase
    {
        private readonly TodoContext _context;

        public Equipment_listController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/Equipment_list
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipment_list>>> GetEquipment_list()
        {
          if (_context.Equipment_list == null)
          {
              return NotFound();
          }
            return await _context.Equipment_list.ToListAsync();
        }

        // GET: api/Equipment_list/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Equipment_list>> GetEquipment_list(int id)
        {
          if (_context.Equipment_list == null)
          {
              return NotFound();
          }
            var equipment_list = await _context.Equipment_list.FindAsync(id);

            if (equipment_list == null)
            {
                return NotFound();
            }

            return equipment_list;
        }

        // PUT: api/Equipment_list/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEquipment_list(int id, Equipment_list equipment_list)
        {
            if (id != equipment_list.ID)
            {
                return BadRequest();
            }

            _context.Entry(equipment_list).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Equipment_listExists(id))
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

        // POST: api/Equipment_list
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Equipment_list>> PostEquipment_list(Equipment_list equipment_list)
        {
          if (_context.Equipment_list == null)
          {
              return Problem("Entity set 'TodoContext.Equipment_list'  is null.");
          }
            _context.Equipment_list.Add(equipment_list);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEquipment_list", new { id = equipment_list.ID }, equipment_list);
        }

        // DELETE: api/Equipment_list/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEquipment_list(int id)
        {
            if (_context.Equipment_list == null)
            {
                return NotFound();
            }
            var equipment_list = await _context.Equipment_list.FindAsync(id);
            if (equipment_list == null)
            {
                return NotFound();
            }

            _context.Equipment_list.Remove(equipment_list);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Equipment_listExists(int id)
        {
            return (_context.Equipment_list?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

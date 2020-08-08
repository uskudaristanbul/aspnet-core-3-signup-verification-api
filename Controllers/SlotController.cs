using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Entities;
using WebApi.Helpers;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ApiPolicy")]

    public class SlotController : ControllerBase
    {
        private readonly DataContext _context;

        public SlotController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Slot
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Slot>>> GetSlot()
        {
            return await _context.Slot.ToListAsync();
        }

        // GET: api/Slot/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Slot>> GetSlot(int id)
        {
            var slot = await _context.Slot.FindAsync(id);

            if (slot == null)
            {
                return NotFound();
            }

            return slot;
        }

        // PUT: api/Slot/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSlot(int id, Slot slot)
        {
            if (id != slot.Id)
            {
                return BadRequest();
            }

            _context.Entry(slot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlotExists(id))
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

        // POST: api/Slot
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Slot>> PostSlot(Slot slot)
        {
            _context.Slot.Add(slot);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSlot", new { id = slot.Id }, slot);
        }

        // DELETE: api/Slot/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Slot>> DeleteSlot(int id)
        {
            var slot = await _context.Slot.FindAsync(id);
            if (slot == null)
            {
                return NotFound();
            }

            _context.Slot.Remove(slot);
            await _context.SaveChangesAsync();

            return slot;
        }

        private bool SlotExists(int id)
        {
            return _context.Slot.Any(e => e.Id == id);
        }
    }
}

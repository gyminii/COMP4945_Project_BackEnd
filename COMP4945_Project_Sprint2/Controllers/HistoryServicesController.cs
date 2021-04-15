using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using COMP4945_Project_Sprint2.Data;
using COMP4945_Project_Sprint2.Models;

namespace COMP4945_Project_Sprint2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryServicesController : ControllerBase
    {
        private readonly COMP4945_Project_Sprint2Context _context;

        public HistoryServicesController(COMP4945_Project_Sprint2Context context)
        {
            _context = context;
        }

        // GET: api/HistoryServices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HistoryService>>> GetHistoryService()
        {
            return await _context.HistoryService.ToListAsync();
        }

        // GET: api/HistoryServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HistoryService>> GetHistoryService(int id)
        {
            var historyService = await _context.HistoryService.FindAsync(id);

            if (historyService == null)
            {
                return NotFound();
            }

            return historyService;
        }

        // PUT: api/HistoryServices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistoryService(int id, HistoryService historyService)
        {
            if (id != historyService.HistoryServiceId)
            {
                return BadRequest();
            }

            _context.Entry(historyService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
            
                bool historyServiceExist = id => {return _context.HistoryService.Any(e => e.HistoryServiceId == id);}
                if (!historyServiceExist)
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

        // POST: api/HistoryServices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HistoryService>> PostHistoryService(HistoryService historyService)
        {
            _context.HistoryService.Add(historyService);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistoryService", new { id = historyService.HistoryServiceId }, historyService);
        }

        // DELETE: api/HistoryServices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistoryService(int id)
        {
            var historyService = await _context.HistoryService.FindAsync(id);
            if (historyService == null)
            {
                return NotFound();
            }

            _context.HistoryService.Remove(historyService);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // private bool HistoryServiceExists(int id)
        // {
        //     return _context.HistoryService.Any(e => e.HistoryServiceId == id);
        // }
    }
}

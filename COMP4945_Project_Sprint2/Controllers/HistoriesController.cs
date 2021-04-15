﻿using System;
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
    public class HistoriesController : ControllerBase
    {
        private readonly COMP4945_Project_Sprint2Context _context;

        public HistoriesController(COMP4945_Project_Sprint2Context context)
        {
            _context = context;
        }

        // GET: api/Histories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<History>>> GetHistory()
        {
            return await _context.History.ToListAsync();
        }

        // GET: api/Histories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<History>> GetHistory(int id)
        {
            var history = await _context.History.FindAsync(id);

            if (history == null)
            {
                return NotFound();
            }

            return history;
        }

        // PUT: api/Histories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistory(int id, History history)
        {
            if (id != history.HistoryId)
            {
                return BadRequest();
            }

            _context.Entry(history).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
       
                bool historyExist = id => {return _context.History.Any(e => e.HistoryId == id);}

                if (!historyExist)
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

        // POST: api/Histories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<History>> PostHistory(History history)
        {
            _context.History.Add(history);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHistory", new { id = history.HistoryId }, history);
        }

        // DELETE: api/Histories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistory(int id)
        {
            var history = await _context.History.FindAsync(id);
            if (history == null)
            {
                return NotFound();
            }

            _context.History.Remove(history);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // private bool HistoryExists(int id)
        // {
        //     return _context.History.Any(e => e.HistoryId == id);
        // }
    }
}

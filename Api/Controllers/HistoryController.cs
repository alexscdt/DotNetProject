using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectDotNet.Models;

namespace ProjectDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoryController : ControllerBase
    {
        private readonly HistoryDbContext _dbContext;

        public HistoryController(HistoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/History
        [HttpGet]
        public async Task<ActionResult<IEnumerable<History>>> GetTodoItems()
        {
            return await _dbContext.history.ToListAsync();
        }

        // GET: api/History/5
        [HttpGet("{id}")]
        public async Task<ActionResult<History>> GetHistory(long id)
        {
            var history = await _dbContext.history.FindAsync(id);

            if (history == null)
            {
                return NotFound();
            }

            return history;
        }

        // PUT: api/History/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHistory(long id, History history)
        {
            if (id != history.Id)  
            {
                return BadRequest();
            }

            _dbContext.Entry(history).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HistoryExists(id))
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

        // POST: api/History
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<History>> PostHistory(History history)
        {
            _dbContext.history.Add(history);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction("GetHistory", new { id = history.Id }, history);
        }

        // DELETE: api/History/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHistory(long id)
        {
            var history = await _dbContext.history.FindAsync(id);
            if (history == null)
            {
                return NotFound();
            }

            _dbContext.history.Remove(history);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool HistoryExists(long id)
        {
            return _dbContext.history.Any(e => e.Id == id);
        }
    }
}

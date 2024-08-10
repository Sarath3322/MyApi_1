using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApi_1.Data;
using MyApi_1.Models;

namespace MyApi_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ApiClassesController : ControllerBase
    {
        private readonly DBCONTEXT _context;

        public ApiClassesController(DBCONTEXT context)
        {
            _context = context;
        }

        // GET: api/ApiClasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApiClass>>> GetStudent()
        {
            return await _context.Student.ToListAsync();
        }

        // GET: api/ApiClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiClass>> GetApiClass(int id)
        {
            var apiClass = await _context.Student.FindAsync(id);

            if (apiClass == null)
            {
                return NotFound();
            }

            return apiClass;
        }

        // PUT: api/ApiClasses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApiClass(int id, ApiClass apiClass)
        {
            if (id != apiClass.Id)
            {
                return BadRequest();
            }

            _context.Entry(apiClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApiClassExists(id))
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

        // POST: api/ApiClasses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostApiClass(ApiClass apiClass)
        {
            _context.Student.Add(apiClass);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApiClass", new { id = apiClass.Id }, apiClass);
        }

        // DELETE: api/ApiClasses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApiClass(int id)
        {
            var apiClass = await _context.Student.FindAsync(id);
            if (apiClass == null)
            {
                return NotFound();
            }

            _context.Student.Remove(apiClass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApiClassExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}

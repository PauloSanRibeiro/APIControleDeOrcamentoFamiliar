using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleDeOrcamentoFamiliar.Data;
using ControleDeOrcamentoFamiliar.Models;

namespace ControleDeOrcamentoFamiliar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DespesasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Despesas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Despesas>>> GetDespesas()
        {
            return await _context.Despesas.ToListAsync();
        }

        // GET: api/Despesas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Despesas>> GetDespesas(int id)
        {
            var despesas = await _context.Despesas.FindAsync(id);

            if (despesas == null)
            {
                return NotFound();
            }

            return despesas;
        }

        // PUT: api/Despesas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDespesas(int id, Despesas despesas)
        {
            if (id != despesas.Id)
            {
                return BadRequest();
            }

            _context.Entry(despesas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DespesasExists(id))
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

        // POST: api/Despesas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Despesas>> PostDespesas(Despesas despesas)
        {
            _context.Despesas.Add(despesas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDespesas", new { id = despesas.Id }, despesas);
        }

        // DELETE: api/Despesas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDespesas(int id)
        {
            var despesas = await _context.Despesas.FindAsync(id);
            if (despesas == null)
            {
                return NotFound();
            }

            _context.Despesas.Remove(despesas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DespesasExists(int id)
        {
            return _context.Despesas.Any(e => e.Id == id);
        }
    }
}

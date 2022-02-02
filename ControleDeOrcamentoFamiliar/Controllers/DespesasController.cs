using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ControleDeOrcamentoFamiliar.Data;
using ControleDeOrcamentoFamiliar.Models;
using AutoMapper;

namespace ControleDeOrcamentoFamiliar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DespesasController : ControllerBase
    {
        private readonly OrcamentoContext _context;
        private readonly IMapper _mapper;
        public DespesasController(OrcamentoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddDespesa([FromBody] CreateDespesasDto despesasDto)
        {
            Despesas despesa = _mapper.Map<Despesas>(despesasDto);
            _context.Despesas.Add(despesa);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaDespesasPorId), new { Id = despesa.Id }, despesa);
        }


        [HttpGet]
        public IActionResult RecuperaDespesas()
        {
            return Ok(_context.Despesas);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaDespesasPorId(int id)
        {
            Despesas despesa = _context.Despesas.FirstOrDefault(despesa => despesa.Id == id);
            if (despesa != null)
            {
                ReadDespesasDto despesasDto = _mapper.Map<ReadDespesasDto>(despesa);
                return Ok(despesa);
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaDespesas(int id, [FromBody] UpdateDespesasDto despesasDto)
        {
            Despesas despesa = _context.Despesas.FirstOrDefault(despesa => despesa.Id == id);
            if (despesa != null)
            {
                _mapper.Map(despesasDto, despesa);
                _context.SaveChanges();

                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaDespesa(int id)
        {
            Despesas despesa = _context.Despesas.FirstOrDefault(despesa => despesa.Id == id);
            if (despesa != null)
            {
                _context.Remove(despesa);
                _context.SaveChanges();
            }

            return NotFound();
        }
    }
}


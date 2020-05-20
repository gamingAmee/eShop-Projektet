using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ProduktService.Concrete;
using ServiceLayer.ProduktService;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduktController : ControllerBase
    {
        private readonly IProduktService _produktService;

        public ProduktController(IProduktService produktService)
        {
            _produktService = produktService;
        }

        // GET: api/Produkt
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProduktDto>>> GetProdukts()
        {
            return await _produktService.GetProdukts().ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ProduktDto>> CreateProdukt(ProduktDto produktDTO)
        {
            return await _produktService.Create(produktDTO);
        }

        // GET: api/Produkt/id
        [HttpGet("{id}")]
        public async Task<ActionResult<ProduktDto>> GetProdukt(int id)
        {
            var produkt = await _produktService.GetProduktById(id);

            if (produkt == null)
            {
                return NotFound();
            }

            return produkt;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditProdukt(int id, ProduktDto produktDTO)
        {

            if (id != produktDTO.ProduktId)
            {
                return BadRequest();
            }

            ProduktDto produkt = await _produktService.GetProduktById(id);
            if (produkt == null)
            {
                return NotFound();
            }

            try
            {
                produkt = produktDTO;
            }
            catch
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProdukt(int id)
        {
            try
            {
                await _produktService.Delete(id);
            }
            catch 
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
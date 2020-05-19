using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ProduktService.Concrete;
using ServiceLayer.ProduktService;

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

        // GET: api/TodoItems
        [HttpGet]
        public ActionResult<IEnumerable<ProduktDto>> GetProdukts()
        {
            return _produktService.GetProdukts().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ProduktDto> GetProdukt(int id)
        {
            ProduktDto produkt = _produktService.GetProduktById(id);

            if (produkt == null)
            {
                return NotFound();
            }

            return produkt;
        }

        [HttpPost]
        public ActionResult<ProduktDto> CreateProdukt(ProduktDto produktDTO)
        {
            return _produktService.Create(produktDTO);
        }

        [HttpPut("{id}")]
        public IActionResult EditProdukt(int id, ProduktDto produktDTO)
        {

            if (id != produktDTO.ProduktId)
            {
                return BadRequest();
            }

            ProduktDto produkt = _produktService.GetProduktById(id);
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
        public IActionResult DeleteProdukt(int id)
        {
            try
            {
                _produktService.Delete(id);
            }
            catch 
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
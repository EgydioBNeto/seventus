using Microsoft.AspNetCore.Mvc;
using Seventus.Data;
using Seventus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seventus.Controllers
{
    [ApiController]
    [Route("controller")]
    public class EventoController : ControllerBase
    {

        private EventoContext _context;

        public EventoController(EventoContext context) { 
        
            _context = context;
        
        }

        [HttpGet]
        public IEnumerable<Evento> GetEvento()
        {

            return _context.Eventos;

        }

        [HttpPost]

        public IActionResult AddEvento([FromBody]Evento evento)
        {
            _context.Eventos.Add(evento);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetEventoById), new {Id = evento.Id}, evento);
        }

        [HttpGet("{id}")]
        public IActionResult GetEventoById(int id)
        {

            Evento evento = _context.Eventos.FirstOrDefault(evento => evento.Id == id);
            if (evento != null) {

                return Ok(evento);
            }
            return NotFound();
        }


    }
}

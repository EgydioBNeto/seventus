using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Seventus.Data;
using Seventus.Data.Dtos;
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
        private IMapper _mapper;

        public EventoController(EventoContext context, IMapper mapper) { 
        
            _context = context;
            _mapper = mapper;
        
        }

        [HttpGet]
        public IEnumerable<Evento> GetEvento()
        {

            return _context.Eventos;

        }

        [HttpPost]

        public IActionResult AddEvento([FromBody]CreateEventoDto eventoDto)
        {
            Evento evento = _mapper.Map<Evento>(eventoDto);
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

        [HttpPut("{id}")]
        public IActionResult UpdateEvento(int id,[FromBody] Evento eventoDto)
        {
            Evento evento1 = _context.Eventos.FirstOrDefault(evento1 => evento1.Id == id);
            if (evento1 == null)
            {
                return NotFound();
            }
            _mapper.Map(eventoDto, evento1);
            _context.SaveChanges();
            return NoContent();
        }

    }
}

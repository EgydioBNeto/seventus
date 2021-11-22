using Microsoft.AspNetCore.Mvc;
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
        private List<Evento> eventos = new List<Evento>();
        [HttpGet]
        public IActionResult GetEvento()
        {

            return Ok(eventos);

        }

        [HttpPost]

        public IActionResult AddEvento([FromBody]Evento evento)
        {
            eventos.Add(evento);
            return Ok(evento);
        }

        [HttpGet("{nome}")]
        public IActionResult GetEventoByNome(string nome)
        {

            Evento evento = eventos.FirstOrDefault(evento => evento.Nome == nome);
            if (evento != null) {

                return Ok(evento);
            }
            return NotFound();
        }


    }
}

using Microsoft.EntityFrameworkCore;
using Seventus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seventus.Data
{
    public class EventoContext : DbContext
    {
        public EventoContext(DbContextOptions<EventoContext> opt) : base (opt)
        { 
        }

        public DbSet<Evento> Eventos { get; set; }

    }
}

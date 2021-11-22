using AutoMapper;
using Seventus.Data.Dtos;
using Seventus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seventus.Profiles
{
    public class EventoProfile : Profile
    {
        public EventoProfile()
        { 
            CreateMap<CreateEventoDto, Evento>();
            CreateMap<UpdateEventoDto, Evento>();
        }    

    }
}

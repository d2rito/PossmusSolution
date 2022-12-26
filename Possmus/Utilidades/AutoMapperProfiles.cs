using AutoMapper;
using Possmus.Clases;
using Possmus.DTOs;

namespace Possmus.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<CandidatoDTO, CandidatoDTO>();
            CreateMap<EmpleoDTO, EmpleoDTO>();
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Possmus.Clases;
using Possmus.DTOs;
using Possmus.Interfaces;

namespace Possmus.Servicios
{
    public class EmpleoService : IEmpleoService
    {
        private readonly IEmpleoRepository _empleoRepository; 
        private readonly IMapper _mapper; 

        public EmpleoService(IEmpleoRepository empleoRepository, IMapper mapper)
        {
            _empleoRepository = empleoRepository;
            _mapper = mapper;
        }

        public async Task<ActionResult> DeleteEmpleo(int id)
        {
            var existeEmpleo = await _empleoRepository.FindEmpleoById(id);
            if (existeEmpleo)
            {
                return await _empleoRepository.DeleteEmpleo(id);
            }
            else
            {
                //Status code 404 cuando el recurso no se encuentra
                return new StatusCodeResult(404);
            }
        }

        public async Task<ActionResult<List<Empleo>>> GetAllEmpleos()
        {
            return await _empleoRepository.GetAllEmpleos();
        }

        public async Task<ActionResult> SaveEmpleo(EmpleoDTO empleo)
        {
            var existeCandidato = await _empleoRepository.FindEmpleoByNombre(empleo.Nombre);
            if (!existeCandidato)
            {
                var empleoMapped = _mapper.Map<Empleo>(empleo);
                return await _empleoRepository.SaveEmpleo(empleoMapped);
            }
            else
            {
                //Status code 409 cuando el recurso ya existe
                return new StatusCodeResult(409);
            }
        }

        public async Task<ActionResult> UpdateEmpleo(EmpleoDTO empleo, int id)
        {
            var existeCandidato = await _empleoRepository.FindEmpleoById(id);
            if (existeCandidato)
            {
                var empleoMapped = _mapper.Map<Empleo>(empleo);
                return await _empleoRepository.UpdateEmpleo(empleoMapped);
            }
            else
            {
                //Status code 404 cuando el recurso no se encuentra
                return new StatusCodeResult(404);
            }
        }
    }
}


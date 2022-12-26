using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Possmus.Clases;
using Possmus.DTOs;
using Possmus.Interfaces;

namespace Possmus.Servicios
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository; 
        private readonly IMapper _mapper; 

        public CandidatoService(ICandidatoRepository candidatoRepository, IMapper mapper)
        {
            _candidatoRepository = candidatoRepository;
            _mapper = mapper;
        }

        public async Task<ActionResult> DeleteCandidato(int id)
        {
            var existeCandidato = await _candidatoRepository.FindCandidatoById(id);
            if (existeCandidato)
            {
                return await _candidatoRepository.DeleteCandidato(id);
            }
            else
            {
                //Status code 404 cuando el recurso no se encuentra
                return new StatusCodeResult(404);
            }
        }

        public async Task<ActionResult<List<Candidato>>> GetAllCandidatos()
        {
            return await _candidatoRepository.GetAllCandidatos();
        }

        public async Task<ActionResult> SaveCandidato(CandidatoDTO candidato)
        {
            var existeCandidato = await _candidatoRepository.FindCandidatoByMail(candidato.Email);
            if (!existeCandidato)
            {
                var candidatoMapped = _mapper.Map<Candidato>(candidato);
                return await _candidatoRepository.SaveCandidato(candidatoMapped);
            }
            else
            {
                //Status code 409 cuando el recurso ya existe
                return new StatusCodeResult(409);
            }
        }

        public async Task<ActionResult> UpdateCandidato(CandidatoDTO candidato, int id)
        {
            var existeCandidato = await _candidatoRepository.FindCandidatoById(id);
            if (existeCandidato)
            {
                var candidatoMapped = _mapper.Map<Candidato>(candidato);
                return await _candidatoRepository.UpdateCandidato(candidatoMapped);
            }
            else
            {
                //Status code 404 cuando el recurso no se encuentra
                return new StatusCodeResult(404);
            }
        }
    }
}


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Possmus.Clases;
using Possmus.Context;
using Possmus.DTOs;
using Possmus.Interfaces;

namespace Possmus.Controllers
{
    [ApiController]
    [Route("Api/Candidatos")]
    public class CandidatoController : ControllerBase
    {
        private readonly ICandidatoService _candidatoService;
        private readonly ILogger<CandidatoController> _logger;

        public CandidatoController(ILogger<CandidatoController> logger, ICandidatoService candidatoService)
        {
            _logger = logger;
            _candidatoService = candidatoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Candidato>>> Get()
        {
            return await _candidatoService.GetAllCandidatos();
        }

        [HttpPost]
        public async Task<ActionResult> Post(CandidatoDTO candidato)
        {
            return await _candidatoService.SaveCandidato(candidato);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(CandidatoDTO candidato, int id)
        {
            return await _candidatoService.UpdateCandidato(candidato, id);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await _candidatoService.DeleteCandidato(id);
        }
    }
}
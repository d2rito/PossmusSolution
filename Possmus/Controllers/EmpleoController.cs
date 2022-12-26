using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Possmus.Clases;
using Possmus.Interfaces;

namespace Possmus.Controllers
{
    [ApiController]
    [Route("api/empleos")]
    public class EmpleoController : ControllerBase
    {
        private readonly IEmpleoService _empleoService;
        private readonly ILogger<CandidatoController> _logger;
        public EmpleoController (IEmpleoService empleoService, ILogger<CandidatoController> logger)
        {
            _empleoService = empleoService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<Empleo>>> Get()
        {
            return await _empleoService.GetAllEmpleos();
        }

        [HttpPost]
        public async Task<ActionResult> Post(EmpleoDTO empleo)
        {
            return await _empleoService.SaveEmpleo(empleo);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(EmpleoDTO empleo, int id)
        {
            return await _empleoService.UpdateEmpleo(empleo, id);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            return await _empleoService.DeleteEmpleo(id);
        }
    }
}

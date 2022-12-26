using Microsoft.AspNetCore.Mvc;
using Possmus.Clases;
using Possmus.DTOs;

namespace Possmus.Interfaces
{
    public interface IEmpleoService
    {
        public Task<ActionResult<List<Empleo>>> GetAllEmpleos();
        public Task<ActionResult> SaveEmpleo(EmpleoDTO empleo);
        public Task<ActionResult> UpdateEmpleo(EmpleoDTO empleo, int id);
        public Task<ActionResult> DeleteEmpleo(int id);
    }
}

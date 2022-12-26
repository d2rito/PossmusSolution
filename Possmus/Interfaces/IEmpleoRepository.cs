using Microsoft.AspNetCore.Mvc;
using Possmus.Clases;
using Possmus.DTOs;

namespace Possmus.Interfaces
{
    public interface IEmpleoRepository
    {
        public Task<ActionResult<List<Empleo>>> GetAllEmpleos();
        public Task<ActionResult> SaveEmpleo(Empleo empleo);
        public Task<ActionResult> UpdateEmpleo(Empleo empleo);
        public Task<ActionResult> DeleteEmpleo(int id);
        public Task<bool> FindEmpleoById(int id);
        public Task<bool> FindEmpleoByNombre(string nombre);
    }
}

using Microsoft.AspNetCore.Mvc;
using Possmus.Clases;
using Possmus.DTOs;

namespace Possmus.Interfaces
{
    public interface ICandidatoService
    {
        public Task<ActionResult<List<Candidato>>> GetAllCandidatos();
        public Task<ActionResult> SaveCandidato(CandidatoDTO candidato);
        public Task<ActionResult> UpdateCandidato(CandidatoDTO candidato, int id);
        public Task<ActionResult> DeleteCandidato(int id);
    }
}

using Microsoft.AspNetCore.Mvc;
using Possmus.Clases;
using Possmus.DTOs;

namespace Possmus.Interfaces
{
    public interface ICandidatoRepository
    {
        public Task<ActionResult<List<Candidato>>> GetAllCandidatos();
        public Task<ActionResult> SaveCandidato(Candidato candidato);
        public Task<ActionResult> UpdateCandidato(Candidato candidato);
        public Task<ActionResult> DeleteCandidato(int id);
        public Task<bool> FindCandidatoByMail(string email);
        public Task<bool> FindCandidatoById(int id);
    }
}

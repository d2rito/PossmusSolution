using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Possmus.Clases;
using Possmus.Context;
using Possmus.Interfaces;

namespace Possmus.Repository
{
    public class CandidatoRepository : ICandidatoRepository
    {
        private readonly ApplicationDbContext _context;
        public CandidatoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> FindCandidatoByMail(string email)
        {
            bool existeONo = false;
            existeONo = await _context.Candidatos.AnyAsync(x => x.Email == email);
            return existeONo;
        }        
        public async Task<bool> FindCandidatoById(int id)
        {
            bool existeONo = false;
            existeONo = await _context.Candidatos.AnyAsync(x => x.Id == id);
            return existeONo;
        }

        public async Task<ActionResult<List<Candidato>>> GetAllCandidatos()
        {
            return await _context.Candidatos.ToListAsync();
        }

        public async Task<ActionResult> SaveCandidato(Candidato candidato)
        {
            _context.Add(candidato);
            await _context.SaveChangesAsync();
            return new StatusCodeResult(200);
        }        
        public async Task<ActionResult> UpdateCandidato(Candidato candidato)
        {
            _context.Update(candidato);
            await _context.SaveChangesAsync();
            return new StatusCodeResult(200);
        }

        public async Task<ActionResult> DeleteCandidato(int id)
        {
            _context.Remove(new Candidato() { Id = id});
            await _context.SaveChangesAsync();
            return new StatusCodeResult(200);
        }
    }
}

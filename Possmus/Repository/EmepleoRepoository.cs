using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Possmus.Clases;
using Possmus.Context;
using Possmus.Interfaces;

namespace Possmus.Repository
{
    public class EmpleoRepository : IEmpleoRepository
    {
        private readonly ApplicationDbContext _context;
        public EmpleoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<List<Empleo>>> GetAllEmpleos()
        {
            return await _context.Empleos.ToListAsync();
        }

        public async Task<ActionResult> SaveEmpleo(Empleo empleo)
        {
            _context.Add(empleo);
            await _context.SaveChangesAsync();
            return new StatusCodeResult(200);
        }

        public async Task<ActionResult> UpdateEmpleo(Empleo empleo)
        {
            _context.Update(empleo);
            await _context.SaveChangesAsync();
            return new StatusCodeResult(200);
        }

        public async Task<ActionResult> DeleteEmpleo(int id)
        {
            _context.Remove(new Empleo() { Id = id });
            await _context.SaveChangesAsync();
            return new StatusCodeResult(200);
        }

        public async Task<bool> FindEmpleoById(int id)
        {
            bool existeONo = false;
            existeONo = await _context.Empleos.AnyAsync(x => x.Id == id);
            return existeONo;
        }        
        public async Task<bool> FindEmpleoByNombre(string nombre)
        {
            bool existeONo = false;
            existeONo = await _context.Empleos.AnyAsync(x => x.Nombre == nombre);
            return existeONo;
        }
    }
}

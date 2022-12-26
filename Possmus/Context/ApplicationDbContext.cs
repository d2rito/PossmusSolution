using Microsoft.EntityFrameworkCore;
using Possmus.Clases;

namespace Possmus.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Candidato> Candidatos { get; set; }
        public DbSet<Empleo> Empleos { get; set; }
    }
}

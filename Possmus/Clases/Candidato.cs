using System.ComponentModel.DataAnnotations;

namespace Possmus.Clases
{
    public class Candidato
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; } = DateTime.Now;
        public string Email { get; set; }
        public string Telefono { get; set; }
        public List<EmpleoDTO>? Empleos { get; set; }
    }
}

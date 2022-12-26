namespace Possmus.Clases
{
    public class Empleo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get;set; }
        public DateTime InicioPeriodo { get; set; }
        public DateTime FinPeriodo { get; set;}
        public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }
    }
}

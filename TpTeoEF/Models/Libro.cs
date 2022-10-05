namespace TpTeoEF.Models
{
    public class Libro
    {
        public string Titulo { get; set; }
        public int Id { get; set; }

        public string Resumen { get; set; }
        public DateTime FechaPub { get; set; }
        public int AutorId { get; set; }
        public int GeneroId { get; set; }
        public Autor? autor { get; set; }

        public Genero? genero { get; set; }

        //public string foto { get; set; }
    }

}

namespace TpTeoEF.Models
{
    public class Genero
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public List<Libro>? ListaLibros { get; set; }
        
    }
}

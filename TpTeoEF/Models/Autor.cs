namespace TpTeoEF.Models
{
    public class Autor
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Biografia { get; set; }

        public List<Libro>? ListaLibros { get; set; }
    }
}

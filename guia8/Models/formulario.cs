using System.ComponentModel.DataAnnotations;
namespace guia8.Models
{
    public class formulario
    {
        [Key]
        public int id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string contrasenia { get; set; }
        public string? genero { get; set; }
        public string? direccion { get; set; }
        public string? pasatiempo { get; set; }
        public string? cursos { get; set; }
        public string? conocimientos { get; set; }
    }
}

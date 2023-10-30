#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
namespace FormularioUsuarios.Models;

public class Usuario{
    [Required]
    [MinLength(2, ErrorMessage ="Tu nombre debe de tener al menos 3 letras.")]
    public string Nombre {get; set;}
    [Required]
    public string Dojo {get; set;}
    [Required]
    public string Lenguaje {get; set;}
    [Required]
    [MinLength(20, ErrorMessage ="Tu comentario debe de tener al menos 20 letras.")]
    public string Comentario {get; set;}

}
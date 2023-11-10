using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcFei.Models;

public class Alumno
{

    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    [Display(Name = "Matricula")]
    public string AlumnoId { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    [StringLength (50, MinimumLength = 3, ErrorMessage = "El campo {0} debe ser una cadena con un minimo de {1} y un maximo de {2} caracteres.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    [Display(Name = "Fecha de ingreso")]
    [DataType(DataType.Date, ErrorMessage ="El campo {0} debe ser una fecha.")]
    public DateTime FechaIngreso { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    [StringLength(8, ErrorMessage = "El campo {0} debe ser una cadena con un minimo de {1} caracteres.")]
    public string Carrera { get; set; }

    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    [Range(1, 10, ErrorMessage ="El campo {0} debe ser un numero con un minimo de {1} y un maximo de {2}.")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Promedio { get; set; }
}

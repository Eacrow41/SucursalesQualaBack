using System.ComponentModel.DataAnnotations;

namespace OfQuala.Model
{
    public class Site : IValidatableObject
    {
    public int codigo { get; set; }

    [Required(ErrorMessage = "Campo requerido.")]
    [StringLength(250, ErrorMessage = "Cantidad maxima de caracteres permitidos es de 250")]
    public string descripcion { get; set; }

    [Required(ErrorMessage = "Campo requerido.")]
    [StringLength(250, ErrorMessage = "Cantidad maxima de caracteres permitidos es de 250")]
    public string direccion { get; set; }

    [Required(ErrorMessage = "Campo requerido.")]
    [StringLength(250, ErrorMessage = "Cantidad maxima de caracteres permitidos es de 50")]
    public string identificacion { get; set; }
    
    public DateTime fecha_creacion { get; set; }

    [Required(ErrorMessage = "Campo requerido.")]
    public string moneda { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            DateTime thisDay = DateTime.Today;


            if (fecha_creacion.Equals(""))
            {
                yield return new ValidationResult(
                    $"Campo requerido.",
                    new[] { nameof(fecha_creacion) });
            }
            else {
                if (fecha_creacion < thisDay)
                {
                    yield return new ValidationResult(
                        $"El valor de fecha: {fecha_creacion} es invalido, solo se permite el registro de la fecha actual o superior.",
                        new[] { nameof(fecha_creacion) });
                }
            }

        }
    }

   
}

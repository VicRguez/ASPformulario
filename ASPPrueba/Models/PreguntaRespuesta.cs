using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASPPrueba.Models
{
    public class PreguntaRespuesta
    {
        [Required]
        public Pregunta pregunta { get; set; }
        //[Required]
        //public Respuesta respuesta { get; set; }
        [Required]
        public String textoRespuesta { get; set; }

    }
}

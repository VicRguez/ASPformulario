using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;




namespace ASPPrueba.Models
{
    public class Respuesta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string TextoRespuesta { get; set; }




        [Required]
        public Pregunta Pregunta { get; set; }
    }


}
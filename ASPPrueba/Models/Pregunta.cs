using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace ASPPrueba.Models
{
    public class Pregunta
    {
        [Key]
        public int Id { get; set; }
        
        public string Titulo { get; set; }
        [Required]
        public string TextoPregunta { get; set; }


        public string PosiblesRespuestas { get; set; }


        public string TipoPregunta { get; set; }

        

    }
    
   
}

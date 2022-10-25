namespace ASPPrueba.Controllers;

using ASPPrueba.Data;
using ASPPrueba.Models;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Linq;

public class PreguntasController : Controller
{
    private readonly ApplicationDBContext _db;

    public PreguntasController(ApplicationDBContext db)
    {
        _db = db;
    }

    public IActionResult ListadoPreguntas()
    {
        IEnumerable<Pregunta> objPreguntasList = _db.preguntas;
        objPreguntasList.ElementAt(0);
        return View(objPreguntasList);
    }

    public IActionResult PrimeraPregunta(PreguntaRespuesta obj)
    {
        IEnumerable<Pregunta> objPreguntasList = _db.preguntas;

        List<Pregunta> asList = objPreguntasList.ToList();

        Pregunta primeraPregunta =  asList.ElementAt(0);

        obj.pregunta = primeraPregunta;

      

        return View( obj);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(PreguntaRespuesta respuesta)
    {
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\nentrando en post\n\n\n\n\n\n");
        if (ModelState.IsValid)
        {
            


            _db.respuestas.Add(new Respuesta
            { 
                Pregunta=respuesta.pregunta,
                TextoRespuesta = respuesta.textoRespuesta,
                
                

            });
            _db.SaveChanges();
            return RedirectToAction("ListadoPreguntas");
        }
        return View("ListadoPreguntas");
    }


}

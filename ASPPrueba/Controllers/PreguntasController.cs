namespace ASPPrueba.Controllers;

using ASPPrueba.Data;
using ASPPrueba.Models;
using Microsoft.AspNetCore.Mvc;
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

    public IActionResult PrimeraPregunta()
    {
        IEnumerable<Pregunta> objPreguntasList = _db.preguntas;

        List<Pregunta> asList = objPreguntasList.ToList();

        Pregunta primeraPregunta =  asList.ElementAt(0);

   

        return View(primeraPregunta);
    }



}

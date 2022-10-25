namespace ASPPrueba.Controllers;

using ASPPrueba.Data;
using ASPPrueba.Models;
using Microsoft.AspNetCore.Mvc;

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
        return View(objPreguntasList);
    }


}

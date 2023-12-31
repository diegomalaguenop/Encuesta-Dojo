using Microsoft.AspNetCore.Mvc;

namespace FormularioUsuarios.Controllers;

public class PrincipalController : Controller{

    private static List<string> ListaUsuarios = new List<string>();

    [HttpGet]
    [Route("")]
    public IActionResult Index(){
        string titulo = "Formulario Usuarios";
        string subtitulo = "Bienvenidos";
        ViewBag.Titulo = titulo;
        ViewBag.Subtitulo = subtitulo;
        return View("Index");
    }

    [HttpGet("usuarios")]
    public IActionResult Usuarios(){
        ViewBag.ListaUsuarios = ListaUsuarios;
        return View("Usuarios");
    }

    [HttpGet]
    [Route("procesa/usuarios")]
    public RedirectToActionResult ProcesaUsuarios(){
        Console.WriteLine("Procesando usuarios!!!");
        return RedirectToAction("Usuarios");
        // return RedirectToAction("TablaDeMultiplicar", new {num = 10, limite = 20});
    }

    [HttpGet]
    [Route("formulario/usuario")]
    public IActionResult FormularioUsuario(){
        return View("FormularioUsuario");
    }

    [HttpPost]
    [Route("nuevo/usuario")]
    public IActionResult AgregaUsuario(string nombre, string dojo, string lenguaje, string comentario)
    {
        ListaUsuarios.Add("Nombre: " + nombre);
        ListaUsuarios.Add("Ubicación Dojo: " + dojo);
        ListaUsuarios.Add("Lenguaje Favorito: " + lenguaje);
        ListaUsuarios.Add("Comentario: " + comentario);

        return RedirectToAction("Usuarios");
    }

    public IActionResult Usuario()
    {
        return View();
    }

    [HttpGet]
    [Route("api/usuarios")]
    public JsonResult APIUsuarios(){
        return Json(ListaUsuarios);
    }
}
using guia8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace guia8.Controllers
{
    public class vistaController : Controller
    {
        private readonly GuiaDbContext contexto;
        public vistaController(GuiaDbContext contextoo)
        {
            contexto = contextoo;
        }

        public IActionResult Index()
        {
            var listadoFormulario = (from e in contexto.formulario
                                     select new
                                     {
                                         nombre = e.nombre_usuario,
                                         contrasenia = e.contrasenia,
                                         genero = e.genero,
                                         direccion = e.direccion,
                                         pasatiempo = e.pasatiempo,
                                         cursos = e.cursos,
                                         conocimientos = e.conocimientos
                                     }).ToList();
            ViewData["listadoFormulario"] = listadoFormulario;

            return View();
        }

        public IActionResult CrearFormulario(formulario nuevoFormulario)
        {
            contexto.Add(nuevoFormulario);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}

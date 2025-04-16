using Microsoft.AspNetCore.Mvc;
using Pagina_Deportes.Models;
using Pagina_Deportes.Repositories;

namespace Pagina_Deportes.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult ListaEquipos()
        {
            EquipoRepositorio equipoRepositorio = new EquipoRepositorio();
            List<Equipo> equipos = equipoRepositorio.DevuelveListadoEquipos();

            return View(equipos);
        }
    }
}

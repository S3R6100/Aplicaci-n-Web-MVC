using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
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
        public IActionResult Details(int id, EquipoRepositorio equipoRepositorio)
        {
            var equipo = equipoRepositorio.DevuelveListadoEquipos().FirstOrDefault(e => e.Id == id);
            if (equipo == null)
                return NotFound();
            return View(equipo);
        }

        public IActionResult InformacionEquipo(int id)
        {
            EquipoRepositorio repo = new EquipoRepositorio();
            var equipo = repo.DevuelveListadoEquipos().FirstOrDefault(e => e.Id == id);

            if (equipo == null)
            {
                return NotFound();
            }

            return View(equipo);
        }


    }
}

using Pagina_Deportes.Models;

namespace Pagina_Deportes.Interfaces
{
    public interface InterfaceEquipo
    {
        List<Equipo> DevuelveListadoEquipos();

        Equipo DevuelveInfoEquipo();

        bool CrearEquipo();

        bool ActualizarEquipo();

        bool EliminarEquipo();
    }
}

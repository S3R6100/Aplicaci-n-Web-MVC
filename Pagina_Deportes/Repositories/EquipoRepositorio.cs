using AspNetCoreGeneratedDocument;
using Pagina_Deportes.Interfaces;
using Pagina_Deportes.Models;

namespace Pagina_Deportes.Repositories
{
    public class EquipoRepositorio : InterfaceEquipo
    {
        public bool ActualizarEquipo()
        {
            throw new NotImplementedException();
        }

        public bool CrearEquipo()
        {
            throw new NotImplementedException();
        }

        public Equipo DevuelveInfoEquipo()
        {
            throw new NotImplementedException();
        }

        public List<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();
            {
                Equipo Equipo1 = new Equipo();
                {
                    Equipo1.Id = 1;
                    Equipo1.Nombre = "Equipo 1";
                    Equipo1.PartidosJugados = 10;
                    Equipo1.PartidosGanados = 8;
                    Equipo1.PartidosEmpatados = 2;
                    Equipo1.PartidosPerdidos = 0;
                }
                equipos.Add(Equipo1);

                Equipo Equipo2 = new Equipo();
                {
                    Equipo2.Id = 2;
                    Equipo2.Nombre = "Equipo 2";
                    Equipo2.PartidosJugados = 5;
                    Equipo2.PartidosGanados = 3;
                    Equipo2.PartidosEmpatados = 1;
                    Equipo2.PartidosPerdidos = 0;
                }
                equipos.Add(Equipo2);
            }
            return equipos;
        }

        public bool EliminarEquipo()
        {
            throw new NotImplementedException();
        }
    }
    }

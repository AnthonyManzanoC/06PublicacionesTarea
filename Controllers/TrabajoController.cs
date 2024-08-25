using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06Publicaciones.config;

namespace _06Publicaciones.Controllers
{
    public class TrabajoController
    {
        // Método para insertar un trabajo
        public Trabajo InsertarTrabajo(Trabajo trabajo)
        {
            return Trabajo.Insertar(trabajo);
        }

        // Método para actualizar un trabajo
        public string ActualizarTrabajo(Trabajo trabajo)
        {
            return Trabajo.Actualizar(trabajo);
        }

        // Método para eliminar un trabajo
        public string EliminarTrabajo(string trabajo)
        {
            return Trabajo.Eliminar(trabajo);
        }

        // Método para obtener un trabajo por ID
        public Trabajo ObtenerTrabajoPorId(string idTrabajo)
        {
            return Trabajo.ObtenerPorId(idTrabajo);
        }

        // Método para obtener todos los trabajos
        public List<Trabajo> ObtenerTodosLosTrabajos()
        {
            return Trabajo.ObtenerTodos();
        }
    }
}

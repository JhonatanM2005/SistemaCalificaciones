using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCalificaciones.Model
{
    public class Calificacion
    {
        public int Id { get; set; }
        public int Id_Estudiante { get; set; }
        public int Id_Materia { get; set; }
        public decimal Nota { get; set; }
    }
}

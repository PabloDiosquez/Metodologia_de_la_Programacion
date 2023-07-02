using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(int dni, string nombre, string apellido, int legajo) : base(dni, nombre, apellido, legajo)
        { }

        public new int responderPregunta(int pregunta)
        {
            return pregunta;
        }
    }
}

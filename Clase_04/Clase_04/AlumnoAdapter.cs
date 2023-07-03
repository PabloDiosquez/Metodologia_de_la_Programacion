using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDPI;

namespace Clase_04
{
    public class AlumnoAdapter : Student
    {
        private Alumno alumno; // Adaptable

        public AlumnoAdapter(Alumno alumno)
        {
            this.alumno = alumno;
        }

        public bool equals(Student student)
        {
            return alumno.sosIgual((Alumno)student);
        }

        public string getName()
        {
            return alumno.getNombre();
        }

        public bool greaterThan(Student student)
        {
            return alumno.sosMayor((Alumno)student);    
        }

        public bool lessThan(Student student)
        {
            return alumno.sosMenor((Alumno)student);

        }
        public void setScore(int score)
        {
            alumno.setCalificacion(score);
        }

        public string showResult()
        {
            return alumno.mostrarCalificacion();
        }

        public int yourAnswerIs(int question)
        {
            return alumno.responderPregunta(question);
        }
    }
}

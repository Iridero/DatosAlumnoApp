using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosAlumnoApp
{
    [Serializable]
    public class Alumno
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public Persona Padre { get; set; }
        public Persona Madre { get; set; }
    }
}

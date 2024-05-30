using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos.Modelos
{
    public class Estudiante
    {
        public string cuenta;
        public string nombreCompleto;
        public double calificación;

        public override string ToString()
        {
            return "Cuenta: " +cuenta+
                "\nNombre: " +nombreCompleto+
                "\nCalificación: "+calificación;
        }
        


    }
}

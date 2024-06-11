using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigurasPolimorfismo.Modelos
{
    public abstract class Figura
    {
        public string Color { get; set; }

        public Figura(string color) {
            this.Color = color;
        }

        public abstract double CalcularArea(); 
    }
}

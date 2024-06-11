using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigurasPolimorfismo.Modelos
{
    public class Circulo : Figura
    {
        public double Radio {  get; set; }
        public Circulo(string color, double radio):base(color) {
            this.Radio = radio;
        }

        public override double CalcularArea()
        {
            return 2*Math.PI*Math.Pow(Radio,2);
        }
        public override string ToString()
        {
            return "Figura: Circulo"+
                "\nColor: "+base.Color+
                "\nArea: "+CalcularArea();
        }
    }
}

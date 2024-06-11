using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigurasPolimorfismo.Modelos
{
    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Triangulo(string color, double baseTriangulo, double altura) : base(color) {
            Base = baseTriangulo;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return 0.5*this.Base*this.Altura;
        }

        public override string ToString()
        {
            return "Figura: Triangulo"+
                "\nColor: "+base.Color+
                "\nArea: "+CalcularArea();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuentasBancarias.Modelos
{
    public class CuentaBasica:Cuenta
    {
        public CuentaBasica(string idCuenta, string nombre, double balance, double porcentajeInteres)
            : base(idCuenta, nombre, balance, porcentajeInteres) { }

        public override double CalcularInteres()
        {
            return base.Balance*base.PorcentajeInteres;
        }

        public override string ToString()
        {
            return "Cuenta Básica" +
                "\nId de Cuenta: "+IdCuenta
                +"\nNombre: "+Nombre
                +"\nBalance: "+Balance
                +"\nPorcentaje de Interes:"+PorcentajeInteres
                +"\nInteres Ganado: "+CalcularInteres();
        }
    }
}

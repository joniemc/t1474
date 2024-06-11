using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuentasBancarias.Modelos
{
    public abstract class Cuenta
    {
        public string IdCuenta { get; set; }
        public string Nombre { get; set; }
        public double Balance { get; set; }
        public double PorcentajeInteres { get; set; }

        public Cuenta() { }

        public Cuenta(string idCuenta, string nombre, double balance, double porcentajeInteres)
        {
            IdCuenta=idCuenta;
            Nombre=nombre;
            Balance=balance;
            PorcentajeInteres=porcentajeInteres;
        }

        public void Deposito(double monto){
            if (monto>0) {
                Balance += monto;
            }
        }
        public void Retiro(double monto)
        {
            if (monto <= Balance) {
                Balance -= monto; 
            }
        }

        public abstract double CalcularInteres();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCuentasBancarias.Modelos
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public Usuario() { }

        public Usuario(string nombre, string correo) {
            Nombre = nombre;
            Correo = correo;
        }

    }
}

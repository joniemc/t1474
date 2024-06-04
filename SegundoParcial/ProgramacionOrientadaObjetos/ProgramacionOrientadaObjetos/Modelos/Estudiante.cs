using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos.Modelos
{
    public class Estudiante
    {
       //Definición de propiedades o atributos
        private string cuenta;
        private string nombreCompleto;
        private double calificacion;
        public string Estado {  get; set; }

        public Estudiante() { }
        public Estudiante(string cuenta) {
            this.Cuenta = cuenta;
        }
        public Estudiante(string cuenta, string nombreCompleto, double calificacion) {
            this.Cuenta = cuenta;
            this.NombreCompleto = nombreCompleto;
            this.Calificacion = calificacion;
        }

        //Setter & Getters
        public string Cuenta
        {
            get
            {
                return this.cuenta;
            }
            set
            {
                if (!value.Equals("001"))
                {
                    this.cuenta = value;
                }
                else
                {
                    this.cuenta = "Es Jonie";
                }
            }
        }

        public string NombreCompleto {
            get { 
                return this.nombreCompleto;
            }
            set {
                this.nombreCompleto = value;
            }
        }

        public double Calificacion
        {
            get
            {
                return this.calificacion;
            }
            set
            {
                if (value >0)
                {
                    if (value > 60)
                    {
                        this.Estado = "APROBÓ";
                    }
                    else
                    {
                        this.Estado = "REPROBÓ";
                    }

                    this.calificacion = value;
                }
                else
                {
                    this.calificacion= 0;
                }
            }
        }

        // Metodos especificos
        public override string ToString()
        {
            return "Cuenta: " +Cuenta+
                "\nNombre: " +nombreCompleto+
                "\nCalificación: "+Calificacion+
                "\nEstado: "+Estado;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENE
{
    class Empleado
    {
        // Propiedades de la clase Empleado

        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal ValorHora { get; set; }
        public decimal ValorExtra { get; set; }

        // Constructor de la clase Empleado
        
        public Empleado(string rut, string nombre, string direccion, string telefono, decimal valorHora, decimal valorExtra)
        {
            Rut = rut;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            ValorHora = valorHora;
            ValorExtra = valorExtra;
        }

        public Empleado()
        {
        }
    }

}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio_3
{
    public class Clientes
    {
        public string Nombre { get; set; }

        public string Correo { get; set; }

        public string Direccion { get; set; }

        public Clientes(string nombre, string correo, string direccion)
        {
            Nombre = nombre;
            Correo = correo;
            Direccion = direccion;
        }

        public void AsignarCliente(string nombreCliente)
        {
            if (Disponible)
            {
                ClienteAsignado = nombreCliente;
                CambiarDisponibilidad(false);
                Console.WriteLine($"Habitación {Numero} asignada a {nombreCliente}.");
            }
            else
            {
                Console.WriteLine($"La habitación {Numero} no está disponible.");
            }
        }
    }
}

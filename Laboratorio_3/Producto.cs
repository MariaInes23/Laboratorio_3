using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Producto
    {
        public string Nombre { get; set; }

        public string Precio { get; set; }

        public Producto(string nombre, string precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }
}

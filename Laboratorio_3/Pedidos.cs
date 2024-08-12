using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Pedidos
    {
        public int NumeroPedido { get; set; }

        public string Fecha { get; set; }

        public Pedidos(int numeroPedido, string fecha)
        {
            NumeroPedido = numeroPedido;
            Fecha = fecha;
        }
    }
}

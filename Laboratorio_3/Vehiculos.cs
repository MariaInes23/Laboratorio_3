using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3
{
    public class Vehiculos
    {
        public string Matricula { get; set; }

        public string Modelo { get; set; }

        public string TipoCombustible { get; set; }

        public Vehiculos(string matricula, string modelo, string tipoCombustible)
        {
            Matricula = matricula;
            Modelo = modelo;
            TipoCombustible = tipoCombustible;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Comida
    {
        string nombre;
        int carbohidratos;
        int proteinas;
        int grasas;

        public Comida(string n, int c, int p, int g)
        {
            nombre = n;
            carbohidratos = c;
            proteinas = p;
            grasas = g;
        }

        public override string ToString()
        {
            return $"{nombre} Carbohidratos:<{carbohidratos}> Proteinas:<{proteinas}> Grasas:<{grasas}>";
        }
    }
}

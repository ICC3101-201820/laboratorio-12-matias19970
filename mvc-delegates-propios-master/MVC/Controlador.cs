using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace MVC
{
    class Controlador
    {
        public Form1 form1;
        private ListaComidas comidas;

        public Controlador()
        {
            comidas = new ListaComidas();
        }

        public void OnAgregarComida(string nombre, int carbohidratos, int proteinas, int grasas)
        {
            Comida comida = new Comida(nombre, carbohidratos, proteinas, grasas);
            comidas.Agregar(comida);
            form1.AgregarComida(comida);
        }
    }
}

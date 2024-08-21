using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_3.Models
{
    internal class Dias
    {
        private int diadelmes;
        private int cantidaddevehiculos;
        public int Diadelmes { get { return diadelmes; } private set { } }
        public int Cantidaddevehiculos { get { return cantidaddevehiculos; } private set { } }
        public Dias(int dia)
        {
            this.diadelmes = dia;
        }

        public void sumarvehiculos(int autos)
        {
            cantidaddevehiculos = cantidaddevehiculos + autos;
        }


    }
}

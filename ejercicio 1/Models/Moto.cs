using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1.Models
{
    internal class Moto
    {
        private string marca;
        private int modelo;
        private double valorfrabrica;

        public Moto(string marca, int modelo, double valorfrabrica)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.valorfrabrica = valorfrabrica;
        }

        public string Marca { get { return marca; } private set { } }
        public int Modelo { get { return modelo; } private set { } }

        public double Valorfrabrica{ get { return valorfrabrica; } private set { } }
    }
}

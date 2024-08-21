using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1.Models
{
    internal class Calculadora
    {
        private string modelo;
        private string color;

        public Calculadora(string modelo, string color)
        {
            this.modelo = modelo;
            this.color = color;
        }

        public string Modelo { get { return modelo; } }

        public string Color { get { return color; } }

        public double DepreciacionLineal(double monto, int modelo, double añoactual, double vidautil)
        {
            double valoractualizado = monto - (monto * añoactual / vidautil);
            return valoractualizado;
        }

        public double DepreciacionAnual(double monto, double depreciacion)
        {
            double valoractualizado = monto * (monto * (1 - depreciacion));
            return valoractualizado;
        }

        public int añosdeuso(int modelomoto, int añoactual)
        {
            int depreciacion = añoactual - modelomoto;
            return depreciacion;
        }

    }
}

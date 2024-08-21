using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3__Solo_una_clase_.models
{
    internal class Peaje
    {
        private int cantidadtotalvehiculomes;
        private double promedio;
        private int[] misdias = new int[30];
        private int[] dias = new int[30];
        private int[] diasmayorespromedio = new int[30];
        private int cont = 0;
        private int contmayores = 0;

        public int Cantidadtotalvehiculomes { get { return cantidadtotalvehiculomes; } set{;} } 
        public double Promedio { get { return promedio; } }

        public int[] Misdias { get { return misdias; } }
        public int[] Dias { get { return dias; } }
        public int[] Diasmayorespromedio { get { return diasmayorespromedio; } }
        public int Cont { get { return cont; } }
        public int Contmayores { get { return contmayores; } }
        public void corroborardias()
        {
            for(int i=0; i<30; i++)
            {
                if (dias[i] > 0)
                {
                    misdias[cont] = dias[i];
                    cont++;
                }
            }
        }



        public void calcularpromedio()
        {
            int acum = 0;
            for (int i = 0; i < cont; i++)
            {
                acum = acum + misdias[i];
            }

            if ( cont > 0)
            {
                promedio = acum / cont;
            }
        }

        public void diasmayoresalpromedio()
        {
            for (int i = 0; i < 30; i++)
            { 
                if (dias[i] > promedio)
                {
                    diasmayorespromedio[contmayores] = i;
                }
            }
        }
    }
}

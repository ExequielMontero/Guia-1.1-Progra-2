using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    internal class Peaje
    {
        private int cantidadtotalvehiculomes;
        private double promedio;
        private ArrayList diasmayores = new ArrayList();
        public int Cantidadtotalvehiculomes { get { return cantidadtotalvehiculomes; } set { this.cantidadtotalvehiculomes = value; } } 
        public ArrayList Diasmayores { get { return diasmayores; } }
        public double Promedio { get { return promedio; } }
     
        

        static private ArrayList milista = new ArrayList();
        public ArrayList Milista { get { return milista; } }

        
        
        public void calcularpromedio(ArrayList milista)
        {
            int acum = 0;
            Dias diames = null;
            for (int i = 0; i < milista.Count; i++)
            {
                milista[0] = diames;
                acum = diames.Cantidaddevehiculos;
            }

            if(milista.Count > 0)
            {
                promedio = acum / milista.Count;
            }
        }

        public void diasmayoresalpromedio(ArrayList dias)
        {
            Dias j = null;
            for(int i=0; i<dias.Count; i++)
            {
                dias[0] = j;
                if (j.Cantidaddevehiculos > promedio)
                {
                    diasmayores.Add(j);
                }
            }
        }


    }
}

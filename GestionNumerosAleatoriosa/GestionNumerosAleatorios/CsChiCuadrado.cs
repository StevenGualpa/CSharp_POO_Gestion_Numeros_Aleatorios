using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNumerosAleatorios
{
    internal class CsChiCuadrado
    {

        private double valorreal;
        private double valorchi;
        private double[] data;

        public double Valorreal 
        { 
            get => valorreal; 
            set => valorreal = value; 
        }
        public double Valorchi 
        { 
            get => valorchi; 
            set => valorchi = value; 
        }
        public double[] Data 
        { 
            get => data; 
            set => data = value; 
        }

        public CsChiCuadrado(double[] Datos)
        { 
            Data= Datos;
        }

        public bool ChiCuadrado()
        {
            int k = (int)Math.Sqrt(Data.Length);
            double[] frequency = new double[k];
            Valorreal = 0;
            Valorchi = ChiSquared.InvCDF(k - 1, 0.95);

            for (int i = 0; i < Data.Length; i++)
            {
                int index = (int)(Data[i] * k);
                frequency[index]++;
            }
            for (int i = 0; i < k; i++)
            {
                double expected = Data.Length / (double)k;
                Valorreal += ((frequency[i] - expected) * (frequency[i] - expected)) / expected;
            }
            Valorchi = Valorchi;
            if (Valorreal < Valorchi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

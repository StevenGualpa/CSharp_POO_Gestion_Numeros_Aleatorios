using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNumerosAleatorios
{
    internal class csMediaVarianza
    {
        private double Varianza;
        private double Varianzaesperada;
        private double Promedio;
        private double PromedioEsperado;
        private double[] data;


        
        public double[] Data
        {
            get => data;
            set => data = value;
        }
        public double Varianza1 
        { 
            get => Varianza; 
            set => Varianza = value; 
        }
        public double Varianzaesperada1 
        { 
            get => Varianzaesperada; 
            set => Varianzaesperada = value; 
        }
        public double Promedio1 
        { 
            get => Promedio; 
            set => Promedio = value; 
        }
        public double PromedioEsperado1 
        { 
            get => PromedioEsperado; 
            set => PromedioEsperado = value; 
        }

        public csMediaVarianza(double[] data)
        {
            Data = data;
            Varianzaesperada1 = 0.08333;
            PromedioEsperado1 = 0.5;

        }

        public bool MediayVarianza()
        {
            double sum = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                sum += Data[i];
            }

            Promedio1 = sum / Data.Length;

            double sumOfSquares = 0;
            for (int i = 0; i < Data.Length; i++)
            {
                sumOfSquares += Math.Pow(Data[i] - Promedio1, 2);
            }

            Varianza1 = sumOfSquares / (Data.Length - 1);

            Console.WriteLine("Media esperada = 0.5");

            if (Math.Abs(Varianza1 - (1.0 / 12.0)) < 0.05)
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

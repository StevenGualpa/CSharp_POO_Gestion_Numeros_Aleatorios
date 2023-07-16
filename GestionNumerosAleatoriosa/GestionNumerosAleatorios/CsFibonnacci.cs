using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestionNumerosAleatorios
{
    internal class CsFibonnacci
    {

        private long lastNumber;
        private long currentNumber;
        private int cantidad;

        public long LastNumber 
        { get => lastNumber; 
          set => lastNumber = value; 
        }
        public long CurrentNumber 
        { get => currentNumber; 
          set => currentNumber = value; 
        }
        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public CsFibonnacci() 
        { 
        
        }
        public CsFibonnacci(long semilla, int cantidad)
        {
            LastNumber = semilla;
            CurrentNumber = semilla+1;
            Cantidad = cantidad;

        }


        public long NextRandomNumber()
        {
            long nextNumber = (LastNumber + CurrentNumber) % long.MaxValue;

            LastNumber = CurrentNumber;
            CurrentNumber = nextNumber;

            return nextNumber;
        }

        public long[] Generacion()
        {
            long[] generacion = new long[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                long numeroAleatorio = NextRandomNumber();
                generacion[i] = numeroAleatorio;
            }
            return generacion;
        
        }




    }
}

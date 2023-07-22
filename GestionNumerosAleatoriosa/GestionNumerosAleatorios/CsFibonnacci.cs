using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public CsFibonnacci(long semilla, long semilla2, int cantidad)
        {
            LastNumber = semilla;
            CurrentNumber = semilla2;
            Cantidad = cantidad;

        }
        public double NextRandomNumber()
        {
            double nextNumber = Math.Abs((lastNumber + currentNumber) % cantidad);

            long aux = lastNumber;
            LastNumber = CurrentNumber;
            CurrentNumber = aux+currentNumber;

            return nextNumber;
        }

        public DataGridView Generacion(DataGridView dataGridView)
        {
            CsAuxiliares auxiliares = new CsAuxiliares();
            dataGridView= auxiliares.Generar_Columnas_Filas(dataGridView,Cantidad,4);
            for (int i = 0; i < Cantidad; i++)
            {
                dataGridView[0, i].Value = (i+1).ToString();
                dataGridView[1, i].Value = LastNumber.ToString();
                dataGridView[2, i].Value = CurrentNumber.ToString();
                double numeroAleatorio = NextRandomNumber();
                dataGridView[3, i].Value = (numeroAleatorio/Cantidad).ToString();
            }
            return dataGridView;
        }

    }
}

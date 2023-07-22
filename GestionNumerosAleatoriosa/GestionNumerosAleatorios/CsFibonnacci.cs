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
        public double[] Generacion()
        {
            double[] generacion = new double[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
             
                double numeroAleatorio = NextRandomNumber();

                generacion[i] = numeroAleatorio / cantidad;
            }
            return generacion;
        }

        public DataGridView Generacion(DataGridView dataGridView)
        {
            dataGridView= Generar_Columnas_Filas(dataGridView);
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




        private DataGridView Generar_Columnas_Filas(DataGridView dataGridView)
        {
            DataGridViewTextBoxColumn coltext;
            string nam = "C";
            if (dataGridView.ColumnCount == 0)
            {
                dataGridView.RowCount = Cantidad;
                for (int i = 0; i < 4; i++)
                {
                    coltext = new DataGridViewTextBoxColumn();
                    coltext.Name = (nam + i.ToString());
                    dataGridView.Columns.Add(coltext);
                }
            }
            else
            {
                Limpiar_DataGridView(dataGridView);
                dataGridView.RowCount = Cantidad;
                for (int i = 0; i < 4; i++)
                {
                    coltext = new DataGridViewTextBoxColumn();
                    coltext.Name = (nam + i.ToString());
                    dataGridView.Columns.Add(coltext);
                }
            }
            dataGridView.Columns.RemoveAt(0);
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.RowHeadersVisible = false;
            return dataGridView;
        }

        void Limpiar_DataGridView(DataGridView dataGridView)
        {
            int numcl = 1;
            for (int i = 0; i < numcl; i++)
            {
                dataGridView.Columns.RemoveAt(0);
            }
            dataGridView.Rows.Clear();
        }
    }
}

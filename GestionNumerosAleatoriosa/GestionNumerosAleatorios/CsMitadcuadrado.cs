using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNumerosAleatorios
{
    internal class CsMitadcuadrado
    {

        private int cantidad;
        private int semilla;

        public String[] Serie;
        public String[] x1;
        public String[] xx;
        public String[] r;




        public int Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }
        public int Semilla
        {
            get => semilla;
            set => semilla = value;
        }



        public CsMitadcuadrado(int cantidad, int semilla) 
        { 
            this.Cantidad = cantidad;
            this.Semilla = semilla;
            Serie = new String[Cantidad];
            x1 = new String[Cantidad];
            xx = new String[Cantidad];
            r = new String[Cantidad];
        }

        public DataGridView Generacion(DataGridView dataGridView)
        {
            CsAuxiliares auxiliares = new CsAuxiliares();
            dataGridView = auxiliares.Generar_Columnas_Filas(dataGridView,Cantidad,5);
            for (int i = 0; i < Cantidad; i++)
            {
                int numDigitos = Semilla.ToString().Length;
                // Calcular el cuadrado de la semilla
                int cuadrado = Semilla * Semilla;
                // Convertir el cuadrado a una cadena
                string cuadradoCadena = cuadrado.ToString();
                // Si el número cuadrado tiene menos dígitos que el doble del número original,
                // rellenamos con ceros a la izquierda
                cuadradoCadena = cuadradoCadena.PadLeft(2 * numDigitos, '0');
                // Extraer los dígitos del medio
                string medio = cuadradoCadena.Substring(numDigitos / 2, numDigitos);


                dataGridView[0, i].Value = (i + 1).ToString();
                dataGridView[1, i].Value = Semilla.ToString();
                dataGridView[2, i].Value = cuadrado.ToString();
                dataGridView[3, i].Value = medio.ToString();
                dataGridView[4, i].Value = "0." + medio.ToString(); 



                //Almacenamos los Datos, aunque solo usaremos r para la Validacion
                Serie[i] = (i + 1).ToString();
                x1[i] = Semilla.ToString();
                xx[i] = cuadrado.ToString();
                r[i] = "0." + medio.ToString();
                Semilla = int.Parse(medio);//Actualizamos Semilla
            }
            return dataGridView;
        }

    }
}

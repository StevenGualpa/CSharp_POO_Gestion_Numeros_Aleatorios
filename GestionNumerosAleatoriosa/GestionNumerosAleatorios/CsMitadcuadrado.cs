using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        public void DatosAleatorios()
        {
            
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
                

                //Almacenamos los Datos
                Serie[i]=(i+1).ToString();
                x1[i]=Semilla.ToString();
                xx[i] = cuadrado.ToString();
                r[i] = "0."+medio.ToString();
                Semilla= int.Parse(medio);//Actualizamos Semilla
            }
        }




        public string Mensaje() 
        {
            DatosAleatorios();
          
            return r[0].ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNumerosAleatorios
{
    internal class CsCongruencialMixto
    {

        private int a;      // Multiplicador
        private int c;      // Incremento
        private int m;     // Modulo
        private int X0;     // Semilla
        private int Cantidad;


        public int A { get => a; set => a = value; }
        public int C { get => c; set => c = value; }
        public int M { get => m; set => m = value; }
        public int X01 { get => X0; set => X0 = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }

        public CsCongruencialMixto()
        {


        }

        public CsCongruencialMixto(int a, int c, int m, int x01, int cantidad1)
        {
            A = a;
            C = c;
            M = m;
            X01 = x01;
            Cantidad1 = cantidad1;
        }


        public DataGridView Generacion(DataGridView dataGridView)
        {
            CsAuxiliares auxiliares = new CsAuxiliares();
            dataGridView = auxiliares.Generar_Columnas_Filas(dataGridView, Cantidad, 3);
            for (int i = 0; i < Cantidad; i++)
            {
                dataGridView[0, i].Value = (i + 1).ToString();
                dataGridView[1, i].Value = (X01).ToString();

                double aux = CongruencialMixto();
                dataGridView[2, i].Value = (aux).ToString();


            }
            return dataGridView;
        }


        double CongruencialMixto()
        {
            X01 = (A * X01 + C) % M;
            return (double)X01 / M;
        }

    }
}

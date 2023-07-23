using MathNet.Numerics.Distributions;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace GestionNumerosAleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Btn_MitadCuadrado_Click(object sender, EventArgs e)
        {
            FrmMitadCuadrado frm = new FrmMitadCuadrado();
            frm.ShowDialog();
        }

        private void Btn_Fibonacci_Click(object sender, EventArgs e)
        {
            FrmMetodoFibonnaci fibonnaci = new FrmMetodoFibonnaci();
            fibonnaci.ShowDialog();
        }

        private void Btn_Multiplicativo_Click(object sender, EventArgs e)
        {
            FrmCroguencialMultiplicativo frm = new FrmCroguencialMultiplicativo();
            frm.ShowDialog();
        }

        private void Btn_Mixto_Click(object sender, EventArgs e)
        {
            FrmCongruencialMixto frm = new FrmCongruencialMixto();
            frm.ShowDialog();
        }

        private void Btn_Cargar_Click(object sender, EventArgs e)
        {
            Imprimirreporte();

        }
        public void Imprimirreporte()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            // Mostrar el diálogo de vista previa antes de imprimir
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }


        public void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            CsAuxiliares csAuxiliares= new CsAuxiliares();
            double [] datos = csAuxiliares.ExtraerDatos();

            // Configurar fuente y colores
            Font fontEncabezado = new Font("Times new Roman", 12, FontStyle.Bold);
            Font fonText = new Font("Arial", 10);


            // Definir dimensiones y posiciones
            float xEncabezado = e.MarginBounds.Left;
            float yEncabezado = e.MarginBounds.Top;

            // Dibujar encabezado
            e.Graphics.DrawString("Números pseudoaleatorios evaluados: " + datos.Length,
                new Font("Times new Roman", 12, FontStyle.Bold), 
                new SolidBrush(Color.Black), 
                xEncabezado, 
                yEncabezado);


            // Dibujar línea horizontal
            float yLinea = yEncabezado + fontEncabezado.GetHeight() + 10;
            e.Graphics.DrawLine(new Pen(Color.Black), xEncabezado, yLinea, e.MarginBounds.Right, yLinea);

            // Definir fuente y posición para el texto adicional
            float xTexto = xEncabezado; // Misma posición X que el encabezado
            float yTexto = yLinea + 10; // Ajusta la posición Y según tu necesidad

            // Dibujar líneas de texto adicionales
            e.Graphics.DrawString("Pruebas realizadas:", fonText, new SolidBrush(Color.Black), xTexto, yTexto);

            yTexto += fonText.GetHeight() + 5; //Salto de Linea
            e.Graphics.DrawString("* Media y varianza", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 5; //Salto de Linea
            e.Graphics.DrawString("* Prueba de Chi Cuadrado", fonText, new SolidBrush(Color.Black), xTexto, yTexto);

            yTexto += fonText.GetHeight() + 5; //Salto de Linea
            yTexto += fonText.GetHeight() + 5; //Salto de Linea
            e.Graphics.DrawLine(new Pen(Color.Black), xEncabezado, yTexto, e.MarginBounds.Right, yTexto);


            bool chi = ChiCuadrado(datos);

            e.Graphics.DrawString("Prueba de chi cuadrado", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 5;
            yTexto += fonText.GetHeight() + 5;
            e.Graphics.DrawString("Sumatoria: " + valorreal, fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 5;
            e.Graphics.DrawString("Chi cuadrado: " + valorchi, fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 5;


            if (chi)
            {
                e.Graphics.DrawString("Los datos analizados no se pueden rechazar, debido a que la sumatoria es menor a la prueba de chi cuadrada. Se acepta", 
                    fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            }
            else
            {
                e.Graphics.DrawString("Los datos analizados no se pueden aceptar, debido a que la sumatoria es mayor a la prueba de chi cuadrada. No se acepta", fonText, 
                    new SolidBrush(Color.Black), xTexto, yTexto);
            }
            yTexto += fonText.GetHeight() + 5;
            yTexto += fonText.GetHeight() + 5;
            e.Graphics.DrawLine(new Pen(Color.Black), xEncabezado, yTexto, e.MarginBounds.Right, yTexto);
            bool var = MediayVarianza(datos);
            e.Graphics.DrawLine(new Pen(Color.Black), xEncabezado, yTexto, e.MarginBounds.Right, yTexto);
            yTexto += fonText.GetHeight() + 5;
            yTexto += fonText.GetHeight() + 5;
            e.Graphics.DrawString("Prueba de Media Y Varianza", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 5;
            yTexto += fonText.GetHeight() + 5;


            e.Graphics.DrawString("Promedio: " + Promedio, fonText, new SolidBrush(Color.Black), xTexto, yTexto);

            yTexto += fonText.GetHeight() + 5;
            e.Graphics.DrawString("Promedio esperado: 0.5", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 5;
            if (Math.Abs((Promedio - 0.5) / Promedio) < 0.05)
            {
                e.Graphics.DrawString("Promedio observado es bastante cercano al promedio esperado, por ende pasa la prueba", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            }
            else
            {
                e.Graphics.DrawString("Promedio observado difiere bastante del promedio esperado. No pasa la prueba", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            }
            yTexto += fonText.GetHeight() + 5;

                        
            e.Graphics.DrawString("Varianza: " + Varianza, fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 5;
            e.Graphics.DrawString("Varianza esperada: " + Varianzaesperada, fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 5;
            if (Math.Abs(Varianza - (1.0 / 12.0)) < 0.05)
            {
                e.Graphics.DrawString("La secuencia pasa la prueba de varianza.", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            }
            else
            {
                e.Graphics.DrawString("La secuencia no pasa la prueba de varianza.", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            }
            yTexto += fonText.GetHeight() + 5;
            e.Graphics.DrawLine(new Pen(Color.Black), xEncabezado, yTexto, e.MarginBounds.Right, yTexto);


        }






        //Metodos Validacion
        private double valorreal, valorchi, Varianza, Varianzaesperada, Promedio;

        bool ChiCuadrado(double[] data)
        {
            int k = (int)Math.Sqrt(data.Length);
            double[] frequency = new double[k];
            double chiSquared = 0;
            double chiSquaredCritical = ChiSquared.InvCDF(k - 1, 0.95);

            for (int i = 0; i < data.Length; i++)
            {
                int index = (int)(data[i] * k);
                frequency[index]++;
            }

            for (int i = 0; i < k; i++)
            {
                double expected = data.Length / (double)k;
                chiSquared += ((frequency[i] - expected) * (frequency[i] - expected)) / expected;
                //Console.WriteLine("Intervalo {0}: Frecuencia = {1}, Valor esperado = {2}, Valor Chi = {3}", i + 1, frequency[i], expected, ((frequency[i] - expected) * (frequency[i] - expected)) / expected);
            }

            //Console.WriteLine("\nChi cuadrado total = {0}", chiSquared);
            //Console.WriteLine("Valor crítico de Chi cuadrado = {0}", chiSquaredCritical);
            valorreal=chiSquared;
            valorchi=chiSquaredCritical;

            if (chiSquared < chiSquaredCritical)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        bool MediayVarianza(double[] data)
        {
            double sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }

            double sampleMean = sum / data.Length;

            double sumOfSquares = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sumOfSquares += Math.Pow(data[i] - sampleMean, 2);
            }

            double sampleVariance = sumOfSquares / (data.Length - 1);

            Promedio = sampleMean;
            Varianza = sampleVariance;
            Varianzaesperada = 0.08333;
            Console.WriteLine("Media de la muestra = {0}", sampleMean);
            Console.WriteLine("Media esperada = 0.5");
            Console.WriteLine("Varianza de la muestra = {0}", sampleVariance);
            Console.WriteLine("Varianza esperada = 0.08333");

            if (Math.Abs(sampleVariance - (1.0 / 12.0)) < 0.05)
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

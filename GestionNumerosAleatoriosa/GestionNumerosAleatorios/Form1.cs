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

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }


        public void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            CsAuxiliares csAuxiliares= new CsAuxiliares();
            CsChiCuadrado csChiCuadrado;
            csMediaVarianza csMediaVarianza;

            double [] datos = csAuxiliares.ExtraerDatos();

            // Configurar fuente y colores
            Font fontEncabezado = new Font("Times new Roman", 12, FontStyle.Bold);
            Font fonText = new Font("Times new Roman", 10);


            // Definir dimensiones y posiciones
            float xEncabezado = e.MarginBounds.Left;
            float yEncabezado = e.MarginBounds.Top;

            // Dibujar encabezado
            e.Graphics.DrawString("Números pseudoaleatorios evaluados: " + datos.Length, fontEncabezado, new SolidBrush(Color.Black), xEncabezado, yEncabezado);


            // Dibujar línea horizontal
            float yLinea = yEncabezado + fontEncabezado.GetHeight() + 10;

            // Definir fuente y posición para el texto adicional
            float xTexto = xEncabezado; // Misma posición X que el encabezado
            float yTexto = yLinea + 10; // Ajusta la posición Y según tu necesidad


            // Pruebas Realizadas
            string texto = String.Format("Pruebas realizadas:\n  \n *Prueba de Chi Cuadrado:\n  \n *Media y varianza: ");
            e.Graphics.DrawString(texto, fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 100; //Salto de Linea

            // Chi Cuadrado
            csChiCuadrado = new CsChiCuadrado(datos);
            bool chi = csChiCuadrado.ChiCuadrado();
            texto = String.Format("Prueba de chi cuadrado\n  \n *Sumatoria: {0}\n  \n *Chi cuadrado:{1} ", csChiCuadrado.Valorreal, csChiCuadrado.Valorchi);
            if (chi)
                e.Graphics.DrawString(texto+ "\n  \n *Se acepta", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            else
                e.Graphics.DrawString(texto + "\n  \n *No se acepta", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            yTexto += fonText.GetHeight() + 150;  //Salto de Linea

            // Media y Varianza
            csMediaVarianza = new csMediaVarianza(datos);
            bool var = csMediaVarianza.MediayVarianza();
            texto = String.Format("Prueba de Media Y Varianza\n  \n *Promedio: {0}\n  \n *Promedio esperado: 0.5\n  \n ", 
                csMediaVarianza.Promedio1);

            if (Math.Abs((csMediaVarianza.Promedio1 - 0.5) / csMediaVarianza.Promedio1) < 0.05)
                texto += "*Pasa la Prueba, promedio observado es cercano al esperado\n  \n";
            else
                texto += "*No pasa la Prueba, promedio observado difiere al esperado\n  \n";

            texto += "*Varianza: " + csMediaVarianza.Varianza1+ "\n  \n";
            texto += "*Varianza esperada: " + csMediaVarianza.Varianzaesperada1 + "\n  \n";

            if (var)
                e.Graphics.DrawString(texto+ "*La secuencia pasa la prueba", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
            else
                e.Graphics.DrawString(texto + "*La secuencia no pasa la prueba", fonText, new SolidBrush(Color.Black), xTexto, yTexto);
        }
    }
}

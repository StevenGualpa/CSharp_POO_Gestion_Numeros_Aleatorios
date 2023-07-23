using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNumerosAleatorios
{
    internal class CsAuxiliares
    {
             
        public CsAuxiliares() { }


        //Validar Valores Numericos
        public bool ValidarInt(string valor) 
        {
            try {
                int resul = Convert.ToInt32(valor);
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        public bool ValidarDouble(string valor)
        {
            try
            {
                double resul = Convert.ToDouble(valor);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ValidarLong(string valor)
        {
            try
            {
                long resul = Convert.ToInt64(valor);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



        //Manejo de DataGridViews

        public DataGridView Generar_Columnas_Filas(DataGridView dataGridView,int Cantidad,int Columnas)
        {
            DataGridViewTextBoxColumn coltext;
            string nam = "C";
            if (dataGridView.ColumnCount == 0)
            {
                dataGridView.RowCount = Cantidad;
                for (int i = 0; i < Columnas; i++)
                {
                    coltext = new DataGridViewTextBoxColumn();
                    coltext.Name = (nam + i.ToString());
                    dataGridView.Columns.Add(coltext);
                }
            }
            else
            {
                Limpiar_DataGridView(dataGridView, Columnas);
                dataGridView.RowCount = Cantidad;
                for (int i = 0; i < Columnas; i++)
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

        void Limpiar_DataGridView(DataGridView dataGridView,int Columnas)
        {
            int numcl = 1;
            for (int i = 0; i < Columnas; i++)
            {
                dataGridView.Columns.RemoveAt(0);
            }
            dataGridView.Rows.Clear();
        }


        //Metodo Para Guardar
        public string Crearruta()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            saveFileDialog.Title = "Guardar archivo de texto";
            saveFileDialog.CheckFileExists = false;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }
            else
            { return "error"; }
        }

        public void Guardar(DataGridView dataGridView, int celda) 
        {
            if (dataGridView.RowCount != 0)
            {
                string ruta= Crearruta();
                try
                {
                    using (StreamWriter writer = new StreamWriter(ruta))
                    {
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            string linea = dataGridView.Rows[i].Cells[celda].Value.ToString();
                            writer.WriteLine(linea);
                        }
                    }
                }
                catch
                {

                }

            }
            else { MessageBox.Show("No existen números Pseudoaleatorios"); }
        }

        //Metodo Para Leer
        private string Obtenerruta()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            openFileDialog.Title = "Seleccionar archivo de texto";
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            { return "error"; }
        }

    }
}

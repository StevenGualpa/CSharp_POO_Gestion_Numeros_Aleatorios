using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNumerosAleatorios
{
    internal class CsAuxiliares
    {
             
        public CsAuxiliares() { }

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


    }
}

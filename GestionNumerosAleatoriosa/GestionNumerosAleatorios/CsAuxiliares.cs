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


        public DataGridView Llenar()
        { 
            DataGridView dgv=new DataGridView();
            return dgv;
        }

    }
}

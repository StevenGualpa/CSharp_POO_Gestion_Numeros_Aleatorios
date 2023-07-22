using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNumerosAleatorios
{
    public partial class FrmMetodoFibonnaci : Form
    {
        public FrmMetodoFibonnaci()
        {
            InitializeComponent();
        }

        private void FrmMetodoFibonnaci_Load(object sender, EventArgs e)
        {


        }        


        private void Btn_GenerarAleatorios_Click(object sender, EventArgs e)
        {
            string semilla=Txt_GenerarAleatorios.Text;
            string x0=Txt_Semilla01.Text;
            string x1=Txt_c.Text;
            CsAuxiliares axu = new CsAuxiliares();
            CsFibonnacci fibonnacci;
            if (axu.ValidarInt(semilla))
            {
                if (axu.ValidarInt(x0))
                {
                    if (axu.ValidarInt(x1))
                    {
                        fibonnacci = new CsFibonnacci(Convert.ToInt64(x0), Convert.ToInt64(x1), Convert.ToInt32(semilla));
                        dataGridView1 = fibonnacci.Generacion(dataGridView1);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese solo Numeros");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese solo Numeros");
                }

            }
            else
            {
                MessageBox.Show("Ingrese solo Numeros");
            }

        
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

        }


    }
}

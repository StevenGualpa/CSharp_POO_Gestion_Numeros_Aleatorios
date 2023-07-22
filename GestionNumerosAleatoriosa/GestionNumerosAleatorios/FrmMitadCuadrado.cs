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
    public partial class FrmMitadCuadrado : Form
    {
        public FrmMitadCuadrado()
        {
            InitializeComponent();
        }

        private void FrmMitadCuadrado_Load(object sender, EventArgs e)
        {

        }

        private void Btn_GenerarAleatorios_Click(object sender, EventArgs e)
        {
            string semilla = Txt_GenerarAleatorios.Text;
            string x0 = Txt_Semilla01.Text;
            CsAuxiliares axu = new CsAuxiliares();
            if (axu.ValidarInt(semilla))
            {
                if (axu.ValidarInt(x0))
                {
                    CsMitadcuadrado mitadcuadrado = new CsMitadcuadrado(Convert.ToInt32(semilla), Convert.ToInt32(x0));
                    dataGridView1 = mitadcuadrado.Generacion(dataGridView1);
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

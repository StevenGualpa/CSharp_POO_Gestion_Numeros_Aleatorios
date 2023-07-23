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
    public partial class FrmCroguencialMultiplicativo : Form
    {
        public FrmCroguencialMultiplicativo()
        {
            InitializeComponent();
        }

        private void FrmCroguencialMultiplicativo_Load(object sender, EventArgs e)
        {

        }

        private void Btn_GenerarAleatorios_Click(object sender, EventArgs e)
        {
            string semilla = Txt_GenerarAleatorios.Text;
            string x0 = Txt_Semilla01.Text;
            string a = Txt_a.Text;
            string m = Txt_m.Text;
            CsAuxiliares auxiliares = new CsAuxiliares();
            if (auxiliares.ValidarInt(semilla)
                && auxiliares.ValidarInt(x0)
                && auxiliares.ValidarInt(a)
                && auxiliares.ValidarInt(m))
            {
                CsCongruencialMultiplicativo csCongruencialMultiplicativo = new CsCongruencialMultiplicativo(Convert.ToInt32(a),
                    Convert.ToInt32(m), Convert.ToInt32(x0), Convert.ToInt32(semilla));
                dataGridView1 = csCongruencialMultiplicativo.Generacion(dataGridView1);
            }
            else
            {
                MessageBox.Show("Ingrese solo Numeros");
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            CsAuxiliares auxiliares = new CsAuxiliares();
            auxiliares.Guardar(dataGridView1, 2);
        }
    }
}

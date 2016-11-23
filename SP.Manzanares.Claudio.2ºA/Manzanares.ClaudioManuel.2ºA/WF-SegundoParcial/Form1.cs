using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using miLibreriaDeClases;

namespace WF_SegundoParcial
{
    public partial class Form1 : Form
    {
        Tienda miTienda = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            string salidaDatos=null;

            miTienda.Leer("Tienda.txt", out salidaDatos);

            MessageBox.Show(salidaDatos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            miTienda = new Tienda(txtboxDireccion.Text,txtboxAncho.Text,txtboxLegajo.Text);

            miTienda.Guardar("Tienda.txt");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLibrary;

namespace Eventos
{
    public partial class Form1 : Form
    {
        Cuenta miCuenta;

        public Form1()
        {
            InitializeComponent();
            miCuenta = new Cuenta();
            miCuenta.SaldoNegativo += this.juan;//Asigno el manejador al evento.
        }

        private void txtboxUno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            miCuenta.SacarDinero(1000);
        }

        private void btnAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("BTN ACEPTAR");
        }

        private void btnAceptar_KeyPress2(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("BTN ACEPTAR2");
        }
        private void btnAceptar_KeyPressMIO(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("MIO");
        }

        /// <summary>
        /// Manejador para el evento.
        /// </summary>
        /// <param name="dinero"></param>
        public void juan(float dinero)
        {
            MessageBox.Show(dinero.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myLibrary
{
    //Creo la firma para el evento.
    public delegate void CuentaDelegado(float dinero);
    public class Cuenta
    {
        public float saldo;

        public void SacarDinero(float dinero)
        {
            if (dinero > saldo)
            { //Si estuvieramos en una aplicacion de consola "console.write".
              //Si fuera winform "messagebox".
              //Si fuera pagina web seria un alert.

                SaldoNegativo(dinero);//Disparo evento.
            }
        }
        
        //Creo el evento.
        public event CuentaDelegado SaldoNegativo;
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using miLibreriaDeClases;
using Excepciones;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {           
                Tienda miTienda = new Tienda("Av.Mitre 1010", "30", "11124");
                miTienda.Guardar("X:BadLocation.txt");
                Assert.Fail("Sin excepcion directorio erronero.");

            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NoGuardaException));
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            string salidaDatos = null;

            try
            {
                Tienda miTienda = new Tienda("Av.Mitre 1010", "30", "11124");
                if (!miTienda.Guardar("Tienda.txt"))
                {
                    Assert.Fail("No Guardo");
                }
                if (!miTienda.Leer("Tienda.txt", out salidaDatos))
                {
                    Assert.Fail("No Leyo el archivo.");
                }
            }
            catch (Exception e)
            {
               Assert.IsInstanceOfType(e, typeof(NoLeeException));
            }
        
        }
    }
}

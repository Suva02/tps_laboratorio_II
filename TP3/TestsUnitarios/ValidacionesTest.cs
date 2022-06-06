using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suetta.Valentin._2C.TPFinal;
using System;

namespace TestsUnitarios
{
    [TestClass]
    public class ValidacionesTest
    {
        /// <summary>
        /// TESTEA QUE EL METODO "validarString" retorne "TRUE" CUANDO UNA CADENA ESTA 
        /// COMPUESTA POR NUMEROS
        /// </summary>
        [TestMethod]
        public void validarString_CuandoLaCadenaEstaCompuestPorNumeros_DeberiaRetornarTrue()
        {
            bool actual;
            bool expected = true;
            Cliente cliente = new Cliente();

            actual = cliente.validarString("1234");


            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// TESTEA QUE EL METODO "validarString" retorne "TRUE" CUANDO UNA CADENA ESTA
        /// VACIA
        /// </summary>
        [TestMethod]
        public void validarString_CuandoLaCadenaEstaVacia_DeberiaRetornarTrue()
        {
            bool actual;
            bool expected = true;
            Cliente cliente = new Cliente();

            actual = cliente.validarString("");


            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// TESTEA QUE EL METODO "validarString" retorne "TRUE" CUANDO UNA CADENA TIENE
        /// ESPACIOS.
        /// </summary>
        [TestMethod]
        public void validarString_CuandoLaCadenaContengaEspacios_DeberiaRetornarTrue()
        {
            bool actual;
            bool expected = true;
            Cliente cliente = new Cliente();

            actual = cliente.validarString("   ");


            Assert.AreEqual(expected, actual);
        }

    }
}
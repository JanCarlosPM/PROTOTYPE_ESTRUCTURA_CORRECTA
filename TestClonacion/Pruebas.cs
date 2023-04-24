using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class Pruebas
    {
        //TEST METHOD PARA EL MÉTODO CLONE()//
        [TestMethod]
        public void TestClonarComputadora()
        {
            // Crea una nueva computadora
            Computadoras original = new Computadoras();
            original.Marca = "Dell";
            original.Modelo = "Inspiron";
            original.Procesador = "Intel i8";
            original.MemoriaRam = 16;
            original.Almacenamiento = 500;
            original.SistemaOperativo = "Windows";

            // Clona la computadora
            Computadoras clon = (Computadoras)original.Clone();
          
            // Verifica que los atributos de la computadora clonada sean iguales a los de la original
            Assert.AreEqual(original.Marca, clon.Marca);
            Assert.AreEqual(original.Modelo, clon.Modelo);
            Assert.AreEqual(original.Procesador, clon.Procesador);
            Assert.AreEqual(original.MemoriaRam, clon.MemoriaRam);
            Assert.AreEqual(original.Almacenamiento, clon.Almacenamiento);
            Assert.AreEqual(original.SistemaOperativo, clon.SistemaOperativo);
        }

        //TEST METHOD PARA LA CONEXIÓN A LA BASE DE DATOS//
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestConexionBaseDeDatos()
        {
            DataAccess.VerificarConexionBaseDeDatos();
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBasicBuild;

namespace BasicVerification.Test
{
    [TestClass]
    public class BasicVerification
    {
        [TestMethod]
        public void Basic_Unit_Test()
        {
            var basicTest = new Mensajes();
            Assert.AreEqual("Hola Jenkins", $"{Mensajes.Greeting()} {Mensajes.Name()}");
        }
    }
}

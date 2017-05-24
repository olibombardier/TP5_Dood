using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP5_Dood.VuesModeles;

namespace TestTP5_Dood
{
    [TestClass]
    public class ParcsVueModelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            // Faire cela mais selon les tests que David à écris pour le TP 4
            vueModel.NomReservoirActuel = "Salut";

            Assert.AreEqual("Salut", vueModel.NomReservoirActuel);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP5_Dood.VuesModeles;
using TP5_Dood.Modeles;

namespace TestTP5_Dood
{
    [TestClass]
    public class ParcsVueModelTest
    {
        Random rand = new Random(DateTime.Now.GetHashCode());

        //TEST NORMAL
        [TestMethod]
        public void ReservoirNormal()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            string nomAttendu = "Réservoir 1";
            string typeHuileAttendu = "Huile usée";
            double seuil1Attendu = 0.7;
            double seuil2Attendu = 0.8;
            double seuil3Attendu = 0.9;

            vueModel.ReservoirActuel = new Reservoir() { Nom = "Réservoir 1", Type_Huile = "Huile usée", Seuil1 = 0.7, Seuil2 = 0.8, Seuil3 = 0.9 };

            Assert.AreEqual(nomAttendu, vueModel.NomReservoirActuel);
            Assert.AreEqual(typeHuileAttendu, vueModel.TypeHuileReservoirActuel);
            Assert.AreEqual(seuil1Attendu, vueModel.Seuil1ReservoirActuel);
            Assert.AreEqual(seuil2Attendu, vueModel.Seuil2ReservoirActuel);
            Assert.AreEqual(seuil3Attendu, vueModel.Seuil3ReservoirActuel);
        }

        //TESTS ALÉATOIRES
        [TestMethod]
        public void Seuil1NegatifAleatoire()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil1Attendu = 0;

            vueModel.Seuil1ReservoirActuel = -rand.Next();

            Assert.AreEqual(seuil1Attendu, vueModel.Seuil1ReservoirActuel);
        }

        [TestMethod]
        public void Seuil2NegatifAleatoire()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil2Attendu = 0;

            vueModel.Seuil2ReservoirActuel = -rand.Next();

            Assert.AreEqual(seuil2Attendu, vueModel.Seuil2ReservoirActuel);
        }

        [TestMethod]
        public void Seuil3NegatifAleatoire()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil3Attendu = 0;

            vueModel.Seuil3ReservoirActuel = -rand.Next();

            Assert.AreEqual(seuil3Attendu, vueModel.Seuil3ReservoirActuel);
        }

        [TestMethod]
        public void Seuil1SuperieurPlusAleatoire()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil1Attendu = 1;

            vueModel.Seuil1ReservoirActuel = 1 + rand.Next();

            Assert.AreEqual(seuil1Attendu, vueModel.Seuil1ReservoirActuel);
        }

        [TestMethod]
        public void Seuil2SuperieurPlusAleatoire()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil2Attendu = 1;

            vueModel.Seuil2ReservoirActuel = 1 + rand.Next();

            Assert.AreEqual(seuil2Attendu, vueModel.Seuil2ReservoirActuel);
        }

        [TestMethod]
        public void Seuil3SuperieurPlusAleatoire()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil3Attendu = 1;

            vueModel.Seuil3ReservoirActuel = 1 + rand.Next();

            Assert.AreEqual(seuil3Attendu, vueModel.Seuil3ReservoirActuel);
        }

        //TESTS DE LIMITES
        [TestMethod]
        public void ReservoirNomNull()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            string nomAttendu = null;

            vueModel.NomReservoirActuel = null;

            Assert.AreEqual(nomAttendu, vueModel.NomReservoirActuel);
        }

        [TestMethod]
        public void ReservoirNomTropLong()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            string nomAttendu = new string('a', 255);

            vueModel.NomReservoirActuel = new string('a', 256);

            Assert.AreEqual(nomAttendu, vueModel.NomReservoirActuel);
        }

        [TestMethod]
        public void ReservoirTypeHuileNull()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            string typeHuileAttendu = null;

            vueModel.TypeHuileReservoirActuel = null;

            Assert.AreEqual(typeHuileAttendu, vueModel.TypeHuileReservoirActuel);
        }

        [TestMethod]
        public void ReservoirTypeHuileTropLong()
        {
            ParcsVueModel vueModel = new ParcsVueModel();
            
            string typeHuileAttendu = new string('a', 255);

            vueModel.NomReservoirActuel = new string('a', 256);
            
            Assert.AreEqual(typeHuileAttendu, vueModel.TypeHuileReservoirActuel);
        }

        [TestMethod]
        public void ReservoirStringsNull()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            string nomAttendu = null;
            string typeHuileAttendu = null;

            vueModel.ReservoirActuel = new Reservoir() { Nom = null, Type_Huile = null };

            Assert.AreEqual(nomAttendu, vueModel.NomReservoirActuel);
            Assert.AreEqual(typeHuileAttendu, vueModel.TypeHuileReservoirActuel);
        }

        [TestMethod]
        public void ReservoirNull()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            string nomAttendu = null;
            string typeHuileAttendu = null;
            double seuil1Attendu = 0;
            double seuil2Attendu = 0;
            double seuil3Attendu = 0;

            vueModel.ReservoirActuel = null;

            Assert.AreEqual(nomAttendu, vueModel.NomReservoirActuel);
            Assert.AreEqual(typeHuileAttendu, vueModel.TypeHuileReservoirActuel);
            Assert.AreEqual(seuil1Attendu, vueModel.Seuil1ReservoirActuel);
            Assert.AreEqual(seuil2Attendu, vueModel.Seuil2ReservoirActuel);
            Assert.AreEqual(seuil3Attendu, vueModel.Seuil3ReservoirActuel);
        }

        [TestMethod]
        public void Seuil1ReservoirLimiteInferieureMoins()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil1Attendu = 0;

            vueModel.Seuil1ReservoirActuel = -double.Epsilon;

            Assert.AreEqual(seuil1Attendu, vueModel.Seuil1ReservoirActuel);

        }

        [TestMethod]
        public void Seuil1ReservoirLimiteInferieure()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil1Attendu = 0;

            vueModel.Seuil1ReservoirActuel = 0;

            Assert.AreEqual(seuil1Attendu, vueModel.Seuil1ReservoirActuel);
        }

        [TestMethod]
        public void Seuil1ReservoirLimiteSuperieure()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil1Attendu = 1;

            vueModel.Seuil1ReservoirActuel = 1;

            Assert.AreEqual(seuil1Attendu, vueModel.Seuil1ReservoirActuel);
        }

        [TestMethod]
        public void Seuil1ReservoirLimiteSuperieurPlus()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil1Attendu = 1d+double.Epsilon;

            vueModel.Seuil1ReservoirActuel = 1;

            Assert.AreEqual(seuil1Attendu, vueModel.Seuil1ReservoirActuel);
        }

        [TestMethod]
        public void Seuil2ReservoirLimiteInferieureMoins()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil2Attendu = 0;

            vueModel.Seuil2ReservoirActuel = -double.Epsilon;

            Assert.AreEqual(seuil2Attendu, vueModel.Seuil2ReservoirActuel);

        }

        [TestMethod]
        public void Seuil2ReservoirLimiteInferieure()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil2Attendu = 0;

            vueModel.Seuil2ReservoirActuel = 0;

            Assert.AreEqual(seuil2Attendu, vueModel.Seuil2ReservoirActuel);
        }

        [TestMethod]
        public void Seuil2ReservoirLimiteSuperieure()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil2Attendu = 1;

            vueModel.Seuil2ReservoirActuel = 1;

            Assert.AreEqual(seuil2Attendu, vueModel.Seuil2ReservoirActuel);
        }

        [TestMethod]
        public void Seuil2ReservoirLimiteSuperieurPlus()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil2Attendu = 1d + double.Epsilon;

            vueModel.Seuil2ReservoirActuel = 1;

            Assert.AreEqual(seuil2Attendu, vueModel.Seuil2ReservoirActuel);
        }

        [TestMethod]
        public void Seuil3ReservoirLimiteInferieureMoins()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil3Attendu = 0;

            vueModel.Seuil3ReservoirActuel = -double.Epsilon;

            Assert.AreEqual(seuil3Attendu, vueModel.Seuil3ReservoirActuel);

        }

        [TestMethod]
        public void Seuil3ReservoirLimiteInferieure()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil3Attendu = 0;

            vueModel.Seuil3ReservoirActuel = 0;

            Assert.AreEqual(seuil3Attendu, vueModel.Seuil3ReservoirActuel);
        }

        [TestMethod]
        public void Seuil3ReservoirLimiteSuperieure()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil3Attendu = 1;

            vueModel.Seuil3ReservoirActuel = 1;

            Assert.AreEqual(seuil3Attendu, vueModel.Seuil3ReservoirActuel);
        }

        [TestMethod]
        public void Seuil3ReservoirLimiteSuperieurPlus()
        {
            ParcsVueModel vueModel = new ParcsVueModel();

            double seuil3Attendu = 1d + double.Epsilon;

            vueModel.Seuil3ReservoirActuel = 1;

            Assert.AreEqual(seuil3Attendu, vueModel.Seuil3ReservoirActuel);
        }
    }
}

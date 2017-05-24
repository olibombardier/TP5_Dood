using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP5_Dood.VuesModeles;
using TP5_Dood.Modeles;

namespace TestTP5_Dood
{
    [TestClass]
    public class ParcsVueModelTest
    {
        [TestMethod]
        public void ReservoirNull()
        {
            // Les test vont pas mal tous ressembler à ça

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
            // Si les tests ne passent pas lorsque tu fais 'Test > Excecuter > Tous les tests',
            // il faut que tu t'arrange pour qu'il passent (Si un string est trop grand, fais un substring, etc.)
        }

        [TestMethod]
        public void ReservoirNormal()
        {
            // Les test vont pas mal tous ressembler à ça

            ParcsVueModel vueModel = new ParcsVueModel();

            string nomAttendu = "Réservoir 1";
            string typeHuileAttendu = "Huile usée";
            double seuil1Attendu = 0.7;
            double seuil2Attendu = 0.8;
            double seuil3Attendu = 0.9;

            vueModel.ReservoirActuel = new Reservoir() { Nom = "Réservoir 1", Type_Huile = "Huile usée", Seuil1 = 0.7, Seuil2 = 0.8, Seuil3 = 0.9};

            Assert.AreEqual(nomAttendu, vueModel.NomReservoirActuel);
            Assert.AreEqual(typeHuileAttendu, vueModel.TypeHuileReservoirActuel);
            Assert.AreEqual(seuil1Attendu, vueModel.Seuil1ReservoirActuel);
            Assert.AreEqual(seuil2Attendu, vueModel.Seuil2ReservoirActuel);
            Assert.AreEqual(seuil3Attendu, vueModel.Seuil3ReservoirActuel);
            // Si les tests ne passent pas lorsque tu fais 'Test > Excecuter > Tous les tests',
            // il faut que tu t'arrange pour qu'il passent (Si un string est trop grand, fais un substring, etc.)
        }

        /* Autre example de trucs à tester
         * - Seuil1reservoirActuel lorsqu'on lui met une valeur négative (Devrait devenir 0)
         * - Seuil1reservoirActuel lorsqu'on lui met une valeur plus haute que 1(100%) (Devrait devenir 1)
         * - Le nom ou le type d'huile du réservoir actuel lorsqu'il y a plus de caractère que permis dans la BD
         * - Autre chose peut-être je sais pas trop, au pire regarde l'énoncé pour voir combien il faut en faire
         */

        /*
         * Exemple de Stephane
         * 
         * public void TestSelectionArticleNull()
         * {
         *     string NomArticleAttendu = null;
         *     int quantiteArticleAttendu = 0;
         *     decimal? coutArticleAttendu = 0;
         *     decimal? prixVenteAttendu = 0;
         * 
         *     GestionArticlesModele GestionArticlesModeleReal = new GestionArticlesModele();
         * 
         *     GestionArticlesModeleReal.ArticleSelectionne = null;
         * 
         *     Assert.AreEqual(NomArticleAttendu, GestionArticlesModeleReal.NomArticle);
         *     Assert.AreEqual(quantiteArticleAttendu, GestionArticlesModeleReal.QuantiteArticle);
         *     Assert.AreEqual(coutArticleAttendu, GestionArticlesModeleReal.CoutArticle);
         *     Assert.AreEqual(prixVenteAttendu, GestionArticlesModeleReal.PrixVenteArticle);
         * }
        */
    }
}

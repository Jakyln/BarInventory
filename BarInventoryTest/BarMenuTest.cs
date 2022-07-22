using BarInventory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BarInventoryTest
{
    [TestClass]
    public class BarMenuTest
    {
        [TestMethod]
        public void prixTotalTest()
        {
            //Arrange
            Boisson Ricard = new Boisson("Ricard", 3.0, 6.0, "alcool", 10);
            Boisson Jagerbomb = new Boisson("Jagerbomb", 4.0, 7.50, "alcool", 4);
            List<Boisson> boissons = new List<Boisson>()
        {
            Ricard, Jagerbomb
        };
            f_menu f_menu = new f_menu();

            //Act
            double prixTotal = f_menu.updatePrixTotal(boissons);
            double prixTotalExcepted = 6d * 10d + 7.5 * 4d; //90

            //Assert
            Assert.AreEqual(prixTotalExcepted, prixTotal, "Mauvais prix total");
        }

        [TestMethod]
        public void prixTotalProduitTest()
        {
            //Arrange
            Boisson Ricard = new Boisson("Ricard", 3.0, 6.0, "alcool", 10);
            f_menu f_menu = new f_menu();

            //Act
            double prixTotalProduit = f_menu.calculPrixVenteTotalProduit(Ricard);
            double prixTotalProduitExcepted = 6d * 10d; //90

            //Assert
            Assert.AreEqual(prixTotalProduitExcepted, prixTotalProduit, "Mauvais prix total du produit");
        }

        [TestMethod]
        public void ajouterProduitTest()
        {
            //Arrange
            Boisson Ricard = new Boisson("Ricard", 3.0, 6.0, "alcool", 10);
            f_menu f_menu = new f_menu();

            //Act
            f_menu.ajouterProduit(Ricard);

            //Assert
            Assert.AreEqual(11, Ricard.Quantite, "Mauvais prix total du produit");
        }

        [TestMethod]
        public void retirerProduitTest()
        {
            //Arrange
            Boisson Ricard = new Boisson("Ricard", 3.0, 6.0, "alcool", 10);
            f_menu f_menu = new f_menu();

            //Act
            f_menu.retirerProduit(Ricard);

            //Assert
            Assert.AreEqual(9, Ricard.Quantite, "Mauvais prix total du produit");
        }

        [TestMethod]
        public void retirerProduitQteEmptyTest()
        {
            //Arrange
            Boisson Ricard = new Boisson("Ricard", 3.0, 6.0, "alcool", 0);
            f_menu f_menu = new f_menu();

            //Act
            f_menu.retirerProduit(Ricard);

            //Assert
            Assert.AreEqual(0, Ricard.Quantite, "Mauvais prix total du produit");
        }

    }
}

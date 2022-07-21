﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarInventory
{
    public class Boisson
    {
        int id;
        string name;
        double prixDeCreation;
        double prixDeVente;
        string type;

        public Boisson()
        {

        }
        public Boisson(string name, double prixDeCreation,double prixDeVente, string type)
        {
            this.name = name;
            this.prixDeCreation = prixDeCreation;
            this.prixDeVente = prixDeVente;
            this.type = type;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double PrixDeCreation { get; set; }
        public double PrixDeVente { get; set; }
        public string Type { get; set; }
    }

    public class Inventaire
    {
        List<Boisson> listBoissons;

        public Inventaire()
        {

        }
        public Inventaire(List<Boisson> listBoissons)
        {
            this.listBoissons = listBoissons;
        }
        public List<Boisson> ListBoissons { get; set; }

        public int getStockTotal()
        {
            return listBoissons.Count();
        }
        public double getPrixDeVenteTotal()
        {
            double total = 0;
            foreach (Boisson boisson in listBoissons)
            {
                total += boisson.PrixDeVente;
            }
            return total;
        }
        public double getPrixDeCreationTotal()
        {
            double total = 0;
            foreach (Boisson boisson in listBoissons)
            {
                total += boisson.PrixDeCreation;
            }
            return total;
        }

        public int getStockFromListBoisson(List<Boisson> boissons)
        {
            return boissons.Count();
        }
        public double getPrixDeVenteFromListBoisson(List<Boisson> boissons)
        {
            double total = 0;
            foreach (Boisson boisson in boissons)
            {
                total += boisson.PrixDeCreation;
            }
            return total;
        }
        public double getPrixDeCreationFromListBoisson(List<Boisson> boissons)
        {
            double total = 0;
            foreach (Boisson boisson in boissons)
            {
                total += boisson.PrixDeCreation;
            }
            return total;
        }
        public List<Boisson> getAllBoissonWithName(string name)
        {
            List<Boisson> boissonsWithName = new List<Boisson>();
            foreach(Boisson boisson in listBoissons)
            {
                if (boisson.Name.Equals(name))
                {
                    boissonsWithName.Add(boisson);
                }
            }
            return boissonsWithName;
        }
        public int getStockFromBoissonsWithName(string name)
        {
            int count = 0;
            foreach (Boisson boisson in listBoissons)
            {
                if (boisson.Name.Equals(name))
                {
                    count++;
                }
            }
            return count;
        }
        public double getPrixDeVenteTotalFromBoissonsWithName(string name)
        {
            double total = 0;
            foreach (Boisson boisson in listBoissons)
            {
                if (boisson.Name.Equals(name))
                {
                    total += boisson.PrixDeVente;
                }
            }
            return total;
        }
        public double getPrixDeCreationTotalFromBoissonsWithName(string name)
        {
            double total = 0;
            foreach (Boisson boisson in listBoissons)
            {
                if (boisson.Name.Equals(name))
                {
                    total += boisson.PrixDeCreation;
                }
            }
            return total;
        }
        public List<Boisson> getAllBoissonWithType(string type)
        {
            List<Boisson> boissonsWithName = new List<Boisson>();
            foreach (Boisson boisson in listBoissons)
            {
                if (boisson.Type.Equals(type))
                {
                    boissonsWithName.Add(boisson);
                }
            }
            return boissonsWithName;
        }
        public int getStockFromBoissonsWithType(string type)
        {
            int count = 0;
            foreach (Boisson boisson in listBoissons)
            {
                if (boisson.Type.Equals(type))
                {
                    count++;
                }
            }
            return count;
        }
        public double getPrixDeVenteTotalFromBoissonsWithType(string type)
        {
            double total = 0;
            foreach (Boisson boisson in listBoissons)
            {
                if (boisson.Type.Equals(type))
                {
                    total += boisson.PrixDeVente;
                }
            }
            return total;
        }
        public double getPrixDeCreationTotalFromBoissonsWithType(string type)
        {
            double total = 0;
            foreach (Boisson boisson in listBoissons)
            {
                if (boisson.Type.Equals(type))
                {
                    total += boisson.PrixDeCreation;
                }
            }
            return total;
        }
    }
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Boisson Ricard = new Boisson("Ricard", 3.0, 6.0);
            Boisson Jagerbomb = new Boisson("Jagerbomb", 4.0, 7.50);
            Boisson Cocoroco = new Boisson("Cocoroco", 3.0, 6.0);
            Boisson Devils_spring_vodka = new Boisson("Devils_spring_vodka", 5.0, 9.50);
            Boisson Sunset_very_strong_rhum = new Boisson("Sunset_very_strong_rhum", 7.0, 15.0);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }


}

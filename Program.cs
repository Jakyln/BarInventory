using System;
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

        public Boisson()
        {

        }
        public Boisson(string name, double prixDeCreation,double prixDeVente)
        {
            this.name = name;
            this.prixDeCreation = prixDeCreation;
            this.prixDeVente = prixDeVente;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double PrixDeCreation { get; set; }
        public double PrixDeVente { get; set; }
    }

    public class Inventaire
    {
        List<Boisson> listBoissons;

        public Inventaire()
        {

        }
        public Inventaire(List<Boisson> listBoissons, double prixDeCreationTotal, double prixDeVenteTotal)
        {
            this.listBoissons = listBoissons;
        }
        public List<Boisson> ListBoissons { get; set; }

        public int getStockTotal()
        {
            //TODO
            return 0;
        }
        public double getPrixDeVenteTotal()
        {
            //TODO
            return 0d;
        }
        public double getPrixDeCreationTotal()
        {
            //TODO
            return 0d;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }


}

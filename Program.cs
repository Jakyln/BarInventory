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
        string type;
        int quantite;

        public Boisson()
        {

        }
        public Boisson(string name, double prixDeCreation,double prixDeVente, string type, int quantite)
        {
            this.name = name;
            this.prixDeCreation = prixDeCreation;
            this.prixDeVente = prixDeVente;
            this.type = type;
            this.quantite = quantite;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double PrixDeCreation
        {
            get { return prixDeCreation; }
            set { prixDeCreation = value; }
        }

        public double PrixDeVente
        {
            get { return prixDeVente; }
            set { prixDeVente = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
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
            Application.Run(new f_menu());
        }

    }


}

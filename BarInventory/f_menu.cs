using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarInventory
{
    public partial class f_menu : Form
    {
        static Boisson Ricard = new Boisson("Ricard", 3.0, 6.0, "alcool", 10);
        static Boisson Jagerbomb = new Boisson("Jagerbomb", 4.0, 7.50, "alcool", 4);
        static Boisson Cocoroco = new Boisson("Cocoroco", 3.0, 6.0, "alcool", 8);
        static Boisson Devils_spring_vodka = new Boisson("Devils_spring_vodka", 5.0, 9.50, "alcool", 5);
        static Boisson Sunset_very_strong_rhum = new Boisson("Sunset_very_strong_rhum", 7.0, 15.0, "alcool", 4);
        static List<Boisson> boissons = new List<Boisson>()
        {
            Ricard, Jagerbomb, Cocoroco, Devils_spring_vodka, Sunset_very_strong_rhum
        };

        public double updatePrixTotal(List<Boisson> ListBoissons)
        {
            double prixTotal = 0;
            foreach (Boisson boisson in ListBoissons)
            {
                prixTotal += boisson.PrixDeVente * boisson.Quantite;
            }
            return prixTotal;
        }

        public double calculPrixVenteTotalProduit(Boisson boisson)
        {
            return boisson.PrixDeVente * boisson.Quantite;
        }

        public void ajouterProduit(Boisson boisson)
        {
            boisson.Quantite++;
        }

        public void retirerProduit(Boisson boisson)
        {
            if (boisson.Quantite == 0)
            {
                MessageBox.Show("Vide !");
            }
            else
            {
                boisson.Quantite--;
            }
        }

        public f_menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = Ricard.Name;
            lbl2.Text = Jagerbomb.Name;
            lbl3.Text = Cocoroco.Name;
            lbl4.Text = Devils_spring_vodka.Name;
            lbl5.Text = Sunset_very_strong_rhum.Name;
            lblQte1.Text = Ricard.Quantite.ToString();
            lblQte2.Text = Jagerbomb.Quantite.ToString();
            lblQte3.Text = Cocoroco.Quantite.ToString();
            lblQte4.Text = Devils_spring_vodka.Quantite.ToString();
            lblQte5.Text = Sunset_very_strong_rhum.Quantite.ToString();
            lblPrix1.Text = calculPrixVenteTotalProduit(Ricard).ToString() + " $";
            lblPrix2.Text = calculPrixVenteTotalProduit(Jagerbomb).ToString() + " $";
            lblPrix3.Text = calculPrixVenteTotalProduit(Cocoroco).ToString() + " $";
            lblPrix4.Text = calculPrixVenteTotalProduit(Devils_spring_vodka).ToString() + " $";
            lblPrix5.Text = calculPrixVenteTotalProduit(Sunset_very_strong_rhum).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        #region produit1
        private void btnMoins1_Click(object sender, EventArgs e)
        {
            retirerProduit(Ricard);
            lblQte1.Text = Ricard.Quantite.ToString();
            lblPrix1.Text = calculPrixVenteTotalProduit(Ricard).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            ajouterProduit(Ricard);
            lblQte1.Text = Ricard.Quantite.ToString();
            lblPrix1.Text = calculPrixVenteTotalProduit(Ricard).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrix1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region produit2
        private void btnMoins2_Click(object sender, EventArgs e)
        {
            retirerProduit(Jagerbomb);
            lblQte2.Text = Jagerbomb.Quantite.ToString();
            lblPrix2.Text = calculPrixVenteTotalProduit(Jagerbomb).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            ajouterProduit(Jagerbomb);
            lblQte2.Text = Jagerbomb.Quantite.ToString();
            lblPrix2.Text = calculPrixVenteTotalProduit(Jagerbomb).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lblPrix2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region produit3
        private void btnMoins3_Click(object sender, EventArgs e)
        {
            retirerProduit(Cocoroco);
            lblQte3.Text = Cocoroco.Quantite.ToString();
            lblPrix3.Text = calculPrixVenteTotalProduit(Cocoroco).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            ajouterProduit(Cocoroco);
            lblQte3.Text = Cocoroco.Quantite.ToString();
            lblPrix3.Text = calculPrixVenteTotalProduit(Cocoroco).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void lblPrix3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region produit4
        private void btnMoins4_Click(object sender, EventArgs e)
        {
            retirerProduit(Devils_spring_vodka);
            lblQte4.Text = Devils_spring_vodka.Quantite.ToString();
            lblPrix4.Text = calculPrixVenteTotalProduit(Devils_spring_vodka).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }


        private void btnPlus4_Click(object sender, EventArgs e)
        {
            ajouterProduit(Devils_spring_vodka);
            lblQte4.Text = Devils_spring_vodka.Quantite.ToString();
            lblPrix4.Text = calculPrixVenteTotalProduit(Devils_spring_vodka).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void lblPrix4_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region produit5
        private void btnMoins5_Click(object sender, EventArgs e)
        {
            retirerProduit(Sunset_very_strong_rhum);
            lblQte5.Text = Sunset_very_strong_rhum.Quantite.ToString();
            lblPrix5.Text = calculPrixVenteTotalProduit(Sunset_very_strong_rhum).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            ajouterProduit(Sunset_very_strong_rhum);
            lblQte5.Text = Sunset_very_strong_rhum.Quantite.ToString();
            lblPrix5.Text = calculPrixVenteTotalProduit(Sunset_very_strong_rhum).ToString() + " $";
            lblTotalPrix.Text = updatePrixTotal(boissons).ToString() + " $";
        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void lblPrix5_Click(object sender, EventArgs e)
        {

        }



        #endregion

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrix_Click(object sender, EventArgs e)
        {

        }
    }
}

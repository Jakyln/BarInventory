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
    public partial class Form1 : Form
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

        public void updatePrixTotal()
        {
            double prixTotal = 0;
            foreach (Boisson boisson in boissons)
            {
                prixTotal += boisson.PrixDeVente * boisson.Quantite;
            }
            lblTotalPrix.Text = prixTotal.ToString();
        }

        public Form1()
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
            lblPrix1.Text = (Ricard.PrixDeVente * Ricard.Quantite).ToString();
            lblPrix2.Text = (Jagerbomb.PrixDeVente * Jagerbomb.Quantite).ToString();
            lblPrix3.Text = (Cocoroco.PrixDeVente * Cocoroco.Quantite).ToString();
            lblPrix4.Text = (Devils_spring_vodka.PrixDeVente * Devils_spring_vodka.Quantite).ToString();
            lblPrix5.Text = (Sunset_very_strong_rhum.PrixDeVente * Sunset_very_strong_rhum.Quantite).ToString();
            updatePrixTotal();
        }

        #region produit1
        private void btnMoins1_Click(object sender, EventArgs e)
        {
            int quantitie = Ricard.Quantite;

            if(quantitie == 0)
            {
                MessageBox.Show("Vide !");
            } 
            else
            {
                quantitie--;
            }
            Ricard.Quantite = quantitie;
            double prixTotal = Ricard.PrixDeVente * Ricard.Quantite;
            lblPrix1.Text = prixTotal.ToString();
            lblQte1.Text = quantitie.ToString();
            updatePrixTotal();
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            int quantitie = Ricard.Quantite;
            quantitie++;
            Ricard.Quantite = quantitie;
            lblQte1.Text = quantitie.ToString();
            double prixTotal = Ricard.PrixDeVente * Ricard.Quantite;
            lblPrix1.Text = prixTotal.ToString();
            updatePrixTotal();
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
            {
                int quantitie = Ricard.Quantite;
                if (quantitie == 0)
                {
                    MessageBox.Show("Vide !");
                }
                else
                {
                    quantitie--;
                }
                Jagerbomb.Quantite = quantitie;
                lblQte2.Text = quantitie.ToString();
                double prixTotal = Jagerbomb.PrixDeVente * Jagerbomb.Quantite;
                lblPrix2.Text = prixTotal.ToString();
                updatePrixTotal();
            }
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            Jagerbomb.Quantite++;
            lblQte2.Text = Jagerbomb.Quantite.ToString();
            double prixTotal = Jagerbomb.PrixDeVente * Jagerbomb.Quantite;
            lblPrix2.Text = prixTotal.ToString();
            updatePrixTotal();
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
            {
                {
                    int quantitie = Cocoroco.Quantite;
                    if (quantitie == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        quantitie--;
                    }
                    Cocoroco.Quantite = quantitie;
                    lblQte3.Text = quantitie.ToString();
                    double prixTotal = Cocoroco.PrixDeVente * Cocoroco.Quantite;
                    lblPrix3.Text = prixTotal.ToString();
                    updatePrixTotal();
                }
            }
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            Cocoroco.Quantite++;
            lblQte3.Text = Cocoroco.Quantite.ToString();
            double prixTotal = Cocoroco.PrixDeVente * Cocoroco.Quantite;
            lblPrix3.Text = prixTotal.ToString();
            updatePrixTotal();
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
            {
                {
                    int quantitie = Devils_spring_vodka.Quantite;
                    if (quantitie == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        quantitie--;
                    }
                    Devils_spring_vodka.Quantite = quantitie;
                    lblQte4.Text = quantitie.ToString();
                    double prixTotal = Devils_spring_vodka.PrixDeVente * Devils_spring_vodka.Quantite;
                    lblPrix4.Text = prixTotal.ToString();
                    updatePrixTotal();
                }
            }
        }


        private void btnPlus4_Click(object sender, EventArgs e)
        {
            Devils_spring_vodka.Quantite++;
            lblQte4.Text = Devils_spring_vodka.Quantite.ToString();
            double prixTotal = Devils_spring_vodka.PrixDeVente * Devils_spring_vodka.Quantite;
            lblPrix4.Text = prixTotal.ToString();
            updatePrixTotal();
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
            {
                {
                    int quantitie = Sunset_very_strong_rhum.Quantite;
                    if (quantitie == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        quantitie--;
                    }
                    Sunset_very_strong_rhum.Quantite = quantitie;
                    lblQte5.Text = quantitie.ToString();
                    double prixTotal = Sunset_very_strong_rhum.PrixDeVente * Sunset_very_strong_rhum.Quantite;
                    lblPrix5.Text = prixTotal.ToString();
                    updatePrixTotal();
                }
            }
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            Sunset_very_strong_rhum.Quantite++;
            lblQte5.Text = Sunset_very_strong_rhum.Quantite.ToString();
            double prixTotal = Sunset_very_strong_rhum.PrixDeVente * Sunset_very_strong_rhum.Quantite;
            lblPrix5.Text = prixTotal.ToString();
            updatePrixTotal();
        }

        private void lbl5_Click(object sender, EventArgs e)
        {

        }

        private void lblPrix5_Click(object sender, EventArgs e)
        {

        }



        #endregion
    }
}

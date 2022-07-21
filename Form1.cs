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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Boisson Ricard = new Boisson("Ricard", 3.0, 6.0, "alcool", 10);
            Boisson Jagerbomb = new Boisson("Jagerbomb", 4.0, 7.50, "alcool", 4);
            Boisson Cocoroco = new Boisson("Cocoroco", 3.0, 6.0, "alcool", 8);
            Boisson Devils_spring_vodka = new Boisson("Devils_spring_vodka", 5.0, 9.50, "alcool", 5);
            Boisson Sunset_very_strong_rhum = new Boisson("Sunset_very_strong_rhum", 7.0, 15.0, "alcool", 4);
            List<Boisson> list = new List<Boisson>();
            list.Add(Ricard);
            list.Add(Jagerbomb);
            list.Add(Cocoroco);
            list.Add(Devils_spring_vodka);
            list.Add(Sunset_very_strong_rhum);
            Inventaire inventaire = new Inventaire(list);
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
        }

        #region produit1
        private void btnMoins1_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblQte1.Text);
            if(quantitie == 0)
            {
                MessageBox.Show("Vide !");
            } 
            else
            {
                quantitie--;
            }
            lblQte1.Text = quantitie.ToString();
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblQte1.Text);
            quantitie++;
            lblQte1.Text = quantitie.ToString();
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
                int quantitie = int.Parse(lblQte2.Text);
                if (quantitie == 0)
                {
                    MessageBox.Show("Vide !");
                }
                else
                {
                    quantitie--;
                }
                lblQte2.Text = quantitie.ToString();
            }
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblQte2.Text);
            quantitie++;
            lblQte2.Text = quantitie.ToString();
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
                    int quantitie = int.Parse(lblQte3.Text);
                    if (quantitie == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        quantitie--;
                    }
                    lblQte3.Text = quantitie.ToString();
                }
            }
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblQte3.Text);
            quantitie++;
            lblQte3.Text = quantitie.ToString();
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
                    int quantitie = int.Parse(lblQte4.Text);
                    if (quantitie == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        quantitie--;
                    }
                    lblQte4.Text = quantitie.ToString();
                }
            }
        }


        private void btnPlus4_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblQte4.Text);
            quantitie++;
            lblQte4.Text = quantitie.ToString();
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
                    int quantitie = int.Parse(lblQte5.Text);
                    if (quantitie == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        quantitie--;
                    }
                    lblQte5.Text = quantitie.ToString();
                }
            }
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblQte5.Text);
            quantitie++;
            lblQte5.Text = quantitie.ToString();
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

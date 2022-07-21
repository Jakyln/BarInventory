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
            lblPrix1.Text = Ricard.Quantite.ToString();
            lblPrix2.Text = Jagerbomb.Quantite.ToString();
            lblPrix3.Text = Cocoroco.Quantite.ToString();
            lblPrix4.Text = Devils_spring_vodka.Quantite.ToString();
            lblPrix5.Text = Sunset_very_strong_rhum.Quantite.ToString();
        }

        #region produit1
        private void btnMoins1_Click(object sender, EventArgs e)
        {
            int prix = int.Parse(lblPrix1.Text);
            if(prix == 0)
            {
                MessageBox.Show("Vide !");
            } 
            else
            {
                prix--;
            }
            lblPrix1.Text = prix.ToString();
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            int prix = int.Parse(lblPrix1.Text);
            prix++;
            lblPrix1.Text = prix.ToString();
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
                int prix = int.Parse(lblPrix2.Text);
                if (prix == 0)
                {
                    MessageBox.Show("Vide !");
                }
                else
                {
                    prix--;
                }
                lblPrix2.Text = prix.ToString();
            }
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            int prix = int.Parse(lblPrix2.Text);
            prix++;
            lblPrix2.Text = prix.ToString();
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
                    int prix = int.Parse(lblPrix3.Text);
                    if (prix == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        prix--;
                    }
                    lblPrix3.Text = prix.ToString();
                }
            }
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            int prix = int.Parse(lblPrix3.Text);
            prix++;
            lblPrix3.Text = prix.ToString();
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
                    int prix = int.Parse(lblPrix4.Text);
                    if (prix == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        prix--;
                    }
                    lblPrix4.Text = prix.ToString();
                }
            }
        }


        private void btnPlus4_Click(object sender, EventArgs e)
        {
            int prix = int.Parse(lblPrix4.Text);
            prix++;
            lblPrix4.Text = prix.ToString();
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
                    int prix = int.Parse(lblPrix5.Text);
                    if (prix == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        prix--;
                    }
                    lblPrix5.Text = prix.ToString();
                }
            }
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            int prix = int.Parse(lblPrix5.Text);
            prix++;
            lblPrix5.Text = prix.ToString();
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

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

        }

        #region produit1
        private void btnMoins1_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblStock1.Text);
            if(quantitie == 0)
            {
                MessageBox.Show("Vide !");
            } 
            else
            {
                quantitie--;
            }
            lblStock1.Text = quantitie.ToString();
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblStock1.Text);
            quantitie++;
            lblStock1.Text = quantitie.ToString();
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
                int quantitie = int.Parse(lblStock2.Text);
                if (quantitie == 0)
                {
                    MessageBox.Show("Vide !");
                }
                else
                {
                    quantitie--;
                }
                lblStock2.Text = quantitie.ToString();
            }
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblStock2.Text);
            quantitie++;
            lblStock2.Text = quantitie.ToString();
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
                    int quantitie = int.Parse(lblStock3.Text);
                    if (quantitie == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        quantitie--;
                    }
                    lblStock3.Text = quantitie.ToString();
                }
            }
        }

        private void btnPlus3_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblStock3.Text);
            quantitie++;
            lblStock3.Text = quantitie.ToString();
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
                    int quantitie = int.Parse(lblStock4.Text);
                    if (quantitie == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        quantitie--;
                    }
                    lblStock4.Text = quantitie.ToString();
                }
            }
        }


        private void btnPlus4_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblStock4.Text);
            quantitie++;
            lblStock4.Text = quantitie.ToString();
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
                    int quantitie = int.Parse(lblStock5.Text);
                    if (quantitie == 0)
                    {
                        MessageBox.Show("Vide !");
                    }
                    else
                    {
                        quantitie--;
                    }
                    lblStock5.Text = quantitie.ToString();
                }
            }
        }

        private void btnPlus5_Click(object sender, EventArgs e)
        {
            int quantitie = int.Parse(lblStock5.Text);
            quantitie++;
            lblStock5.Text = quantitie.ToString();
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

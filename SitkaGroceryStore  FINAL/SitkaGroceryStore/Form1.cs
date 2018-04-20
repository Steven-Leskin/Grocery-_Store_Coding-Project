using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitkaGroceryStore
{

    public partial class Form1 : Form
    {
         public Form1()
        {
            InitializeComponent();
        }

        private void breakfastBTN_Click(object sender, EventArgs e)
        {
            breakfastFRM bre = new breakfastFRM();
            bre.TopLevel = false;
            cartFLP.Controls.Add(bre);
            bre.Show();
        }

        private void lunchBTN_Click(object sender, EventArgs e)
        {
            lunchFRM lun = new lunchFRM();
            lun.TopLevel = false;
            cartFLP.Controls.Add(lun);
            lun.Show();
        }

        private void dinnerBTN_Click(object sender, EventArgs e)
        {
            dinnerFRM din = new dinnerFRM();
            din.TopLevel = false;
            cartFLP.Controls.Add(din);
            din.Show();
        }

        private void dessertBTN_Click(object sender, EventArgs e)
        {
            dessertFRM des = new dessertFRM();
            des.TopLevel = false;
            cartFLP.Controls.Add(des);
            des.Show();

        }

        private void drinksBTN_Click(object sender, EventArgs e)
        {
            drinksFRM dri = new drinksFRM();
            dri.TopLevel = false;
            cartFLP.Controls.Add(dri);
            dri.Show();
        }

        private void SNACKS_Click(object sender, EventArgs e)
        {
            snacksFRM sna = new snacksFRM();
            sna.TopLevel = false;
            cartFLP.Controls.Add(sna);
            sna.Show();
        }

        //Right side controls

         private void payBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your purchase", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            cartFLP.Controls.Clear();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cashRB_Click(object sender, EventArgs e)
        {
            if (homeDeliveryRB.Checked);
            MessageBox.Show("Cash payment not accepted for home delivery.", "Payment terms", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void creditRB_Click(object sender, EventArgs e)
        {
            creditIntakeFRM cre = new creditIntakeFRM();
            cre.ShowDialog();
        }

        private void homeDeliveryRB_Click(object sender, EventArgs e)
        {
            deliveryIntakeFRM del = new deliveryIntakeFRM();
            del.ShowDialog();
        }

        private void cashRB_CheckedChanged(object sender, EventArgs e)
        {
            if (homeDeliveryRB.Checked);
            MessageBox.Show("Cash payment not accepted for home deliveries.", "PAYMENT TERMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

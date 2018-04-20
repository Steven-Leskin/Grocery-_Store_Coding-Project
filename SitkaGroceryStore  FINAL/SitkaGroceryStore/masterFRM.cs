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
    public partial class masterFRM : Form
    {
        decimal unitPrice = 0;

        public masterFRM()
        {
            InitializeComponent();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //Set Unit Price based on UoM

        public decimal SetUnitPrice()

        {
            if (UOM_LB.SelectedIndex == 0)
                unitPrice = 1.2M;
            else if (UOM_LB.SelectedIndex == 1)
                unitPrice = 3.45M;
            else if (UOM_LB.SelectedIndex == 2)
                unitPrice = 6.78M;
            //else if (UOM_LB.SelectedIndex == 3)
            //    unitPrice =
            //else if (UOM_LB.SelectedIndex == 4)
            //    unitPrice =

                return unitPrice;

        }

        public void CalculateUnitPrice()
        {
            unitPriceDisplayLBL.Text = "$"+ Convert.ToString(SetUnitPrice());
        }

        public void ItemSubTotal()
        {
            itemSubTotalLBL.Text = "$"+(Convert.ToString(quantityNU.Value * SetUnitPrice()));
        }

        private void quantityNU_ValueChanged(object sender, EventArgs e)
        {
            ItemSubTotal();
            CalculateUnitPrice();
        }
        private void UOM_LB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateUnitPrice();
            ItemSubTotal();
        }
    }

}

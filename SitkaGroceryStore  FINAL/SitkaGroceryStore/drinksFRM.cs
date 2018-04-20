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
    public partial class drinksFRM : Form
    {
        decimal unitPrice = 0;

        public drinksFRM()
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
                unitPrice = 24.00M;
            else if (UOM_LB.SelectedIndex == 1)
                unitPrice = 36.00M;

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

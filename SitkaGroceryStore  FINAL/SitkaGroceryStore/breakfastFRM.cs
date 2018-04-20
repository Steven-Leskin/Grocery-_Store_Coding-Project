using System;
using System.Windows.Forms;

namespace SitkaGroceryStore
{
    public partial class breakfastFRM : Form
    {
        decimal unitPrice;

        public breakfastFRM()
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
                unitPrice = 3.50M;
            else if (UOM_LB.SelectedIndex == 1)
                unitPrice = 4.50M;
            else if (UOM_LB.SelectedIndex == 2)
                unitPrice = 5.50M;
            else if (UOM_LB.SelectedIndex == 3)
                unitPrice =6.50M;
            
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

        private void addBTN_Click(object sender, EventArgs e)
        {
           
        }
    }

}

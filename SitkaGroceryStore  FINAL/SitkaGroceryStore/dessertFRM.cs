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
    public partial class dessertFRM : Form
    {
        decimal unitPrice = 0;

        public dessertFRM()
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
                unitPrice = 6.50M;
            else if (UOM_LB.SelectedIndex == 1)
                unitPrice = 8.50M;
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

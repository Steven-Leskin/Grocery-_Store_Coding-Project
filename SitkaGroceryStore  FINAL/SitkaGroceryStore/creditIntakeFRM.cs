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
    public partial class creditIntakeFRM : Form
    {
        public creditIntakeFRM()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CONFIRMING YOUR CREDIT INFORMATION:\n \nYour name:   " + " " + textBox1.Text +
                "\nYour Credit Card Number:   " + cardNuTB.Text +
                "\nType of Card:   "+CardIssuerLB.SelectedItem.ToString()+
                "\nCard Expiration Date:   " + monthLB.SelectedItem.ToString() + " " + yearLB.SelectedItem.ToString(),"PAYMENT INFORMATION",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);

        }
    }
}

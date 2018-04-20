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
    public partial class deliveryIntakeFRM : Form
    {
        public deliveryIntakeFRM()
        {
            InitializeComponent();
        }

        private string ConcatenateAddress()

        {
            string address;
            address = delAddress1TB.Text +" "+ delAddress2TB.Text +" "+ delCityTB.Text +" "+ delStateTB.Text +" "+ delZipTB.Text;
            return address;
        }

        private void delSubmitBTN_Click(object sender, EventArgs e)
        {
            receiptFRM rec = new receiptFRM(delFullNameTB.Text, ConcatenateAddress());
            rec.Show();
        }
    }
}

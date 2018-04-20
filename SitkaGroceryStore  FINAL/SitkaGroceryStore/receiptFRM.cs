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
    public partial class receiptFRM : Form
    {
        public receiptFRM(string FullName, string Address)
        {
            InitializeComponent();
            recFullNameDisplayLBL.Text = FullName;
            addressDisplayTB.Text = Address;
            DisplayDates();
            DisplayTime();
            EstimateDeliveryDate();
        }

        public string DisplayDates()
        {
            return dateDisplayLBL.Text = DateTime.Now.ToShortDateString();
        }

        public string DisplayTime()
        {
            return recTimeDisplayLBL.Text = DateTime.Now.ToShortTimeString();
        }

        public string EstimateDeliveryDate()
        {
            return recEstimateDateDisplayLBL.Text = DateTime.Now.AddDays(6).ToShortDateString();
        }
    }
}

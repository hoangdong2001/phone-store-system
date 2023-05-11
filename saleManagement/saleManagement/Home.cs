using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saleManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
           
        private void itemMenu_Click(object sender, EventArgs e)
        {
            item formItem = new item();
            formItem.ShowDialog();
        }

        private void receiptMenu_Click(object sender, EventArgs e)
        {
            receipt formReceipt = new receipt();
            formReceipt.ShowDialog();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            item formItem = new item();
            formItem.ShowDialog();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            receipt formReceipt = new receipt();
            formReceipt.ShowDialog();
        }

        private void btnDeliveryBill_Click(object sender, EventArgs e)
        {
            deliveryBill formDeliveryBill = new deliveryBill();
            formDeliveryBill.ShowDialog();
        }

        private void deliveryBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deliveryBill formDeliveryBill = new deliveryBill();
            formDeliveryBill.ShowDialog();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            statistical formStatistical = new statistical();
            formStatistical.ShowDialog();
        }

        private void reneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            revenueMonthly formRevenueMonthly = new revenueMonthly();
            formRevenueMonthly.ShowDialog();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            revenueMonthly formRevenueMonthly = new revenueMonthly();
            formRevenueMonthly.ShowDialog();
        }
    }
}

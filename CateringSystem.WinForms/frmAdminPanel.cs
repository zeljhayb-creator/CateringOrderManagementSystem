using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CateringBusinessLogic;
using CateringDataLogic;

namespace CateringSystem.WinForms
{
    public partial class frmAdminPanel : Form
    {
        private readonly CateringService cateringService;
        public frmAdminPanel()
        {
            InitializeComponent();

            ICateringRepository repository = new CateringRepository();
            cateringService = new CateringService(repository);
        }
        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            List<CateringOrder> orders = cateringService.GetOrders();

            dgvOrders.DataSource = null;
            dgvOrders.DataSource = orders;

            if (orders.Count == 0)
            {
                MessageBox.Show("No customer orders found.");
            }
        }

        private void btnAcceptOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            int orderId = Convert.ToInt32(
                dgvOrders.SelectedRows[0].Cells["OrderId"].Value
            );

            bool accepted = cateringService.AcceptOrder(orderId);

            if (accepted)
            {
                MessageBox.Show("Order accepted successfully!");

                btnViewOrders_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Unable to accept this order.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

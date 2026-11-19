using CateringBusinessLogic;
using CateringDataLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CateringSystem.WinForms
{
    public partial class frmCustomerOrder : Form
    {
        private readonly ICateringRepository repository = new CateringRepository();
        private readonly CateringService cateringService;
        public frmCustomerOrder()
        {
            InitializeComponent();

            cateringService = new CateringService(repository);

            cboEventType.Items.AddRange(new string[]
            {
        "Birthday",
        "Wedding",
        "Corporate Event",
        "Other"
            });

            cboFoodOrder.Items.AddRange(new string[]
            {
        "Chicken",
        "Pork",
        "Beef",
        "Fish"
            });

            cboEventType.SelectedIndex = 0;
            cboFoodOrder.SelectedIndex = 0;
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please enter your name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            CateringOrder order = new CateringOrder()
            {
                CustomerName = txtCustomerName.Text,
                EventType = cboEventType.Text,
                EventDate = dtpEventDate.Value.ToShortDateString(),
                NumberOfGuests = nudNumberOfGuests.Value.ToString(),
                FoodOrder = cboFoodOrder.Text,
                Quantity = nudQuantity.Value.ToString()
            };


            cateringService.SubmitOrder(order);
            

            MessageBox.Show("Your catering order has been submitted successfully!",
                "Order Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            txtCustomerName.Clear();


            cboEventType.SelectedIndex = 0;
            cboFoodOrder.SelectedIndex = 0;


            nudNumberOfGuests.Value = 1;
            nudQuantity.Value = 1;


            dtpEventDate.Value = DateTime.Today;
        }

        private void frmCustomerOrder_Load(object sender, EventArgs e)
        {

        }
    }
}

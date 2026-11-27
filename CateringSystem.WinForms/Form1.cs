namespace CateringSystem.WinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerOrder_Click(object sender, EventArgs e)
        {
            using (frmCustomerOrder form = new frmCustomerOrder())
            {
                form.ShowDialog(this);
            }
        }
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            using (frmAdminLogin form = new frmAdminLogin())
            {
                form.ShowDialog(this);
            }
        }
    }
}

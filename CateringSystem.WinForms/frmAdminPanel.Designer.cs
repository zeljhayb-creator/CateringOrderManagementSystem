namespace CateringSystem.WinForms
{
    partial class frmAdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            dgvOrders = new DataGridView();
            btnViewOrders = new Button();
            btnAcceptOrder = new Button();
            btnExit = new Button();
            btnDeclineOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(232, -4);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(539, 79);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CATERING ADMIN PANEL";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(35, 78);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(920, 380);
            dgvOrders.TabIndex = 1;
            // 
            // btnViewOrders
            // 
            btnViewOrders.Location = new Point(209, 474);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(130, 40);
            btnViewOrders.TabIndex = 2;
            btnViewOrders.Text = "View Orders";
            btnViewOrders.UseVisualStyleBackColor = true;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnAcceptOrder
            // 
            btnAcceptOrder.Location = new Point(364, 474);
            btnAcceptOrder.Name = "btnAcceptOrder";
            btnAcceptOrder.Size = new Size(130, 40);
            btnAcceptOrder.TabIndex = 3;
            btnAcceptOrder.Text = "Accept Order";
            btnAcceptOrder.UseVisualStyleBackColor = true;
            btnAcceptOrder.Click += btnAcceptOrder_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(855, 474);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 40);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeclineOrder
            // 
            btnDeclineOrder.Location = new Point(518, 474);
            btnDeclineOrder.Name = "btnDeclineOrder";
            btnDeclineOrder.Size = new Size(130, 40);
            btnDeclineOrder.TabIndex = 5;
            btnDeclineOrder.Text = "Decline Order";
            btnDeclineOrder.UseVisualStyleBackColor = true;
            btnDeclineOrder.Click += btnDeclineOrder_Click;
            // 
            // frmAdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(btnDeclineOrder);
            Controls.Add(btnExit);
            Controls.Add(btnAcceptOrder);
            Controls.Add(btnViewOrders);
            Controls.Add(dgvOrders);
            Controls.Add(lblTitle);
            Name = "frmAdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catering Admin Panel";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvOrders;
        private Button btnViewOrders;
        private Button btnAcceptOrder;
        private Button btnExit;
        private Button btnDeclineOrder;
    }
}
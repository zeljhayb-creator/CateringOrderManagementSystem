namespace CateringSystem.WinForms
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnCustomerOrder = new Button();
            btnAdminLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(223, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(556, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CATERING ORDER MANAGEMENT SYSTEM";
            // 
            // btnCustomerOrder
            // 
            btnCustomerOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerOrder.Location = new Point(279, 134);
            btnCustomerOrder.Name = "btnCustomerOrder";
            btnCustomerOrder.Size = new Size(200, 50);
            btnCustomerOrder.TabIndex = 1;
            btnCustomerOrder.Text = "Customer Order";
            btnCustomerOrder.UseVisualStyleBackColor = true;
            btnCustomerOrder.Click += btnCustomerOrder_Click;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.Font = new Font("Segoe UI", 12F);
            btnAdminLogin.Location = new Point(529, 134);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(200, 50);
            btnAdminLogin.TabIndex = 2;
            btnAdminLogin.Text = "Admin Login";
            btnAdminLogin.UseVisualStyleBackColor = true;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(407, 218);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(btnExit);
            Controls.Add(btnAdminLogin);
            Controls.Add(btnCustomerOrder);
            Controls.Add(lblTitle);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catering Order Management System";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnCustomerOrder;
        private Button btnAdminLogin;
        private Button btnExit;
    }
}

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
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(224, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(556, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CATERING ORDER MANAGEMENT SYSTEM";
            // 
            // btnCustomerOrder
            // 
            btnCustomerOrder.BackColor = Color.FromArgb(105, 16, 35);
            btnCustomerOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerOrder.ForeColor = Color.White;
            btnCustomerOrder.Location = new Point(115, 60);
            btnCustomerOrder.Name = "btnCustomerOrder";
            btnCustomerOrder.Size = new Size(200, 50);
            btnCustomerOrder.TabIndex = 1;
            btnCustomerOrder.Text = "Customer Order";
            btnCustomerOrder.UseVisualStyleBackColor = false;
            btnCustomerOrder.Click += btnCustomerOrder_Click;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.FromArgb(105, 16, 35);
            btnAdminLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(365, 60);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(200, 50);
            btnAdminLogin.TabIndex = 2;
            btnAdminLogin.Text = "Admin Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            btnAdminLogin.Click += btnAdminLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(232, 213, 216);
            btnExit.FlatAppearance.BorderColor = Color.Black;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(105, 16, 35);
            btnExit.Location = new Point(243, 144);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(105, 16, 35);
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 140);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnAdminLogin);
            panel2.Controls.Add(btnCustomerOrder);
            panel2.Location = new Point(153, 193);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 270);
            panel2.TabIndex = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 240);
            ClientSize = new Size(984, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catering Order Management System";
            Load += frmMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Button btnCustomerOrder;
        private Button btnAdminLogin;
        private Button btnExit;
        private Panel panel1;
        private Panel panel2;
    }
}

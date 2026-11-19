namespace CateringSystem.WinForms
{
    partial class frmCustomerOrder
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
            lblOrderTitle = new Label();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblEventType = new Label();
            cboEventType = new ComboBox();
            lblEventDate = new Label();
            dtpEventDate = new DateTimePicker();
            lblNumberOfGuests = new Label();
            nudNumberOfGuests = new NumericUpDown();
            lblFoodOrder = new Label();
            cboFoodOrder = new ComboBox();
            lblQuantity = new Label();
            nudQuantity = new NumericUpDown();
            btnSubmitOrder = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfGuests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderTitle.Location = new Point(140, 9);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(306, 32);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "CUSTOMER ORDER FORM";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(63, 119);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(106, 17);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Font = new Font("Segoe UI", 10F);
            txtCustomerName.Location = new Point(175, 116);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(300, 25);
            txtCustomerName.TabIndex = 2;
            // 
            // lblEventType
            // 
            lblEventType.AutoSize = true;
            lblEventType.Font = new Font("Segoe UI", 10F);
            lblEventType.Location = new Point(91, 161);
            lblEventType.Name = "lblEventType";
            lblEventType.Size = new Size(78, 19);
            lblEventType.TabIndex = 3;
            lblEventType.Text = "Event Type:";
            // 
            // cboEventType
            // 
            cboEventType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEventType.Font = new Font("Segoe UI", 10F);
            cboEventType.FormattingEnabled = true;
            cboEventType.Location = new Point(175, 155);
            cboEventType.Name = "cboEventType";
            cboEventType.Size = new Size(300, 25);
            cboEventType.TabIndex = 4;
            // 
            // lblEventDate
            // 
            lblEventDate.AutoSize = true;
            lblEventDate.Font = new Font("Segoe UI", 10F);
            lblEventDate.Location = new Point(91, 200);
            lblEventDate.Name = "lblEventDate";
            lblEventDate.Size = new Size(79, 19);
            lblEventDate.TabIndex = 5;
            lblEventDate.Text = "Event Date:";
            // 
            // dtpEventDate
            // 
            dtpEventDate.Font = new Font("Segoe UI", 10F);
            dtpEventDate.Format = DateTimePickerFormat.Short;
            dtpEventDate.Location = new Point(175, 194);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(200, 25);
            dtpEventDate.TabIndex = 6;
            // 
            // lblNumberOfGuests
            // 
            lblNumberOfGuests.AutoSize = true;
            lblNumberOfGuests.Font = new Font("Segoe UI", 10F);
            lblNumberOfGuests.Location = new Point(45, 239);
            lblNumberOfGuests.Name = "lblNumberOfGuests";
            lblNumberOfGuests.Size = new Size(124, 19);
            lblNumberOfGuests.TabIndex = 7;
            lblNumberOfGuests.Text = "Number of Guests:";
            // 
            // nudNumberOfGuests
            // 
            nudNumberOfGuests.Font = new Font("Segoe UI", 10F);
            nudNumberOfGuests.Location = new Point(175, 233);
            nudNumberOfGuests.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNumberOfGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumberOfGuests.Name = "nudNumberOfGuests";
            nudNumberOfGuests.Size = new Size(120, 25);
            nudNumberOfGuests.TabIndex = 8;
            nudNumberOfGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblFoodOrder
            // 
            lblFoodOrder.AutoSize = true;
            lblFoodOrder.Font = new Font("Segoe UI", 10F);
            lblFoodOrder.Location = new Point(86, 278);
            lblFoodOrder.Name = "lblFoodOrder";
            lblFoodOrder.Size = new Size(83, 19);
            lblFoodOrder.TabIndex = 9;
            lblFoodOrder.Text = "Food Order:";
            // 
            // cboFoodOrder
            // 
            cboFoodOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFoodOrder.Font = new Font("Segoe UI", 10F);
            cboFoodOrder.FormattingEnabled = true;
            cboFoodOrder.Location = new Point(175, 274);
            cboFoodOrder.Name = "cboFoodOrder";
            cboFoodOrder.Size = new Size(300, 25);
            cboFoodOrder.TabIndex = 10;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10F);
            lblQuantity.Location = new Point(103, 317);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(66, 19);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe UI", 10F);
            nudQuantity.Location = new Point(175, 311);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 25);
            nudQuantity.TabIndex = 12;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmitOrder.Location = new Point(217, 358);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new Size(150, 40);
            btnSubmitOrder.TabIndex = 13;
            btnSubmitOrder.Text = "Submit Order";
            btnSubmitOrder.UseVisualStyleBackColor = true;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.Location = new Point(231, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmCustomerOrder
            // 
            AcceptButton = btnSubmitOrder;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(584, 611);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmitOrder);
            Controls.Add(nudQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cboFoodOrder);
            Controls.Add(lblFoodOrder);
            Controls.Add(nudNumberOfGuests);
            Controls.Add(lblNumberOfGuests);
            Controls.Add(dtpEventDate);
            Controls.Add(lblEventDate);
            Controls.Add(cboEventType);
            Controls.Add(lblEventType);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(lblOrderTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCustomerOrder";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Customer Order";
            Load += frmCustomerOrder_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumberOfGuests).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderTitle;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private Label lblEventType;
        private ComboBox cboEventType;
        private Label lblEventDate;
        private DateTimePicker dtpEventDate;
        private Label lblNumberOfGuests;
        private NumericUpDown nudNumberOfGuests;
        private Label lblFoodOrder;
        private ComboBox cboFoodOrder;
        private Label lblQuantity;
        private NumericUpDown nudQuantity;
        private Button btnSubmitOrder;
        private Button btnCancel;
    }
}
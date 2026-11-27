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
            pnlHeader = new Panel();
            lblHeaderSubtitle = new Label();
            pnlOrderContainer = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudNumberOfGuests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlHeader.SuspendLayout();
            pnlOrderContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.BackColor = Color.Transparent;
            lblOrderTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderTitle.Location = new Point(35, 35);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(306, 32);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "CUSTOMER ORDER FORM";
            lblOrderTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = Color.FromArgb(105, 16, 35);
            lblCustomerName.Location = new Point(35, 35);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(137, 21);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "Customer Name:";
            lblCustomerName.TextAlign = ContentAlignment.MiddleLeft;
            lblCustomerName.Click += lblCustomerName_Click;
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.White;
            txtCustomerName.BorderStyle = BorderStyle.FixedSingle;
            txtCustomerName.Font = new Font("Segoe UI", 12F);
            txtCustomerName.ForeColor = Color.FromArgb(45, 45, 45);
            txtCustomerName.Location = new Point(225, 35);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(650, 29);
            txtCustomerName.TabIndex = 2;
            // 
            // lblEventType
            // 
            lblEventType.AutoSize = true;
            lblEventType.BackColor = Color.Transparent;
            lblEventType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEventType.ForeColor = Color.FromArgb(105, 16, 35);
            lblEventType.Location = new Point(35, 95);
            lblEventType.Name = "lblEventType";
            lblEventType.Size = new Size(97, 21);
            lblEventType.TabIndex = 3;
            lblEventType.Text = "Event Type:";
            lblEventType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboEventType
            // 
            cboEventType.BackColor = Color.White;
            cboEventType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEventType.Font = new Font("Segoe UI", 12F);
            cboEventType.ForeColor = Color.FromArgb(45, 45, 45);
            cboEventType.FormattingEnabled = true;
            cboEventType.Location = new Point(225, 95);
            cboEventType.Name = "cboEventType";
            cboEventType.Size = new Size(300, 29);
            cboEventType.TabIndex = 4;
            // 
            // lblEventDate
            // 
            lblEventDate.AutoSize = true;
            lblEventDate.BackColor = Color.Transparent;
            lblEventDate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEventDate.ForeColor = Color.FromArgb(105, 16, 35);
            lblEventDate.Location = new Point(35, 155);
            lblEventDate.Name = "lblEventDate";
            lblEventDate.Size = new Size(89, 20);
            lblEventDate.TabIndex = 5;
            lblEventDate.Text = "Event Date:";
            lblEventDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEventDate
            // 
            dtpEventDate.Font = new Font("Segoe UI", 10F);
            dtpEventDate.Format = DateTimePickerFormat.Short;
            dtpEventDate.Location = new Point(225, 155);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(200, 25);
            dtpEventDate.TabIndex = 6;
            // 
            // lblNumberOfGuests
            // 
            lblNumberOfGuests.AutoSize = true;
            lblNumberOfGuests.BackColor = Color.Transparent;
            lblNumberOfGuests.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNumberOfGuests.ForeColor = Color.FromArgb(105, 16, 35);
            lblNumberOfGuests.Location = new Point(35, 215);
            lblNumberOfGuests.Name = "lblNumberOfGuests";
            lblNumberOfGuests.Size = new Size(142, 20);
            lblNumberOfGuests.TabIndex = 7;
            lblNumberOfGuests.Text = "Number of Guests:";
            lblNumberOfGuests.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudNumberOfGuests
            // 
            nudNumberOfGuests.Font = new Font("Segoe UI", 11F);
            nudNumberOfGuests.ForeColor = Color.FromArgb(45, 45, 45);
            nudNumberOfGuests.Location = new Point(225, 215);
            nudNumberOfGuests.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudNumberOfGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNumberOfGuests.Name = "nudNumberOfGuests";
            nudNumberOfGuests.Size = new Size(120, 27);
            nudNumberOfGuests.TabIndex = 8;
            nudNumberOfGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblFoodOrder
            // 
            lblFoodOrder.AutoSize = true;
            lblFoodOrder.BackColor = Color.Transparent;
            lblFoodOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFoodOrder.ForeColor = Color.FromArgb(105, 16, 35);
            lblFoodOrder.Location = new Point(35, 275);
            lblFoodOrder.Name = "lblFoodOrder";
            lblFoodOrder.Size = new Size(93, 20);
            lblFoodOrder.TabIndex = 9;
            lblFoodOrder.Text = "Food Order:";
            lblFoodOrder.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboFoodOrder
            // 
            cboFoodOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFoodOrder.Font = new Font("Segoe UI", 11F);
            cboFoodOrder.ForeColor = Color.FromArgb(45, 45, 45);
            cboFoodOrder.FormattingEnabled = true;
            cboFoodOrder.Location = new Point(225, 275);
            cboFoodOrder.Name = "cboFoodOrder";
            cboFoodOrder.Size = new Size(300, 28);
            cboFoodOrder.TabIndex = 10;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblQuantity.ForeColor = Color.FromArgb(105, 16, 35);
            lblQuantity.Location = new Point(35, 335);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(74, 20);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Quantity:";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudQuantity
            // 
            nudQuantity.Font = new Font("Segoe UI", 11F);
            nudQuantity.ForeColor = Color.FromArgb(45, 45, 45);
            nudQuantity.Location = new Point(225, 335);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 27);
            nudQuantity.TabIndex = 12;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSubmitOrder
            // 
            btnSubmitOrder.BackColor = Color.FromArgb(105, 16, 35);
            btnSubmitOrder.Cursor = Cursors.Hand;
            btnSubmitOrder.FlatStyle = FlatStyle.Flat;
            btnSubmitOrder.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmitOrder.ForeColor = Color.White;
            btnSubmitOrder.Location = new Point(590, 390);
            btnSubmitOrder.Name = "btnSubmitOrder";
            btnSubmitOrder.Size = new Size(140, 40);
            btnSubmitOrder.TabIndex = 13;
            btnSubmitOrder.Text = "Submit Order";
            btnSubmitOrder.UseVisualStyleBackColor = false;
            btnSubmitOrder.Click += btnSubmitOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(232, 213, 216);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(105, 16, 35);
            btnCancel.Location = new Point(745, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(105, 16, 35);
            pnlHeader.Controls.Add(lblHeaderSubtitle);
            pnlHeader.Controls.Add(lblOrderTitle);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            pnlHeader.ForeColor = Color.White;
            pnlHeader.Location = new Point(2, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(984, 140);
            pnlHeader.TabIndex = 15;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.BackColor = Color.Transparent;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(255, 230, 220);
            lblHeaderSubtitle.Location = new Point(38, 88);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(226, 21);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Let us make your event special!";
            // 
            // pnlOrderContainer
            // 
            pnlOrderContainer.BackColor = Color.White;
            pnlOrderContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlOrderContainer.Controls.Add(txtCustomerName);
            pnlOrderContainer.Controls.Add(lblCustomerName);
            pnlOrderContainer.Controls.Add(btnCancel);
            pnlOrderContainer.Controls.Add(cboFoodOrder);
            pnlOrderContainer.Controls.Add(btnSubmitOrder);
            pnlOrderContainer.Controls.Add(lblEventType);
            pnlOrderContainer.Controls.Add(nudQuantity);
            pnlOrderContainer.Controls.Add(cboEventType);
            pnlOrderContainer.Controls.Add(lblQuantity);
            pnlOrderContainer.Controls.Add(lblEventDate);
            pnlOrderContainer.Controls.Add(dtpEventDate);
            pnlOrderContainer.Controls.Add(lblFoodOrder);
            pnlOrderContainer.Controls.Add(lblNumberOfGuests);
            pnlOrderContainer.Controls.Add(nudNumberOfGuests);
            pnlOrderContainer.Location = new Point(30, 165);
            pnlOrderContainer.Name = "pnlOrderContainer";
            pnlOrderContainer.Size = new Size(910, 450);
            pnlOrderContainer.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 35);
            label1.Name = "label1";
            label1.Size = new Size(488, 45);
            label1.TabIndex = 2;
            label1.Text = "____________________________________";
            // 
            // frmCustomerOrder
            // 
            AcceptButton = btnSubmitOrder;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 248, 240);
            CancelButton = btnCancel;
            ClientSize = new Size(984, 661);
            Controls.Add(pnlOrderContainer);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCustomerOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Order";
            Load += frmCustomerOrder_Load;
            ((System.ComponentModel.ISupportInitialize)nudNumberOfGuests).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlOrderContainer.ResumeLayout(false);
            pnlOrderContainer.PerformLayout();
            ResumeLayout(false);
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
        private Panel pnlHeader;
        private Label lblHeaderSubtitle;
        private Panel pnlOrderContainer;
        private Label label1;
    }
}
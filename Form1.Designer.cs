namespace Employee_Registery
{
    partial class formApp
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
            this.gbxSeller = new System.Windows.Forms.GroupBox();
            this.gbxConsultant = new System.Windows.Forms.GroupBox();
            this.gbxClerk = new System.Windows.Forms.GroupBox();
            this.lblSellerName = new System.Windows.Forms.Label();
            this.lblSellerCommision = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.tbxSellerName = new System.Windows.Forms.TextBox();
            this.tbxSellerCommission = new System.Windows.Forms.TextBox();
            this.tbxSellerSales = new System.Windows.Forms.TextBox();
            this.btnRegisterSale = new System.Windows.Forms.Button();
            this.btnRegsiterShift = new System.Windows.Forms.Button();
            this.tbxConsultantHours = new System.Windows.Forms.TextBox();
            this.tbxConsultantRate = new System.Windows.Forms.TextBox();
            this.tbxConsultantName = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblConsultantName = new System.Windows.Forms.Label();
            this.btnRegisterSalary = new System.Windows.Forms.Button();
            this.tbxClerkName = new System.Windows.Forms.TextBox();
            this.lblClerkName = new System.Windows.Forms.Label();
            this.tbxClerkSalary = new System.Windows.Forms.TextBox();
            this.lblMonthlySalary = new System.Windows.Forms.Label();
            this.lbxRegistery = new System.Windows.Forms.ListBox();
            this.lblSysRegister = new System.Windows.Forms.Label();
            this.lbxSalaries = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculateSalaries = new System.Windows.Forms.Button();
            this.lblTotalSalaries = new System.Windows.Forms.Label();
            this.tbxTotalSalaries = new System.Windows.Forms.TextBox();
            this.gbxSeller.SuspendLayout();
            this.gbxConsultant.SuspendLayout();
            this.gbxClerk.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSeller
            // 
            this.gbxSeller.Controls.Add(this.btnRegisterSale);
            this.gbxSeller.Controls.Add(this.tbxSellerSales);
            this.gbxSeller.Controls.Add(this.tbxSellerCommission);
            this.gbxSeller.Controls.Add(this.tbxSellerName);
            this.gbxSeller.Controls.Add(this.lblSale);
            this.gbxSeller.Controls.Add(this.lblSellerCommision);
            this.gbxSeller.Controls.Add(this.lblSellerName);
            this.gbxSeller.Location = new System.Drawing.Point(12, 12);
            this.gbxSeller.Name = "gbxSeller";
            this.gbxSeller.Size = new System.Drawing.Size(160, 156);
            this.gbxSeller.TabIndex = 0;
            this.gbxSeller.TabStop = false;
            this.gbxSeller.Text = "Seller";
            // 
            // gbxConsultant
            // 
            this.gbxConsultant.Controls.Add(this.btnRegsiterShift);
            this.gbxConsultant.Controls.Add(this.tbxConsultantName);
            this.gbxConsultant.Controls.Add(this.tbxConsultantHours);
            this.gbxConsultant.Controls.Add(this.lblConsultantName);
            this.gbxConsultant.Controls.Add(this.tbxConsultantRate);
            this.gbxConsultant.Controls.Add(this.lblHourlyRate);
            this.gbxConsultant.Controls.Add(this.lblHoursWorked);
            this.gbxConsultant.Location = new System.Drawing.Point(214, 12);
            this.gbxConsultant.Name = "gbxConsultant";
            this.gbxConsultant.Size = new System.Drawing.Size(172, 156);
            this.gbxConsultant.TabIndex = 1;
            this.gbxConsultant.TabStop = false;
            this.gbxConsultant.Text = "Consultant";
            // 
            // gbxClerk
            // 
            this.gbxClerk.Controls.Add(this.btnRegisterSalary);
            this.gbxClerk.Controls.Add(this.tbxClerkName);
            this.gbxClerk.Controls.Add(this.lblMonthlySalary);
            this.gbxClerk.Controls.Add(this.lblClerkName);
            this.gbxClerk.Controls.Add(this.tbxClerkSalary);
            this.gbxClerk.Location = new System.Drawing.Point(408, 12);
            this.gbxClerk.Name = "gbxClerk";
            this.gbxClerk.Size = new System.Drawing.Size(178, 156);
            this.gbxClerk.TabIndex = 2;
            this.gbxClerk.TabStop = false;
            this.gbxClerk.Text = "Clerk";
            // 
            // lblSellerName
            // 
            this.lblSellerName.AutoSize = true;
            this.lblSellerName.Location = new System.Drawing.Point(6, 16);
            this.lblSellerName.Name = "lblSellerName";
            this.lblSellerName.Size = new System.Drawing.Size(35, 13);
            this.lblSellerName.TabIndex = 3;
            this.lblSellerName.Text = "Name";
            // 
            // lblSellerCommision
            // 
            this.lblSellerCommision.AutoSize = true;
            this.lblSellerCommision.Location = new System.Drawing.Point(6, 42);
            this.lblSellerCommision.Name = "lblSellerCommision";
            this.lblSellerCommision.Size = new System.Drawing.Size(62, 13);
            this.lblSellerCommision.TabIndex = 4;
            this.lblSellerCommision.Text = "Commission";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(6, 68);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(28, 13);
            this.lblSale.TabIndex = 5;
            this.lblSale.Text = "Sale";
            // 
            // tbxSellerName
            // 
            this.tbxSellerName.Location = new System.Drawing.Point(69, 13);
            this.tbxSellerName.Name = "tbxSellerName";
            this.tbxSellerName.Size = new System.Drawing.Size(85, 20);
            this.tbxSellerName.TabIndex = 6;
            // 
            // tbxSellerCommission
            // 
            this.tbxSellerCommission.Location = new System.Drawing.Point(69, 42);
            this.tbxSellerCommission.Name = "tbxSellerCommission";
            this.tbxSellerCommission.Size = new System.Drawing.Size(85, 20);
            this.tbxSellerCommission.TabIndex = 7;
            // 
            // tbxSellerSales
            // 
            this.tbxSellerSales.Location = new System.Drawing.Point(69, 68);
            this.tbxSellerSales.Name = "tbxSellerSales";
            this.tbxSellerSales.Size = new System.Drawing.Size(85, 20);
            this.tbxSellerSales.TabIndex = 8;
            // 
            // btnRegisterSale
            // 
            this.btnRegisterSale.Location = new System.Drawing.Point(9, 127);
            this.btnRegisterSale.Name = "btnRegisterSale";
            this.btnRegisterSale.Size = new System.Drawing.Size(145, 23);
            this.btnRegisterSale.TabIndex = 9;
            this.btnRegisterSale.Text = "Register Sale";
            this.btnRegisterSale.UseVisualStyleBackColor = true;
            this.btnRegisterSale.Click += new System.EventHandler(this.btnRegisterSale_Click);
            // 
            // btnRegsiterShift
            // 
            this.btnRegsiterShift.Location = new System.Drawing.Point(9, 127);
            this.btnRegsiterShift.Name = "btnRegsiterShift";
            this.btnRegsiterShift.Size = new System.Drawing.Size(145, 23);
            this.btnRegsiterShift.TabIndex = 16;
            this.btnRegsiterShift.Text = "Register Shift";
            this.btnRegsiterShift.UseVisualStyleBackColor = true;
            this.btnRegsiterShift.Click += new System.EventHandler(this.btnRegsiterShift_Click);
            // 
            // tbxConsultantHours
            // 
            this.tbxConsultantHours.Location = new System.Drawing.Point(81, 71);
            this.tbxConsultantHours.Name = "tbxConsultantHours";
            this.tbxConsultantHours.Size = new System.Drawing.Size(85, 20);
            this.tbxConsultantHours.TabIndex = 15;
            // 
            // tbxConsultantRate
            // 
            this.tbxConsultantRate.Location = new System.Drawing.Point(81, 45);
            this.tbxConsultantRate.Name = "tbxConsultantRate";
            this.tbxConsultantRate.Size = new System.Drawing.Size(85, 20);
            this.tbxConsultantRate.TabIndex = 14;
            // 
            // tbxConsultantName
            // 
            this.tbxConsultantName.Location = new System.Drawing.Point(81, 16);
            this.tbxConsultantName.Name = "tbxConsultantName";
            this.tbxConsultantName.Size = new System.Drawing.Size(85, 20);
            this.tbxConsultantName.TabIndex = 13;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(6, 74);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(71, 13);
            this.lblHoursWorked.TabIndex = 12;
            this.lblHoursWorked.Text = "Time Worked";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(6, 45);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(63, 13);
            this.lblHourlyRate.TabIndex = 11;
            this.lblHourlyRate.Text = "Hourly Rate";
            // 
            // lblConsultantName
            // 
            this.lblConsultantName.AutoSize = true;
            this.lblConsultantName.Location = new System.Drawing.Point(6, 19);
            this.lblConsultantName.Name = "lblConsultantName";
            this.lblConsultantName.Size = new System.Drawing.Size(35, 13);
            this.lblConsultantName.TabIndex = 10;
            this.lblConsultantName.Text = "Name";
            // 
            // btnRegisterSalary
            // 
            this.btnRegisterSalary.Location = new System.Drawing.Point(9, 127);
            this.btnRegisterSalary.Name = "btnRegisterSalary";
            this.btnRegisterSalary.Size = new System.Drawing.Size(145, 23);
            this.btnRegisterSalary.TabIndex = 23;
            this.btnRegisterSalary.Text = "Register Salary";
            this.btnRegisterSalary.UseVisualStyleBackColor = true;
            this.btnRegisterSalary.Click += new System.EventHandler(this.btnRegisterSalary_Click);
            // 
            // tbxClerkName
            // 
            this.tbxClerkName.Location = new System.Drawing.Point(87, 13);
            this.tbxClerkName.Name = "tbxClerkName";
            this.tbxClerkName.Size = new System.Drawing.Size(85, 20);
            this.tbxClerkName.TabIndex = 20;
            // 
            // lblClerkName
            // 
            this.lblClerkName.AutoSize = true;
            this.lblClerkName.Location = new System.Drawing.Point(6, 16);
            this.lblClerkName.Name = "lblClerkName";
            this.lblClerkName.Size = new System.Drawing.Size(35, 13);
            this.lblClerkName.TabIndex = 17;
            this.lblClerkName.Text = "Name";
            // 
            // tbxClerkSalary
            // 
            this.tbxClerkSalary.Location = new System.Drawing.Point(87, 42);
            this.tbxClerkSalary.Name = "tbxClerkSalary";
            this.tbxClerkSalary.Size = new System.Drawing.Size(85, 20);
            this.tbxClerkSalary.TabIndex = 21;
            // 
            // lblMonthlySalary
            // 
            this.lblMonthlySalary.AutoSize = true;
            this.lblMonthlySalary.Location = new System.Drawing.Point(6, 42);
            this.lblMonthlySalary.Name = "lblMonthlySalary";
            this.lblMonthlySalary.Size = new System.Drawing.Size(76, 13);
            this.lblMonthlySalary.TabIndex = 18;
            this.lblMonthlySalary.Text = "Monthly Salary";
            // 
            // lbxRegistery
            // 
            this.lbxRegistery.FormattingEnabled = true;
            this.lbxRegistery.Location = new System.Drawing.Point(12, 216);
            this.lbxRegistery.Name = "lbxRegistery";
            this.lbxRegistery.Size = new System.Drawing.Size(160, 160);
            this.lbxRegistery.TabIndex = 17;
            // 
            // lblSysRegister
            // 
            this.lblSysRegister.AutoSize = true;
            this.lblSysRegister.Location = new System.Drawing.Point(56, 200);
            this.lblSysRegister.Name = "lblSysRegister";
            this.lblSysRegister.Size = new System.Drawing.Size(69, 13);
            this.lblSysRegister.TabIndex = 18;
            this.lblSysRegister.Text = "REGISTERY";
            // 
            // lbxSalaries
            // 
            this.lbxSalaries.FormattingEnabled = true;
            this.lbxSalaries.Location = new System.Drawing.Point(214, 216);
            this.lbxSalaries.Name = "lbxSalaries";
            this.lbxSalaries.Size = new System.Drawing.Size(172, 160);
            this.lbxSalaries.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "SALARY PAYMENTS";
            // 
            // btnCalculateSalaries
            // 
            this.btnCalculateSalaries.Location = new System.Drawing.Point(408, 216);
            this.btnCalculateSalaries.Name = "btnCalculateSalaries";
            this.btnCalculateSalaries.Size = new System.Drawing.Size(178, 23);
            this.btnCalculateSalaries.TabIndex = 21;
            this.btnCalculateSalaries.Text = "Calculate Salaries";
            this.btnCalculateSalaries.UseVisualStyleBackColor = true;
            this.btnCalculateSalaries.Click += new System.EventHandler(this.btnCalculateSalaries_Click);
            // 
            // lblTotalSalaries
            // 
            this.lblTotalSalaries.AutoSize = true;
            this.lblTotalSalaries.Location = new System.Drawing.Point(405, 293);
            this.lblTotalSalaries.Name = "lblTotalSalaries";
            this.lblTotalSalaries.Size = new System.Drawing.Size(71, 13);
            this.lblTotalSalaries.TabIndex = 22;
            this.lblTotalSalaries.Text = "Total Salaries";
            // 
            // tbxTotalSalaries
            // 
            this.tbxTotalSalaries.Location = new System.Drawing.Point(408, 309);
            this.tbxTotalSalaries.Name = "tbxTotalSalaries";
            this.tbxTotalSalaries.ReadOnly = true;
            this.tbxTotalSalaries.Size = new System.Drawing.Size(178, 20);
            this.tbxTotalSalaries.TabIndex = 23;
            // 
            // formApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 388);
            this.Controls.Add(this.tbxTotalSalaries);
            this.Controls.Add(this.lblTotalSalaries);
            this.Controls.Add(this.btnCalculateSalaries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxSalaries);
            this.Controls.Add(this.lblSysRegister);
            this.Controls.Add(this.lbxRegistery);
            this.Controls.Add(this.gbxClerk);
            this.Controls.Add(this.gbxConsultant);
            this.Controls.Add(this.gbxSeller);
            this.Name = "formApp";
            this.Text = "Employee Registery";
            this.gbxSeller.ResumeLayout(false);
            this.gbxSeller.PerformLayout();
            this.gbxConsultant.ResumeLayout(false);
            this.gbxConsultant.PerformLayout();
            this.gbxClerk.ResumeLayout(false);
            this.gbxClerk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSeller;
        private System.Windows.Forms.Button btnRegisterSale;
        private System.Windows.Forms.TextBox tbxSellerSales;
        private System.Windows.Forms.TextBox tbxSellerCommission;
        private System.Windows.Forms.TextBox tbxSellerName;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.Label lblSellerCommision;
        private System.Windows.Forms.Label lblSellerName;
        private System.Windows.Forms.GroupBox gbxConsultant;
        private System.Windows.Forms.Button btnRegsiterShift;
        private System.Windows.Forms.TextBox tbxConsultantName;
        private System.Windows.Forms.TextBox tbxConsultantHours;
        private System.Windows.Forms.Label lblConsultantName;
        private System.Windows.Forms.TextBox tbxConsultantRate;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.GroupBox gbxClerk;
        private System.Windows.Forms.Button btnRegisterSalary;
        private System.Windows.Forms.TextBox tbxClerkName;
        private System.Windows.Forms.Label lblMonthlySalary;
        private System.Windows.Forms.Label lblClerkName;
        private System.Windows.Forms.TextBox tbxClerkSalary;
        private System.Windows.Forms.ListBox lbxRegistery;
        private System.Windows.Forms.Label lblSysRegister;
        private System.Windows.Forms.ListBox lbxSalaries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateSalaries;
        private System.Windows.Forms.Label lblTotalSalaries;
        private System.Windows.Forms.TextBox tbxTotalSalaries;
    }
}


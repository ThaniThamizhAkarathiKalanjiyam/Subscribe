namespace SubscriptionSystem
{
    partial class usrCntrlCustomerEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCusSubscripsionDate = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtOneOffPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblOneOffPaymentAmount = new System.Windows.Forms.Label();
            this.lblIsRecurringEnabled = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.cboRecurringEnabled = new System.Windows.Forms.ComboBox();
            this.cboDate = new System.Windows.Forms.ComboBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(354, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(261, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblCustomerName.Location = new System.Drawing.Point(19, 31);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(216, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Enter Customer Name";
            // 
            // lblCusSubscripsionDate
            // 
            this.lblCusSubscripsionDate.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblCusSubscripsionDate.Location = new System.Drawing.Point(19, 62);
            this.lblCusSubscripsionDate.Name = "lblCusSubscripsionDate";
            this.lblCusSubscripsionDate.Size = new System.Drawing.Size(216, 13);
            this.lblCusSubscripsionDate.TabIndex = 3;
            this.lblCusSubscripsionDate.Text = "Enter Subscripsion Date";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(244, 28);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(184, 20);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtOneOffPaymentAmount
            // 
            this.txtOneOffPaymentAmount.Location = new System.Drawing.Point(244, 116);
            this.txtOneOffPaymentAmount.Name = "txtOneOffPaymentAmount";
            this.txtOneOffPaymentAmount.Size = new System.Drawing.Size(184, 20);
            this.txtOneOffPaymentAmount.TabIndex = 9;
            // 
            // lblOneOffPaymentAmount
            // 
            this.lblOneOffPaymentAmount.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblOneOffPaymentAmount.Location = new System.Drawing.Point(19, 119);
            this.lblOneOffPaymentAmount.Name = "lblOneOffPaymentAmount";
            this.lblOneOffPaymentAmount.Size = new System.Drawing.Size(216, 13);
            this.lblOneOffPaymentAmount.TabIndex = 7;
            this.lblOneOffPaymentAmount.Text = "Enter OneOff Payment Amount";
            // 
            // lblIsRecurringEnabled
            // 
            this.lblIsRecurringEnabled.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblIsRecurringEnabled.Location = new System.Drawing.Point(19, 88);
            this.lblIsRecurringEnabled.Name = "lblIsRecurringEnabled";
            this.lblIsRecurringEnabled.Size = new System.Drawing.Size(216, 13);
            this.lblIsRecurringEnabled.TabIndex = 6;
            this.lblIsRecurringEnabled.Text = "Want Recurring subscripsion?";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(244, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(184, 20);
            this.textBox5.TabIndex = 11;
            // 
            // lblAccountStatus
            // 
            this.lblAccountStatus.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblAccountStatus.Location = new System.Drawing.Point(19, 155);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(216, 13);
            this.lblAccountStatus.TabIndex = 10;
            this.lblAccountStatus.Text = "Account Status";
            // 
            // cboRecurringEnabled
            // 
            this.cboRecurringEnabled.FormattingEnabled = true;
            this.cboRecurringEnabled.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboRecurringEnabled.Location = new System.Drawing.Point(244, 85);
            this.cboRecurringEnabled.Name = "cboRecurringEnabled";
            this.cboRecurringEnabled.Size = new System.Drawing.Size(184, 21);
            this.cboRecurringEnabled.TabIndex = 12;
            // 
            // cboDate
            // 
            this.cboDate.FormattingEnabled = true;
            this.cboDate.Location = new System.Drawing.Point(244, 54);
            this.cboDate.Name = "cboDate";
            this.cboDate.Size = new System.Drawing.Size(48, 21);
            this.cboDate.TabIndex = 13;
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(300, 54);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(48, 21);
            this.cboMonth.TabIndex = 14;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(356, 54);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(73, 21);
            this.cboYear.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 105);
            this.dataGridView1.TabIndex = 16;
            // 
            // usrCntrlCustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 329);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.cboDate);
            this.Controls.Add(this.cboRecurringEnabled);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.lblAccountStatus);
            this.Controls.Add(this.txtOneOffPaymentAmount);
            this.Controls.Add(this.lblOneOffPaymentAmount);
            this.Controls.Add(this.lblIsRecurringEnabled);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCusSubscripsionDate);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "usrCntrlCustomerEdit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCusSubscripsionDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOneOffPaymentAmount;
        private System.Windows.Forms.Label lblOneOffPaymentAmount;
        private System.Windows.Forms.Label lblIsRecurringEnabled;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblAccountStatus;
        private System.Windows.Forms.ComboBox cboRecurringEnabled;
        private System.Windows.Forms.ComboBox cboDate;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

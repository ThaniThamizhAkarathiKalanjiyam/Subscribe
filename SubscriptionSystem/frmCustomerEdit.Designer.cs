namespace SubscriptionSystem
{
    partial class frmCustomerEdit
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
            this.usrCntrlCustomerEdit1 = new SubscriptionSystem.usrCntrlCustomerEdit();
            this.SuspendLayout();
            // 
            // usrCntrlCustomerEdit1
            // 
            this.usrCntrlCustomerEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usrCntrlCustomerEdit1.Location = new System.Drawing.Point(0, 0);
            this.usrCntrlCustomerEdit1.Name = "usrCntrlCustomerEdit1";
            this.usrCntrlCustomerEdit1.Size = new System.Drawing.Size(457, 314);
            this.usrCntrlCustomerEdit1.TabIndex = 0;
            // 
            // frmCustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 314);
            this.Controls.Add(this.usrCntrlCustomerEdit1);
            this.Name = "frmCustomerEdit";
            this.Text = "frmCustomerEdit";
            this.ResumeLayout(false);

        }

        #endregion

        private usrCntrlCustomerEdit usrCntrlCustomerEdit1;
    }
}
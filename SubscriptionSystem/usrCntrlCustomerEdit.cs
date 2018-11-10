using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SubscriptionSystemBusiness;
using SubscriptionSystemEntity;

namespace SubscriptionSystem
{
    public partial class usrCntrlCustomerEdit : Form
    {
        public usrCntrlCustomerEdit()
        {
            InitializeComponent();

            //Date
            for (int i = 1; i <= 31; i++)
            {
                if (i < 10)
                {
                    cboDate.Items.Add("0" + i);
                }
                else
                {
                    cboDate.Items.Add(i);
                }
            }
            //Month
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                {
                    cboMonth.Items.Add("0" + i);
                }
                else
                {
                    cboMonth.Items.Add(i);
                }
            }
            //Year
            for (int i = 2018; i <= 2019; i++)
            {
                cboYear.Items.Add(i);
            }

        }
        CustomerB objCustomerB = CustomerB.Instance;

        private void btnSave_Click(object sender, EventArgs e)
        {
            objCustomerB.Customers.Add(new CustomerE
            {
                CustomerName = txtCustomerName.Text,
                CusSubscripsionDate = new DateTime(
                    Convert.ToInt32(cboYear.Text),
                    Convert.ToInt32(cboMonth.Text),
                    Convert.ToInt32(cboDate.Text)
                    ),
                IsRecurringEnabled = cboRecurringEnabled.Text == "Yes" ? true : false,
                OneOffPaymentAmount = Convert.ToInt32(txtOneOffPaymentAmount.Text)
            });

            MessageBox.Show("No of customers: " + objCustomerB.Customers.Count);

            this.Dispose();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

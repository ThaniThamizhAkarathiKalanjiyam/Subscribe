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
    public partial class frmCntrlCustomerEdit : Form
    {
        public frmCntrlCustomerEdit()
        {
            InitializeComponent();

            LoadDateValues();

        }

        private void LoadDateValues()
        {
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

        public frmCntrlCustomerEdit(string customerName)
        {
            InitializeComponent();

            LoadDateValues();
            LoadCustomerDetailsFromList(customerName);
        }
        string customerNameLoc = "";
        CustomerE customerDetail = new CustomerE();
        private void LoadCustomerDetailsFromList(string customerName)
        {
            customerNameLoc = customerName;

            for (int i = 0; i < objCustomerB.Customers.Count; i++)
            {
                if (objCustomerB.Customers[i].CustomerName == customerName)
                {
                    customerDetail = objCustomerB.Customers[i];
                }
            }

            txtCustomerName.Text = customerDetail.CustomerName;
            cboDate.Text = customerDetail.CusSubscripsionDate.ToString("dd");
            cboMonth.Text = customerDetail.CusSubscripsionDate.ToString("MM");
            cboYear.Text = customerDetail.CusSubscripsionDate.Year.ToString();

            paymentLOC = customerDetail.Payment;

            var list = new BindingList<PaymentE>(customerDetail.Payment);
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }

        CustomerB objCustomerB = CustomerB.Instance;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (customerNameLoc == "")
            {
                //add coding
                objCustomerB.Customers.Add(new CustomerE
                {
                    CustomerName = txtCustomerName.Text,
                    CusSubscripsionDate = new DateTime(
                        Convert.ToInt32(cboYear.Text),
                        Convert.ToInt32(cboMonth.Text),
                        Convert.ToInt32(cboDate.Text)
                        ),
                    Payment = paymentLOC
                    //IsRecurringEnabled = cboRecurringEnabled.Text == "Yes" ? true : false,
                    //OneOffPaymentAmount = Convert.ToInt32(txtOneOffPaymentAmount.Text)
                });
            }
            else
            {
                // editing
                customerDetail.CustomerName = txtCustomerName.Text;
                customerDetail.CusSubscripsionDate = new DateTime(
                    Convert.ToInt32(cboYear.Text),
                    Convert.ToInt32(cboMonth.Text),
                    Convert.ToInt32(cboDate.Text)
                    );
                //customerDetail.IsRecurringEnabled = cboRecurringEnabled.Text == "Yes" ? true : false;
                //customerDetail.OneOffPaymentAmount = Convert.ToInt32(txtOneOffPaymentAmount.Text);

            }

            MessageBox.Show("No of customers: " + objCustomerB.Customers.Count);

            this.Dispose();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        List<PaymentE> paymentLOC = new List<PaymentE>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPayment objFrmPayment = new frmPayment();
            objFrmPayment.ShowDialog();

            paymentLOC.Add
                (
                    objFrmPayment.getPayment()
                );
            objFrmPayment.Dispose();


            var list = new BindingList<PaymentE>(paymentLOC);
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }
    }
}

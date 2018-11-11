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
    public partial class usrCntrlCustomerSummary : UserControl
    {
        CustomerB objCustomerB = CustomerB.Instance;

        public usrCntrlCustomerSummary()
        {
            InitializeComponent();

           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCntrlCustomerEdit objFrmCustomerEdit = new frmCntrlCustomerEdit();
            objFrmCustomerEdit.ShowDialog();


            var list = new BindingList<CustomerE>(objCustomerB.Customers);
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            string selectedCustomerName =
            dataGridView1.CurrentRow.Cells["CustomerName"].Value.ToString();

            frmCntrlCustomerEdit objFrmCustomerEdit = new frmCntrlCustomerEdit(selectedCustomerName);
            objFrmCustomerEdit.ShowDialog();

            var list = new BindingList<CustomerE>(objCustomerB.Customers);
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            objCustomerB.calculateAccountStatus();

            var list = new BindingList<CustomerE>(objCustomerB.Customers);
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }
    }
}

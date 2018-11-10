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
            usrCntrlCustomerEdit objFrmCustomerEdit = new usrCntrlCustomerEdit();
            objFrmCustomerEdit.ShowDialog();


            var list = new BindingList<CustomerE>(objCustomerB.Customers);
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }
    }
}

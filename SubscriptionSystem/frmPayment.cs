using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SubscriptionSystemEntity;

namespace SubscriptionSystem
{
    public partial class frmPayment : Form
    {
        
        public frmPayment()
        {
            InitializeComponent();
            LoadDateValues();
            comboBox1.DataSource =
                Enum.GetValues(typeof(PaymentTypeE));
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        internal PaymentE getPayment()
        {
            PaymentE objPaymentE = new PaymentE();

            objPaymentE.PaymentType = comboBox1.Text == "One_Off_Payment" ? PaymentTypeE.One_Off_Payment : PaymentTypeE.Recurring_Payment;
            objPaymentE.PaymentAmount = Convert.ToInt32(textBox1.Text);
            objPaymentE.PaymentDate = new DateTime(
               Convert.ToInt32( cboYear.Text),
               Convert.ToInt32( cboMonth.Text),
                Convert.ToInt32(cboDate.Text)
                );

            return objPaymentE;
        }
    }
}

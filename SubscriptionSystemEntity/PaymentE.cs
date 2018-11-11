using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubscriptionSystemEntity
{
    public class PaymentE
    {
        /*Given the following sequence of events, determine whether each customer's 
        * account is paid in full, in a overdue state, or disabled.*/
        PaymentTypeE paymentType = PaymentTypeE.One_Off_Payment;

        public PaymentTypeE PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }

        int paymentAmount = 0;

        public int PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }

        DateTime paymentDate = new DateTime();

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
    }
}

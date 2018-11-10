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
    }
}

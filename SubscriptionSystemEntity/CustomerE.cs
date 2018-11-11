/*
 * Created by SharpDevelop.
 * User: muthukumaran
 * Date: 11/10/2018
 * Time: 11:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SubscriptionSystemEntity
{
    /// <summary>
    /// Description of Customer.
    /// </summary>
    public class CustomerE
    {

        string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        AccountStatusE accountStatus = AccountStatusE.Disabled;

        public AccountStatusE AccountStatus
        {
            get { return accountStatus; }
            set { accountStatus = value; }
        }
        int dueAmount;

        public int DueAmount
        {
            get { return dueAmount; }
            set { dueAmount = value; }
        }
        DateTime cusSubscripsionDate = new DateTime(2018, 01, 01);

        public DateTime CusSubscripsionDate
        {
            get { return cusSubscripsionDate; }
            set { cusSubscripsionDate = value; }
        }
        bool isRecurringEnabled = false;

        public bool IsRecurringEnabled
        {
            get { return isRecurringEnabled; }
            set { isRecurringEnabled = value; }
        }
        
        int oneOffPaymentAmount;

        public int OneOffPaymentAmount
        {
            get { return oneOffPaymentAmount; }
            set { oneOffPaymentAmount = value; }
        }

        List<PaymentE> payment = new List<PaymentE>();

        public List<PaymentE> Payment
        {
            get { return payment; }
            set { payment = value; }
        }
 

        public CustomerE()
        {

        }

    }

}

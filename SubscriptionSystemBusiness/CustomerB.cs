using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubscriptionSystemEntity;

namespace SubscriptionSystemBusiness
{
    public sealed class CustomerB
    {
        public int  SubscriptionCost = 4;

        private static CustomerB instance = new CustomerB();

        public static CustomerB Instance
        {
            get
            {
                return instance;
            }
        }
        List<CustomerE> customers = new List<CustomerE>();

        public List<CustomerE> Customers
        {
            get { return customers; }
            set { customers = value; }
        }
        private CustomerB()
        {
        }
    }
}

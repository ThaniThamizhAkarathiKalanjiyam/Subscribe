using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SubscriptionSystemEntity;

namespace SubscriptionSystemBusiness
{
    public sealed class CustomerB
    {
        public int SubscriptionCost = 4;
        DateTime TodayDate = new DateTime(2018, 07, 31);

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



        public void calculateAccountStatus()
        {
            int totalMonths = 0;
            int totalSunscriptionAmount = 0;
            int subAmount = 0;

            for (int i = 0; i < customers.Count; i++)
            {

                totalMonths = TodayDate.Month - customers[i].CusSubscripsionDate.Month + 1;
                totalSunscriptionAmount = SubscriptionCost * totalMonths;

                int totalPayment = 0;
                for (int j = 0; j < customers[i].Payment.Count; j++)
                {
                    if (customers[i].Payment[j].PaymentType
                        == PaymentTypeE.One_Off_Payment)
                    {
                        //Remove $ 1 from whole amount for surcharge
                        totalPayment += (customers[i].Payment[j].PaymentAmount - 1);
                    }
                    else
                    {
                        totalPayment += customers[i].Payment[j].PaymentAmount;
                    }
                }
                subAmount = totalPayment - totalSunscriptionAmount;
                customers[i].DueAmount = subAmount;
                if (subAmount == 0 || subAmount > 0)
                { 
                    //Fully Paid
                    customers[i].AccountStatus = AccountStatusE.Fully_Paid;                
                }
                else if (subAmount < 0 && subAmount >= -8)
                {
                    customers[i].AccountStatus = AccountStatusE.Over_Due;
                }
                else //if (subAmount < -8)
                {
                    customers[i].AccountStatus = AccountStatusE.Disabled;
                }
            }
        }
    }
}

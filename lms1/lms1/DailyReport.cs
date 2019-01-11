using System;

namespace lms1
{
    public class DailyReport
    {

        public void RecordPurchase(double price)
        {
            actualCustomerCount++;
            EndingBalance += price;
        }
        public double InitialBalance
        {
            get { return initialBalance; }
            set
            { initialBalance = value; }
        }

        int potentialCustomerCount;
        public int PotentialCustomerCount
        {
            get { return potentialCustomerCount; }
            set { potentialCustomerCount = value; }
        }

        int actualCustomerCount;
        public int ActualCustomerCount
        {
            get { return actualCustomerCount; }
            set { actualCustomerCount = value; }
        }
        double endingBalance;
        public double EndingBalance
        {
            get { return endingBalance; }
            set { endingBalance = value; }
        }
        double initialBalance;
        
        bool ranOutOfInventory = false;
        public bool RanOutOfInventory
        {
            get { return ranOutOfInventory; }
            set { ranOutOfInventory = value; }
        }

      

    }
}
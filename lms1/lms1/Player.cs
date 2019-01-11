using System;
using System.Collections.Generic;

namespace lms1
{
    abstract public class Player
    {
        static double initialBalance = 20;

        double balance;
        string name;
        Dictionary<string, int> inventory;
        List<DailyReport> dailyReports;


        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public static double InitialBalance
        {
            get { return initialBalance; }
            private set { initialBalance = value; }
        }

        public List<DailyReport> DailyReports
        {
            get { return dailyReports; }
            set { dailyReports = value; }
        }

        public Dictionary<string, int> Invetory
        {
            get { return inventory; }
            private set { inventory = value; }
        }

        public string Name
        {
            get { return name.ToLower(); }

            set { name = value.ToLower(); }
        }

        public Player(Store store)
        {
            Balance = InitialBalance;
            name = "";
            inventory = new Dictionary<string, int>();
            DailyReports = new List<DailyReport>();
            for (int i = 0; i < store.Products.Count; i++)
            {
                inventory.Add(store.Products[i].Name, 0);
            }
            DailyReports = new List<DailyReport>();
        }

        public int AdjustInventory(string item, int quanityIncrementer)
        {
            int currentQuanity;

            if (inventory.TryGetValue(item, out currentQuanity))
            {
                if (int.MaxValue - currentQuanity >= quanityIncrementer)
                {
                    inventory[item] = currentQuanity + quanityIncrementer;
                }
                else
                {
                    throw new OverflowException();
                }
            }
            else
            {
                inventory[item] = quanityIncrementer > 0 ? quanityIncrementer : 0;
            }

            return inventory[item];
        }

        

        private void UseInventory(object name, object measurement)
        {
            throw new NotImplementedException();
        }

        public double ProcessTransaction(double increaseBalanceBy)
        {
            if (double.MaxValue - Balance <= increaseBalanceBy) { throw new OverflowException(); }
            if (double.MinValue + Balance >= increaseBalanceBy) { throw new OverflowException(); }
            return Balance += increaseBalanceBy;
        }

        public void SetPlayerName(string playerLabel)
        {
            Name = Shopping.GetInput($"Enter {playerLabel}'s name:", "string");
        }

        private void UseInventory(string item, int quanity)
        {
            inventory[item] -= quanity;
        }
    }
}
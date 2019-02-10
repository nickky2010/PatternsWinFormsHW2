using System;
using System.Collections.Generic;

namespace Task1_Singleton_Proxy.Proxy.Singleton
{
    class Chief : Order
    {
        private static Chief instance;
        public string Name { get; private set; }
        public decimal RewardFund { get; private set; }
        private decimal BalanceRewardFund { get; set; }
        private static object syncRoot = new Object();
        public List<string> ListRewardEmployee { get; private set; }
        private Chief(string name, decimal rewardFund)
        {
            this.Name = name;
            this.RewardFund = rewardFund;
            BalanceRewardFund = rewardFund;
            ListRewardEmployee = new List<string>();
        }

        public static Chief GetInstance(string name, decimal rewardFund)
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                        instance = new Chief(name, rewardFund);
                }
            }
            return instance;
        }
        public override void AddToRewardOrder(string employeeName, double percent)
        {
            if(employeeName == "")
                throw new Exception("Employee name is not specified!");
            decimal award = RewardFund * (decimal)(percent / 100);
            string rewardOrder = "Not award";
            if (BalanceRewardFund >= award)
            {
                BalanceRewardFund -= award;
                rewardOrder = (ListRewardEmployee.Count+1).ToString()+". Award " + employeeName + " in the amount of " + award.ToString("C2");
            }
            else
                throw new Exception("There are not enough money in the fund for rewards!");
            ListRewardEmployee.Add(rewardOrder);
        }

        public override List<string> CreatRewardOrder()
        {
            return ListRewardEmployee;
        }
    }
}

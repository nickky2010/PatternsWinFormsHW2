using System;
using System.Collections.Generic;
using Task1_Singleton_Proxy.Proxy.Singleton;

namespace Task1_Singleton_Proxy.Proxy
{
    class Secretary:Order
    {
        Chief chief;
        string nameChief;
        decimal rewardFund;
        public string Name { get; private set; }
        List<string> Order { get; set; }

        public Secretary(string name, string nameChief, decimal rewardFund)
        {
            this.Name = name;
            this.nameChief = nameChief;
            this.rewardFund = rewardFund;
            Order = new List<string>();
        }

        public override void AddToRewardOrder(string employeeName, double percent)
        {
            if (chief == null)
                chief = Chief.GetInstance(nameChief, rewardFund);
            chief.AddToRewardOrder(employeeName, percent);
        }

        public override List<string> CreatRewardOrder()
        {
            Order.Add("\tLLC \"Horns and Hooves\"");
            Order.Add("\t\tOrder");
            Order.Add("");
            Order.AddRange(chief.ListRewardEmployee);
            Order.Add("");
            Order.Add(DateTime.Now.ToShortDateString()+"\t\t"+ Name);
            return Order;
        }
    }
}

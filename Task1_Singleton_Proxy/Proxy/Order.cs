using System.Collections.Generic;

namespace Task1_Singleton_Proxy.Proxy
{
    abstract class Order
    {
        public abstract void AddToRewardOrder(string employeeName, double percent);
        public abstract List<string> CreatRewardOrder();

    }
}

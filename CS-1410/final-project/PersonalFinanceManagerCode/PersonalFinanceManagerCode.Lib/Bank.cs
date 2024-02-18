namespace PersonalFinanceManager
{
    public class Bank
    {
        private string name;
        private int routingNumber;
        
        public string Name { get => name; }
        public int RoutingNumber { get => routingNumber; }

        public Bank(string bankName, int routingNum)
        {
            name = bankName;
            routingNumber = routingNum;
        }

    }
}
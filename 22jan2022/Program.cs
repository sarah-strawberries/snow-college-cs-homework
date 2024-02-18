using System;

namespace InterfacePractice
{
    class Program
    {
        public interface IBusiness
        {
            public bool BuySomething();
            public bool SellSomething();
            public bool PayEmployees();
            public void AddToList(string item, decimal cost);
        
        }


        class SmallBusiness : IBusiness
        {
            public decimal minimumWage = 10; //$ per hour
            private decimal funds;

            private IDictionary<string, int> thingsToBuy = new Dictionary< string, int>();
            private IDictionary<string, int> sellingInventory = new Dictionary< string, int>();
            public bool BuySomething()
            {
                //If funds are sufficient, decrease funds by the price of item in thingsToBuy list and add item to sellingInventory list. Allow user to declare new price before adding to selling inventory.
                return true;
            }
            public bool SellSomething()
            {
                //Remove a specified item from the sellingInventory list and increase the money in funds variable by the item's cost
                return true;
            }
            public bool PayEmployees()
            {
                //remove a set amount of money from funds for each employee, provided there is enough money in funds
                return true;
            }
            public void AddToList(string item, decimal cost)
            {
                //Add an item to the list of things you can buy
            }
            public SmallBusiness(decimal initialFunds)
            {
                funds = initialFunds;
                Console.WriteLine("Press any key to add an item to the list of things your small business wants to buy.");
                if (Console.ReadLine() != null)
                {
                    string item = Console.ReadLine("Please write the name of the item.");
                    decimal cost = Console.ReadLine("Please write the cost of the item as a whole-number value (in US dollars).");
                    AddToList(item, cost);
                }
                }
            }
        }

    } 
}
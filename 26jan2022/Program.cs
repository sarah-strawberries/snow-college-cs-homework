using System;

namespace Section4_8Practice
{
    class Program
    {
        public interface IBusiness
        {
            public void BuySomething();
            public bool SellSomething();
            private decimal funds;
            private string kindOfBusiness;
            private IDictionary<string, int> QtyInventory = new IDictionary<string, int>();
            private IDictionary<string, decimal> ProductsForSale = new IDictionary<string, decimal>();

        }

        public class Manufacturer : IBusiness
        {
            
        }
    }
}
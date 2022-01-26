using System;

namespace Section4_8Practice
{
    class Program
    {
        public interface IBusiness
        {
            public void BuySomething(string thing, decimal cost);
            public bool SellSomething();

        }

        public abstract class Business : IBusiness
        {
            void IBusiness.BuySomething(string thing, decimal cost)
            {
        
            }

            bool IBusiness.SellSomething()
            {
                throw new NotImplementedException();
            }
            protected decimal funds;
            private string kindOfBusiness;
            public Business(string kind, decimal startingFunds)
            {
                kindOfBusiness = kind;
                funds = startingFunds;
            }
        }
        public class BigBusiness : Business, IBusiness
        {
            public override void BuySomething(string thing, decimal cost)
            {
            }
        }
    }
}
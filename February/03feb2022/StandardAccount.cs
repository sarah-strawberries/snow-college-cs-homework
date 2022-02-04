namespace PracticeWithHashesAndArrays
{
    class StandardAccount : IAccount
    {
        private string Name;
        private decimal balance;

        public StandardAccount(string name, decimal startingBalance)
        {
            Name = name;
            if (startingBalance <0)
            {
                throw new BadInputException("No negative starting balances allowed!");
            }
            balance = startingBalance;
        }

        public void DepositFunds(decimal amount)
        {
            balance = balance + amount;
            Console.WriteLine($"Your deposit of ${amount} was successful.");
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public bool WithdrawFunds(decimal amount)
        {
            if (balance < amount) 
            {
                Console.WriteLine("ERROR: Insufficient funds!");
                return false;
            }
            balance = balance - amount;
            Console.WriteLine($"Your withdrawal of ${amount} was successful.");
            return true;
        }

        string IAccount.GetName()
        {
            return this.Name;
        }
    }
}
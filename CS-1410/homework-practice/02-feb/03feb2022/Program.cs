using System;
namespace PracticeWithHashesAndArrays
{
    interface IAccount
    {
        void DepositFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
        string GetName();
    }

    interface IBank
    {
        public IAccount FindAccount(string name);
        public bool StoreAccount(IAccount account);        
    }
    class Program
    {
        IBank bank = new ArrayBank(25);
    }

    public class ArrayBank : IBank
    {
        public int position = 0;
        private IAccount [] accounts;
        public ArrayBank(int size)
        {
            accounts = new IAccount[size];
        }

        public IAccount FindAccount(string name)
        {
            for (position = 0; position < accounts.Length; position++)
            {
                if (accounts[position] == null)
                {
                    continue;
                }
                if (accounts[position].GetName() != name)
                {
                    continue;
                }
                if (accounts[position].GetName() == name)
                {
                    return accounts[position];
                }
                return null;
            }
        }
        
        public bool IBank.StoreAccount(IAccount account)
        {
            for (position = 0; position < accounts.Length; position++)
            {
                if (accounts[position] == null)
                {
                    accounts[position] = account;
                    return true;
                }
                return false;
        }
    }


}g
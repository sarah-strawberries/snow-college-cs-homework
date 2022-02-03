using System;
namespace PracticeWithHashesAndArrays
{
    interface IAccount
    {
        void DepositFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank2
{
    class Account
    {
        protected int accountNumber;
        protected double balance;
        public Account(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }
        public virtual void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Not enough money");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Account: {accountNumber}\n, Balance: {balance}");
            }
        }
    }
    class VipAccount : Account
    {
        private double overDreaftMax;
        public VipAccount(int accountNumber, double balance, double overDreaftMax)
        : base(accountNumber, balance)
        {
            this.overDreaftMax = overDreaftMax;
        }
        public override void Withdraw(double amount)
        {
            if (balance - amount < -overDreaftMax)
            {
                Console.WriteLine("Not enough money (your overdraft is over 5000$)");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("You withdraw from a VIP account");
                Console.WriteLine($"Account: {accountNumber},\nBalance: {balance}");
            }
        }
    }
}
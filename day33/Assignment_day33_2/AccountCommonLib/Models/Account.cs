using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommonLib.Models
{
    public class Account
    {
        public string Name { get; private set; }
        public double Balance { get; private set; }

        public Account(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }

        public void Debit(double amount)
        {
            if (Balance < amount) throw new InsufficientFundException(account);
            Balance = Balance - amount;
        }

        public void Credit(int amount) => Balance = amount + Balance;
    }
}

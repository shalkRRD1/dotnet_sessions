using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_day25.Models
{
    internal class Account
    {
        private string name;
        private int amt = 10000;
        public Account(string name, int amt)
        {
            this.name = name;
            this.amt = amt;

            Console.WriteLine("Account created");
        }

        //constructor chaining
        //public Account(string name) : this(name, amt)
        //{

        //}
        public Account CanYouTransfer(Account secondAcc)
        {

            //Player x;x expects an object of Player class

            if (this.amt == secondAcc.amt)
            {
                return null;
            }

            return secondAcc.amt > this.amt ? secondAcc : this;
        }
        public int Amt
        {
            get { return amt; }
        }
        public string Name
        {
            get { return name; }
        }
    }
}

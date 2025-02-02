﻿using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountHolder[] accountHolders = new AccountHolder[] {

            new AccountHolder("Abcd",50000),
            new AccountHolder("Abcd Efgh", 30000),
            new AccountHolder("Abcd Xyzabc", 75000) };

            DisplayRichest(accountHolders);
            DisplayLengthyName(accountHolders);

            string accNameTo = null;
            string accNameFrom = null;
            double amount = 0;
            Console.WriteLine("Enter the account to transfer from:");
            accNameFrom = Console.ReadLine();
            Console.WriteLine("Enter the account to transfer to:");
            accNameTo = Console.ReadLine();
            Console.WriteLine("Enter the amount to transfer:");
            amount = Int32.Parse(Console.ReadLine());
            DisplayTransfer(accNameFrom, accNameTo, amount, accountHolders);
        }

        public static void DisplayRichest(AccountHolder[] acc)
        {
            double max = 0;
            string maxName = null;
            for (int i = 0; i < acc.Length; i++)
            {
                if (max < acc[i].Balance)
                {
                    maxName = acc[i].Name;
                    max = acc[i].Balance;
                }
            }
            Console.WriteLine($"Name: {maxName}, Balance: {max}");
        }
        public static void DisplayLengthyName(AccountHolder[] acc)
        {
            int maxLength = 0;
            string maxName = null;
            for (int i = 0; i < acc.Length; i++)
            {
                if (acc[i].Name.Length > 8)
                {
                    maxName = acc[i].Name;
                    maxLength = acc[i].Name.Length;
                    Console.WriteLine($"Name: {maxName}, Name Length: {maxLength}");
                }
            }
        }
        public static void DisplayTransfer(string accNameFrom, string accNameTo, double amount, AccountHolder[] acc)
        {
            int maxLength = 0;
            string maxName = null;
            for (int i = 0; i < acc.Length; i++)
            {
                if (acc[i].Name == accNameFrom)
                {
                    acc[i].Balance = acc[i].Balance - amount;
                    Console.WriteLine($"Account Name: {acc[i].Name} transfered an amount of: {amount},Current Balance: {acc[i].Balance}");
                }
                if (acc[i].Name == accNameTo)
                {
                    acc[i].Balance = acc[i].Balance + amount;
                    Console.WriteLine($"Account Name: {acc[i].Name} receved an amount of: {amount},Current Balance: {acc[i].Balance}");

                }
            }

        }
    }
    public class AccountHolder
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public AccountHolder(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }

    }
}
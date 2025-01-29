using System;

namespace Assignment_day33_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("Abc Xyz", 2000);
            try
            {
                account.Debit(2001);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: " + ex.Message);
                Console.WriteLine("Account Balance: " + account.Balance);
            }

        }
    }
}
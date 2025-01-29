using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommonLib.Models
{
    public class InsufficientFundException(Account account) : Exception
    {
         private Account _accountHolder;//HasA relationship

         public InsufficientFundException(Account account)
         { 

            _accountHolder=account;
            //_amount = amount;
            //_balance = balance;
        }
         public override string Message {
             get {

                 return $"account holder:{_accountHolder.Name} , doesnot have sufficends for withraw of balacne is only ${_accountHolder.Balance}";
             }
         }

    }


}
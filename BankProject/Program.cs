using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var account = new BankAccount("Ahror", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(250, DateTime.Now, "Metro");

            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(50, DateTime.Now, "dairyQueen");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());

            // Test for a negative balance.
            /*try
            {
                account.MakeWithdrawal(7500, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }*/

            // Test that the initial balances must be positive.
           /* BankAccount invalidAccount;
            try
            {
                invalidAccount = new BankAccount("invalid", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
                
            }*/
          

            //account.MakeDeposit(-300, DateTime.Now, "Stealing");

            /*account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);*/
        }
    }
}

using System;

namespace Encapsulation_Violation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(100);

            // we can perform all sorts of operations on balance since this field is public
            // you can withdraw money even if there are insufficient funds
            
            bankAccount.balance += 400;
            bankAccount.balance -= 300;

            Console.WriteLine("Your bank account balance is " + bankAccount.balance);
            Console.ReadLine();
        }
    }
}

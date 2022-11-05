namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankAccount = new BankAccount(100);
            Console.WriteLine("Your bank account balance is " + bankAccount.GetBalance() + " EUR.");

            var depositResponse = bankAccount.Deposit(400);
            Console.WriteLine(depositResponse);

            var firstWithdrawResponse = bankAccount.Withdraw(800);
            Console.WriteLine(firstWithdrawResponse);

            var secondWithdrawResponse = bankAccount.Withdraw(300);
            Console.WriteLine(secondWithdrawResponse);

            Console.WriteLine("Your bank account balance is " + bankAccount.GetBalance() + " EUR.");
            Console.ReadLine();
        }
    }
}
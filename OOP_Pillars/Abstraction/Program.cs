namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.MakeCoffee();

            Console.ReadLine();
        }
    }
}
using System;

namespace Abstraction
{
    internal class CoffeeMachine
    {
        public void MakeCoffee()
        {
            this.AddCoffee();
            this.AddWater();
            this.BoilCoffee();
        }

        private void AddWater()
        {
            Console.WriteLine("Water added.");
        }

        private void AddCoffee()
        {
            Console.WriteLine("Coffee added.");
        }

        private void BoilCoffee()
        {
            Console.WriteLine("Coffee done.");
        }
    }
}

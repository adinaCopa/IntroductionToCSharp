namespace Polymorphism_MethodOverriding
{
    internal class Lion : Animal
    {
        public override string MakeNoise()
        {
            // use 'base' keyword when you want to use the method from the parent class

            var animalNoise = base.MakeNoise();
            
            var lionNoise = animalNoise + " + second Roar";

            return lionNoise;
        }
    }
}

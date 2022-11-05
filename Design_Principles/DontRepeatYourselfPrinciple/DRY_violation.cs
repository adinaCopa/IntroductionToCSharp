namespace DontRepeatYourselfPrinciple
{
    internal static class DRY_violation
    {
        public static void DisplayPeter()
        {
            var address = "Gouda, NL";
            var format = "{0} is {1}, lives in {2}, age {3}";

            Console.WriteLine(format, "Peter", "my cousin", address, 10);
        }

        public static void DisplayIris()
        {
            var address = "Gouda, NL";
            var format = "{0} is {1}, lives in {2}, age {3}";
            
            Console.WriteLine(format, "Iris", "a colleague", address, 54);
        }

        public static void DisplayMartin()
        {
            var address = "Gouda, NL";
            var format = "{0} is {1}, lives in {2}, age {3}";
            
            Console.WriteLine(format, "Martin", "a neighbour", address, 25);
        }
    }
}

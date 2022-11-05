namespace DontRepeatYourselfPrinciple
{
    internal class DRY_fix
    {
        private static string address = Constants.Address;
        private static string format = Constants.StandardFormat;

        public static void DisplayPeter()
        {
            Console.WriteLine(format, "Peter", "my cousin", address, 10);
        }

        public static void DisplayIris()
        {
            Console.WriteLine(format, "Iris", "a colleague", address, 54);
        }

        public static void DisplayMartin()
        {
            Console.WriteLine(format, "Martin", "a neighbour", address, 25);
        }
    }
}

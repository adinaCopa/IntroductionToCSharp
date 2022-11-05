namespace Polymorphism_MethodOverloading
{
    internal class Person
    {
        private string ssn;
        private string name;
        private int age;

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, string ssn)
        {
            this.name = name;
            this.ssn = ssn;
        }

        public Person(string name, string ssn, int age)
        {
            this.name = name;
            this.ssn = ssn;
            this.age = age;
        }

        public string DisplayInfo()
        {
            return $"Name = {this.name}, SSN = {this.ssn}, age = {this.age}";
        }
    }
}

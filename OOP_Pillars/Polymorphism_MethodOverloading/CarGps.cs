namespace Polymorphism_MethodOverloading
{
    internal class CarGps
    {
        public string SwitchRoute(string location)
        {
            return $"Route changed to {location}";
        }

        public string SwitchRoute(string location1, string location2)
        {
            return $"Route changed to {location1} -> {location2}";
        }

        public string SwitchRoute(string location1, string location2, string location3)
        {
            return $"Route changed to {location1} -> {location2} -> {location3}";
        }
    }
}

namespace InterfaceSegregationPrinciple_Violation
{
    internal class MultifunctionalVehicle : IVehicle
    {
        public string Drive()
        {
            return "Driving a multifunctional vehicle";
        }

        public string Fly()
        {
            return "Flying a multifunctional vehicle";
        }
    }
}

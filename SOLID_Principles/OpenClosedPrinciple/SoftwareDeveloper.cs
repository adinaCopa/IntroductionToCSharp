namespace OpenClosedPrinciple
{
    internal class SoftwareDeveloper : Job
    {
        public override int GetVacationDays()
        {
            return base.GetVacationDays() + 3;
        }
    }
}

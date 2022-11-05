namespace OpenClosedPrinciple
{
    internal class SoftwareTester : Job
    {
        public override int GetVacationDays()
        {
            return base.GetVacationDays() + 5;
        }
    }
}

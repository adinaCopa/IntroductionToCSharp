namespace KeepItSimpleStupidPrinciple
{
    internal class KISS_fix
    {
        public string GetWeekDay(int day)
        {
            if (day < 1 || day > 7)
            {
                return "Day must be in range 1 to 7.";
            }

            return ((DayOfWeek)day).ToString();
        }
    }
}

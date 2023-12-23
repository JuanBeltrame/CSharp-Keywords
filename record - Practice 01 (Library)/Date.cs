using System.Globalization;

namespace record___Practice_01__Library_
{
    record Date(int Year, int Month, int Day)
    {
        public string GetMonthName()
        {
            return DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
        }
    }


}

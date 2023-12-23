using System.Globalization;
using System.Reflection.Metadata;


Date date = new Date(2023, 2, 14);

var monthName = date.GetMonthName();
Console.WriteLine(monthName);

record Date(int Year, int Month, int Day)
{
    public string GetMonthName()
    {
        return DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
    }
}


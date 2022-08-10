using System.Globalization;

namespace TimeTest;

public class FirstDayOfWeekTest
{
    [Fact]
    public void test_net6()
    {
        var ci = new CultureInfo("en-AU");
        Assert.Equal(DayOfWeek.Monday, ci.DateTimeFormat.FirstDayOfWeek);
    }
}
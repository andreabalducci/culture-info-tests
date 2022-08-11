using System;
using System.Globalization;
using Xunit;
using Xunit.Abstractions;

namespace TimeTest
{
    public class FirstDayOfWeekTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public FirstDayOfWeekTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void test_en_au()
        {
            var ci = new CultureInfo("en-AU");

            _testOutputHelper.WriteLine($"Current UI culture {CultureInfo.CurrentUICulture.DisplayName} => First day of week is {CultureInfo.CurrentUICulture.DateTimeFormat.FirstDayOfWeek}");
            _testOutputHelper.WriteLine($"Current    culture {CultureInfo.CurrentCulture.DisplayName} => First day of week is {CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek}");
            _testOutputHelper.WriteLine($"Test       culture {ci.DisplayName} => First day of week is {ci.DateTimeFormat.FirstDayOfWeek}");

            Assert.Equal(DayOfWeek.Monday, ci.DateTimeFormat.FirstDayOfWeek);
        }
    }
}
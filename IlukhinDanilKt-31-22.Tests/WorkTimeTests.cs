using System.Text.RegularExpressions;
using WebApplication1.Models;

namespace IlukhinDanilKt_31_22.Tests
{
    public class WorkTimeTests
    {
        [Fact]
        public void IsValidWorkTimeHours_120_True()
        {
            // arrange
            var testWorkTime = new WorkTimeTest
            {
                WorkTimeHours = 120
            };

            // act
            var result = testWorkTime.IsValidWorkTimeHours();

            // assert
            Assert.True(result);
        }
    }

    public class WorkTimeTest : WorkTime
    {
        public bool IsValidWorkTimeHours()
        {
            return WorkTimeHours < 10000;
        }
    }
}

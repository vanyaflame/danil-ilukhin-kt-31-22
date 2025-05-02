using System.Text.RegularExpressions;

namespace IlukhinDanilKt_31_22.Tests
{
    public class GroupTests
    {
        [Fact]
        public void IsValidGroupName_KT3122_False()
        {
            // arrange
            var testGroup = new Group
            {
                GroupName = "КТ-31-22"
            };

            // act
            var result = testGroup.IsValidGroupName();

            // assert
            Assert.False(result);
        }
    }

    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public bool IsValidGroupName()
        {
            return Regex.Match(GroupName, @"/\D*0\d*0\d\d/g").Success;
        }
    }
}

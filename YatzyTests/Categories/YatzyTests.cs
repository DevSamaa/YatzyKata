using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class YatzyTests
    {
        public static IEnumerable<object[]> YatzyCategory() 
        {
            yield return new object[] {new List<int>() { 1,1,1,1,1 }, 50 };
            yield return new object[] {new List<int>() { 1,1,1,2,1 }, 0 };
        }
        
        [Theory]
        [MemberData(nameof(YatzyCategory))]
        public void YatzyShouldReturn50Or0(List<int>rolledDice, int expectedOutcome)
        {
            var yatzy = new Yatzy();
            var result = yatzy.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}

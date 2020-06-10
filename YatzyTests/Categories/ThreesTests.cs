using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class ThreesTests
    {
        //Step 5 Threes Category
        public static IEnumerable<object[]> ThreesCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,2,4,2 }, 6 };
            yield return new object[] {new List<int>() { 1,2,3,4,1 }, 3 };
            yield return new object[] {new List<int>() { 2,2,2,2,2 }, 0 };
            yield return new object[] {new List<int>() { 3,3,3,3,3 }, 15 };
        }
        
        [Theory]
        [MemberData(nameof(ThreesCategory))]
        public void ThreesShouldReturnSumOf3S(List<int>rolledDice, int expectedOutcome)
        {
            var threes = new Threes();
            var result = threes.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
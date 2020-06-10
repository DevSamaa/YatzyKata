using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class LargeStraightTests
    {
        //Step 14 - Large Straight
        public static IEnumerable<object[]> LargeStraightCategory() 
        {
            yield return new object[] {new List<int>() { 2,3,4,5,6 }, 20 };
            yield return new object[] {new List<int>() { 6,4,5,2,3 }, 20 };
            yield return new object[] {new List<int>() { 1,2,3,4,6 }, 0 };
            yield return new object[] {new List<int>() { 1,2,3,4,5 }, 0 };
        }
        
        [Theory]
        [MemberData(nameof(LargeStraightCategory))]
        public void LargeStraightShouldReturn20(List<int>rolledDice, int expectedOutcome)
        {
            var largeStraight = new LargeStraight();
            var result = largeStraight.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class SmallStraightTests
    {
        //Step 13 - Small Straight
        public static IEnumerable<object[]> SmallStraightCategory() 
        {
            yield return new object[] {new List<int>() { 1,2,3,4,5 }, 15 };
            yield return new object[] {new List<int>() { 5,3,2,4,1 }, 15 };
            yield return new object[] {new List<int>() { 1,2,3,4,6 }, 0 };
            yield return new object[] {new List<int>() { 2,3,4,5,6 }, 0 };
            yield return new object[] {new List<int>() { 2,3,4,5,6 }, 0 };
        }
        
        [Theory]
        [MemberData(nameof(SmallStraightCategory))]
        public void SmallStraightShouldReturn15(List<int>rolledDice, int expectedOutcome)
        {
            var smallStraight = new SmallStraight();
            var result = smallStraight.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
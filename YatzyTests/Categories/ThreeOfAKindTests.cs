using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class ThreeOfAKindTests
    {
        //Step 11 - Three Of A kind Category
        public static IEnumerable<object[]> ThreeOfAKindCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,3,4,5 }, 9 };
            yield return new object[] {new List<int>() { 3,3,4,5,6 }, 0 };
            yield return new object[] {new List<int>() { 3,3,3,3,1 }, 9 };
            yield return new object[] {new List<int>() { 6,6,6,6,1 }, 18 };
        }
        [Theory]
        [MemberData(nameof(ThreeOfAKindCategory))]
        public void ThreeOfAKindShouldReturnSumOfThreeNumbers(List<int>rolledDice, int expectedOutcome)
        {
            var threeOfAKind = new ThreeOfAKind();
            var result = threeOfAKind.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
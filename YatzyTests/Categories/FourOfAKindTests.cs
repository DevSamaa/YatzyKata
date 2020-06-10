using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class FourOfAKindTests
    {
        //Step 12 - Four of a kind Category
        public static IEnumerable<object[]> FourOfAKindCategory() 
        {
            yield return new object[] {new List<int>() { 2,2,2,2,5 }, 8 };
            yield return new object[] {new List<int>() { 2,2,2,5,5 }, 0 };
            yield return new object[] {new List<int>() { 2,2,2,2,2 }, 8 };
            yield return new object[] {new List<int>() { 6,6,6,6,1 }, 24 };
        }
        [Theory]
        [MemberData(nameof(FourOfAKindCategory))]
        public void FourOfAKindShouldReturnSumOfFourNumbers(List<int>rolledDice, int expectedOutcome)
        {
            var fourOfAKind = new FourOfAKind();
            var result = fourOfAKind.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
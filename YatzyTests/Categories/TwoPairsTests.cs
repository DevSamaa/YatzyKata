using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class TwoPairsTests
    {
        // Step 10 - TwoPairs Category
        public static IEnumerable<object[]> TwoPairsCategory() 
        {
            yield return new object[] {new List<int>() { 1,1,2,3,3 }, 8 };
            yield return new object[] {new List<int>() { 1,1,2,3,4 }, 0 };
            yield return new object[] {new List<int>() { 1,1,2,2,2 }, 6 };
        }
      
        [Theory]
        [MemberData(nameof(TwoPairsCategory))]
        public void TwoPairsShouldReturnSumOfPairs(List<int>rolledDice, int expectedOutcome)
        {
            var twoPairs = new TwoPairs();
            var result = twoPairs.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
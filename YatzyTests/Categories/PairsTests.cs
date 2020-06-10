using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class PairsTests
    {
        
// Step 9 - Pairs Category
        public static IEnumerable<object[]> PairsCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,3,4,4 }, 8 };
            yield return new object[] {new List<int>() { 1,1,6,2,6 }, 12 };
            yield return new object[] {new List<int>() { 3,3,3,4,1 }, 6 };
            yield return new object[] {new List<int>() { 3,3,3,3,1 }, 6 };
            yield return new object[] {new List<int>() { 6,5,5,5,4 }, 10 };
        }
      
        [Theory]
        [MemberData(nameof(PairsCategory))]
        public void PairsShouldReturnSumOfPairs(List<int>rolledDice, int expectedOutcome)
        {
            var pairs = new Pairs();
            var result = pairs.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
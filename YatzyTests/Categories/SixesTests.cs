using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class SixesTests
    {
        //Step 8 Sixes Category
        public static IEnumerable<object[]> SixesCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,2,4,6 }, 6 };
            yield return new object[] {new List<int>() { 6,2,4,4,6 }, 12 };
            yield return new object[] {new List<int>() { 5,5,5,5,5 }, 0 };
            yield return new object[] {new List<int>() { 6,3,6,3,6 }, 18 };
        }
        
        [Theory]
        [MemberData(nameof(SixesCategory))]
        public void SixesShouldReturnSumOf6S(List<int>rolledDice, int expectedOutcome)
        {
            var sixes = new Sixes();
            var result = sixes.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
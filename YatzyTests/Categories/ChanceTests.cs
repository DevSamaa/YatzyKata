using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class ChanceTests
    {
        public static IEnumerable<object[]> ChanceCategory() 
        {
            yield return new object[] {new List<int>() { 1,1,3,3,6 }, 14 };
            yield return new object[] {new List<int>() { 4,5,5,6,1 }, 21 };
        }
        
        [Theory]
        [MemberData(nameof(ChanceCategory))]
        public void ChanceShouldReturnSumOfAllNumbers(List<int>rolledDice, int expectedOutcome)
        {
            var chance = new Chance();
            var result = chance.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }

    }
}
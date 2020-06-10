using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class FivesTests
    {
        //Step 7 Fives Category
        public static IEnumerable<object[]> FivesCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,2,4,5 }, 5 };
            yield return new object[] {new List<int>() { 5,2,4,4,5 }, 10 };
            yield return new object[] {new List<int>() { 5,5,5,5,5 }, 25 };
            yield return new object[] {new List<int>() { 4,3,4,3,4 }, 0 };
        }
        
        [Theory]
        [MemberData(nameof(FivesCategory))]
        public void FivesShouldReturnSumOf5S(List<int>rolledDice, int expectedOutcome)
        {
            var fives = new Fives();
            var result = fives.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
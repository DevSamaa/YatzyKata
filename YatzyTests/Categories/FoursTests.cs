using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class FoursTests
    {
        //Step 6 Fours Category
        public static IEnumerable<object[]> FoursCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,2,4,2 }, 4 };
            yield return new object[] {new List<int>() { 1,2,4,4,1 }, 8 };
            yield return new object[] {new List<int>() { 2,2,2,2,2 }, 0 };
            yield return new object[] {new List<int>() { 4,3,4,3,4 }, 12 };
        }
        
        [Theory]
        [MemberData(nameof(FoursCategory))]
        public void FoursShouldReturnSumOf4S(List<int>rolledDice, int expectedOutcome)
        {
            var fours = new Fours();
            var result = fours.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
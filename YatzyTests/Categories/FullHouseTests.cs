using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class FullHouseTests
    {
        // Step 15 - Full house
        public static IEnumerable<object[]> FullHouseCategory() 
        {
            yield return new object[] {new List<int>() { 1,1,2,2,2 }, 8 };
            yield return new object[] {new List<int>() { 3,3,6,6,6 }, 24 };
            yield return new object[] {new List<int>() { 2,2,3,3,4 }, 0 };
            yield return new object[] {new List<int>() { 4,4,4,4,4 }, 0 };
            yield return new object[] {new List<int>() { 4,4,4,6,6 }, 24 };
            yield return new object[] {new List<int>() { 4,4,4,5,1 }, 0 };
            yield return new object[] {new List<int>() { 1,5,1,5,1 }, 13 };
        }
        
        [Theory]
        [MemberData(nameof(FullHouseCategory))]
        public void FullHouseShouldReturnSumOfAllDice(List<int>rolledDice, int expectedOutcome)
        {
            var fullHouse = new FullHouse();
            var result = fullHouse.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
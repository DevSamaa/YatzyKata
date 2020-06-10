using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class TwosTests
    {
        //Step 4 Twos Category
        public static IEnumerable<object[]> TwosCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,2,4,2 }, 4 };
            yield return new object[] {new List<int>() { 1,2,3,4,1 }, 2 };
            yield return new object[] {new List<int>() { 2,2,2,2,2 }, 10 };
        }
        
        [Theory]
        [MemberData(nameof(TwosCategory))]
        public void TwosShouldReturnSumOf2S(List<int>rolledDice, int expectedOutcome)
        {
            var twos = new Twos();
            var result = twos.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
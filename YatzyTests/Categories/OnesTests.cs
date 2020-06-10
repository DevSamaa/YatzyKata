using System.Collections.Generic;
using Xunit;
using YatzyKata.Categories;

namespace YatzyTests.Categories
{
    public class OnesTests
    {
        public static IEnumerable<object[]> OnesCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,3,4,5 }, 0 };
            yield return new object[] {new List<int>() { 1,2,3,4,1 }, 2 };
            yield return new object[] {new List<int>() { 1,1,1,1,1 }, 5 };
        }
        
        [Theory]
        [MemberData(nameof(OnesCategory))]
        public void OnesShouldReturnSumOf1s(List<int>rolledDice, int expectedOutcome)
        {
            var ones = new Ones();
            var result = ones.CalculateScore(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
}
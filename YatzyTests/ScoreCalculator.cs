using System;
using System.Collections.Generic;
using Xunit;
using YatzyKata;

namespace YatzyTests

{
    public class ScoreCalculatorShould
    {
        public ScoreCalculator _scoreCalculator;
        public ScoreCalculatorShould()
        {
           _scoreCalculator = new ScoreCalculator(); 
        }
        // Step 1 - Chance Category
        public static IEnumerable<object[]> SampleData() 
        {
            yield return new object[] {new List<int>() { 1,1,3,3,6 }, 14 };
            yield return new object[] {new List<int>() { 4,5,5,6,1 }, 21 };
        }
        
        [Theory]
        [MemberData(nameof(SampleData))]
        public void TakeListOfNumbersAndReturnTheirSum(List<int>rolledDice, int expectedOutcome)
        {
            var result = _scoreCalculator.Chance(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }

      
        
    }
}





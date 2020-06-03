using System;
using System.Collections.Generic;
using Xunit;
using YatzyKata;

namespace YatzyTests

{
    public class ScoreCalculatorTests
    {
        public ScoreCalculator _scoreCalculator;
        
        public ScoreCalculatorTests()
        {
           _scoreCalculator = new ScoreCalculator(); 
        }
        
        // Step 1 - Chance Category
        public static IEnumerable<object[]> ChanceCategory() 
        {
            yield return new object[] {new List<int>() { 1,1,3,3,6 }, 14 };
            yield return new object[] {new List<int>() { 4,5,5,6,1 }, 21 };
        }
        
        [Theory]
        [MemberData(nameof(ChanceCategory))]
        public void ChanceShouldReturnSumOfAllNumbers(List<int>rolledDice, int expectedOutcome)
        {
            var result = _scoreCalculator.Chance(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }

      
        //Step 2 - Yatzy Category
        public static IEnumerable<object[]> YatzyCategory() 
        {
            yield return new object[] {new List<int>() { 1,1,1,1,1 }, 50 };
            yield return new object[] {new List<int>() { 1,1,1,2,1 }, 0 };
        }
        
        [Theory]
        [MemberData(nameof(YatzyCategory))]
        public void YatzyShouldReturn50Or0(List<int>rolledDice, int expectedOutcome)
        {
            var result = _scoreCalculator.Yatzy(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
        //Step 3 - Ones Category
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
            var result = _scoreCalculator.Ones(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
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
            var result = _scoreCalculator.Twos(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
        //Step 5 Threes Category
        public static IEnumerable<object[]> ThreesCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,2,4,2 }, 6 };
            yield return new object[] {new List<int>() { 1,2,3,4,1 }, 3 };
            yield return new object[] {new List<int>() { 2,2,2,2,2 }, 0 };
            yield return new object[] {new List<int>() { 3,3,3,3,3 }, 15 };

        }
        
        [Theory]
        [MemberData(nameof(ThreesCategory))]
        public void ThreesShouldReturnSumOf3S(List<int>rolledDice, int expectedOutcome)
        {
            var result = _scoreCalculator.Threes(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
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
            var result = _scoreCalculator.Fours(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
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
            var result = _scoreCalculator.Fives(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
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
            var result = _scoreCalculator.Sixes(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
    
}





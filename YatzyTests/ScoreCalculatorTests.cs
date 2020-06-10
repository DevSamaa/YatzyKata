using System;
using System.Collections.Generic;
using Xunit;
using YatzyKata;
using YatzyKata.Categories;

namespace YatzyTests

{
    public class ScoreCalculatorTests
    {
        public ScoreCalculator _scoreCalculator;
        
        public ScoreCalculatorTests()
        {
           _scoreCalculator = new ScoreCalculator(); 
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
            var result = _scoreCalculator.Pairs(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
        // Step 10 - TwoPairs Category
        public static IEnumerable<object[]> TwoPairsCategory() 
        {
            yield return new object[] {new List<int>() { 1,1,2,3,3 }, 8 };
            yield return new object[] {new List<int>() { 1,1,2,3,4 }, 0 };
            yield return new object[] {new List<int>() { 1,1,2,2,2 }, 6 };
        }
      
        [Theory]
        [MemberData(nameof(TwoPairsCategory))]
        public void TwoPairsShouldReturnSumOfPairs(List<int>rolledDice, int expectedOutcome)
        {
            var result = _scoreCalculator.TwoPairs(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
        //Step 11 - Three Of A kind Category
        public static IEnumerable<object[]> ThreeOfAKindCategory() 
        {
            yield return new object[] {new List<int>() { 3,3,3,4,5 }, 9 };
            yield return new object[] {new List<int>() { 3,3,4,5,6 }, 0 };
            yield return new object[] {new List<int>() { 3,3,3,3,1 }, 9 };
            yield return new object[] {new List<int>() { 6,6,6,6,1 }, 18 };
        }
        [Theory]
        [MemberData(nameof(ThreeOfAKindCategory))]
        public void ThreeOfAKindShouldReturnSumOfThreeNumbers(List<int>rolledDice, int expectedOutcome)
        {
            var result = _scoreCalculator.ThreeOfAKind(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
        //Step 12 - Four of a kind Category
        public static IEnumerable<object[]> FourOfAKindCategory() 
        {
            yield return new object[] {new List<int>() { 2,2,2,2,5 }, 8 };
            yield return new object[] {new List<int>() { 2,2,2,5,5 }, 0 };
            yield return new object[] {new List<int>() { 2,2,2,2,2 }, 8 };
            yield return new object[] {new List<int>() { 6,6,6,6,1 }, 24 };
        }
        [Theory]
        [MemberData(nameof(FourOfAKindCategory))]
        public void FourOfAKindShouldReturnSumOfFourNumbers(List<int>rolledDice, int expectedOutcome)
        {
            var result = _scoreCalculator.FourOfAKind(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
        //Step 13 - Small Straight
        public static IEnumerable<object[]> SmallStraightCategory() 
        {
            yield return new object[] {new List<int>() { 1,2,3,4,5 }, 15 };
            yield return new object[] {new List<int>() { 5,3,2,4,1 }, 15 };
            yield return new object[] {new List<int>() { 1,2,3,4,6 }, 0 };
            yield return new object[] {new List<int>() { 2,3,4,5,6 }, 0 };
            yield return new object[] {new List<int>() { 2,3,4,5,6 }, 0 };

        }
        
        [Theory]
        [MemberData(nameof(SmallStraightCategory))]
        public void SmallStraightShouldReturn15(List<int>rolledDice, int expectedOutcome)
        {
            var result = _scoreCalculator.SmallStraight(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
        //Step 14 - Large Straight
        public static IEnumerable<object[]> LargeStraightCategory() 
        {
            yield return new object[] {new List<int>() { 2,3,4,5,6 }, 20 };
            yield return new object[] {new List<int>() { 6,4,5,2,3 }, 20 };
            yield return new object[] {new List<int>() { 1,2,3,4,6 }, 0 };
            yield return new object[] {new List<int>() { 1,2,3,4,5 }, 0 };

        }
        
        [Theory]
        [MemberData(nameof(LargeStraightCategory))]
        public void LargeStraightShouldReturn20(List<int>rolledDice, int expectedOutcome)
        {
            var result = _scoreCalculator.LargeStraight(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
        
        // Step 15 - Full house
        // Full house: If the dice are two of a kind and three of a kind,
        // the player scores the sum of all the dice. For example, when placed on “full house”
        // 1,1,2,2,2 scores 8 (1+1+2+2+2)
        // 2,2,3,3,4 scores 0
        // 4,4,4,4,4 scores 0
        
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
            var result = _scoreCalculator.FullHouse(rolledDice);
            Assert.Equal(expectedOutcome, result);
        }
    }
    
}



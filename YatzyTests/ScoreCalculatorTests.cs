using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;
using YatzyKata;
using YatzyKata.Categories;

namespace YatzyTests
{
    public class ScoreCalculatorTests
    {
        private List<ICategory> _allCategories;
        public ScoreCalculatorTests()
        {
            _allCategories = new AllCategories().CreateCategories();
        }
        [Fact]
        public void GetScoresHigherThan0ShouldNotBeEmpty()
        {
            var rolledDice = new List<int>() {1, 1, 3, 3, 6};
            var scoreCalculator = new ScoreCalculator(_allCategories);
            var result = scoreCalculator.GetScoresHigherThan0(rolledDice);
            
            //list should not be empty
            Assert.NotEmpty(result);
        }
        
        [Fact]
        public void GetScoresHigherThan0ShouldHaveScoresHigherThan0()
        {
            var rolledDice = new List<int>() {1, 1, 3, 3, 6};
            var scoreCalculator = new ScoreCalculator(_allCategories);
            var result = scoreCalculator.GetScoresHigherThan0(rolledDice);
            
            //all of the scores should be higher than 0
            Assert.All(result,item =>Assert.True(item.Score > 0));
            
        }
        
        [Fact]
        public void GetScoresHigherThan0ShouldHaveName()
        {
            var rolledDice = new List<int>() {1, 1, 3, 3, 6};
            var scoreCalculator = new ScoreCalculator(_allCategories);
            var result = scoreCalculator.GetScoresHigherThan0(rolledDice);
            
            //the objects on the list should contain a name
            Assert.DoesNotContain(result, item => string.IsNullOrWhiteSpace(item.Name));
        }
        
         
        [Fact]
        public void GetScoresHigherThan0ShouldHaveMultipleResults()
        {
            var rolledDice = new List<int>() {1, 1, 3, 3, 6};
            var scoreCalculator = new ScoreCalculator(new List<ICategory>{new Twos(), new Fours()});
            var result = scoreCalculator.GetScoresHigherThan0(rolledDice);
            
            Assert.Empty(result);
        }
        
     
        public static IEnumerable<object[]> TestData() 
        {
            yield return new object[] {new List<int>() { 3,3,2,4,2 }, new List<ICategory> { new Threes()},6 };
            yield return new object[] {new List<int>() { 3,3,2,4,2 }, new List<ICategory> { new Twos()}, 4 };
        }
        
        [Theory]
        [MemberData(nameof(TestData))]
        public void GetScoresHigherThan0WithMemberData(List<int>rolledDice, List<ICategory> categoriesToBeChecked,int expectedOutcome)
        {
            var scoreCalculator = new ScoreCalculator(categoriesToBeChecked);
            var result = scoreCalculator.GetScoresHigherThan0(rolledDice);
            Assert.Equal(expectedOutcome, result.First().Score);

        }
    }
}
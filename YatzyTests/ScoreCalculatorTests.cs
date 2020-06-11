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
        [Fact]
        public void GetScoresHigherThan0ShouldNotBeEmpty()
        {
            var rolledDice = new List<int>() {1, 1, 3, 3, 6};
            var scoreCalculator = new ScoreCalculator();
            var result = scoreCalculator.GetScoresHigherThan0(rolledDice);
            
            //list should not be empty
            Assert.NotEmpty(result);
        }
        
        [Fact]
        public void GetScoresHigherThan0ShouldHaveScoresHigherThan0()
        {
            var rolledDice = new List<int>() {1, 1, 3, 3, 6};
            var scoreCalculator = new ScoreCalculator();
            var result = scoreCalculator.GetScoresHigherThan0(rolledDice);
            
            //all of the scores should be higher than 0
            Assert.All(result,item =>Assert.True(item.Score > 0));
            
        }
        
        [Fact]
        public void GetScoresHigherThan0ShouldHaveName()
        {
            var rolledDice = new List<int>() {1, 1, 3, 3, 6};
            var scoreCalculator = new ScoreCalculator();
            var result = scoreCalculator.GetScoresHigherThan0(rolledDice);
            
            //the objects on the list should contain a name
            Assert.DoesNotContain(result, item => string.IsNullOrWhiteSpace(item.Name));
        }
    }
}
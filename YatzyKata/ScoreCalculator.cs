using System;
using System.Collections.Generic;
using System.Linq;
using YatzyKata.Categories;

namespace YatzyKata
{
    public class ScoreCalculator
    {
        private List<ICategory> _categories;

        public ScoreCalculator()
        {
          _categories = new List<ICategory>
          {
              new Chance(),
              new Fives(),
              new FourOfAKind(),
              new Fours(),
              new FullHouse(),
              new LargeStraight(),
              new Ones(),
              new Pairs(),
              new Sixes(),
              new SmallStraight(),
              new ThreeOfAKind(),
              new Threes(),
              new TwoPairs(),
              new Twos(),
              new Yatzy()
          };  
          
        }
        public List<CategoryScore> GetScoresHigherThan0(List<int>rolledDice)
        {
            var result = new List<CategoryScore>();
            
            foreach (var category in _categories)
            {
                var tempScore = category.CalculateScore(rolledDice);
                if (tempScore > 0)
                {
                    result.Add(new CategoryScore(tempScore, category.Name));
                }
            }
            // 1. run each CalculateScore method, one by one 
            // 2. If the score that is returned >0,
            //         create a CategoryScore(score, name) and add it to a list
            // 3. return the list

            return result.OrderByDescending(item => item.Score).ToList();
        }

        public void PrintHighestCateories(List<CategoryScore> highestScores)
        {
            foreach (var item in highestScores)
            {
                Console.WriteLine($"{item.Name} : {item.Score}");
            }
        }
    }
}
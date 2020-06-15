using System;
using System.Collections.Generic;
using System.Linq;
using YatzyKata.Categories;

namespace YatzyKata
{
    public class ScoreCalculator
    {
        private List<ICategory> _categories;

        public ScoreCalculator(List<ICategory> incomingCategories)
        {
            _categories = incomingCategories;
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
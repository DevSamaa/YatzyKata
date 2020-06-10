using System.Collections.Generic;

namespace YatzyKata.Categories
{
    public class Pairs : ICategory
    {
        private Helpers _helper;
        
        public Pairs()
        {
            _helper = new Helpers();
        }
        
        public int CalculateScore(List<int> rolledDice)
        {
            return _helper.AddUpMultiples(rolledDice, 2);

        }
    }
}
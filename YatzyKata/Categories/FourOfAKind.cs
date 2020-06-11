using System.Collections.Generic;

namespace YatzyKata.Categories
{
    public class FourOfAKind : ICategory
    {
        public string Name => "Four of a kind";

        private Helpers _helper;

        public FourOfAKind()
        {
            _helper = new Helpers();
        }
        
        public int CalculateScore(List<int> rolledDice)
        {
            return _helper.AddUpMultiples(rolledDice, 4);
        }
    }
}
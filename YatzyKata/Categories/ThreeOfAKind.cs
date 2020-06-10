using System.Collections.Generic;
using System.Threading;

namespace YatzyKata.Categories
{
    public class ThreeOfAKind :ICategory
    {
        private Helpers _helper;

        public ThreeOfAKind()
        {
            _helper = new Helpers();
        }
        
        public int CalculateScore(List<int> rolledDice)
        {
            return _helper.AddUpMultiples(rolledDice, 3);

        }
    }
}
using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class LargeStraight : ICategory
    {
        public string Name => "Large Straight";

        private Helpers _helper;

        public LargeStraight()
        {
            _helper = new Helpers();
        }
        public int CalculateScore(List<int> rolledDice)
        {
            return _helper.SumOfStraight(rolledDice, 2);
        }
    }
}
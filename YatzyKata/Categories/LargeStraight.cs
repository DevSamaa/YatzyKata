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
            // List<int> largeStraightNumbers = new List<int>{2,3,4,5,6};
            // var range = Enumerable.Range(2, 5).ToList();
            // return _helper.SumOfStraight(rolledDice, range);
            return _helper.SumOfStraight2(rolledDice, 2);

        }
    }
}
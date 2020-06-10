using System.Collections.Generic;

namespace YatzyKata.Categories
{
    public class LargeStraight : ICategory
    {
        private Helpers _helper;

        public LargeStraight()
        {
            _helper = new Helpers();
        }
        public int CalculateScore(List<int> rolledDice)
        {
            List<int> largeStraightNumbers = new List<int>{2,3,4,5,6};
            return _helper.SumOfStraight(rolledDice, largeStraightNumbers);
        }
    }
}
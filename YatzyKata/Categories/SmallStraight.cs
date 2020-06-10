using System.Collections.Generic;

namespace YatzyKata.Categories
{
    public class SmallStraight :ICategory
    {
        private Helpers _helper;

        public SmallStraight()
        {
            _helper = new Helpers();
        }
        public int CalculateScore(List<int> rolledDice)
        {
            List<int> smallStraightNumbers = new List<int>{1,2,3,4,5};
            return _helper.SumOfStraight(rolledDice, smallStraightNumbers);
        }
    }
}
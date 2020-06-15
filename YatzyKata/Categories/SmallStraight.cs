using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class SmallStraight :ICategory
    {
        public string Name => "Small Straight";
        private Helpers _helper;

        public SmallStraight()
        {
            _helper = new Helpers();
        }


        public int CalculateScore(List<int> rolledDice)
        {
            return _helper.SumOfStraight(rolledDice, 1);
        }
    }
}
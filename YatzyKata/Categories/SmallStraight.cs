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
            var range = Enumerable.Range(1, 5).ToList();
            return _helper.SumOfStraight(rolledDice, range);
        }
    }
}
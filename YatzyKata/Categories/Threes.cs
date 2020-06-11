using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Threes : ICategory
    {
        public string Name => "Threes";

        public int CalculateScore(List<int> rolledDice)
        {
            return rolledDice.Where(dice => dice == 3).Sum();
        }
    }
}
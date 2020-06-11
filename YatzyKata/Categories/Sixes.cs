using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Sixes :ICategory
    {
        public string Name => "Sixes";

        public int CalculateScore(List<int> rolledDice)
        {
            return rolledDice.Where(dice => dice == 6).Sum();
        }
    }
}
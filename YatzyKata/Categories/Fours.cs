using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Fours : ICategory
    {
        public string Name => "Fours";

        public int CalculateScore(List<int> rolledDice)
        {
            return rolledDice.Where(dice => dice == 4).Sum();
        }
    }
}
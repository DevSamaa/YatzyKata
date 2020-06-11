using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Fives : ICategory
    {
        public string Name => "Fives";
        public int CalculateScore(List<int> rolledDice)
        {
            return rolledDice.Where(dice => dice == 5).Sum();
        }
    }
}
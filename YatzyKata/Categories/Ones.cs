using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Ones : ICategory
    {
        public int CalculateScore(List<int> rolledDice)
        {
            return rolledDice.Where(dice => dice == 1).Sum();
        }
    }
}
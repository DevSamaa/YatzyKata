using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Chance : ICategory
    {
        public int CalculateScore(List<int> rolledDice)
        {
            return rolledDice.Sum();
        }
    }
}
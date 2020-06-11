using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Ones : ICategory
    {
        public string Name => "Ones";

        public int CalculateScore(List<int> rolledDice)
        {
            return rolledDice.Where(dice => dice == 1).Sum();
        }
    }
}
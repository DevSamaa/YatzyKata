using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Twos : ICategory
    {
        public string Name => "Twos";

        public int CalculateScore(List<int> rolledDice)
        {
            return rolledDice.Where(dice => dice == 2).Sum();
        }
    }
}
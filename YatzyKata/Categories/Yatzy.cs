using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Yatzy : ICategory
    {
        public string Name => "Yatzy";

        public int CalculateScore(List<int> rolledDice)
        {
            return rolledDice.All(dice => dice == rolledDice[0])? 50:0;
        }
    }
}
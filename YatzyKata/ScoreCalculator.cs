using System.Collections.Generic;
using System.Linq;

namespace YatzyKata
{
    public class ScoreCalculator
    {
        public int Chance(List<int> rolledDice)
        {
            return rolledDice.Sum();
        }
    }
}
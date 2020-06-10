using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class TwoPairs : ICategory
    {
        public int CalculateScore(List<int> rolledDice)
        {
            var numberToBeChecked = 6;
            var total = 0;
            var pairsFound = 0;
            while (numberToBeChecked >0 && pairsFound<2)
            {
                var amountOfNumberFound = rolledDice.Count(dice => dice == numberToBeChecked);
                if (amountOfNumberFound >=2)
                {
                    total += numberToBeChecked * 2;
                    pairsFound++;
                }
                numberToBeChecked -= 1;  
            }
            return pairsFound<2 ? 0:total;
        }
    }
}
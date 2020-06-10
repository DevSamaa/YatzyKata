using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class FullHouse : ICategory
    {
        public int CalculateScore(List<int> rolledDice)
        {
            var numberToBeChecked = 6;
            var pairsFound = 0;
            
            while (numberToBeChecked >0)
            {
                var numberFound = rolledDice.Where(dice => dice == numberToBeChecked).ToList();
                if (numberFound.Count() ==3)
                {
                    pairsFound++;

                    var remainingNumbers = rolledDice.Where(dice => dice != numberToBeChecked).ToArray();
                    if (remainingNumbers[0] == remainingNumbers[1])
                    {
                        pairsFound++;
                    }
                }
                numberToBeChecked -= 1;  
            }
            return pairsFound<2? 0:rolledDice.Sum();
        }
    }
}
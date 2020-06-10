using System.Collections.Generic;
using System.Linq;

namespace YatzyKata.Categories
{
    public class Helpers
    {
        public int AddUpMultiples(List<int>rolledDice,int multiple)
        {
            var numberToBeChecked = 6;
            while (numberToBeChecked >0)
            {
                var amountOfNumberFound = rolledDice.Count(dice => dice == numberToBeChecked);
                if (amountOfNumberFound >=multiple)
                {
                    return numberToBeChecked * multiple;
                }
                numberToBeChecked -= 1;  
            }
            return 0;
        }
        
        public int SumOfStraight(List<int> rolledDice, List<int>straightNumbers)
        {
            rolledDice.Sort();
            bool isEqual = rolledDice.SequenceEqual(straightNumbers);
            if (isEqual)
            {
                return rolledDice.Sum();
            }
            return 0;
        }
    }
}
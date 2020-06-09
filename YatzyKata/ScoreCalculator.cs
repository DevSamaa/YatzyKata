using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace YatzyKata
{
    public class ScoreCalculator
    {
        public int Chance(List<int> rolledDice)
        {
            return rolledDice.Sum();
        }
        
        public int Yatzy(List<int> rolledDice)
        {
            return rolledDice.All(dice => dice == rolledDice[0])? 50:0;
        }
        
        public int Ones(List<int> rolledDice)
        {
            return AddUpNumbers(rolledDice, 1);
        }
        
        public int Twos(List<int> rolledDice)
        {
            return AddUpNumbers(rolledDice, 2);
        }
        
        public int Threes(List<int> rolledDice)
        {
            return AddUpNumbers(rolledDice, 3);
        }
        
        public int Fours(List<int> rolledDice)
        {
            return AddUpNumbers(rolledDice, 4);
        }
        
        public int Fives(List<int> rolledDice)
        {
            return AddUpNumbers(rolledDice, 5);
        }
        
        public int Sixes(List<int> rolledDice)
        {
            return AddUpNumbers(rolledDice, 6);
        }
        
        private int AddUpNumbers(List<int> rolledDice, int numberToBeAdded)
        {
            return rolledDice.Where(dice => dice == numberToBeAdded).Sum();
        }

        public int TwoPairs(List<int>rolledDice)
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
        
        public int Pairs(List<int>rolledDice)
        {
            return AddUpMultiples(rolledDice, 2);
        }

        public int ThreeOfAKind(List<int>rolledDice)
        {
            return AddUpMultiples(rolledDice, 3);
        }

        public int FourOfAKind(List<int> rolledDice)
        {
            return AddUpMultiples(rolledDice, 4);
        }

        private int AddUpMultiples(List<int>rolledDice,int multiple)
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

        public int SmallStraight(List<int> rolledDice)
        {
            List<int> smallStraightNumbers = new List<int>{1,2,3,4,5};
            return SumOfStraight(rolledDice, smallStraightNumbers);
        }
        
        public int LargeStraight(List<int> rolledDice)
        {
            List<int> largeStraightNumbers = new List<int>{2,3,4,5,6};
            return SumOfStraight(rolledDice, largeStraightNumbers);
        }

        private int SumOfStraight(List<int> rolledDice, List<int>straightNumbers)
        {
            rolledDice.Sort();
            bool isEqual = rolledDice.SequenceEqual(straightNumbers);
            if (isEqual)
            {
                return rolledDice.Sum();
            }
            return 0;
        }
        
        public int FullHouse(List<int>rolledDice)
        {
            var numberToBeChecked = 6;
            var total = 0;
            var pairsFound = 0;
            
            while (numberToBeChecked >0)
            {
                var numberFound = rolledDice.Where(dice => dice == numberToBeChecked);
                if (numberFound.Count() ==3)
                {
                    total += numberToBeChecked * 3;
                    pairsFound++;

                    var remainingNumbers = rolledDice.Where(dice => dice != numberToBeChecked).ToArray();
                    if (remainingNumbers[0] == remainingNumbers[1])
                    {
                        total += remainingNumbers.Sum();
                        pairsFound++;
                    }
                }
                numberToBeChecked -= 1;  
            }
            return pairsFound<2? 0:total;
        }
        
        public int FullHouse2(List<int>rolledDice)
        {
            var numberToBeChecked = 6;
            var pairsFound = 0;
            
            while (numberToBeChecked >0)
            {
                var numberFound = rolledDice.Where(dice => dice == numberToBeChecked);
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
    
    //TODO - ask why numberToBeChecked is yellow underlines, I didn't understand the IDE explanation/suggestion.
    //TODO - get feedback on FullHouse/FullHouse2, which one is "better" in FullHouse2 I don't keep track of the actual total score, just add up all numbers in the end.
}


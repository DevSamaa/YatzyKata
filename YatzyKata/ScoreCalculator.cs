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
        
    }
}


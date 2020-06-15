using System.Collections.Generic;
using YatzyKata.Categories;

namespace YatzyKata
{
    public class AllCategories
    {
        
        public List<ICategory> CreateCategories()
        {
            return new List<ICategory>
            {
                new Chance(),
                new Fives(),
                new FourOfAKind(),
                new Fours(),
                new FullHouse(),
                new LargeStraight(),
                new Ones(),
                new Pairs(),
                new Sixes(),
                new SmallStraight(),
                new ThreeOfAKind(),
                new Threes(),
                new TwoPairs(),
                new Twos(),
                new Yatzy()
            };   
        }
        
    }
}
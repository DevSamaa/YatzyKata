using System.Collections.Generic;

namespace YatzyKata.Categories
{
    public interface ICategory
    {
        public int CalculateScore(List<int> rolledDice);
    }
}
using System.Collections.Generic;

namespace YatzyKata.Categories
{
    public interface ICategory
    {
        public string Name { get; }
        public int CalculateScore(List<int> rolledDice);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    public interface IGift
    {
        IEnumerable<Sweet> items { get; }

        void Add(Sweet sweet);
        int GiftWeight();
        decimal GiftCalories();
        void Sort();

        IEnumerable<Sweet> FindCandyByCalories(int minSort, int maxSort);
    }
}

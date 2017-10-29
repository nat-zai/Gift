using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift.Factory
{
    class ChocolateCreator : Creator
    {
        public override Sweet FactoryMethod(string chocolateName, int chocolateWeight, decimal chocolateCalories, TypeOfChocolate chocolateColor)
        {
            return new Chocolate(chocolateName, chocolateWeight, chocolateCalories, chocolateColor);
        }

        public override Sweet FactoryMethod(string candyName, int candyWeight, decimal candyCalories, TypeOfCandy type)
        {
            throw new NotImplementedException();
        }
    }
}

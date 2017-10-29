using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift.Factory
{
    public abstract class Creator
    {
        public abstract Sweet FactoryMethod(string candyName,
            int candyWeight, decimal candyCalories, TypeOfCandy type);
        public abstract Sweet FactoryMethod(string chocolateName,
            int chocolateWeight, decimal chocolateCalories, TypeOfChocolate typeChocolate);
    }
}

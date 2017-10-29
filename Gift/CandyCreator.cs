using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift.Factory
{
    class CandyCreator : Creator
    {
        public override Sweet FactoryMethod(string candyName, int candyWeight, decimal candyCalories, TypeOfCandy typeCandy)
        {
            return new Candy(candyName, candyWeight, candyCalories, typeCandy);
        }

        public override Sweet FactoryMethod(string chocolateName, int chocolateWeight, decimal chocolateCalories, TypeOfChocolate typeChocolate)
        {
            throw new NotImplementedException();
        }
    }
}

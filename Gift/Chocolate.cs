using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{    //enum - перечисление типов шоколада
    public enum TypeOfChocolate { White, Bitter, Dark, Lactic };

    class Chocolate : Sweet
    {
        public TypeOfChocolate typeChocolate;

        //base используется для доступа к членам базового из производного класса для
        //Определения конструктора базового класса, который должен вызываться при
        //создании экземпляров производного класса.
        public Chocolate(string chocolateName, int chocolateWeight, decimal chocolateCalories, TypeOfChocolate chocolateColor)
            : base(chocolateName, chocolateWeight, chocolateCalories)
        {
            this.typeChocolate = chocolateColor;
        }

        public override void TypeOfSweet()
        {
            Console.WriteLine(typeChocolate.ToString());
        }
    }
}

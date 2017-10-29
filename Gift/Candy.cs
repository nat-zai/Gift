using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gift
{
    //enum - перечисление типов конфет
    public enum TypeOfCandy { Lollipop, ChocolateCandies };

    class Candy : Sweet
    {
        public TypeOfCandy typeCandy;

        //base используется для доступа к членам базового из производного класса для
        //Определения конструктора базового класса, который должен вызываться при
        //создании экземпляров производного класса.
        public Candy(string candyName, int candyWeight, decimal candyCalories, TypeOfCandy typeCandy)
            : base(candyName, candyWeight, candyCalories)
        {
            this.typeCandy = typeCandy;
        }

        public override void TypeOfSweet()
        {
            Console.WriteLine(typeCandy.ToString());
        }
    }
}
